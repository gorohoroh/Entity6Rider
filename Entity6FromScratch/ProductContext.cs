namespace Entity6FromScratch
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Family> Families { get; set; }
        
    }
}