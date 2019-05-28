using Organizer_DAL;
using Organizer_Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer_BLL
{
    public static class UserBLL
    {
      static DataContext dbContext = new DataContext(); 

        public static void InsertUser(Users user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }
    }
}
