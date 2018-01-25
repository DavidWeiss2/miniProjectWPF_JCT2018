namespace dotNet5778_Project_5337_7178
{
    namespace BE
    {
        using System;

        #region Classes

        /// <summary>
        /// Defines the <see cref="Mother" />
        /// </summary>
        public class Mother : Human
        {
            #region Fields

            private string addressOfSerchArea;
            private bool[] IsSearchingInDay = new bool[7];
            private string notes;
            private string phoneNumber;
            private int[,] WorkingTimes = new int[7, 2];

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
            public string PhoneNumber
            {
                get => this.phoneNumber; set => this.phoneNumber = value;
            }
            public int[,] WorkingTimes1
            {
                get => this.WorkingTimes; set => this.WorkingTimes = value;
            }

            #endregion

            #region Constructors

            public Mother(long iD = 0) : base(iD)
            {
                ;
            }
            public Mother(long iD, string firstName, string lastName, DateTime dateOfBirth, string address, string phoneNumber, string addressOfSerchArea, string notes, bool isFemale = true) : base(iD, dateOfBirth, firstName, lastName, isFemale, address)
            {
                this.AddressOfSerchArea = addressOfSerchArea;
                this.PhoneNumber = phoneNumber;
                this.Notes = notes;
            }

            #endregion
        }

        #endregion
    }
}
