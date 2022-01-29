﻿namespace SalesWebMvc.Models
{
    public class Departament
    {
        public Departament() {}

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set;} = new List<Seller>();

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public  double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(s => s.TotalSales(initial, final));
        }
    }
}
