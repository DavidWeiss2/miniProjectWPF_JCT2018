namespace dotNet5778_Project_5337_7178
{
    namespace DS
    {
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Linq.Expressions;

        using dotNet5778_Project_5337_7178.BE;

        /// <summary>
        /// Defines the <see cref="DataSource" />
        /// </summary>
        public class DataSource
        {
            #region Fields

            public static List<Child> childList = new List<Child>();
            public static List<Contract> contractList = new List<Contract>();
            public static List<Mother> motherList = new List<Mother>();
            public static List<Nanny> nannyList = new List<Nanny>();

            #endregion
        }

        /// <summary>
        /// Defines the <see cref="Dal_imp" />
        /// </summary>
        public class Dal_imp
        {
            #region Properties

            public DChild Child { get; } = new DChild();
            public DContract Contract { get; } = new DContract();
            public DMother Mother { get; } = new DMother();
            public DNanny Nanny { get; } = new DNanny();

            #endregion

            #region Methods

            /// <summary>
            /// The CreateGetter
            /// </summary>
            /// <param name="runtimeType">The <see cref="Type"/></param>
            /// <param name="propertyName">The <see cref="string"/></param>
            /// <returns>The <see cref="Func{object, object}"/></returns>
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

            /// <summary>
            /// Defines the <see cref="DChild" />
            /// </summary>
            public class DChild : DAL.IDal<Child>
            {
                #region Methods

                /// <summary>
                /// The Add
                /// </summary>
                /// <param name="item">The <see cref="Child"/></param>
                public void Add(Child item)
                {
                    if (item.ID == 0)
                        throw new ArgumentNullException(nameof(item.ID));
                    if (DataSource.childList.Contains(item))
                        throw new InvalidOperationException($"Child with ID: {item.ID} is already in the data base, with artibautes: {DataSource.childList.Find(i => i.ID == item.ID)}");
                    if (DataSource.motherList.Find(i => i.ID == item.MotherID) == new Mother())
                        throw new InvalidOperationException($"Mother ID: {item.ID} can't be real");
                    DataSource.childList.Add(item);
                }

                /// <summary>
                /// The Edit
                /// </summary>
                /// <param name="item">The <see cref="Child"/></param>
                public void Edit(Child item)
                {
                    DataSource.childList.Remove(item);
                    DataSource.childList.Add(item);
                }

                /// <summary>
                /// The GetListOfT
                /// </summary>
                /// <returns>The <see cref="List{Child}"/></returns>
                public List<Child> GetListOfT() => (from item in DataSource.childList orderby item select item).ToList<Child>();

                /// <summary>
                /// The GetListofTByKeyField
                /// </summary>
                /// <param name="keyField">The <see cref="string"/></param>
                /// <returns>The <see cref="List{Child}"/></returns>
                public List<Child> GetListofTByKeyField(string keyField)
                {
                    Func<object,object> codeGetter = CreateGetter(DataSource.childList.Last().GetType, keyField);// using the 1st element as an example
                    return GetListOfT().OrderBy(o => codeGetter(o)).ToList();
                }

                /// <summary>
                /// The Remove
                /// </summary>
                /// <param name="item">The <see cref="Child"/></param>
                public void Remove(Child item)
                {
                    if (!DataSource.childList.Remove(item))
                        throw new Exception($"Child: {item} didn't match any Child ID in the data base.");
                    DataSource.childList.Remove(item);
                }

                #endregion
            }

            /// <summary>
            /// Defines the <see cref="DMother" />
            /// </summary>
            public class DMother : DAL.IDal<Mother>
            {
                #region Methods

                /// <summary>
                /// The Add
                /// </summary>
                /// <param name="item">The <see cref="Mother"/></param>
                public void Add(Mother item)
                {
                    if (item.ID == 0)
                        throw new ArgumentNullException(nameof(item.ID));
                    if (DataSource.motherList.Contains(item))
                        throw new InvalidOperationException($"Mother with ID: {item.ID} is already in the data base, with artibautes: {DataSource.motherList.Find(i => i.ID == item.ID)}");
                    DataSource.motherList.Add(item);
                }

                /// <summary>
                /// The Edit
                /// </summary>
                /// <param name="item">The <see cref="Mother"/></param>
                public void Edit(Mother item)
                {
                    DataSource.motherList.Remove(item);
                    DataSource.motherList.Add(item);
                }

                /// <summary>
                /// The GetListOfT
                /// </summary>
                /// <returns>The <see cref="List{Mother}"/></returns>
                public List<Mother> GetListOfT() => (from item in DataSource.motherList orderby item select item).ToList<Mother>();

                /// <summary>
                /// The GetListofTByKeyField
                /// </summary>
                /// <param name="keyField">The <see cref="string"/></param>
                /// <returns>The <see cref="List{Mother}"/></returns>
                public List<Mother> GetListofTByKeyField(string keyField)
                {
                    Func<object, object> codeGetter = CreateGetter(DataSource.motherList.Last().GetType, keyField);// using the 1st element as an example
                    return GetListOfT().OrderBy(o => codeGetter(o)).ToList();
                }

                /// <summary>
                /// The Remove
                /// </summary>
                /// <param name="item">The <see cref="Mother"/></param>
                public void Remove(Mother item)
                {
                    if (!DataSource.motherList.Remove(item))
                        throw new Exception($"Mother: {item} didn't match any Mother ID in the data base.");
                    DataSource.motherList.Remove(item);
                }

                #endregion
            }

            /// <summary>
            /// Defines the <see cref="DContract" />
            /// </summary>
            public class DContract : DAL.IDal<Contract>
            {
                #region Methods

                /// <summary>
                /// The Add
                /// </summary>
                /// <param name="item">The <see cref="Contract"/></param>
                public void Add(Contract item)
                {
                    if (item.ID == 0)
                        throw new ArgumentNullException(nameof(item.ID));
                    if (DataSource.contractList.Contains(item))
                        throw new InvalidOperationException($"Contract with ID: {item.ID} is already in the data base, with artibautes: {DataSource.contractList.Find(i => i.ID == item.ID)}");
                    DataSource.contractList.Add(item);
                }

                /// <summary>
                /// The Edit
                /// </summary>
                /// <param name="item">The <see cref="Contract"/></param>
                public void Edit(Contract item)
                {
                    DataSource.contractList.Remove(item);
                    DataSource.contractList.Add(item);
                }

                /// <summary>
                /// The GetListOfT
                /// </summary>
                /// <returns>The <see cref="List{Contract}"/></returns>
                public List<Contract> GetListOfT() => (from item in DataSource.contractList orderby item select item).ToList<Contract>();

                /// <summary>
                /// The GetListofTByKeyField
                /// </summary>
                /// <param name="keyField">The <see cref="string"/></param>
                /// <returns>The <see cref="List{Contract}"/></returns>
                public List<Contract> GetListofTByKeyField(string keyField)
                {
                    Func<object, object> codeGetter = CreateGetter(DataSource.contractList.Last().GetType, keyField);// using the 1st element as an example
                    return GetListOfT().OrderBy(o => codeGetter(o)).ToList();
                }

                /// <summary>
                /// The Remove
                /// </summary>
                /// <param name="item">The <see cref="Contract"/></param>
                public void Remove(Contract item)
                {
                    if (!DataSource.contractList.Remove(item))
                        throw new Exception($"Contract: {item} didn't match any Contract ID in the data base.");
                    DataSource.contractList.Remove(item);
                }

                #endregion
            }

            /// <summary>
            /// Defines the <see cref="DNanny" />
            /// </summary>
            public class DNanny : DAL.IDal<Nanny>
            {
                #region Methods

                /// <summary>
                /// The Add
                /// </summary>
                /// <param name="item">The <see cref="Nanny"/></param>
                public void Add(Nanny item)
                {
                    if (item.ID == 0)
                        throw new ArgumentNullException(nameof(item.ID));
                    if (DataSource.nannyList.Contains(item))
                        throw new InvalidOperationException($"Nanny with ID: {item.ID} is already in the data base, with artibautes: {DataSource.nannyList.Find(i => i.ID == item.ID)}");
                    DataSource.nannyList.Add(item);
                }

                /// <summary>
                /// The Edit
                /// </summary>
                /// <param name="item">The <see cref="Nanny"/></param>
                public void Edit(Nanny item)
                {
                    DataSource.nannyList.Remove(item);
                    DataSource.nannyList.Add(item);
                }

                /// <summary>
                /// The GetListOfT
                /// </summary>
                /// <returns>The <see cref="List{Nanny}"/></returns>
                public List<Nanny> GetListOfT() => (from item in DataSource.nannyList orderby item select item).ToList<Nanny>();

                /// <summary>
                /// The GetListofTByKeyField
                /// </summary>
                /// <param name="keyField">The <see cref="string"/></param>
                /// <returns>The <see cref="List{Nanny}"/></returns>
                public List<Nanny> GetListofTByKeyField(string keyField)
                {
                    Func<object, object> codeGetter = CreateGetter(DataSource.nannyList.Last().GetType, keyField);// using the 1st element as an example
                    return GetListOfT().OrderBy(o => codeGetter(o)).ToList();
                }

                /// <summary>
                /// The Remove
                /// </summary>
                /// <param name="item">The <see cref="Nanny"/></param>
                public void Remove(Nanny item)
                {
                    if (!DataSource.nannyList.Remove(item))
                        throw new Exception($"Nanny: {item} didn't match any Nanny ID in the data base.");
                    DataSource.nannyList.Remove(item);
                }

                #endregion
            }
        }
    }
}
