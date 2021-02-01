using System;
using System.Collections.Generic;
using System.Linq;
using ECommerce.Entity;

namespace ECommerce.Data
{
    public class CustomerRepository : ICustomerRepository
    {

        private List<Customer> _customers = new List<Customer>();
        private int _idCounter = 0;


        public CustomerRepository()
        {
            _customers.Add(new Customer { Id = ++_idCounter, FirstName = "alihan", LastName = "bayraktar", IsActive = true, ImageUrl = "3.jpg", LastOrder = null, Orders = new List<Order>(), PhoneNumber = "05356993232" });
            _customers.Add(new Customer { Id = ++_idCounter, FirstName = "merve", LastName = "bayraktar", IsActive = true, ImageUrl = "1.jpg", LastOrder = null, Orders = new List<Order>(), PhoneNumber = "05356993232" });
            _customers.Add(new Customer { Id = ++_idCounter, FirstName = "deniz", LastName = "bayraktar", IsActive = true, ImageUrl = "1.jpg", LastOrder = null, Orders = new List<Order>(), PhoneNumber = "05356993232" });
            _customers.Add(new Customer { Id = ++_idCounter, FirstName = "ahmet", LastName = "bayraktar", IsActive = true, ImageUrl = "2.jpg", LastOrder = null, Orders = new List<Order>(), PhoneNumber = "05356993232" });
            _customers.Add(new Customer { Id = ++_idCounter, FirstName = "ilknur", LastName = "bayraktar", IsActive = true, ImageUrl = "1.jpg", LastOrder = null, Orders = new List<Order>(), PhoneNumber = "05356993232" });
        }

        public void Delete(Customer entity)
        {
            DeleteById(entity.Id);
        }

        public void DeleteById(int id)
        {
            _customers.Remove(FindById(id));
        }

        public List<Customer> FindAll()
        {
            return _customers;
        }

        public List<Customer> FindAll(Pageable pageable)
        {
            int index = pageable.Page * pageable.Size;

            if (index >= _customers.Count)
                return new List<Customer>();
            else
            {
                int lastIndex = index + pageable.Size - 1;

                if (lastIndex < _customers.Count)
                    return _customers.GetRange(index, pageable.Size);
                else
                {
                    return _customers.GetRange(index, _customers.Count - index);
                }
            }

            
        }

        public Customer FindByFullName(string fullName)
        {
            String [] nameParts = fullName.Split(char.Parse(" "));

            String firstName = null;
            String lastName = null;

            if(nameParts.Length == 2)
            {
                firstName = nameParts[0];
                lastName = nameParts[1];
            }
            else
            {
                String [] firstNameParts = nameParts.Take(nameParts.Length - 1).ToArray();

                firstName = String.Join(" ", firstNameParts);
                lastName = nameParts[nameParts.Length - 1];
            }

            return _customers.Where(c => c.FirstName == firstName && c.LastName == lastName).FirstOrDefault();

        }

        public Customer FindById(int id)
        {
            return _customers.Find(customer => customer.Id == id);
        }

        public Customer Save(Customer entity)
        {
            if(entity.Id == 0)
            {
                entity.Id = ++_idCounter;
                _customers.Add(entity);
            } else if(entity.Id > 0)
            {
                Customer customer = FindById(entity.Id);
                customer.FirstName = entity.FirstName;
                customer.LastName = entity.LastName;
                customer.LastOrder = entity.LastOrder;
                customer.Orders = entity.Orders;
                customer.PhoneNumber = entity.PhoneNumber;
                customer.IsActive = entity.IsActive;
                customer.ImageUrl = entity.ImageUrl;
                

                entity = customer;
            }

            return entity;
        }
    }
}
