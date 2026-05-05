using System;
using System.Collections.Generic;
using System.Text;

namespace tugas_sistem_sekolah
{
    public class GuruBahasa : Guru
    {
        public GuruBahasa(string nama, int umur, string mataPelajaran) : base(nama, umur, mataPelajaran)
        {
        }

        public void MengajarBahasa()
        {
            Console.WriteLine($"{nama} sedang mengajar bahasa {mataPelajaran}.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} sedang melakukan aktivitas mengajar bahasa pada mata pelajaran{mataPelajaran}.");
        }
        
    }
}
