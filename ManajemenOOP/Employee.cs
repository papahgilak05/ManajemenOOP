using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenOOP
{
    public class Employee
    {
        public string Nama { get; set; }
        public string Nomor { get; set; }
        public int Gaji { get; set; }   
        
        /*public List<string> Nama { get; set; } = new List<string>();
        public List<string> Nomor { get; set; } = new List<string>();
        public List<int> Gaji  { get; set; } = new List<int>();*/
        

        public void Menampilkan() 
        {
            /*foreach (var pair in Nama.Zip(Nomor, (Nama, Nomor) => new { displaynama = Nama, displaynomor = Nomor }))
            {

                Console.WriteLine(pair.displaynama + " " + pair.displaynomor);

            }*/

            Console.WriteLine("Nama Pegawai : " + Nama + "  " + "Nomor Pegawai : " +Nomor + " " + "Gaji : " + Gaji);

        }
        
    }
}
