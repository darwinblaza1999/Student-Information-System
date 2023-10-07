using Information_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_System.Interface
{
    public interface IStudent
    {
        Response<object> AddNewStudent(StudentModel student);
        Response<object> UpdateStudent(UpdateStudentModel student);
        Response<string> ViewStudent();
        Response<object> DeleteStudent(string id);
    }
}
