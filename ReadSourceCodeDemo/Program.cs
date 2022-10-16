using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadSourceCodeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Kuliah\#SEMESTER 5\Perancangan dan Pengembangan Perangkat Lunak\Repos\ReadSourceCodeDemo\ReadSourceCodeDemo\input\JavaClassEx.txt";            

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            //List<string> className = new List<string>();
            
            List<Kelas> KelasCollection = new List<Kelas>();

            int kelasCount = -1;

            for (int i = 0; i < lines.Count; i++ )
            {
                if ((lines[i].Contains("class")))
                {
                    kelasCount++;
                    string[] lineArr = lines[i].Split(' ');
                    Console.WriteLine(lines[i]);
                    if (!(lines[i].Contains("extends")))
                    {                                                
                        Kelas kelas = new Kelas(lineArr[1], "");                        
                        KelasCollection.Add(kelas);
                    } else
                    {
                        Kelas kelas = new Kelas(lineArr[1], lineArr[3]);
                        KelasCollection.Add(kelas);
                    }
                }
            }


            int hitung = 0;
            foreach (Kelas item in KelasCollection)
            {
                Console.WriteLine(++hitung);
                Console.WriteLine("nama class : " + item.namaKelas);
                foreach (string super in item.superKelas)
                {
                    Console.WriteLine("superClass : " + super);
                }

            }


            Console.ReadLine();
        }
    }
}
