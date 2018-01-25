namespace dotNet5778_Project_5337_7178
{
    namespace BE
    {
        using System;

        #region Classes

        /// <summary>
        /// Defines the <see cref="Child" />
        /// </summary>
        public class Child : Human
        {
            #region Fields

            private string disableInfo;
            private bool isDisabled;
            private long motherID;

            #endregion

            #region Properties

            public string DisableInfo
            {
                get => this.disableInfo; set => this.disableInfo = value ?? throw new ArgumentNullException(nameof(this.DisableInfo));
            }
            public bool IsDisabled
            {
                get => this.isDisabled; set => this.isDisabled = value;
            }
            public long MotherID
            {
                get => this.motherID; set => this.motherID = value >= 0 && value < 1000000000 ? value : throw new ArgumentOutOfRangeException(nameof(this.MotherID));
            }

            #endregion

            #region Constructors

            public Child(long iD = 0) : base(iD)
            {
                ;
            }
            public Child(long iD, DateTime dateOfBirth, string firstName, string lastName, bool isFemale, Mother mother, string address, bool isDisabled = false, string disableInfo = "") : base(iD, dateOfBirth, firstName, lastName, isFemale, address)
            {
                this.MotherID = mother.ID;
                this.IsDisabled = isDisabled;
                this.DisableInfo = disableInfo;
            }

            #endregion
        }

        #endregion
    }
}
