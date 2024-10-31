using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab7.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        // 外键
        public int UniversityCampusID { get; set; }

        // 导航属性
        public virtual UniversityCampus UniversityCampus { get; set; }
    }
}