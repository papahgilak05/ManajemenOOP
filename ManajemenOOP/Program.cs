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
        static List<Employee> employee = new List<Employee>();
        static void Main(String[] args)
        {

            /*List<string> np = new List<string>();
            List<string> nk = new List<string>();
            List<int> gaji = new List<int>();
            Employee employee = new Employee();*/

            Employee Data1 = new Employee();
            
            
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
                Employee DI = new Employee();
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
                    Console.Write("Masukkan Nama yang ingin dihapus : ");
                    string input = Console.ReadLine();

                    int index = employee.FindIndex(User => User.Nama == input);

                    if (index != -1)
                    {
                        employee.RemoveAt(index);
                        Console.WriteLine($"{input} berhasil dihapus");

                    }
                    else
                    {
                        Console.WriteLine($"{input} Tidak Ditemukan");
                    }


                }
                
                Console.WriteLine(" tetap ingin menggunakan aplikasi ? ");

                Console.WriteLine("y/n");
                perulangan = Console.ReadLine().ToLower();

            } while (perulangan == "y");


        }




    }

}