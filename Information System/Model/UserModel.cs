using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_System.Model
{
    public class UserModel
    {
        public string firstname { get; set; } 
        public string middlename { get; set; } 
        public string lastname { get; set; } 
        public string address { get; set; } 
        public string email { get; set; } 
        public long conNo { get; set; } 
    }
    public class UpdateUserModel:UserModel
    {
        public string id { get; set; }
    }
    public class LoginResult
    {
        public string id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int roles { get; set;}
    }

}
