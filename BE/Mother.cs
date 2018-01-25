namespace dotNet5778_Project_5337_7178
{
    namespace BE
    {
        using System;

        /// <summary>
        /// Defines the <see cref="Mother" />
        /// </summary>
        public class Mother : Human
        {
            #region Fields

            private string addressOfSerchArea;
            private bool[] IsSearchingInDay = new bool[7];
            private string notes;
            private double[,] WorkingTimes = new double[7, 2];

            #endregion

            public string PhoneNumber
            {
                get => this.phoneNumber; set => this.phoneNumber = value;
            }

            private string phoneNumber;
            #region Properties

            public string AddressOfSerchArea
            {
                get => this.addressOfSerchArea; set => this.addressOfSerchArea = value ?? throw new ArgumentNullException(nameof(this.AddressOfSerchArea));
            }
            public bool[] IsSearchingInDay1
            {
                get => this.IsSearchingInDay; set => this.IsSearchingInDay = value;
            }
            public string Notes
            {
                get => this.notes; set => this.notes = value ?? throw new ArgumentNullException(nameof(this.Notes));
            }
            public double[,] WorkingTimes1
            {
                get => this.WorkingTimes; set => this.WorkingTimes = value;
            }

            #endregion

            /// <summary>
            /// Initializes a new instance of the <see cref="Mother"/> class.
            /// </summary>
            /// <param name="iD">The <see cref="int"/></param>
            /// <param name="firstName">The <see cref="string"/></param>
            /// <param name="lastName">The <see cref="string"/></param>
            /// <param name="dateOfBirth">The <see cref="DateTime"/></param>
            /// <param name="address">The <see cref="string"/></param>
            /// <param name="phoneNumber">The <see cref="string"/></param>
            /// <param name="addressOfSerchArea">The <see cref="string"/></param>
            /// <param name="notes">The <see cref="string"/></param>
            /// <param name="isFemale">The <see cref="bool"/></param>
            public Mother(long iD, string firstName, string lastName, DateTime dateOfBirth, string address, string phoneNumber, string addressOfSerchArea, string notes, bool isFemale = true) : base(iD, dateOfBirth, firstName, lastName, isFemale, address)
            {
                this.AddressOfSerchArea = addressOfSerchArea;
                this.PhoneNumber = phoneNumber;
                this.Notes = notes;
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="Mother"/> class.
            /// </summary>
            /// <param name="iD">The <see cref="long"/></param>
            public Mother(long iD = 0) : base(iD)
            {
                ;
            }

        }
    }
}
