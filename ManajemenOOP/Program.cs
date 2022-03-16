using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenOOP
{
    class Program
    {
        //int tambahgaji(int a, int b)
        //{
        //    return a + b;
        //}
        static void Main(String[] args)
        {

            /*List<string> np = new List<string>();
            List<string> nk = new List<string>();
            List<int> gaji = new List<int>();
            Employee employee = new Employee();*/

            Employee Data1 = new Employee();
            Employee DI = new Employee();
            List<Employee> employee = new List<Employee>();
            Data1.Nama = "Gilang Rizky";
            Data1.Nomor = "1";
            Data1.Gaji = 1000000;
            employee.Add(Data1);
            Data1.Menampilkan();
            string perulangan;


            Console.WriteLine("Silahkan masukan nama anda ");
            string nama = Console.ReadLine();
            do
            {
                Console.WriteLine("Hallo " + nama);
                Console.WriteLine("Apa yang mau dilakukan ?");
                Console.WriteLine("1. Tambah Pegawai ");
                Console.WriteLine("2. Hapus Pegawai ");
                //Console.WriteLine("3. Tambah Gaji Pegawai ");
                string pil = Console.ReadLine();
                pil.ToLower();

                if (pil == "tambah pegawai" || pil == "1")
                {

                    foreach (var item in employee)
                    {

                        item.Menampilkan();

                    }
                    Console.WriteLine("\n");

                    Console.WriteLine("Masukan Nama Pegawai ");
                    DI.Nama = Console.ReadLine();

                    Console.WriteLine("Masukan Nomor pegawai ");
                    DI.Nomor = Console.ReadLine();
                    
                    Console.WriteLine("Masukan besaran Gaji ");
                    string gaji = Console.ReadLine();
                    DI.Gaji = int.Parse(gaji);
                    employee.Add(DI);
                }
                else if (pil == "hapus pegawai" || pil == "2")
                {
                    foreach (var item in employee)
                    {

                        item.Menampilkan();

                    }
                    Console.WriteLine("\n");

                    Console.WriteLine("Masukan Nama Pegawai yang mau dihapus ");
                    DI.Nama = Console.ReadLine();

                    Console.WriteLine("Masukan Nomor pegawai yang mau dihapus ");
                    DI.Nomor = Console.ReadLine();

                    Console.WriteLine("Masukan besaran Gaji yang mau dihapus ");
                    string gaji = Console.ReadLine();
                    DI.Gaji = int.Parse(gaji);
                    employee.Remove(DI);


                }
                // else if (pil == " tambah gaji pegawai ") 
                // {
                //  foreach (var pair in np.Zip(gaji, (np, gaji) => new { dp = np, ga = gaji }))
                // {
                //     int no;
                //      no = 0;
                //      no++;
                //      Console.WriteLine(no + pair.dp + pair.ga);

                // }
                // Console.WriteLine("pilih pegawai berdasarkan nomor");
                // string pilihan = Console.ReadLine();
                // int.Parse(pilihan);
                // int choice = gaji.IndexOf(pilihan);
                Console.WriteLine(" tetap ingin menggunakan aplikasi ? ");

                Console.WriteLine("y/n");
                perulangan = Console.ReadLine().ToLower();

            } while (perulangan == "y");


        }




    }

}