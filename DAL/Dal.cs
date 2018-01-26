namespace DAL
{
    using System;
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
        public DChild Child { get; } = new DChild();
        public DContract Contract { get; } = new DContract();
        public DMother Mother { get; } = new DMother();
        public DNanny Nanny { get; } = new DNanny();
        #region Classes

        /// <summary>
        /// Defines the <see cref="DChild" />
        /// </summary>
        public class DChild : DAL.IDal<Child>
        {
            #region Methods

            public void Add(Child item)
            {
                if (item.ID == 0)
                    throw new ArgumentNullException($"{nameof(item.ID)} of Child can't be 0.", nameof(item.ID));
                if (DataSource.ChildList.Contains(item))
                    throw new InvalidOperationException($"Child with ID: {item.ID} is already in the data base, with artibautes: {DataSource.ChildList.Find(i => i.ID == item.ID)}");
                if (DataSource.MotherList.Find(i => i.ID == item.MotherID) == new Mother())
                    throw new InvalidOperationException($"Mother ID: {item.ID} can't be real");
                DataSource.ChildList.Add(item);
            }

            public void Edit(Child item)
            {
                DataSource.ChildList.Remove(item);
                DataSource.ChildList.Add(item);
            }

            public List<Child> GetGetListOfT() => (from item in DataSource.ChildList orderby item select item).ToList();

            public List<Child> GetListofTByKeyField(string keyField)
            {
                Func<object, object> codeGetter = CreateGetter(DataSource.ChildList.Last().GetType, keyField);// using the 1st element as an example
                return this.GetGetListOfT().OrderBy(o => codeGetter(o)).ToList();
            }

            public void Remove(Child item)
            {
                if (!DataSource.ChildList.Remove(item))
                    throw new InvalidOperationException($"Child: {item} didn't match any Child ID in the data base.");
                DataSource.ChildList.Remove(item);
            }

            #endregion
        }

        /// <summary>
        /// Defines the <see cref="DContract" />
        /// </summary>
        public class DContract : DAL.IDal<Contract>
        {
            public long MaxID
            {
                get
                {
                    try
                    {
                        return this.GetGetListOfT().Max(i => i.ID);
                    }
                    catch
                    {
                        return 0;
                    }
                }
            }
            #region Methods

            public void Add(Contract item)
            {
                if (item.ID == 0)
                    nameof(item.ID).ThrowNull();
                if (DataSource.ContractList.Contains(item))
                    throw new InvalidOperationException($"Contract with ID: {item.ID} is already in the data base, with artibautes: {DataSource.ContractList.Find(i => i.ID == item.ID)}");
                DataSource.ContractList.Add(item);
            }

            public void Edit(Contract item)
            {
                DataSource.ContractList.Remove(item);
                DataSource.ContractList.Add(item);
            }

            public List<Contract> GetGetListOfT() => (from item in DataSource.ContractList orderby item select item).ToList<Contract>();

            public List<Contract> GetListofTByKeyField(string keyField)
            {
                Func<object, object> codeGetter = CreateGetter(DataSource.ContractList.Last().GetType, keyField);// using the 1st element as an example
                return this.GetGetListOfT().OrderBy(o => codeGetter(o)).ToList();
            }

            public void Remove(Contract item)
            {
                if (!DataSource.ContractList.Remove(item))
                    throw new InvalidOperationException($"Contract: {item} didn't match any Contract ID in the data base.");
                DataSource.ContractList.Remove(item);
            }

            #endregion
        }

        /// <summary>
        /// Defines the <see cref="DMother" />
        /// </summary>
        public class DMother : DAL.IDal<Mother>
        {
            #region Methods

            public void Add(Mother item)
            {
                if (item.ID == 0)
                    nameof(item.ID).ThrowNull();
                if (DataSource.MotherList.Contains(item))
                    throw new InvalidOperationException($"Mother with ID: {item.ID} is already in the data base, with artibautes: {DataSource.MotherList.Find(i => i.ID == item.ID)}");
                DataSource.MotherList.Add(item);
            }

            public void Edit(Mother item)
            {
                DataSource.MotherList.Remove(item);
                DataSource.MotherList.Add(item);
            }

            public List<Mother> GetGetListOfT() => (from item in DataSource.MotherList orderby item select item).ToList<Mother>();

            public List<Mother> GetListofTByKeyField(string keyField)
            {
                Func<object, object> codeGetter = CreateGetter(DataSource.MotherList.Last().GetType, keyField);// using the 1st element as an example
                return this.GetGetListOfT().OrderBy(o => codeGetter(o)).ToList();
            }

            public void Remove(Mother item)
            {
                if (!DataSource.MotherList.Remove(item))
                    throw new InvalidOperationException($"Mother: {item} didn't match any Mother ID in the data base.");
                DataSource.MotherList.Remove(item);
            }

            #endregion
        }

        /// <summary>
        /// Defines the <see cref="DNanny" />
        /// </summary>
        public class DNanny : DAL.IDal<Nanny>
        {
            #region Methods

            public void Add(Nanny item)
            {
                if (item.ID == 0)
                    nameof(item.ID).ThrowNull();
                if (DataSource.NannyList.Contains(item))
                    throw new InvalidOperationException($"Nanny with ID: {item.ID} is already in the data base, with artibautes: {DataSource.NannyList.Find(i => i.ID == item.ID)}");
                DataSource.NannyList.Add(item);
            }

            public void Edit(Nanny item)
            {
                DataSource.NannyList.Remove(item);
                DataSource.NannyList.Add(item);
            }

            public List<Nanny> GetGetListOfT() => (from item in DataSource.NannyList orderby item select item).ToList<Nanny>();

            public List<Nanny> GetListofTByKeyField(string keyField)
            {
                Func<object, object> codeGetter = CreateGetter(DataSource.NannyList.Last().GetType, keyField);// using the 1st element as an example
                return this.GetGetListOfT().OrderBy(o => codeGetter(o)).ToList();
            }

            public void Remove(Nanny item)
            {
                if (!DataSource.NannyList.Remove(item))
                    throw new InvalidOperationException($"Nanny: {item} didn't match any Nanny ID in the data base.");
                DataSource.NannyList.Remove(item);
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
