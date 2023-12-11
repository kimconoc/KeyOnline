using KeyOnline.MvcCore.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seafood.Models
{
    public class NapTheResponse
    {
        public NapTheEnum code { get; set; }
        public string msg { get; set; }
        public object info_card { get; set; }
        public string seri { get; set; }
        public string pin { get; set; }
        public string note { get; set; }
        public object transaction_id { get; set; }
    }
}