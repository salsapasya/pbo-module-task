using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace tugas_sistem_sekolah
{
    public class Orang
    {
        public string nama;
        public int umur;

        public Orang(string nama, int umur)
        {
            this.nama = nama;
            this.umur = umur;
        }

        public virtual void Aktivitas()
        {
            Console.WriteLine($"{nama} sedang melakukan aktivitas.");
        }

        public virtual void InfoOrang()
        {
            Console.WriteLine($"Nama : {nama}");
            Console.WriteLine($"Umur : {umur} tahun");
        }
    }
}
