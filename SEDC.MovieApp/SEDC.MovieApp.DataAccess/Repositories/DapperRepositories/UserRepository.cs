using Dapper;
using Dapper.Contrib.Extensions;
//using Dapper.Contrib;
using SEDC.MovieApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SEDC.MovieApp.DataAccess.Repositories.DapperRepositories
{
    public class UserRepository : IUserRepository
    {
        private const string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MovieDB;Integrated Security=True";

        public int Create(User entity)
        {
            string hashed;
            using (MD5 md5 = MD5.Create())
            {
                byte[] passwordBytes = Encoding.ASCII.GetBytes(entity.Password);
                List<byte> hashedBytes = md5.ComputeHash(passwordBytes).ToList();
                StringBuilder sb = new StringBuilder();
                hashedBytes.ForEach(b => sb.Append(b.ToString("X2")));
                hashed = sb.ToString();
            }
            using IDbConnection db = new SqlConnection(ConnectionString);
            db.Open();
            using var transaction = db.BeginTransaction();
            int id = db.QuerySingle<int>(@"
INSERT INTO [User] ([Username], [Password]) 
OUTPUT INSERTED.[UserId] 
VALUES (@username, @password);", new { username = entity.Username, password = hashed }, transaction);
            transaction.Commit();
            return id;
        }

        public IEnumerable<User> GetAll()
        {
            IEnumerable<User> users; // = new List<User>();
            using IDbConnection db = new SqlConnection(ConnectionString);
            users = db.Query<User>("SELECT [UserId], [Username] FROM [User];");

            return users;
        }

        public User GetById(int id)
        {
            using IDbConnection db = new SqlConnection(ConnectionString);
            return db.QuerySingleOrDefault<User>(@"
SELECT [UserId], [Username] 
FROM [User] 
WHERE [UserId] = @id;", new { id });
        }

        public User GetByUsername(string username)
        {
            using IDbConnection db = new SqlConnection(ConnectionString);
            return db.QuerySingleOrDefault<User>(@"
SELECT [UserId], [Username]
FROM [User] 
WHERE [Username] = @username;", new { username });
        }
    }
}
