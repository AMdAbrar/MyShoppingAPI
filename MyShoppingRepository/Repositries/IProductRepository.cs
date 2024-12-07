using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShoppingEntity;//importing our own project from that we can access like class

namespace MyShoppingRepository.Repositries
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product, int id);
        void DeleteProduct(int id);

        Product GetProductById(int id);
        List<Product> GetAll();

    }
}
