namespace dotNet5778_Project_5337_7178
{
    namespace BE
    {
        using System;

        /// <summary>
        /// Defines the <see cref="Contract" />
        /// </summary>
        public class Contract : Id, IEquatable<Contract>
        {
            #region Fields

            private double childID;
            private DateTime contractExpiredTime;
            private static int contracts;
            private DateTime contractSignedTime;
            private bool isContractSigned;
            private bool isMotherAndNannyMets;
            private bool isWagePerHour;
            private double motherID;
            private double nannyID;
            private double wagePerHour;
            private double wagePerMonth;

            #endregion

            #region Properties

            public double ChildID
            {
                get => this.childID; set => this.childID = value >= 100000000 && value < 1000000000 ? value : throw new ArgumentOutOfRangeException(nameof(this.ChildID));
            }
            public DateTime ContractExpiredTime
            {
                get => this.contractExpiredTime; set => this.contractExpiredTime = value;
            }
            public static int Contracts
            {
                get => contracts; set => contracts = value < 1000000 && value >= 0 ? value : throw new ArgumentOutOfRangeException(nameof(Contracts));
            }
            public DateTime ContractSignedTime
            {
                get => this.contractSignedTime; set => this.contractSignedTime = value;
            }
            public bool IsContractSigned
            {
                get => this.isContractSigned; set => this.isContractSigned = value;
            }
            public bool IsMotherAndNannyMets
            {
                get => this.isMotherAndNannyMets; set => this.isMotherAndNannyMets = value;
            }
            public bool IsWagePerHour
            {
                get => this.isWagePerHour; set => this.isWagePerHour = value;
            }
            public double MotherID
            {
                get => this.motherID; set => this.motherID = value >= 100000000 && value < 1000000000 ? value : throw new ArgumentOutOfRangeException(nameof(this.MotherID));
            }
            public double NannyID
            {
                get => this.nannyID; set => this.nannyID = value >= 100000000 && value < 1000000000 ? value : throw new ArgumentOutOfRangeException(nameof(this.NannyID));
            }
            public double WagePerHour
            {
                get => this.wagePerHour; set => this.wagePerHour = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(this.WagePerHour));
            }
            public double WagePerMonth
            {
                get => this.wagePerMonth; set => this.wagePerMonth = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(this.WagePerMonth));
            }

            #endregion

            #region Methods

            /// <summary>
            /// The Equals
            /// </summary>
            /// <param name="other">The <see cref="Contract"/></param>
            /// <returns>The <see cref="bool"/></returns>
            public bool Equals(Contract other) => other != null && this.ID == other.ID || this.NannyID == other.NannyID && this.ChildID == other.ChildID;

            /// <summary>
            /// The ToString
            /// </summary>
            /// <returns>The <see cref="string"/></returns>
            public override string ToString() => $"Contract ID:{this.ID}, nanny ID:{this.NannyID}, child ID:{this.ChildID}, signed at:{this.ContractSignedTime}, deprecated:{this.ContractExpiredTime < DateTime.Now}";

            #endregion

            /// <summary>
            /// Initializes a new instance of the <see cref="Contract"/> class.
            /// </summary>
            /// <param name="nanny">The <see cref="Nanny"/></param>
            /// <param name="mother">The <see cref="Mother"/></param>
            /// <param name="child">The <see cref="Child"/></param>
            /// <param name="isWagePerHour">The <see cref="bool"/></param>
            /// <param name="MonthsUntilExpired">The <see cref="int"/></param>
            /// <param name="isMotherAndNannyMets">The <see cref="bool"/></param>
            /// <param name="isContractSigned">The <see cref="bool"/></param>
            public Contract(Nanny nanny, Mother mother, Child child, bool isWagePerHour, int MonthsUntilExpired, bool isMotherAndNannyMets = false, bool isContractSigned = false) : base(++Contracts)
            {
                this.NannyID = nanny.ID;
                this.MotherID = mother.ID;
                this.ChildID = child.ID;
                this.IsContractSigned = isContractSigned;
                this.IsMotherAndNannyMets = isMotherAndNannyMets;
                this.WagePerHour = nanny.WagePerHour;
                this.WagePerMonth = nanny.WagePerMonth;
                this.IsWagePerHour = nanny.IsAcceptingHourlyWage ? isWagePerHour : isWagePerHour ? throw new ArgumentException(nameof(this.IsWagePerHour)) : isWagePerHour;
                this.ContractSignedTime = DateTime.Now;
                this.ContractExpiredTime = MonthsUntilExpired > 0 ? DateTime.Now.AddMonths(MonthsUntilExpired) : throw new ArgumentOutOfRangeException(nameof(this.ContractExpiredTime));
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="Contract"/> class.
            /// </summary>
            /// <param name="iD">The <see cref="long"/></param>
            public Contract(long iD = 0) : base(iD)
            {
                ;
            }
        }
    }
}
