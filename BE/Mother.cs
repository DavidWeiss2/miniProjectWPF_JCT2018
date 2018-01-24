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
            /// <param name="address">The <see cref="string"/></param>
            /// <param name="dateOfBirth">The <see cref="DateTime"/></param>
            /// <param name="firstName">The <see cref="string"/></param>
            /// <param name="iD">The <see cref="int"/></param>
            /// <param name="lastName">The <see cref="string"/></param>
            /// <param name="phoneNumber">The <see cref="string"/></param>
            /// <param name="isFemale">The <see cref="bool"/></param>
            /// <param name="addressOfSerchArea">The <see cref="string"/></param>
            /// <param name="notes">The <see cref="string"/></param>
            public Mother(string address, DateTime dateOfBirth, string firstName, int iD, string lastName, string phoneNumber, bool isFemale, string addressOfSerchArea, string notes) : base(iD, dateOfBirth, firstName, lastName, isFemale, address, phoneNumber)
            {
                this.AddressOfSerchArea = addressOfSerchArea;
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
