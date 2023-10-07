using Dapper;
using Information_System.Interface;
using Information_System.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_System.Class
{
    public class Student : IStudent
    {
        private SqlConnection connection;
        public Student()
        {
            this.connection = new SqlConnection(Connection.Connect());
        }
        public Response<object> AddNewStudent(StudentModel student)
        {
            var service = new Response<object>();
            try
            {
                var param = new DynamicParameters();
                var property = student.GetType().GetProperties();
                foreach (var item in property)
                {
                    var name = item.Name;
                    var value = item.GetValue(student);
                    param.Add(name, value);
                }

                param.Add("@retval", dbType: DbType.Int32, direction: ParameterDirection.Output);
                var result = this.connection.QueryAsync("usp_AddStudentAccount", param, commandType: CommandType.StoredProcedure);
                var ret = param.Get<int>("@retval");
                if (ret == 100)
                {
                    service.data = JsonConvert.SerializeObject(result);
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

        public Response<object> DeleteStudent(string id)
        {
            var response = new Response<object>();
            try
            {
                var param = new DynamicParameters();
                param.Add("@id", id);
                var result = this.connection.QueryAsync("usp_DeleteStudent", param, commandType: CommandType.StoredProcedure);

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

        public Response<object> UpdateStudent(UpdateStudentModel student)
        {
            var service = new Response<object>();
            try
            {
                var param = new DynamicParameters();
                var property = student.GetType().GetProperties();
                foreach (var item in property)
                {
                    var name = item.Name;
                    var value = item.GetValue(student);
                    param.Add(name, value);
                }

                param.Add("@retval", dbType: DbType.Int32, direction: ParameterDirection.Output);
                var result = this.connection.QueryAsync("usp_UpdateStudent", param, commandType: CommandType.StoredProcedure);
                var ret = param.Get<int>("@retval");
                if (ret == 100)
                {
                    service.data = JsonConvert.SerializeObject(result);
                    service.code = 200;
                    service.message = "Successfully Updated";
                }
                else
                {
                    service.data = null;
                    service.code = 300;
                    service.message = "Failed to update student.";
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

        public Response<string> ViewStudent()
        {
            var response = new Response<string>();
            try
            {
                var param = new DynamicParameters();
                var result = this.connection.QueryAsync("usp_ViewStudent", commandType: CommandType.StoredProcedure).Result;
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
