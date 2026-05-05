using System;
using System.Collections.Generic;
using System.Text;

namespace tugas_sistem_sekolah
{
    public class Guru : Orang
    {
        public string mataPelajaran;

        public Guru(string nama, int umur, string mataPelajaran) : base(nama, umur)
        {
            this.mataPelajaran = mataPelajaran;
        }

        public void Mengajar()
        {
            Console.WriteLine($"{nama} sedang mengajar mata pelajaran {mataPelajaran}.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} sedang melakukan aktivitas mengajar mata pelajaran {mataPelajaran}.");
        }
    }
    
}
