using Information_System.Interface;
using Information_System.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Newtonsoft.Json;
using System.Security.Principal;

namespace Information_System.Class
{
    public class User : IUser
    {
        private SqlConnection _connect;
        public User()
        {
            _connect = new SqlConnection(Connection.Connect());
        }

        public Response<object> DeleteUser(string id)
        {
            var response = new Response<object>();
            try
            {
                var param = new DynamicParameters();
                param.Add("@id", id);
                var result = _connect.QueryAsync("usp_DeleteUser", param, commandType: CommandType.StoredProcedure);

                response.data = null;
                response.code = 200;
                response.message = "Successfuly deleted";
            }
            catch (Exception ex)
            {
                response.data = null;
                response.code = 500;
                response.message = ex.Message;
            }

            return response;
        }

        public async Task<Response<object>> InsertNewUser(UserModel user)
        {
            var service = new Response<object>();
            try
            {
                var param = new DynamicParameters();
                var property = user.GetType().GetProperties();
                foreach (var item in property)
                {
                    var name = item.Name;
                    var value = item.GetValue(user);
                    param.Add(name, value);
                }

                param.Add("@retval", dbType: DbType.Int32, direction: ParameterDirection.Output);
                var result = await _connect.QueryAsync("usp_AddUserAccount", param, commandType: CommandType.StoredProcedure);
                var ret = param.Get<int>("@retval");
                if (ret == 100)
                {
                    service.data = JsonConvert.SerializeObject(result.ToList());
                    service.code = 200;
                    service.message = "Register Successfully";
                }
                else
                {
                    service.data = null;
                    service.code = 300;
                    service.message = "Failed to insert new user.";
                }
            }
            catch (Exception ex)
            {
                service.data = null;
                service.code = 500;
                service.message = ex.Message;
            }
            return service;
        }

        public Response<LoginResult> Login(AccountModel userLogin)
        {
            var service = new Response<LoginResult>();
            try
            {
                var param = new DynamicParameters();
                var property = userLogin.GetType().GetProperties();
                foreach (var item in property)
                {
                    var name = item.Name;
                    var value = item.GetValue(userLogin);
                    param.Add(name, value);
                }

                param.Add("@retval", dbType: DbType.Int32, direction: ParameterDirection.Output);
                var result = _connect.QueryAsync<LoginResult>("usp_Login", param, commandType: CommandType.StoredProcedure).Result.FirstOrDefault();
                var ret = param.Get<int?>("@retval");
                if (ret == 100)
                {
                    service.data = result;
                    service.code = 200;
                    service.message = "Successfully login";
                }
                else
                {
                    service.data = null;
                    service.code = 300;
                    service.message = "Failed to login";
                }
            }
            catch (Exception ex)
            {

                service.data = null;
                service.code = 500;
                service.message = ex.Message;
            }

            return service;
        }

        public Response<object> UpdateAccount(UpdateAccount account)
        {
            var response = new Response<object>();
            try
            {
                var param = new DynamicParameters();
                var property = account.GetType().GetProperties();
                foreach (var item in property)
                {
                    var name = item.Name;
                    var value = item.GetValue(account);
                    param.Add(name, value);
                }

                var result = _connect.QueryAsync("usp_UpdateAccount", param, commandType: CommandType.StoredProcedure);
                response.data = null;
                response.code = 200;
                response.message = "Username and password successfully updated.";
            }
            catch (Exception ex)
            {
                response.data = null;
                response.code = 500;
                response.message = ex.Message;
            }

            return response;
        }

        public Response<object> UpdateUserAccount(UpdateUserModel user)
        {
            var service = new Response<object>();
            try
            {
                var param = new DynamicParameters();
                var property = user.GetType().GetProperties();
                foreach (var item in property)
                {
                    var name = item.Name;
                    var value = item.GetValue(user);
                    param.Add(name, value);
                }

                param.Add("@retval", dbType: DbType.Int32, direction: ParameterDirection.Output);
                var result = _connect.QueryAsync("usp_UpdateUser", param, commandType: CommandType.StoredProcedure);
                var ret = param.Get<int>("@retval");
                if (ret == 100)
                {
                    service.data = null;
                    service.code = 200;
                    service.message = "Successfully updated";
                }
                else
                {
                    service.data = null;
                    service.code = 200;
                    service.message = "Failed to update";
                }
            }
            catch (Exception ex)
            {

                service.data = null;
                service.code = 200;
                service.message = ex.Message;
            }

            return service;
        }

        public Response<string> ViewUser()
        {
            var response = new Response<string>();
            try
            {
                var param = new DynamicParameters();
                var result = _connect.QueryAsync("usp_ViewUsers", commandType: CommandType.StoredProcedure).Result;
                if (result.Count() > 0)
                {
                    response.data = JsonConvert.SerializeObject(result);
                    response.code = 200;
                    response.message = "Recod found";
                }
                else
                {
                    response.data = JsonConvert.SerializeObject(result);
                    response.code = 300;
                    response.message = "No Recod found";
                }
            }
            catch (Exception ex)
            {
                response.data = null;
                response.code = 500;
                response.message = ex.Message;
            }

            return response;
        }
    }
}
