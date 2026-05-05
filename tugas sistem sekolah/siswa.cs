using System;
using System.Collections.Generic;
using System.Text;

namespace tugas_sistem_sekolah
{
    public class Siswa : Orang
    {
        public string kelas;

        public Siswa(string nama, int umur, string kelas) : base(nama, umur)
        {
            this.kelas = kelas;
        }

        public void Belajar()
        {
            Console.WriteLine($"{nama} sedang belajar di kelas {kelas}.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} sedang melakukan aktivitas belajar di kelas {kelas}.");
        }
    }

}
