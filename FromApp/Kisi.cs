using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromApp
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcKimlikNo { get; set; }
        public string Uzmanlik { get; set; }
        public bool IsActive { get; set; }
        public Cinsiyet Cinsiyet { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }
    }

    public enum Cinsiyet
    {
        Kadın,
        Erkek,
        Diger
    }
}
