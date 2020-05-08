﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_UAS
{
    class Menabung
    {
        private string noTransaksi;
        private Teller teller;

        public string NoTransaksi { get { return this.noTransaksi; } set { this.noTransaksi = value; } }
        public Teller _Teller { get { return this.teller; } set { this.teller = value; } }

        public Menabung(string _noTransaksi, Teller _teller)
        {
            this.noTransaksi = _noTransaksi;
            this.teller = _teller;
        }
    }
}
