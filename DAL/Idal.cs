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
    public interface IDal
    {
        #region Methods

        Result<Id> Add(Id item);

        Result<Id> Edit(Id item);

        Result<List<Id>> GetAListFromType(Type type);

        Result<IEnumerable<IGrouping<Func<object, object>, Id>>> GetListofTByKeyField(string keyField, Type type);

        Result<Id> Remove(Id item);

        #endregion
    }
}
