using System;
using System.Collections.Generic;
using System.Text;

namespace tugas_sistem_sekolah
{
    public class SiswaSMA : Siswa
    {
        public SiswaSMA(string nama, int umur, string kelas) : base(nama, umur, kelas)
        {
        }
        public void UjianNasional()
        {
            Console.WriteLine($"{nama} sedang mengikuti ujian nasional di kelas {kelas}.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} sedang melakukan aktivitas mengikuti ujian nasional di kelas {kelas}.");
        }
    }
}
