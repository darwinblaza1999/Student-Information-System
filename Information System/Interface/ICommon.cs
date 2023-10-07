using Information_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_System.Interface
{
    public interface ICommon
    {
        Response<string> GetUserOrStudentById(string id, string type);
    }
}
