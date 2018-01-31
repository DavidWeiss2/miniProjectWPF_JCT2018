using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public readonly struct Result<T> : IEquatable<Result<T>>
    {
        public readonly T Value;
        public readonly bool IsErrorOccurred;
        public readonly string ErrorMassege;

        public Result(T value = default, string errorMassege = "")
        {
            this.Value = value;
            this.IsErrorOccurred = errorMassege == "";
            this.ErrorMassege = errorMassege;
        }
        public Result(T value, Exception exception)
        {
            this.Value = value;
            this.IsErrorOccurred = true;
            this.ErrorMassege = exception.Message;
        }
        public static explicit operator Result<T>(Result<object> v) => new Result<T>((T)v.Value, v.ErrorMassege);
        public static Result<T> operator +(Result<T> left, Result<T> right) => new Result<T>(right.Value, left.ErrorMassege.Append(right.ErrorMassege));
        public static Result<T> operator +(Result<T> left, Result<object> right) => new Result<T>(right.IsErrorOccurred ? default : left.Value, left.ErrorMassege.Append(right.ErrorMassege));
        public static Result<T> operator +(Result<T> left, Exception ex) => new Result<T>(left.Value, ex);
        public static bool operator ==(Result<T> result1, Result<T> result2) => result1.Equals(result2);
        public static bool operator ==(Result<T> result1, T cmp2) => result1.Value.Equals(cmp2);
        public static bool operator !=(Result<T> result1, T cmp2) => !(result1 == cmp2);
        public static bool operator !=(Result<T> result1, Result<T> result2) => !(result1 == result2);

        public override bool Equals(object obj) => obj is Result<T> && this.Equals((Result<T>)obj);
        public bool Equals(Result<T> other) => EqualityComparer<T>.Default.Equals(this.Value, other.Value);

        public override int GetHashCode()
        {
            int hashCode = -783812246;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<T>.Default.GetHashCode(this.Value);
            return hashCode;
        }

        public override string ToString() => this.IsErrorOccurred ? this.ErrorMassege: this.Value.ToString();
    }
}
