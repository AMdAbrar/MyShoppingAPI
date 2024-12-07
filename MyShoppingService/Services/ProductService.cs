using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyShoppingEntity;
using MyShoppingRepository.Repositries;

namespace MyShoppingService.Services
{
    public class ProductService : IProductService
    {
        IProductRepository _repository;

        public ProductService(IProductRepository productRepository)
        {
            _repository = productRepository;
        }

        public void AddProduct(Product product)
        {
            _repository.AddProduct(product);
        }
        public void UpdateProduct(Product product , int id)
        {
            _repository.UpdateProduct(product, id);
        }

        public List<Product> GetProducts()
        {
            return _repository.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _repository.GetProductById(id);
        }

        public void DeleteProduct(int id)
        {
            _repository.DeleteProduct(id);
        }
    }
}
//public void AddProduct(Product product)
//{
//    _repository.AddProduct(product);
//}

////public List<Product> GetAll()
////{
////    var list = _repository.Products.ToList();
////    return list;
////}

//public List<Product> GetProducts()
//{
//    var products = _repository.GetProducts();
//    return products;
//    //return _repository.GetAll();

//}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MyShopingEntity;
//using MyShopingRepository.Repostries;
//using MyShoppingEntity;
//using MyShoppingRepository.Repositries;
//using MyShoppingService.Services;

//namespace MyShopingService.Services
//{
//    public class ProductService : IProductService
//    {
//        IProductRepository _repository;
//        public ProductService(IProductRepository productRepository)
//        {
//            _repository = productRepository;
//        }
//        public void AddProduct(Product product)
//        {
//            _repository.AddProduct(product);
//        }

//        public List<Product> GetProducts()
//        {
//            return _repository.GetAll();
//        }
//    }
//}