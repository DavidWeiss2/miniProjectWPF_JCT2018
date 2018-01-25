namespace dotNet5778_Project_5337_7178
{
    namespace BE
    {
        using System;

        /// <summary>
        /// Defines the <see cref="Child" />
        /// </summary>
        public class Child : Human
        {
            #region Fields

            private string disableInfo;
            private bool isDisabled;
            double motherID;

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
            public double MotherID
            {
                get => this.motherID; set => this.motherID = value >= 0 && value < 1000000000 ? value : throw new ArgumentOutOfRangeException(nameof(this.MotherID));
            }

            #endregion

            /// <summary>
            /// Initializes a new instance of the <see cref="Child"/> class.
            /// </summary>
            /// <param name="iD">The <see cref="int"/></param>
            /// <param name="dateOfBirth">The <see cref="DateTime"/></param>
            /// <param name="firstName">The <see cref="string"/></param>
            /// <param name="lastName">The <see cref="string"/></param>
            /// <param name="isFemale">The <see cref="bool"/></param>
            /// <param name="mother">The <see cref="Mother"/></param>
            /// <param name="address">The <see cref="string"/></param>
            /// <param name="isDisabled">The <see cref="bool"/></param>
            /// <param name="disableInfo">The <see cref="string"/></param>
            /// <param name="phoneNumber">The <see cref="string"/></param>
            public Child(long iD, DateTime dateOfBirth, string firstName, string lastName, bool isFemale, Mother mother, string address, bool isDisabled = false, string disableInfo = "") : base(iD, dateOfBirth, firstName, lastName, isFemale, address)
            {
                this.MotherID = mother.ID;
                this.IsDisabled = isDisabled;
                this.DisableInfo = disableInfo;
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="Child"/> class.
            /// </summary>
            /// <param name="iD">The <see cref="int"/></param>
            public Child(long iD =0) : base(iD)
            {
                ;
            }
        }
    }
}
