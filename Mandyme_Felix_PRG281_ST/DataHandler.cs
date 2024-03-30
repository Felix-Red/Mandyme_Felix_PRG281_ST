using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandyme_Felix_PRG281_ST
{
    class DataHandler
    {
        public List<Student> GetStudents()
        {
            List<Student> campusStudents = new List<Student>();
            campusStudents.Add(new FullTime(577922, "Felix", 67, "Pass", 80000, 900000, "Full Time"));
            campusStudents.Add(new PartTime(511922, "Ashley", 100, "Pass with dinstinction", 70000, 970000, "Part Time"));
            campusStudents.Add(new FullTime(567922, "Tumi",  40, "Fail", 80000, 900000, "Full Time"));
            campusStudents.Add(new PartTime(540922, "Austin", 70, "Pass", 70000, 900000, "Part Time"));

            return campusStudents;
        }
    }
}
