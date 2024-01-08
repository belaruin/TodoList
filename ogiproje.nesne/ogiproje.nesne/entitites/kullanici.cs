using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogiproje.nesne.entitites
{
    public class kullanici
    {
        public Guid Id { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre {  get; set; }
    }
}
