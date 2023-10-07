using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_System.Model
{
    public class AccountModel
    {
        public string username { get; set; }
        public string password { get; set; }
    }
    public class UpdateAccount:AccountModel
    {
        public string id { get; set; }
    }
}
