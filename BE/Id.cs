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

        public new Type GetType => this.GetType();
        public string GetTypeName => this.GetType().Name;
        public long ID { get; } = -1;

        #endregion

        #region Methods

        public int CompareTo(object obj)
        {
            if (this.ID == ((Id)obj).ID)
                return 0;
            if (this.ID < ((Id)obj).ID)
                return -1;
            return 1;
        }

        public virtual bool Equals(Id other) => other != null && this.ID == other.ID;

        public override bool Equals(object obj) => this.Equals(obj as Id);

        public override int GetHashCode() => 1213502048 + this.ID.GetHashCode();

        public override string ToString() => $"Type:{this.GetType().Name} ID:{this.ID}.";

        #endregion

        public Id(long id = -1) => this.ID = id;





        public static bool operator >(Id left, Id right) => left.CompareTo(right) > 0;
        public static bool operator <(Id left, Id right) => left.CompareTo(right) < 0;
        public static bool operator >=(Id left, Id right) => left.CompareTo(right) >= 0;
        public static bool operator <=(Id left, Id right) => left.CompareTo(right) <= 0;

        public static bool operator ==(Id left, Id right) => EqualityComparer<Id>.Default.Equals(left, right);
        public static bool operator ==(long left, Id right) => left==right.ID;
        public static bool operator !=(long left, Id right) => left == right;
        public static bool operator !=(Id left, Id right) => !(left == right);
    }
}
