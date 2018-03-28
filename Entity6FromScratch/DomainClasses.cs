using System;

namespace Entity6FromScratch
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Family Family { get; set; }
        public float Version { get; set; }
        public Vendor Vendor { get; set; }
        public string S { get; set; }
    }

    public class Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime YearEstablished { get; set; }
        public bool IdPublicCompany { get; set; }
    }

    public class Family
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}