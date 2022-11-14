using HotelBooking_KristianJeremic_NETProgramutvecklare.Interfaces;
using HotelBooking_KristianJeremic_NETProgramutvecklare.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelBooking_KristianJeremic_NETProgramutvecklare.Repository
{
    internal class InvoiceRepo : IRepo<Invoice>
    {
        private HotelDBEntities _dbConnection;

        public InvoiceRepo()
        {
            _dbConnection = new HotelDBEntities();
        }
        public void Add(Invoice item)
        {
            try { _dbConnection.Invoices.Add(item); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }

        public Invoice Get(int id)
        {
            try { return _dbConnection.Invoices.Find(id); }
            catch (Exception ex) { throw ex; }
        }

        public List<Invoice> GetAll()
        {
            try { return _dbConnection.Invoices.ToList(); }
            catch (Exception ex) { throw ex; }
        }

        public void Remove(Invoice item)
        {
            try { _dbConnection.Invoices.Remove(item); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }

        public void Update(Invoice item)
        {
            try { _dbConnection.Entry(Get(item.ID)).CurrentValues.SetValues(item); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }
    }
}
