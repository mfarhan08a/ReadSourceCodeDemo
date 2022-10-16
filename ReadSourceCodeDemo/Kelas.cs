using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadSourceCodeDemo
{
    internal class Kelas
    {
        public int jumlahKelas = 0;
        public string namaKelas;
        public List<string> superKelas = new List<string>();
        public int id;

        public Kelas(string aNamaKelas, string aSuperKelas)
        {
            ++jumlahKelas;
            this.id = jumlahKelas;
            this.namaKelas = aNamaKelas;
            this.superKelas.Add(aSuperKelas);
        }

        
    }
}
