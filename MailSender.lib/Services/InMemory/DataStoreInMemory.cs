using System;
using System.Collections.Generic;
using System.Linq;
using MailSender.lib.Entities.Base;
using MailSender.lib.Services.Interfaces.Store;

namespace MailSender.lib.Services.InMemory
{
    /// <summary>
    /// Реализация хранения данных в памяти
    /// </summary>
    /// <typeparam name="T">тип сущности</typeparam>
    public abstract class DataStoreInMemory<T> : IDataStore<T> where T : BaseEntity
    {
        private readonly List<T> _items;

        protected DataStoreInMemory(List<T> Items = null) => _items = Items ?? new List<T>();

        public IEnumerable<T> GetAll() => _items;

        public T GetById(int id) => _items.FirstOrDefault(item => item.Id == id);

        public int Create(T item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));

            if (_items.Contains(item)) return item.Id;
            item.Id = _items.Count == 0
                ? 1
                : _items.Max(r => r.Id) + 1;
            _items.Add(item);
            return item.Id;
        }

        public abstract void Edit(int id, T item);

        public T Remove(int id)
        {
            var item = GetById(id);
            if (item != null)
                _items.Remove(item);
            return item;
        }

        public void SaveChanges()
        {
            System.Diagnostics.Debug.WriteLine("Сохранение изменений в хранилище {0}.", typeof(T));
        }
    }
}
