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
                            int stdName = reader.GetOrdinal("UserName");
                            int stdPassword = reader.GetOrdinal("Password");
                            int stdEmail = reader.GetOrdinal("EmailAddress");
                            int stdRole = reader.GetOrdinal("Role");
                            int stdSurname = reader.GetOrdinal("Surname");
                            int stdGivenName = reader.GetOrdinal("GivenName");

                            while (reader.Read())
                            {
                                users.Add(
                                    new User
                                    {
                                        Id = reader.GetInt32(stdId),
                                        UserName = reader.GetString(stdName),
                                        Password = reader.GetString(stdSurname),
                                        EmailAddress = reader.GetString(stdEmail),
                                        Role = reader.GetString(stdRole),
                                        Surname = reader.GetString(stdSurname),
                                        GivenName = reader.GetString(stdGivenName)
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
                            int stdName = reader.GetOrdinal("UserName");
                            int stdPassword = reader.GetOrdinal("Password");
                            int stdEmail = reader.GetOrdinal("EmailAddress");
                            int stdRole = reader.GetOrdinal("Role");
                            int stdSurname = reader.GetOrdinal("Surname");
                            int stdgivenName = reader.GetOrdinal("GivenName");

                            while (reader.Read())
                            {
                                user.Id = reader.GetInt32(stdId);
                                user.UserName = reader.GetString(stdName);
                                user.Password = reader.GetString(stdSurname);
                                user.EmailAddress = reader.GetString(stdEmail);
                                user.Role = reader.GetString(stdRole);
                                user.Surname = reader.GetString(stdSurname);
                                user.GivenName = reader.GetString(stdgivenName);
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

                    command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = user.UserName;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar).Value = user.EmailAddress;
                    command.Parameters.Add("@Role", SqlDbType.VarChar).Value = user.Role;
                    command.Parameters.Add("@Surname", SqlDbType.Decimal).Value = user.Surname;
                    command.Parameters.Add("@GivenName", SqlDbType.NVarChar).Value = user.GivenName;
                    
                    return command.ExecuteNonQuery();
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

                    command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = user.UserName;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar).Value = user.EmailAddress;
                    command.Parameters.Add("@Role", SqlDbType.VarChar).Value = user.Role;
                    command.Parameters.Add("@Surname", SqlDbType.Decimal).Value = user.Surname;
                    command.Parameters.Add("@GivenName", SqlDbType.NVarChar).Value = user.GivenName;

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
        public IEnumerable<Books> GetBooksWithPicturesAndSellers()
        {
            using (SqlConnection connection = ConnectionManager.CreateConnection())
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[GetBooks]";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var bookList = new List<Books>();
                        if (reader.HasRows)
                        {
                            int stdId = reader.GetOrdinal("Id");
                            int stdTitle = reader.GetOrdinal("Title");
                            int stdAuthor = reader.GetOrdinal("Author");
                            int stdCost = reader.GetOrdinal("Cost");
                            int stdGenre = reader.GetOrdinal("Genre");
                            int stdPublishDate = reader.GetOrdinal("PublishYear");

                            while (reader.Read())
                            {
                                bookList.Add(
                                    new Books
                                    {
                                        Id = reader.GetInt32(stdId),
                                        Title = reader.GetString(stdTitle),
                                        Author = reader.GetString(stdAuthor),
                                        Cost = reader.GetDecimal(stdCost),
                                        Genre = reader.GetString(stdGenre),
                                        PublishYear = reader.GetInt32(stdPublishDate)
                                    });
                            }
                        }
                        return bookList;
                    }
                }
            }
        }
        public int AddBook(Books user)
        {
            using (SqlConnection connection = ConnectionManager.CreateConnection())
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "[dbo].[AddBook]";

                    command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = user.Title;
                    command.Parameters.Add("@Author", SqlDbType.NVarChar).Value = user.Author;
                    command.Parameters.Add("@Genre", SqlDbType.VarChar).Value = user.Genre;
                    command.Parameters.Add("@Cost", SqlDbType.Money).Value = user.Cost;
                    command.Parameters.Add("@PublishYear", SqlDbType.Int).Value = user.PublishYear;
                    
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
