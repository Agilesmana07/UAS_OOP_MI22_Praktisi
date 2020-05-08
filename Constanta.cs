using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_UAS
{
    class Constanta
    {
        #region ** (CONTOH)
        // **. (CONTOH) Membuat fungsi static untuk salam pembuka
        // dengan dua parameter - nama & npm
        public static void SalamPembuka(string nama, string npm)
        {
            Console.Clear();
            Console.WriteLine("============================");
            Console.WriteLine("Selamat Datang di Projek UAS");
            Console.WriteLine("Nama Developer: " + nama);
            Console.WriteLine("NPM: " + npm);
            Console.WriteLine("============================");
        } 
        #endregion

        #region ** (CONTOH)
        // **. (CONTOH) membuat fungsi static untuk menampilkan daftar teller dari suatu list
        public static void TampilkanDaftarTeller(List<Teller> _teller)
        {
            Console.WriteLine("Daftar Teller");
            for (int i = 0; i < _teller.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + _teller[i].KodePegawai + "-" + _teller[i].Nama);
            }
        }
        #endregion

        #region **
        // **. Buat fungsi static untuk menampilkan daftar nasabah dari list
        public static void TampilkanDaftarNasabah(List<Nasabah> _nasabah)
        {
            Console.WriteLine("Daftar Nasabah");
            for (int i = 0; i < _nasabah.Count; i++)
            {
                Console.WriteLine((i + 1) + ". Norek: " + _nasabah[i].NoRekening 
                    + ", atas nama " + _nasabah[i].Nama + ", saldo saat ini: " 
                    + _nasabah[i].Saldo);
            }
        }
        #endregion
    }
}