namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BE;

    /// <summary>
    /// Defines the <see cref="IDal{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDal<T>
    {
        #region Methods

        Result<T> Add(T item);

        Result<T> Edit(T item);

        Result<List<T>> GetListOfT();

        Result<IEnumerable<IGrouping<Func<object, object>, T>>> GetListofTByKeyField(string keyField);

        Result<T> Remove(T item);

        #endregion
    }
}
