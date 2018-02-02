using System;
[assembly: CLSCompliant(true)]
namespace BL
{
    using System.Collections.Generic;
    using System.Linq;
    using BE;
    using DAL;

    /// <summary>
    /// Defines the <see cref="Bl" />
    /// </summary>
    public class Bl : IBl
    {
        public Dal Dal
        {
            get; set;
        } = new Dal();
        private static Result<object> ErrorInvaildMassege(string typeName) => new Result<object>($"I dont know what {typeName} is. please check the wiki, or spelling.");
        public Result<Id> Add(Id item)
        {
            Result<Id> result = new Result<Id>(item);
            switch (item.GetTypeName)
            {
                case "Child":
                    break;
                case "Mother":
                    break;
                case "Nanny":
                    break;
                case "Contract":
                    break;
                default:
                    return result + ErrorInvaildMassege(item.GetTypeName);
            }
            return this.Dal.Add(item);
        }

        public Result<Id> Edit(Id item)
        {
            Result<Id> result = new Result<Id>(item);
            switch (item.GetTypeName)
            {
                case "Child":
                    break;
                case "Mother":
                    break;
                case "Nanny":
                    break;
                case "Contract":
                    break;
                default:
                    break;
            }
            return this.Dal.Add(item);
        }
        public Result<List<Id>> GetList(Type type, string orderByField,bool toOrderByAscending)
        {
            Result<List<Id>> result = this.Dal.GetList(type);
            result +=new Result<List<Id>>(toOrderByAscending?
                result.Value.OrderBy<Id, object>(type.CreateGetter(orderByField)).ToList():
                result.Value.OrderByDescending<Id, object>(type.CreateGetter(orderByField)).ToList());
            return result;
        }
        public Result<IEnumerable<IGrouping<Func<object, object>, Id>>> Group(string[] keyFields, Type type)
        {
            Result<IEnumerable<IGrouping<Func<object, object>, Id>>> result = new Result<IEnumerable<IGrouping<Func<object, object>, Id>>>();
            switch (type.Name)
            {
                case "Child":
                    break;
                case "Mother":
                    break;
                case "Nanny":
                    break;
                case "Contract":
                    break;
                default:
                    break;
            }
            return result;
        }
        public Result<Id> Remove(Id item)
        {
            Result<Id> result = new Result<Id>(item);
            switch (item.GetTypeName)
            {
                case "Child":
                    break;
                case "Mother":
                    break;
                case "Nanny":
                    break;
                case "Contract":
                    break;
                default:
                    break;
            }
            return this.Dal.Remove(item);
        }

    }
}
