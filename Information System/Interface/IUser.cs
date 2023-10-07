using Information_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_System.Interface
{
    public interface IUser
    {
        Task<Response<object>> InsertNewUser(UserModel user);
        Response<object> UpdateAccount(UpdateAccount user);
        Response<object> UpdateUserAccount(UpdateUserModel user);
        Response<LoginResult> Login(AccountModel userLogin);
        Response<string> ViewUser();
        Response<object> DeleteUser(string id);
    }
}
