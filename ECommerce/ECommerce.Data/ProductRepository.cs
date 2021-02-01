using System;
using System.Collections.Generic;
using System.Text;
using ECommerce.Entity;

namespace ECommerce.Data
{
    public class ProductRepository : IProductRepository
    {

        private List<Product> _products = new List<Product>();
        private int _idCounter = 0;


        public ProductRepository()
        {
            Product product = new Product()
            {
                Id = ++_idCounter,
                Description = "Açılama",
                Name = "Xiaomi Mi Band 5 Akıllı Bileklik",
                StockAmount = 100,
                Status = Status.Online,
                ImageUrl = "miband5.jfif",
                UnitPrice = 229
            };


            Product product2 = new Product()
            {
                Id = ++_idCounter,
                Description = "Açıklama",
                Name = "Samsung GE83X/AND 23 lt Mikrodalga Fırın",
                StockAmount = 30,
                Status = Status.Online,
                ImageUrl = "product2.jfif",
                UnitPrice = 898.99
            };

            Product product3 = new Product()
            {
                Id = ++_idCounter,
                Description = "Açılama",
                Name = "Asperox Sarı Güç Çok Amaçlı Ultra Yağ Çözücü 1000 ml x 3 Adet",
                StockAmount = 48,
                Status = Status.Online,
                ImageUrl = "3.jfif",
                UnitPrice = 29.90
            };

            Product product4 = new Product()
            {
                Id = ++_idCounter,
                Description = "Açılama",
                Name = "Dell XPS 13 7390 Intel Core i5 10210U 8GB 512GB SSD Windows 10 Home 13.3\" FHD Taşınabilir Bilgisayar FS210W85N",
                StockAmount = 20,
                Status = Status.Online,
                ImageUrl = "4.jfif",
                UnitPrice = 9298.99
            };

            Product product5 = new Product()
            {
                Id = ++_idCounter,
                Description = "Açılama",
                Name = "Philips Marathon Ultimate FC9925/07 Toz Torbasız Elektrikli Süpürge",
                StockAmount = 31,
                Status = Status.Online,
                ImageUrl = "5.jfif",
                UnitPrice = 1799.90
            };

            _products.Add(product);
            _products.Add(product2);
            _products.Add(product3);
            _products.Add(product4);
            _products.Add(product5);
        }


        public void Delete(Product entity)
        {
            DeleteById(entity.Id);
        }

        public void DeleteById(int id)
        {
            _products.Remove(FindById(id));
        }

        public List<Product> FindAll()
        {
            return _products;
        }

        public List<Product> FindAll(Pageable pageable)
        {
            throw new NotImplementedException();
        }

        public Product FindById(int id)
        {
            return _products.Find(product => product.Id == id);
        }

        public Product Save(Product entity)
        {
            if(entity.Id == 0)
            {
                entity.Id = ++_idCounter;
                _products.Add(entity);
            } else
            {
                Product product = FindById(entity.Id);
                product.ImageUrl = entity.ImageUrl;
                product.Name = entity.Name;
                product.Status = entity.Status;
                product.StockAmount = entity.StockAmount;
                product.UnitPrice = entity.UnitPrice;
                product.Summary = entity.Summary;
                product.Category = entity.Category;
                product.Description = entity.Description;
            
            }

            return entity;
        }
    }
}
