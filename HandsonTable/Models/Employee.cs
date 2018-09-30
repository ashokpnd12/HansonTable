using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsonTable.Models
{
    public class Employee
    {
        public int empId { get; set; }
        public string name { get; set; }
        public string designation { get; set; }
        public bool isPunctual { get; set; }
        public string performance { get;set; }
        public string mobile { get; set; }
        public decimal ctc { get; set; }
        public DateTime doj { get; set; }
    }
}