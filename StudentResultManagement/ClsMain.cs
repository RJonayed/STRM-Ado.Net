﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace StudentResultManagement
{
    class ClsMain
    {       
        public SqlDataReader GblRdrToGetData;
        //public SqlConnection GblCon = new SqlConnection("Persist Security Info=False;User ID=sa;Password='';Initial Catalog='PackSmart';Data Source='NUR';");
        public SqlConnection GblCon = new SqlConnection("Persist Security Info=True;Initial Catalog='StudentReasult';Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\IDB-BiSEWITScholarship\\XMLModule_5\\Ado.Net\\Projects\\STRM\\StudentResultManagement\\StudentReasult.mdf;");
        public SqlCommand GblSqlCmd = new SqlCommand();

        public void toGetData(string QryForRetrieve)
        {
            if (GblCon != null && GblCon.State != ConnectionState.Closed)
            {
                GblCon.Close();
            }

            GblCon.Open();
            SqlCommand GblCmd = new SqlCommand(QryForRetrieve, GblCon);
            GblRdrToGetData = GblCmd.ExecuteReader();

        }

        public string salSheetLock (string mm ,string yy)
        {
            string lck = "0";

            toGetData("select lock from monthlyTbl where formonth='" + mm + "' and forYear='" + yy + "'");
            if (GblRdrToGetData.Read())
            {
                lck=GblRdrToGetData["lock"].ToString();
            }

            return lck;
        }

        public string salSheetLockDateWise(string thedate)
        {
            string lck = "0";

            toGetData("select lock from monthlyTbl where convert(datetime,'" + thedate + "',103) between countfrom and countto");
            if (GblRdrToGetData.Read())
            {
                lck = GblRdrToGetData["lock"].ToString();
            }

            return lck;
        }
        public void toRunStoredProc(string SPName)
        {
            if (GblCon != null && GblCon.State != ConnectionState.Closed)
            {
                GblCon.Close();
            }

            GblCon.Open();
            SqlCommand GblCmd = new SqlCommand(SPName, GblCon);
            
            GblCmd.CommandType = CommandType.StoredProcedure;
            //GblCmd.Parameters.Add(new SqlParameter("@D_BaseMedia", SqlDbType.VarChar, 100));
            //GblCmd.Parameters["@D_BaseMedia"].Value = ClsVar.FileName;
            //GblCmd.Parameters.Add(new SqlParameter("@D_BasePath", SqlDbType.VarChar, 300));
            //GblCmd.Parameters["@D_BasePath"].Value = ClsVar.FilePath;
            //GblCmd.Parameters.Add(new SqlParameter("@D_BaseNAme", SqlDbType.VarChar, 30));
            //GblCmd.Parameters["@D_BaseNAme"].Value = ClsVar.DataBaseName;
            GblCmd.ExecuteNonQuery();


        }

        public Boolean DateCheck(string dt)
        {
            try
            {
                DateTime DtCheck = Convert.ToDateTime(dt);
            }
            catch (Exception msk)
            {
                return false ;
            }
            return true;
        }
        public Int32 GetDateDiffDay(string FDt,string LDt)
        {

            int yFrom = Convert.ToInt32(FDt.Substring(6, 4));
            int mFrom = Convert.ToInt32(FDt.Substring(3, 2));
            int dFrom = Convert.ToInt32(FDt.Substring(0, 2));
            int yTo = Convert.ToInt32(LDt.Substring(6, 4));
            int mTo = Convert.ToInt32(LDt.Substring(3, 2));
            int dTo = Convert.ToInt32(LDt.Substring(0, 2));

            //TimeSpan ts = Convert.ToDateTime(txtToDate.Text).Subtract(Convert.ToDateTime(txtFromDate.Text));


            DateTime a = new DateTime(yFrom, mFrom, dFrom);
            DateTime b = new DateTime(yTo, mTo, dTo);
            int totDay = Convert.ToInt32(b.Subtract(a).TotalDays) + 1;
            return totDay;
        }

        public void SetSalPrd(string mnn, string yr)
        {
            toGetData("select convert(varchar,countfrom,103) as cntFrom,convert(varchar,countTo,103) as cntTo,countDays from monthlyTbl where formonth='" + mnn + "' and foryear='" + yr + "'");
            if (GblRdrToGetData.Read())
            {
                ClsVar.GblCountFrom = GblRdrToGetData["cntFrom"].ToString();
                ClsVar.GblCountTo = GblRdrToGetData["cntTo"].ToString();
                ClsVar.GblCountDays = Convert.ToInt32( GblRdrToGetData["countDays"].ToString());
            }
            else
            {
                ClsVar.GblCountFrom = DateTime.Today.ToString("dd/MM/yyyy");
                ClsVar.GblCountTo = DateTime.Today.ToString("dd/MM/yyyy");
                ClsVar.GblCountDays = 0;
            }
        }


        public string GetDtSelFormulaForDateTwo(string FDt, string LDt)
        {

            string yFrom =FDt.Substring(6, 4);
            string mFrom = FDt.Substring(3, 2);
            string dFrom = FDt.Substring(0, 2);
            string yTo = LDt.Substring(6, 4);
            string mTo = LDt.Substring(3, 2);
            string dTo = LDt.Substring(0, 2);

            //TimeSpan ts = Convert.ToDateTime(txtToDate.Text).Subtract(Convert.ToDateTime(txtFromDate.Text));

            string frmla = "Date(" + yFrom + "," + mFrom + "," + dFrom + ") to Date(" + yTo + "," + mTo + "," + dTo + ")";
            return frmla;
        }

        public string GetDtSelFormulaForDateOne(string FDt)
        {

            string yFrom = FDt.Substring(6, 4);
            string mFrom = FDt.Substring(3, 2);
            string dFrom = FDt.Substring(0, 2);

            string frmla = "Date(" + yFrom + "," + mFrom + "," + dFrom + ")";
            return frmla;
        }

        public string GetTblNm (string FDt)
        {
            DateTime dt1 = Convert.ToDateTime(FDt);
            DateTime exportedTill = Convert.ToDateTime("20/12/2017");

            if (dt1 <= exportedTill)
            {
                return "DailyAttnBak";
            }
            else
            {
                return "DailyAttn";
            }
        }
        public DataSet GblDataSet(string GblQryForCombo)
        {
            if (GblCon != null && GblCon.State != ConnectionState.Closed)
            {
                GblCon.Close();
            }

            DataSet GblDs = new DataSet();
            SqlDataAdapter GblAdp = new SqlDataAdapter(GblQryForCombo, GblCon);
            GblAdp.Fill(GblDs);
            return GblDs;
        }

        public DataTable GblDataTable(string GblQryForGrid)
        {
            if (GblCon != null && GblCon.State != ConnectionState.Closed)
            {
                GblCon.Close();
            }

            DataTable GblDt = new DataTable();
            GblCon.Open();
            //GblCon.ConnectionTimeout = 200;
            SqlDataAdapter GblAdp = new SqlDataAdapter(GblQryForGrid, GblCon);
            GblAdp.Fill(GblDt);
            GblCon.Close();
            return GblDt;
        }
        public void GetMonthYear(string MNm,string Yr)
        {

            toGetData("select convert(varchar,countfrom,103) as cntFrom,convert(varchar,countTo,103) as cntTo,countDays from monthlyTbl where formonth='" + MNm + "' and foryear='" + Yr + "'");
            if (GblRdrToGetData.Read())
            {
                ClsVar.GblCountFrom = GblRdrToGetData["cntFrom"].ToString();
                ClsVar.GblCountTo = GblRdrToGetData["cntTo"].ToString();
                ClsVar.GblCountDays = Convert.ToInt32(GblRdrToGetData["countDays"].ToString());
            }
            else
            {
                ClsVar.GblCountFrom = DateTime.Today.ToString("dd/MM/yyyy");
                ClsVar.GblCountTo = DateTime.Today.ToString("dd/MM/yyyy");
                ClsVar.GblCountDays = 0;
            }

            if (MNm == "January")
            {
                ClsVar.GblMonthNo = 1;
                ClsVar.GblMonthDays  = 31;
                ClsVar.GblFDate  = "01/01/" + Yr ;
                ClsVar.GblLDate = "31/01/" + Yr;
            }

            if (MNm == "February")
            {
                ClsVar.GblMonthNo = 2;
                    
                ClsVar.GblMonthDays = 28;
                ClsVar.GblFDate = "01/02/" + Yr;
                ClsVar.GblLDate = "28/02/" + Yr;

                if (Convert.ToInt32(Yr) % 400 == 0 || (Convert.ToInt32(Yr) % 100 != 0 && Convert.ToInt32(Yr) % 4 == 0))
                {
                    ClsVar.GblMonthDays = 29;
                }
            }
            if (MNm == "March")
            {
                ClsVar.GblMonthNo = 3;
                ClsVar.GblMonthDays = 31;
                ClsVar.GblFDate = "01/03/" + Yr;
                ClsVar.GblLDate = "31/03/" + Yr;
            }
            if (MNm == "April")
            {
                ClsVar.GblMonthNo = 4;
                ClsVar.GblMonthDays = 30;
                ClsVar.GblFDate = "01/04/" + Yr;
                ClsVar.GblLDate = "30/04/" + Yr;
            }
            if (MNm == "May")
            {
                ClsVar.GblMonthNo = 5;
                ClsVar.GblMonthDays = 31;
                ClsVar.GblFDate = "01/05/" + Yr;
                ClsVar.GblLDate = "31/05/" + Yr;
            }
            if (MNm == "June")
            {
                ClsVar.GblMonthNo = 6;
                ClsVar.GblMonthDays = 30;
                ClsVar.GblFDate = "01/06/" + Yr;
                ClsVar.GblLDate = "30/06/" + Yr;
            }
            if (MNm == "July")
            {
                ClsVar.GblMonthNo = 7;
                ClsVar.GblMonthDays = 31;
                ClsVar.GblFDate = "01/07/" + Yr;
                ClsVar.GblLDate = "31/07/" + Yr;
            }
            if (MNm == "August")
            {
                ClsVar.GblMonthNo = 8;
                ClsVar.GblMonthDays = 31;
                ClsVar.GblFDate = "01/08/" + Yr;
                ClsVar.GblLDate = "31/08/" + Yr;
            }

            if (MNm == "September")
            {
                ClsVar.GblMonthNo = 9;
                ClsVar.GblMonthDays = 30;
                ClsVar.GblFDate = "01/09/" + Yr;
                ClsVar.GblLDate = "30/09/" + Yr;
            }

            if (MNm == "October")
            {
                ClsVar.GblMonthNo = 10;
                ClsVar.GblMonthDays = 31;
                ClsVar.GblFDate = "01/10/" + Yr;
                ClsVar.GblLDate = "31/10/" + Yr;
            }

            if (MNm == "November")
            {
                ClsVar.GblMonthNo = 11;
                ClsVar.GblMonthDays = 30;
                ClsVar.GblFDate = "01/11/" + Yr;
                ClsVar.GblLDate = "30/11/" + Yr;
            }
            if (MNm == "December")
            {
                ClsVar.GblMonthNo = 12;
                ClsVar.GblMonthDays = 31;
                ClsVar.GblFDate = "01/12/" + Yr;
                ClsVar.GblLDate = "31/12/" + Yr;
            }
        }
        public void insertUpdate(string GblQry)
        {
            if (GblCon != null && GblCon.State != ConnectionState.Closed)
            {
                GblCon.Close();
            }

            SqlCommand GblCmd = new SqlCommand(GblQry, GblCon);
            GblCon.Open();
            GblCmd.ExecuteNonQuery();
            GblCon.Close();
        }

        public String DataExist(string DataExistQry)
        {
            if (GblCon != null && GblCon.State != ConnectionState.Closed)
            {
                GblCon.Close();
            }

            GblCon.Open();
            SqlCommand GblCmd = new SqlCommand(DataExistQry, GblCon);
            SqlDataReader GblRdr = GblCmd.ExecuteReader();

            if (GblRdr.Read())
            {
                GblCon.Close();
                return "1";
            }
            else
            {
                GblCon.Close();
                return "0";
            }

        }

    }


}





