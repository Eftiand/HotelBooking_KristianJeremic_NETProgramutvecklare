using HotelBooking_KristianJeremic_NETProgramutvecklare.Interfaces;
using HotelBooking_KristianJeremic_NETProgramutvecklare.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelBooking_KristianJeremic_NETProgramutvecklare.Repository
{
    internal class RoomTypeRepo : IRepo<RoomType>
    {
        private HotelDBEntities _dbConnection;

        public RoomTypeRepo()
        {
            _dbConnection = new HotelDBEntities();
        }
        public void Add(RoomType item)
        {
            try { _dbConnection.RoomTypes.Add(item); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }

        public RoomType Get(int id)
        {
            try { return _dbConnection.RoomTypes.Find(id); }
            catch (Exception ex) { throw ex; }
        }

        public List<RoomType> GetAll()
        {
            try { return _dbConnection.RoomTypes.ToList(); }
            catch (Exception ex) { throw ex; }
        }

        public void Remove(RoomType item)
        {
            try { _dbConnection.RoomTypes.Remove(item); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }

        public void Update(RoomType item)
        {
            try { _dbConnection.Entry(Get(item.ID)).CurrentValues.SetValues(item); _dbConnection.SaveChanges(); }
            catch (Exception ex) { throw ex; }
        }
    }
}
