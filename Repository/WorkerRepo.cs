using HotelBooking_KristianJeremic_NETProgramutvecklare.Interfaces;
using HotelBooking_KristianJeremic_NETProgramutvecklare.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelBooking_KristianJeremic_NETProgramutvecklare.Repository
{
    internal class WorkerRepo : IRepo<Worker>
    {
        private HotelDBEntities _dbConnection;

        public WorkerRepo()
        {
            _dbConnection = new HotelDBEntities();
        }
        public void Add(Worker item)
        {
            try
            {
                if (item.Name == null || item.SecretCode.ToString() == "")
                {
                    throw new Exception("Name or pincode is empty");
                }
                if (FindName(item.Name))
                {
                    throw new Exception("Name already exists");
                }
                _dbConnection.Workers.Add(item);
                _dbConnection.SaveChanges();

            }
            catch (Exception ex) { throw ex; }
        }

        public Worker Get(int id)
        {
            try { return _dbConnection.Workers.Find(id); }
            catch (Exception ex) { throw ex; }
        }

        public List<Worker> GetAll()
        {
            try { return _dbConnection.Workers.ToList(); }
            catch (Exception ex) { throw ex; }
        }

        public void Remove(Worker item)
        {
            try { _dbConnection.Workers.Remove(item); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }

        public void Update(Worker item)
        {
            try { _dbConnection.Entry(Get(item.ID)).CurrentValues.SetValues(item); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }
        public Worker Find(string name, string secretCode)
        {
            {
                try
                {
                    var worker = _dbConnection.Workers.Where(w => w.Name == name && w.SecretCode.ToString() == secretCode).FirstOrDefault();

                    return worker;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public bool FindName(string name)
        {
            {
                try
                {
                    var worker = _dbConnection.Workers.Where(w => w.Name == name).FirstOrDefault();

                    return worker != null;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
