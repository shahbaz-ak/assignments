using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignment2.Entities;

namespace assignment2.Repositories
{
    public class CustomerRepository
    {
        public CustomerContext db = new CustomerContext();
        public List<entitiyCustomer> GetCustomers() {
            return db.Customer.ToList();
        }
        public entitiyCustomer GetCustomerId(string cid) {
            return db.Customer.Find(cid);
        }
        public void Add(entitiyCustomer c) {
            db.Customer.Add(c);
            db.SaveChanges();
        }
        public void Delete(entitiyCustomer c) {
            db.Customer.Remove(c);
            db.SaveChanges();
        }
        public void Update(entitiyCustomer c) {
            db.Customer.Update(c);
            db.SaveChanges();
        }
    }
}
