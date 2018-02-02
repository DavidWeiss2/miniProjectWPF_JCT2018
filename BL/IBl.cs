using System;
using System.Collections.Generic;
using System.Linq;
using BE;

namespace BL
{
    /// <summary>
    /// Defines the <see cref="IBl{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IBl
    {
        #region Methods

        Result<Id> Add(Id item);

        Result<Id> Edit(Id item);

        Result<List<Id>> GetList(Type type, string orderByField, bool toOrderByAscending);

        Result<IEnumerable<IGrouping<Func<object, object>, Id>>> Group(string[] keyFields, Type type);

        Result<Id> Remove(Id item);

        #endregion
    }
    
}
