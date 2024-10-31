using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab7.Models
{
    public class UniversityCampus
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // 导航属性
        public virtual ICollection<Student> Students { get; set; }
    }

    

}