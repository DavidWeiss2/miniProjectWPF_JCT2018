using System;
using System.Linq.Expressions;

namespace BE
{
    /// <summary>
    /// Defines the <see cref="TypeExtention" />
    /// </summary>
    public static class TypeExtention
    {
        #region Methods

        public static Func<object, object> CreateGetter(this Type runtimeType, string propertyName)
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
}
