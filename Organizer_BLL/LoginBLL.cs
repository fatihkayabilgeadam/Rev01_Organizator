using Organizer_DAL;
using Organizer_Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer_BLL
{
   public static class LoginBLL
    {
        static DataContext dbContext = new DataContext();
        public static Users LoginUser(string username, string password)
        {
            Users user = dbContext.Users.Where(x => x.Email == username && x.Password == password).FirstOrDefault();
            return user;
        }
        
    }
}
