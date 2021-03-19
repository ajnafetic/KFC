using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KFC.Modals
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public int kolicina { get; set; }

        public string image { get; set; }

        public Product() { }

        public Product(int Id, string Naziv, float Cijena, int kolicina,string image)
        {
            this.Id = Id;
            this.Naziv = Naziv;
            this.Cijena = Cijena;
            this.kolicina = kolicina;
            this.image = image;
        }
    }
}
