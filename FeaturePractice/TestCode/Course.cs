using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    public class Course
    {
        public string Title { get; set; }
        public List<Topic> Topics { get; set; }
        public double Fees { get; set; }
    }
}
