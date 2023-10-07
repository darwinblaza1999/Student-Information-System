using Dapper;
using Information_System.Interface;
using Information_System.Model;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Information_System.Class
{
    public class Common:ICommon
    {
        private readonly SqlConnection _connection;
        public Common()
        {
            _connection = new SqlConnection(Connection.Connect());
        }
        public Response<string> GetUserOrStudentById(string Id, string type)
        {
            var response = new Response<string>();
            try
            {
                var param = new DynamicParameters();
                param.Add("@id", Id);
                param.Add("@type", type);
                var result = _connection.QueryAsync("GetUserOrStudentById", param, commandType: CommandType.StoredProcedure).Result;
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
