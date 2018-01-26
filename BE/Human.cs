
namespace BE
{
    using System;

    #region Classes

    /// <summary>
    /// Defines the <see cref="Human" />
    /// </summary>
    public class Human : Id
    {
        #region Fields

        protected string address;
        protected DateTime dateOfBirth;
        protected string firstName;
        protected bool isFemale;
        protected string lastName;

        #endregion

        #region Properties

        public string Address
        {
            get => this.address; set => this.address = value.IsNotNull(nameof(this.Address));
        }
        public DateTime DateOfBirth
        {
            get => this.dateOfBirth; set => this.dateOfBirth = value.IsInDateRange(DateTime.Now,DateTime.Now.AddYears(-12),nameof(this.DateOfBirth));
        }
        public string FirstName
        {
            get => this.firstName; set => this.firstName = value.IsNotNull(nameof(this.FirstName)).IsFormated(TextFormats.Letters,nameof(this.FirstName));
        }
        public bool IsFemale
        {
            get => this.isFemale; set => this.isFemale = value;
        }
        public string LastName
        {
            get => this.lastName; set => this.lastName = value.IsNotNull(nameof(this.LastName));
        }

        #endregion

        #region Constructors

        public Human(long iD = 0) : base(iD) { }
        public Human(long iD, DateTime dateOfBirth, string firstName, string lastName, bool isFemale, string address) : base(iD)
        {
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IsFemale = isFemale;
            iD.IsInHumanRange(nameof(this.ID));
        }

        #endregion

        #region Methods

        public override string ToString() => $"Type:{this.GetType().Name} ID:{this.ID}, first name:{this.FirstName}, last name:{this.LastName}, address:{this.Address}.";

        #endregion
    }

    #endregion
}
