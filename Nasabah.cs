using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_UAS
{
    #region **
    // **. Class Nasabah merupakan turunan dari kelas Person 
    #endregion
    class Nasabah
    {
        #region Atribut Nasabah - Private Access        
        private string noRekening;
        private string noPIN;
        private int besarSetoranTunai;
        private int saldo;
        private Menabung menabung;
        #endregion

        #region **
        // **. buat properties untuk setiap private atribut                
        // ........................... YOUR CODE IS HERE ------------- 
        #endregion

        #region **
        // **. Buatkan Constructor dengan parameter nya adalah noktp, 
        // nama, alamat, besar setoran awal
        // isikan nilainya ke informasi dari nasabah
        public Nasabah(string _noktp, string _nama, string _alamat, string _norek, string _noPIN, int besarstoran)
        {
            // a. isikan nilai-nilainya
            // ........................... YOUR CODE IS HERE ------------- 

            // b. tambahkan besar setoran tunai awal ke saldo
            // ........................... YOUR CODE IS HERE ------------- 
        } 
        #endregion

        #region **
        // buatlah fungsi untuk nasabah melakukan cek saldo tabungan saat ini
        // dari variable saldo
        public void TampilkanSaldo()
        {
            Console.WriteLine("Saldo anda saat ini adalah " + this.saldo);
        }
        #endregion

        #region **
        // buatlah fungsi untuk nasabah melakukan penggantian nomor pin
        // terdiri dari parameter = PIN lama, PIN baru
        // PIN lama digunakan untuk validasi
        // Tampilkan info jika pin telah diganti (contoh: PIN lama anda = 7948, telah diganti menjadi = 2222)
        // tampilkan juga info jika pin lama adalah salah (contoh: PIN LAMA salah, anda tidak dapat mengganti PIN)
        public void GantiPIN(string _PINLAMA, string _PINBARU)
        {
            if (_PINLAMA == this.noPIN)
            {
                this.noPIN = _PINBARU;
                Console.WriteLine("PIN lama anda: " + _PINLAMA + ", telah diganti menjadi " + _PINBARU);
            }
            else
            {
                Console.WriteLine("PIN lama anda salah, anda gagal mengganti nomor PIN");
            }
        }
        #endregion

        #region **
        // buatlah fungsi untuk menabung, yaitu memberikan setoran tunai yang akan menambahkan jumlah saldo
        // parameter input adalah Menabung, yang terdiri dari nomor transaksi dan teller yang melakukan transaksi
        // tampilkan informasi/pesan di akhir setelah melakukan proses menabung
        // contoh: "No transaksi = xxxx, nama teller = Teller 1, Setoran = Rp Xxx, saldo anda = Rp XXXX)
        public void MelakukanAktivitasMenabung(Menabung _menabung, int _setoran)
        {
            // store variable _menabung ke variable menabung yang ada di class ini
            this.menabung = _menabung;
            // nilai _setoran menambahkan nilai saldo nasabah
            this.saldo += _setoran;
            // tampilkan pesan akhir -------------
            Console.WriteLine("Transaksi Menabung");
            // a. tampilkan nomor transaksi
            Console.WriteLine("No Transaksi: " + _menabung.NoTransaksi);
            // b. tampilkan nama teller
            Console.WriteLine("Teller: " + _menabung._Teller.Nama);
            // c. tampilkan jumlah setoran
            Console.WriteLine("Jumlah Setoran: " + _setoran);
            // d. tampilkan saldo anda saat ini
            Console.WriteLine("Saldo anda: " + this.saldo);
        }
        #endregion
    }
}