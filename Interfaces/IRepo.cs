using System.Collections.Generic;

namespace HotelBooking_KristianJeremic_NETProgramutvecklare.Interfaces
{
    internal interface IRepo<T>
    {
        void Add(T item);
        void Remove(T item);
        void Update(T item);
        T Get(int id);
        List<T> GetAll();
    }
}
