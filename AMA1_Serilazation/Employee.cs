using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AMA1_Serilazation
{
    [Serializable]
    public class Employee
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public DateTime DoB { get; set; }
        public int Salary { get; set; }
    }
}

