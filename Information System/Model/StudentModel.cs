using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_System.Model
{
    public class StudentModel:UserModel
    {
        public string course { get; set; }
        public string yearlevel { get; set; }
    }
    public class UpdateStudentModel: StudentModel
    {
        public string id { get; set; }
    }
}
