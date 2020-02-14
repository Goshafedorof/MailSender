using System.Collections.Generic;

namespace MailSender.lib.Services.Interfaces.Manager
{
    /// <summary>
    /// Управление объектом
    /// </summary>
    /// <typeparam name="T">тип управляемого объекта</typeparam>
    public interface IDataManager<T>
    {
        /// <summary>
        /// Получить все объекты
        /// </summary>
        /// <returns>Перечисление объектов</returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Добавить объект
        /// </summary>
        /// <param name="item">объект</param>
        void Add(T item);
        /// <summary>
        /// Редактировать объект
        /// </summary>
        /// <param name="item">объект</param>
        void Edit(T item);
        /// <summary>
        /// Сохранить изменения
        /// </summary>
        void SaveChanges();
    }
}
