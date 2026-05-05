using System;
using System.Collections.Generic;
using System.Text;

namespace tugas_sistem_sekolah
{
    public class GuruMatematika : Guru
    {
        public GuruMatematika(string nama, int umur, string mataPelajaran) : base(nama, umur, mataPelajaran)
        {
        }

        public void MengajarHitung()
        {
            Console.WriteLine($"{nama} sedang mengajar menghitung pada mata pelajaran {mataPelajaran}.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} sedang melakukan aktivitas mengajar matematika pada mata pelajaran {mataPelajaran}.");
        }
        public override void InfoOrang()
        {
            base.InfoOrang();
            Console.WriteLine($"Mata Pelajaran : {mataPelajaran}");
        }
    }
}
