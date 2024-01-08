using ogiproje.nesne.entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogiproje.nesne.database
{
    public static class sanalDatabase
    {
        public static List<kullanici> kullaniciTablo;
        public static List<todo> todoTablo;

        static sanalDatabase()
        {
            kullaniciTablo = new List<kullanici>();

            kullaniciTablo.Add(new kullanici() { Id = Guid.NewGuid(), kullaniciAdi = "test1", sifre = "1" });
            todoTablo = new List<todo>();
        }
    }
}   