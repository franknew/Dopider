using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Server
    {
        public string sid { get; set; }
        public string sname { get; set; }
        public string sfid { get; set; }
        public string line { get; set; }
        public string level { get; set; }
        public string status { get; set; }
        public DateTime? optime { get; set; }
    }
}
