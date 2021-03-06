﻿using System;
using System.Collections.Generic;

/// <summary>
/// Projek UAS Matakuliah Praktikum Pemrograman Berorientasi Objek
/// Semester Genap TA 1920
/// Dosen Pengampu : Galih Ashari R., S.Si., MT., MTA
/// Politeknik Praktisi Bandung
/// 
/// INSTRUKSI:
/// 1. Projek UAS ini belum sepenuhnya lengkap. Tugas anda adalah melengkap 
/// 2. untuk setiap komen dari script yang memiliki format = Nomor dan Perintah 
/// (contoh: **. Login user dengan parameter username dan password menggunakan konsep OOP), isikan scriptnya.
/// 3. Untuk mengerjakan semua soal ini, logika pemrograman anda harus lah baik
/// 4. Untuk beberapa tanda soal, akan diberikan contoh
/// 5. Kerjakan semua soal dengan sejelas mungkin
/// 6. URUTAN PENGERJAAN BEBAS, MANA SAJA YANG SEKIRANYA MASUK LOGIKA BERPIKIR ANDA !!!
/// 7. Soal ditandai dengan tanda 2 bintang, **
/// yang kemudian ditandai dengan barisan // ........................... YOUR CODE IS HERE ------------- 
/// disitulah anda menuliskan kode anda sebagai jawaban ujian
/// </summary>
namespace OOP_UAS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inisialisasi Data
            Console.WriteLine("INISIALISASI DATA");
            #region ** (CONTOH)
            // ** (CONTOH) buat 3 teller bank (atribut = kodepegawai, nama, nomorteller)
            // Input by User

            List<Teller> daftarTeller = new List<Teller>();
            Console.WriteLine("Data Teller:");
            for (int i = 0; i < 3; i++)
            {
                // Input User
                Console.WriteLine("Teller #" + (i + 1));
                Console.Write("Nomor KTP: "); string _ktp = Console.ReadLine();
                Console.Write("Nama: "); string _namaTeller = Console.ReadLine();
                Console.Write("Alamat: "); string _alamat = Console.ReadLine();
                Console.Write("Kode Pegawai: "); string _kPegawai = Console.ReadLine();
                Console.Write("Nomor Teller: "); string _nomorTeller = Console.ReadLine();

                // create objek teller
                Teller teller = new Teller(_ktp, _namaTeller, _alamat, _kPegawai, _nomorTeller);
                // masukkan teller ke dalam daftar Teller
                daftarTeller.Add(teller);
            }
            #endregion

            #region **
            // ** buat 4 nasabah bank (atribut = nomor rekening, nomor ktp, PIN, nama, alamat, besar setoran
            // Input by User
            List<Nasabah> daftarNasabah = new List<Nasabah>();
            // ........................... YOUR CODE IS HERE -------------            
            #endregion

            #region ** (CONTOH)
            // **. (CONTOH) Fungsi static untuk Kalimat Pembuka, parameter = nama + npm
            // input by User
            Console.Clear();
            Console.WriteLine("Masukkan Data Aplikasi Anda");
            Console.Write("nama: "); string _nama = Console.ReadLine();
            Console.Write("npm: "); string _npm = Console.ReadLine();
            Constanta.SalamPembuka(_nama, _npm);    // ini adalah fungsi static kalimat pembuka 
            #endregion

            // menu pilihan
            Console.WriteLine("Daftar Menu");
            Console.WriteLine("1. Ubah PIN");
            Console.WriteLine("2. Setoran Tunai");
            Console.WriteLine("3. Tampil Saldo");
            Console.Write("pilihan anda: "); string _pilihanMenu = Console.ReadLine();

            if (_pilihanMenu == "1")
            {
                #region ** (CONTOH)
                // tampilkan daftar nasabah -- dari fungsi static di class Constanta
                Constanta.TampilkanDaftarNasabah(daftarNasabah); 
                #endregion

                // memilih nasabah yang akan diganti PIN
                Console.Write("masukkan nomor urut nasabah yang akan diganti PIN: ");
                string _nomorRekeningPilih = Console.ReadLine();

                // code berikut ini adalah membuat objek nasabah berdasarkan daftar nasabah yang telah dipilih
                Nasabah nasabahPilih = daftarNasabah[int.Parse(_nomorRekeningPilih) - 1];
                
                // konfirmasi nasabah yang telah dipilih
                Console.WriteLine("anda memilih nasabah atas nama: " + nasabahPilih.Nama);

                // Pengisian PIN lama dan PIN baru
                Console.Write("PIN lama: "); string _pinLama = Console.ReadLine();
                Console.Write("PIN Baru: "); string _pinBaru = Console.ReadLine();

                #region **
                // Fungsi untuk mengganti PIN dari variable nasabahPilih
                // ........................... YOUR CODE IS HERE -------------
                #endregion
            }
            else if (_pilihanMenu == "2")
            {
                #region **
                // tampilkan daftar nasabah -- berasal dari class Constanta
                // ........................... YOUR CODE IS HERE -------------
                #endregion

                #region **
                // tampilkan daftar teller -- berasal dari class Constanta
                // ........................... YOUR CODE IS HERE ------------- 
                #endregion

                // memilih nasabah yang akan menyetorkan uang
                Console.Write("masukkan nomor urut nasabah yang akan menyetorkan uang: ");
                string urutNasabah = Console.ReadLine();
                Console.Write("besar setoran tunai: "); int _besaran = int.Parse(Console.ReadLine());

                #region **
                // memilih teller yang akan menerima setoran uang
                // ........................... YOUR CODE IS HERE ------------- 
                #endregion

                // kenakan ke objek nasabah dan teller yang terpilih dari DAFTAR nasabah dan teller
                Nasabah nasabahMenabung = daftarNasabah[int.Parse(urutNasabah) - 1];
                Teller tellerTerpilih = daftarTeller[int.Parse(urutTeller) - 1];

                #region **
                // berikut ini adalah pembuatan objek Menabung, yang terdiri dari nomor transaksi (input by sistem),
                // serta teller yang dipilih
                // a. buat objek dari class Menabung
                // ........................... YOUR CODE IS HERE -------------
                // b. objek nasabah yang menabung, memanggil fungsi MelakukanAktivitasMenabung
                // dengan parameternya adalah menabung dan besar setoran
                // ........................... YOUR CODE IS HERE -------------
                #endregion
            }
            else if( _pilihanMenu== "3")
            {
                #region **
                // tampilkan daftar nasabah
                // ........................... YOUR CODE IS HERE ------------- 
                #endregion
                // memilih nasabah yang akan ditampilkan saldo
                
                Console.Write("masukkan nomor urut nasabah yang akan dilihat saldonya: ");
                string urutNasabah = Console.ReadLine();

                #region **
                // a. lempar nasabah yang terpilih ke dalam objek nasabah yang baru
                // ........................... YOUR CODE IS HERE -------------                
                // b. tampilkan saldo dari objek nasabah yang telah dipilih
                // ........................... YOUR CODE IS HERE -------------               
                #endregion
            }
            else
            {
                Console.WriteLine("Pilihan anda diluar opsi");
            }

            Console.WriteLine("\nterima kasih telah menggunakan layanan kami");

            Console.ReadKey();
        }
    }
}