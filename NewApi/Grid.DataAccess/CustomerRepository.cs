using Grid.Contracts;
using Grid.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid.DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {
        private GridDBContext context;

        public CustomerRepository(GridDBContext context)
        {
            this.context = context;
        }

        public List<Customer> GetCustomers()
        {
            return context.Customers.ToList();
        }
        public Customer GetCustomerByID(int customerId)
        {
            return context.Customers.Find(customerId);
        }

        public void InsertCustomer(Customer customer)
        {
            context.Customers.Add(customer);
        }

        public void DeleteCustomer(int customerId)
        {
            Customer customer = context.Customers.Find(customerId);
            context.Customers.Remove(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            context.Entry(customer).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

    }
}
