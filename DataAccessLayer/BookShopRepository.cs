using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.Data
{
    public class BookShopRepository : IBookShopRepository
    {
        public IEnumerable<User> GetUsers()
        {
            using (SqlConnection connection = ConnectionManager.CreateConnection())
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[GetUsers]";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var users = new List<User>();
                        if (reader.HasRows)
                        {
                            int stdId = reader.GetOrdinal("Id");
                            int stdName = reader.GetOrdinal("Name");
                            int stdSurname = reader.GetOrdinal("Surname");
                            int stdEmail = reader.GetOrdinal("Email");
                            int stdAccountNumber = reader.GetOrdinal("AccountNumber");
                            int stdBalance = reader.GetOrdinal("Balance");
                            int stdAddress = reader.GetOrdinal("Address");

                            while (reader.Read())
                            {
                                users.Add(
                                    new User
                                    {
                                        Id = reader.GetInt32(stdId),
                                        Name = reader.GetString(stdName),
                                        Surname = reader.GetString(stdSurname),
                                        Email = reader.GetString(stdEmail),
                                        AccountNumber = reader.GetString(stdAccountNumber),
                                        Balance = reader.GetDecimal(stdBalance),
                                        Address = reader.GetString(stdAddress)
                                    });
                            }
                        }

                        return users;
                    }
                }
            }
        }
        public User GetUser(int id)
        {
            using (SqlConnection connection = ConnectionManager.CreateConnection())
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[GetUser]";
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var user = new User();
                        if (reader.HasRows)
                        {
                            int stdId = reader.GetOrdinal("Id");
                            int stdName = reader.GetOrdinal("Name");
                            int stdSurname = reader.GetOrdinal("Surname");
                            int stdEmail = reader.GetOrdinal("Email");
                            int stdAccountNumber = reader.GetOrdinal("AccountNumber");
                            int stdBalance = reader.GetOrdinal("Balance");
                            int stdAddress = reader.GetOrdinal("Address");
                            int stdDateOfBirth = reader.GetOrdinal("DateOfBirth");

                            while (reader.Read())
                            {
                                user.Id = reader.GetInt32(stdId);
                                user.Name = reader.GetString(stdName);
                                user.Surname = reader.GetString(stdSurname);
                                user.Email = reader.GetString(stdEmail);
                                user.AccountNumber = reader.GetString(stdAccountNumber);
                                user.Balance = reader.GetDecimal(stdBalance);
                                user.Address = reader.GetString(stdAddress);
                            }
                        }

                        return user;
                    }
                }
            }
        }

        public int AddUser(User user)
        {
            using (SqlConnection connection = ConnectionManager.CreateConnection())
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[AddUser]";

                    command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = user.Name;
                    command.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = user.Surname;
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = user.Email;
                    command.Parameters.Add("@AccountNumber", SqlDbType.VarChar).Value = user.AccountNumber;
                    command.Parameters.Add("@Balance", SqlDbType.Decimal).Value = user.Balance;
                    command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = user.Address;

                    SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
                    id.Direction = ParameterDirection.Output;
                    command.Parameters.Add(id);

                    command.ExecuteNonQuery();
                    return Convert.ToInt32(command.Parameters["@id"].Value);
                }
            }
        }

        public void UpdateUser(User user)
        {
            using (SqlConnection connection = ConnectionManager.CreateConnection())
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[UpdateUser]";

                    command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = user.Name;
                    command.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = user.Surname;
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = user.Email;
                    command.Parameters.Add("@AccountNumber", SqlDbType.VarChar).Value = user.AccountNumber;
                    command.Parameters.Add("@Balance", SqlDbType.Int).Value = user.Balance;
                    command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = user.Address;

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteUser(int id)
        {
            using (SqlConnection connection = ConnectionManager.CreateConnection())
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[DeleteUser]";

                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
