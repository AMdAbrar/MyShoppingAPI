using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShoppingEntity;

namespace MyShoppingService.Services
{
    public interface IProductService
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product, int id);


        void DeleteProduct(int id);
        List<Product> GetProducts();
        Product GetProductById(int id);



    }
}
