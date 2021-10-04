using Dapper;
using SEDC.MovieApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text;

namespace SEDC.MovieApp.DataAccess.Repositories.DapperRepositories
{
    public class UserRepository : IUserRepository
    {
        public int Create(User entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            IEnumerable<User> users; // = new List<User>();
            using(IDbConnection db = new SqlConnection(@"Data Source=INSPIRON3537\SQLEXPRESS;Initial Catalog=MovieDB;Integrated Security=True"))
            {
                users = db.Query<User>("SELECT [UserId], [Username] FROM [User]");
                
            }

            return users;
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetByUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}
