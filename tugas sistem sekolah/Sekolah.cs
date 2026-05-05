using System;
using System.Collections.Generic;
using System.Text;

namespace tugas_sistem_sekolah
{
    public class Sekolah
    {
        private List<Orang> daftarOrang = new List<Orang>();
        public void TambahOrang(Orang orang)
        {
            daftarOrang.Add(orang);
        }
        public void DaftarOrang()
        {
            foreach (var orang in daftarOrang)
            {
                Console.WriteLine($"Nama: {orang.nama}, Umur: {orang.umur}");
                Console.WriteLine();
            }
        }
    }
}
