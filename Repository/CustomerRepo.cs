using HotelBooking_KristianJeremic_NETProgramutvecklare.Interfaces;
using HotelBooking_KristianJeremic_NETProgramutvecklare.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelBooking_KristianJeremic_NETProgramutvecklare.Repository
{
    internal class CustomerRepo : IRepo<Customer>
    {
        private HotelDBEntities _dbConnection;
        public CustomerRepo()
        {
            _dbConnection = new HotelDBEntities();
        }

        public void Add(Customer item)
        {
            try { _dbConnection.Customers.Add(item); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }

        public Customer Get(int id)
        {
            try { return _dbConnection.Customers.Find(id); }
            catch (Exception ex) { throw ex; }
        }

        public List<Customer> GetAll()
        {
            try { return _dbConnection.Customers.ToList(); }
            catch (Exception ex) { throw ex; }
        }

        public void Remove(Customer item)
        {
            try { _dbConnection.Customers.Remove(item); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }

        public void Update(Customer item)
        {
            try { _dbConnection.Entry(Get(item.ID)).CurrentValues.SetValues(item); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }
    }
}
