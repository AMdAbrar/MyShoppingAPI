using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyShoppingEntity;

namespace MyShoppingRepository.Data
{
    public class MyShoppingDbContext:DbContext // this is class or we can say database because here we mentioned Dbcontext 
    {
        public MyShoppingDbContext(DbContextOptions<MyShoppingDbContext> options) : base(options) { 


        }
        public DbSet<Product> Products { get; set; } 
        //this is property when ever we {get; set;} and its a table name Product becasue we mentioned DBset

    }
}
