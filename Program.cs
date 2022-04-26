using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BeratBadan
{
    /// <summary>
    /// main class
    /// </summary>
    public class ideal
    {
        /// <summary>
        /// Operasi input data
        /// operasi menghitung berat badan dengan rumus
        /// </summary>
        public int JenisKelamin;
        public float Berat, Tinggi, BMI, Meter;
        public double broca;
        public void input()
        {
            Console.WriteLine("PROGRAM MENGHITUNG BERAT BADAN IDEAL MENURUT RUMUS BMI DAN BROCA");
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write("Jenis Kelamin: " +
                "\n1. Pria " +
                "\n2. perempuan" +
                "\nMasukkan Pilihan: ");
            JenisKelamin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Berat Badan : ");
            Berat = float.Parse(Console.ReadLine());
            Console.Write("Masukkan Tinggi Badan : ");
            Tinggi = float.Parse(Console.ReadLine());
        }
        public void rumusBMI()
        {
            /// <code>
            ///     
            /// </code>
            string Status;
            Meter = Tinggi / 100;
            BMI = (Berat / (Meter * Meter));

            if (BMI < 18.5)
            {
                Status = " (Kurus) ";
            }

            else if (BMI <= 22.9)
            {
                Status = " (Normal) ";
            }

            else if (BMI < 29.9)
            {
                Status = " (Kecenderungan Obesitas) ";
            }

            else
            {
                Status = " (Obesitas) ";
            }

            Console.WriteLine("Berat Badan Anda Menurut Rumus BMI adalah " + BMI + Status);
        }

        //MENGHITUNG BADAN IDEAL 
        //DENGAN MENGGUNAKAN RUMUS BROCA
        public void rumusBroca()
        {
            switch (JenisKelamin)
            {
                case 1:
                    broca = ((Tinggi - 100) - (10 / 100 * (Tinggi - 100)));
                    break;
                case 2:
                    broca = ((Tinggi - 100) - (15 / 100 * (Tinggi - 100)));
                    break;
            }
            //mengkonversi variabel doubel ke integer
            int hasil = (int)broca;
            //menampilkan output
            Console.WriteLine("Berat Badan Ideal Anda Menurut Rumus Broca adalah " + hasil + " kg ");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //membuat objek dari class Ideal
            ideal BeratBadanKamu = new ideal();
            BeratBadanKamu.input();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Hasil dari perhitungan rumus");
            Console.WriteLine("----------------------------");
            BeratBadanKamu.rumusBMI();
            BeratBadanKamu.rumusBroca();
            Console.WriteLine("");
            Console.WriteLine("PRESS ANY KEY TO EXIT");
            Console.ReadLine();
        }
    }
}
