using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    static class ListExtention
    {
        public static Result<T> GetItemByID<T>(this List<T> list, long id)
        {
            foreach (T item in list)
            {
                if (id==(Id)(object)item)
                {
                    return new Result<T>(item);
                }
            }
            return new Result<T>(default,new ArgumentNullException($"The list of {list.FirstOrDefault().GetType()} didnt have item with ID {id}."));
        }
    }
}
