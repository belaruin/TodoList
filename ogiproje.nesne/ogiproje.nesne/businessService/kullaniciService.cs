﻿using ogiproje.nesne.database;
using ogiproje.nesne.entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogiproje.nesne.businessService
{
    public class kullaniciService
    {
        public kullanici kullaniciKontrol(string kullaniciAdi, string sifre)
        {
            return sanalDatabase.kullaniciTablo.Where(x => x.kullaniciAdi == kullaniciAdi && x.sifre == sifre).FirstOrDefault();

        }
    }
}
