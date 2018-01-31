
using System;
[assembly: CLSCompliant(true)]
namespace BE
{

    #region Classes

    /// <summary>
    /// Defines the <see cref="Human" />
    /// </summary>
    public abstract class Human : Id
    {
        public string Address
        {
            get; set;
        } = "";
        public DateTime DateOfBirth
        {
            get; set;
        }
        public string FirstName
        {
            get; set;
        } = "";
        public bool IsFemale
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        } = "";
        #region Constructors

        protected Human(long id = 0) : base(id)
        {

        }

        #endregion

        #region Methods

        public override string ToString() => $"Type:{this.GetType().Name} ID:{this.ID}, first name:{this.FirstName}, last name:{this.LastName}, address:{this.Address}.";

        #endregion
    }

    #endregion
}
