using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultManagement
{
    public class ReportFiled
    {
        public string ClsRoll { get; set; }      
        public decimal AdsCost { get; set; }
        public decimal CourseCost { get; set; }
        public DateTime AdsDate { get; set; }
        public string StName { get; set; }
        public string TchName { get; set; }
        public string CrsName { get; set; }
        public string ImageName { get; set; }
        public byte[] ImageData { get; set; }       
    }
}
