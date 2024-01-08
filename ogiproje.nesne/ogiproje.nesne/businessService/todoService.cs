using ogiproje.nesne.database;
using ogiproje.nesne.entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogiproje.nesne.businessService
{
    public class todoService
    {
        public int kayitKontrol()
        {
            return sanalDatabase.todoTablo.Count;
        }
        public List<todo> kayitListe()
        {
            return sanalDatabase.todoTablo;
        }

        public int kayitYeni(todo data)
        {
            try
            {
                sanalDatabase.todoTablo.Add(data);
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
            

        }
    }
}
