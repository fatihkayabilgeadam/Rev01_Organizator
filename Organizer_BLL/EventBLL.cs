using Organizer_DAL;
using Organizer_Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer_BLL
{
    public static class EventBLL
    {
       static DataContext dataContext = new DataContext();
        public static List<Events> GetEvents()
        {
            List<Events> eventList = dataContext.Events.ToList();
            return eventList;
        }
        public static void AddEvent(Events filledEvent)
        {
            dataContext.Events.Add(filledEvent);
            dataContext.SaveChanges();
        }
        public static List<Events> GetMyEvents (int ownerid)
        {
            List<Events> liste = dataContext.Events.Where(x => x.OwnerID == ownerid).ToList();
            return liste;
        }
    
             
        //public static int Topla(int a,int b)
        //{
        //    int c= a + b;
        //    return c;
        //}


    }
}
