﻿namespace WebSanadApplication.Interface
{
    public interface IGenericRepo<T>
    {
        Task<T> GetAsync(int? id,string name);

       // T Get(int? id);
       Task <IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> Search(string SearchItem);
        


       // IEnumerable<T> GetAll();
       // Task<int> AddAsync(T item);
        //int Add(T item);
        //Task<int> UpdateAsync(T item);

         //  int Update(T item);
        //Task<int> DeleteAsync(T item);

       // int Delete(T item);


    }
}
