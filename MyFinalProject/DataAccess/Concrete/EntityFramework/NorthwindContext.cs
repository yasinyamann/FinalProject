using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccess.Concrete.EntityFramework
{
    //Context:Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext:DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)// Proje hangi veri tabanı ile ilişkili
        {
            optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = NorthwindDb; User ID = SA; Password = Yasinyaman.43; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False");
        }
        public DbSet<Product> Products { get; set; }// Burda ismi degiştirdigim zaman hata alıyorum yani veri tabanına baglanmılşs oluyor
        // VEri tabanında bu isimde yok diyor dogrusu Products olcak
        //Şuan tekrar çalılştrıucam 

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
    
}

