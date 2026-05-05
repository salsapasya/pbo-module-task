using System;
using System.Collections.Generic;
using System.Text;

namespace tugas_sistem_sekolah
{
    public class SiswaSD : Siswa
    {
        public SiswaSD(string nama, int umur, string kelas) : base(nama, umur, kelas)
        {
        }

        public void Main()
        {
            Console.WriteLine($"{nama} sedang bermain di kelas {kelas}.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{nama} sedang melakukan aktivitas bermain di kelas {kelas}.");
        }
    }


}
