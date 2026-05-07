using tugas_sistem_sekolah;

class Program
{
    static void Main(string[] args)
    {
        //objek sekolah
        Sekolah sekolah = new Sekolah();

        //objek orang (guru dan siswa)
        GuruMatematika guru1 = new GuruMatematika("Budi", 30, "Matematika");
        GuruBahasa guru2 = new GuruBahasa("Siti", 28, "Bahasa Indonesia");
        SiswaSMA siswasma1 = new SiswaSMA("Andi", 15, "X IPA 1");
        SiswaSD siswasd1 = new SiswaSD("Rina", 10, "V SD");

        // tambah ke sekolah
        sekolah.TambahOrang(guru1);
        sekolah.TambahOrang(guru2);
        sekolah.TambahOrang(siswasma1);
        sekolah.TambahOrang(siswasd1);

        // tampilkan semua orang 
        sekolah.DaftarOrang();

        // demonstrasi polymorphism
        List<Orang> list = new List<Orang>()
        {
            siswasma1,
            siswasd1,
            guru1,
            guru2
        };

        foreach (Orang o in list)
        {
            o.Aktivitas();
        }

        // panggil method khusus
        guru1.MengajarHitung();
        guru2.MengajarBahasa();
        siswasma1.UjianNasional();
        siswasd1.Main();

        // soal nomer 1
        Console.WriteLine("Soal nomer 1:");
        guru1.Aktivitas();
        siswasma1.Aktivitas();

        //soal nomer 2
        Console.WriteLine("\nSoal nomer 2:");
        guru1.MengajarHitung();

        //soal nomer 3
        Console.WriteLine("\nSoal nomer 3:");
        guru1.InfoOrang();

        //soal nomer 4
        Console.WriteLine("\nSoal nomer 4:");
        siswasma1.UjianNasional();

        //soal nomer 5
        Console.WriteLine("\nSoal nomer 5:");
        Orang siswasd2 = new SiswaSD("Deo", 12, "VI SD");
        sekolah.TambahOrang(siswasd2);
        siswasd2.Aktivitas();
    }
}