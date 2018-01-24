namespace dotNet5778_Project_5337_7178
{
    namespace BE
    {
        using System;
        using System.Collections.Generic;

        /// <summary>
        /// Defines the <see cref="Id" />
        /// </summary>
        public class Id : IEquatable<Id>, IComparable
        {
            #region Properties

            public long ID
            {
                get;
            }
            public string GetTypeName => this.GetType().Name;
            public new Type GetType => this.GetType();

            #endregion

            #region Methods

            /// <summary>
            /// The CompareTo
            /// </summary>
            /// <param name="obj">The <see cref="object"/></param>
            /// <returns>The <see cref="int"/></returns>
            public int CompareTo(object obj)
            {
                if (this.ID == ((Id)obj).ID)
                    return 0;
                if (this.ID < ((Id)obj).ID)
                    return -1;
                if (this.ID > ((Id)obj).ID)
                    return 1;
                throw new Exception();
            }

            /// <summary>
            /// The Equals
            /// </summary>
            /// <param name="other">The <see cref="Id"/></param>
            /// <returns>The <see cref="bool"/></returns>
            public virtual bool Equals(Id other) => other != null && this.ID == other.ID;

            /// <summary>
            /// The Equals
            /// </summary>
            /// <param name="obj">The <see cref="object"/></param>
            /// <returns>The <see cref="bool"/></returns>
            public override bool Equals(object obj) => this.Equals(obj as Id);

            /// <summary>
            /// The ToString
            /// </summary>
            /// <param name="format">The <see cref="string"/></param>
            /// <param name="formatProvider">The <see cref="IFormatProvider"/></param>
            /// <returns>The <see cref="string"/></returns>
            public override string ToString() => $"Type:{this.GetType().Name} ID:{this.ID}.";
            public override int GetHashCode() => 1213502048 + this.ID.GetHashCode();

            #endregion

            /// <summary>
            /// Initializes a new instance of the <see cref="Id"/> class.
            /// </summary>
            /// <param name="iD">The <see cref="int"/></param>
            public Id(long iD=0) => this.ID = iD;


            public static bool operator ==(Id Id1, Id Id2) => EqualityComparer<Id>.Default.Equals(Id1, Id2);
            public static bool operator !=(Id Id1, Id Id2) => !(Id1 == Id2);
        }
    }
}
