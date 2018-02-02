using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    static class ListExtention
    {
        public static Result<T> GetItemByID<T>(this List<T> list, long id)where T:Id,new()
        {
            T tempItem=new Id(id) as T;
            foreach (T item in list)
            {
                if (tempItem == item)
                {
                    return new Result<T>(item);
                }
            }
            return new Result<T>(default,new ArgumentNullException($"The list of {tempItem.GetTypeName} didnt have item with ID {id}."));
        }
    }
}
