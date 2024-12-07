using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShoppingEntity;
using MyShoppingRepository.Data;

namespace MyShoppingRepository.Repositries
{
    public class ProductRepositories : IProductRepository
    {
        MyShoppingDbContext _context;//set dbcontext instance to make crud operation

        public ProductRepositories(MyShoppingDbContext dbcontext)
        {
            _context = dbcontext;//getting instance from container and assign to local variable
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);//insert into products values(product.id, product.name, product.desc)
            _context.SaveChanges();//execute the query like run
        }
        public void UpdateProduct(Product product, int id)
        {
            _context.Products.Update(product);//insert into products values(product.id, product.name, product.desc)
            _context.SaveChanges();//execute the query like run
        }

        public void DeleteProduct(int id)
        {
            Product product = _context.Products.Find(id);// select * from table where id=1;
            //delete from products where id=1
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
       
        public Product GetProductById(int id)
        {
            Product obj = _context.Products.Find(id); // select * from table where id=1 it will fetch and store here
            
            return obj;
        }

        public List<Product> GetAll()
        {
           //List<Product> products = new List<Product>();    
           // return products;
           //select * from products
           //var list=_context.Products.ToList();
           // return list;
            List<Product> list = _context.Products.ToList();
            return list;
        }


       

       
    }
}
