using System;

[assembly: CLSCompliant(true)]
namespace DAL
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    using BE;

    using DS;

    #region Classes

    /// <summary>
    /// Defines the <see cref="Dal" />
    /// </summary>
    public class Dal
    {
        public static DChild Child { get; } = new DChild();
        public static DContract Contract { get; } = new DContract();
        public static DMother Mother { get; } = new DMother();
        public static DNanny Nanny { get; } = new DNanny();
        #region Classes

        /// <summary>
        /// Defines the <see cref="DChild" />
        /// </summary>
        public class DChild : IDal<Child>
        {
            #region Methods

            public Result<Child> Add(Child item)
            {
                if (item.ID == 0)
                    return new Result<Child>(item, new ArgumentNullException($"{nameof(item.ID)} of Child can't be 0.", nameof(item.ID)));
                if (DataSource.ChildList.Contains(item))
                    return new Result<Child>(item, new InvalidOperationException($"Child with ID: {item.ID} is already in the data base, with artibautes: {DataSource.ChildList.Find(i => i.ID == item.ID)}"));
                if (DataSource.MotherList.Find(i => i.ID == item.MotherId) == new Mother())
                    return new Result<Child>(item, new InvalidOperationException($"Mother ID: {item.ID} can't be real"));
                return new Result<Child>(item);
            }

            public Result<Child> Edit(Child item)
            {
                Result<Child> deleteResult = Remove(item);
                if (deleteResult.IsErrorOccurred)
                {
                    return deleteResult;
                }
                Result<Child> addResult = Add(item);
                if (addResult.IsErrorOccurred)
                {
                    return Add(deleteResult.Value);
                }
                return addResult;
            }

            public Result<List<Child>> GetListOfT() => new Result<List<Child>>((from item in DataSource.ChildList orderby DataSource.ChildList.FirstOrDefault().LastName select item).ToList());

            public Result<IEnumerable<IGrouping<Func<object, object>, Child>>> GetListofTByKeyField(string keyField)
            {
                Func<object, object> codeGetter = CreateGetter(DataSource.ChildList.Last().GetType, keyField);// using the 1st element as an example
                return new Result<IEnumerable<IGrouping<Func<object, object>, Child>>>(from child in DataSource.ChildList orderby codeGetter group child by codeGetter);
            }

            public Result<Child> Remove(Child item)
            {
                Child removedChiled = DataSource.ChildList.Find(@child => @child == item);
                if (!DataSource.ChildList.Remove(item))
                    return new Result<Child>(removedChiled, new InvalidOperationException($"Child: {item} didn't match any Child ID in the data base."));
                return new Result<Child>(removedChiled);
            }

            #endregion
        }

        /// <summary>
        /// Defines the <see cref="DContract" />
        /// </summary>
        public class DContract : IDal<Contract>
        {
            #region Methods

            public Result<Contract> Add(Contract item)
            {
                if (item.ID == 0)
                    return new Result<Contract>(item, new ArgumentNullException($"{nameof(item.ID)} of Contract can't be 0.", nameof(item.ID)));
                if (DataSource.ContractList.Contains(item))
                    return new Result<Contract>(item, new InvalidOperationException($"Contract with ID: {item.ID} is already in the data base, with artibautes: {DataSource.ContractList.Find(i => i.ID == item.ID)}"));
                if (DataSource.MotherList.Find(i => i.ID == item.MotherId) == new Mother())
                    return new Result<Contract>(item, new InvalidOperationException($"Mother ID: {item.ID} can't be real"));
                return new Result<Contract>(item);
            }

            public Result<Contract> Edit(Contract item)
            {
                Result<Contract> deleteResult = Remove(item);
                if (deleteResult.IsErrorOccurred)
                {
                    return deleteResult;
                }
                Result<Contract> addResult = Add(item);
                if (addResult.IsErrorOccurred)
                {
                    return Add(deleteResult.Value);
                }
                return addResult;
            }

            public Result<List<Contract>> GetListOfT() => new Result<List<Contract>>((from item in DataSource.ContractList orderby DataSource.ContractList.FirstOrDefault().ContractSignedTime select item).ToList());

            public Result<IEnumerable<IGrouping<Func<object, object>, Contract>>> GetListofTByKeyField(string keyField)
            {
                Func<object, object> codeGetter = CreateGetter(DataSource.ContractList.Last().GetType, keyField);// using the 1st element as an example
                return new Result<IEnumerable<IGrouping<Func<object, object>, Contract>>>(from contract in DataSource.ContractList orderby codeGetter group contract by codeGetter);
            }

            public Result<Contract> Remove(Contract item)
            {
                Contract removedChiled = DataSource.ContractList.Find(@contract => @contract == item);
                if (!DataSource.ContractList.Remove(item))
                    return new Result<Contract>(removedChiled, new InvalidOperationException($"Contract: {item} didn't match any Contract ID in the data base."));
                return new Result<Contract>(removedChiled);
            }

            #endregion
        }
        /// <summary>
        /// Defines the <see cref="DNanny" />
        /// </summary>
        public class DNanny : IDal<Nanny>
        {
            #region Methods

            public Result<Nanny> Add(Nanny item)
            {
                if (item.ID == 0)
                    return new Result<Nanny>(item, new ArgumentNullException($"{nameof(item.ID)} of Nanny can't be 0.", nameof(item.ID)));
                if (DataSource.NannyList.Contains(item))
                    return new Result<Nanny>(item, new InvalidOperationException($"Nanny with ID: {item.ID} is already in the data base, with artibautes: {DataSource.NannyList.Find(i => i.ID == item.ID)}"));
                return new Result<Nanny>(item);
            }

            public Result<Nanny> Edit(Nanny item)
            {
                Result<Nanny> deleteResult = Remove(item);
                if (deleteResult.IsErrorOccurred)
                {
                    return deleteResult;
                }
                Result<Nanny> addResult = Add(item);
                if (addResult.IsErrorOccurred)
                {
                    return Add(deleteResult.Value);
                }
                return addResult;
            }

            public Result<List<Nanny>> GetListOfT() => new Result<List<Nanny>>((from item in DataSource.NannyList orderby DataSource.NannyList.FirstOrDefault().LastName select item).ToList());

            public Result<IEnumerable<IGrouping<Func<object, object>, Nanny>>> GetListofTByKeyField(string keyField)
            {
                Func<object, object> codeGetter = CreateGetter(DataSource.NannyList.Last().GetType, keyField);// using the 1st element as an example
                return new Result<IEnumerable<IGrouping<Func<object, object>, Nanny>>>(from nanny in DataSource.NannyList orderby codeGetter group nanny by codeGetter);
            }

            public Result<Nanny> Remove(Nanny item)
            {
                Nanny removedChiled = DataSource.NannyList.Find(@nanny => @nanny == item);
                if (!DataSource.NannyList.Remove(item))
                    return new Result<Nanny>(removedChiled, new InvalidOperationException($"Nanny: {item} didn't match any Nanny ID in the data base."));
                return new Result<Nanny>(removedChiled);
            }

            #endregion
        }
        /// <summary>
        /// Defines the <see cref="DMother" />
        /// </summary>
        public class DMother : IDal<Mother>
        {
            #region Methods

            public Result<Mother> Add(Mother item)
            {
                if (item.ID == 0)
                    return new Result<Mother>(item, new ArgumentNullException($"{nameof(item.ID)} of Mother can't be 0.", nameof(item.ID)));
                if (DataSource.MotherList.Contains(item))
                    return new Result<Mother>(item, new InvalidOperationException($"Mother with ID: {item.ID} is already in the data base, with artibautes: {DataSource.MotherList.Find(i => i.ID == item.ID)}"));
                return new Result<Mother>(item);
            }

            public Result<Mother> Edit(Mother item)
            {
                Result<Mother> deleteResult = Remove(item);
                if (deleteResult.IsErrorOccurred)
                {
                    return deleteResult;
                }
                Result<Mother> addResult = Add(item);
                if (addResult.IsErrorOccurred)
                {
                    return Add(deleteResult.Value);
                }
                return addResult;
            }

            public Result<List<Mother>> GetListOfT() => new Result<List<Mother>>((from item in DataSource.MotherList orderby DataSource.MotherList.FirstOrDefault().LastName select item).ToList());

            public Result<IEnumerable<IGrouping<Func<object, object>, Mother>>> GetListofTByKeyField(string keyField)
            {
                Func<object, object> codeGetter = CreateGetter(DataSource.MotherList.Last().GetType, keyField);// using the 1st element as an example
                return new Result<IEnumerable<IGrouping<Func<object, object>, Mother>>>(from mother in DataSource.MotherList orderby codeGetter group mother by codeGetter);
            }

            public Result<Mother> Remove(Mother item)
            {
                Mother removedChiled = DataSource.MotherList.Find(@mother => @mother == item);
                if (!DataSource.MotherList.Remove(item))
                    return new Result<Mother>(removedChiled, new InvalidOperationException($"Mother: {item} didn't match any Mother ID in the data base."));
                return new Result<Mother>(removedChiled);
            }

            #endregion
        }

        #endregion

        #region Methods

        public static Func<object, object> CreateGetter(Type runtimeType, string propertyName)
        {
            System.Reflection.PropertyInfo propertyInfo = runtimeType.GetProperty(propertyName);

            // create a parameter (object obj)
            ParameterExpression obj = Expression.Parameter(typeof(object), "obj");

            // cast obj to runtimeType
            UnaryExpression objT = Expression.TypeAs(obj, runtimeType);

            // property accessor
            MemberExpression property = Expression.Property(objT, propertyInfo);

            UnaryExpression convert = Expression.TypeAs(property, typeof(object));
            return (Func<object, object>)Expression.Lambda(convert, obj).Compile();
        }

        #endregion
    }

    #endregion
}
