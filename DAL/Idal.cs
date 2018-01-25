namespace dotNet5778_Project_5337_7178
{
    namespace DAL
    {
        using System.Collections.Generic;

        /// <summary>
        /// Defines the <see cref="IDal" />
        /// </summary>
        public interface IDal<T>
        {
            #region Methods

            /// <summary>
            /// The Add
            /// </summary>
            /// <param name="item">The <see cref="T"/></param>
            void Add(T item);

            /// <summary>
            /// The Edit
            /// </summary>
            /// <param name="item">The <see cref="T"/></param>
            void Edit(T item);

            /// <summary>
            /// The GetListOfT
            /// </summary>
            /// <returns>The <see cref="List{T}"/></returns>
            List<T> GetListOfT {get; }

            /// <summary>
            /// The GetListofTByKeyField
            /// </summary>
            /// <param name="keyField">The <see cref="string"/></param>
            /// <returns>The <see cref="List{T}"/></returns>
            List<T> GetListofTByKeyField(string keyField);

            /// <summary>
            /// The Remove
            /// </summary>
            /// <param name="item">The <see cref="T"/></param>
            void Remove(T item);

            #endregion
        }
    }
}
