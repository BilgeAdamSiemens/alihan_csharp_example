using System;
using System.Collections.Generic;
using System.Text;
using ECommerce.Entity;

namespace ECommerce.Data
{
    public class OrderRepository : IOrderRepository
    {

        private List<Order> _orders = new List<Order>();
        private int _idCounter = 0;

        public OrderRepository()
        {
            ProductRepository productRepository = new ProductRepository();
            CustomerRepository customerRepository = new CustomerRepository();


            Product product = productRepository.FindById(1);
            Product product2 = productRepository.FindById(2);

            Cart cart = new Cart();
            cart.AddProduct(product, 5);
            cart.AddProduct(product2, 2);

            Order order = new Order();

            order.Id = ++_idCounter;
            order.Cart = cart;
            order.Customer = customerRepository.FindById(1);
            order.Date = DateTime.Now;
            order.OrderStatus = OrderStatus.Processing;

            _orders.Add(order);


            order = new Order();

            order.Id = ++_idCounter;
            order.Cart = cart;
            order.Customer = customerRepository.FindById(2);
            order.Date = DateTime.Now;
            order.OrderStatus = OrderStatus.Processing;

            _orders.Add(order);


        }

        public void Delete(Order entity)
        {
            DeleteById(entity.Id);
        }

        public void DeleteById(int id)
        {
            _orders.Remove(FindById(id));
        }

        public List<Order> FindAll()
        {
            return _orders;
        }

        public List<Order> FindAll(Pageable pageable)
        {
            throw new NotImplementedException();
        }

        public Order FindById(int id)
        {
            return _orders.Find(order => order.Id == id);
        }

        public Order Save(Order entity)
        {
            if(entity.Id == 0)
            {
                entity.Id = ++_idCounter;
                _orders.Add(entity);
            }
            else
            {
                Order order = FindById(entity.Id);

                order.Cart = entity.Cart;
                order.Customer = entity.Customer;
                order.Date = entity.Date;
                order.OrderStatus = entity.OrderStatus;


                entity = order;
            }

            return entity;
        }
    }
}
