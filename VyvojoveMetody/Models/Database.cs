using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyvojoveMetody.Models
{
    public sealed class Database
    {
       
        private static Database instance = null;
       

        Database()
        {
             persons = new Dictionary<string, Person>();
        }

        public static Database DatabaseManagement 
        {
            get 
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        
        }

        public Dictionary<string, Person> persons;
    }
}
