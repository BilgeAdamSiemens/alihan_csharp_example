using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Data
{
    public class RepositoryFactory
    {
        private static IProductRepository _productRepository = new ProductRepository();
        private static IOrderRepository _orderRepository = new OrderRepository();
        private static ICustomerRepository _customerRepository = new CustomerRepository();

        private RepositoryFactory()
        {

        }

        public static IProductRepository ProductRepository
        {
            get
            {
                return _productRepository;
            }
        }

        public static IOrderRepository OrderRepository
        {
            get
            {
                return _orderRepository;
            }
        }

        public static ICustomerRepository CustomerRepository
        {
            get
            {
                return _customerRepository;
            }
        }




    }
}
