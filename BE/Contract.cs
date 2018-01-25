namespace dotNet5778_Project_5337_7178
{
    namespace BE
    {
        using System;

        #region Classes

        /// <summary>
        /// Defines the <see cref="Contract" />
        /// </summary>
        public class Contract : Id, IEquatable<Contract>
        {
            #region Fields

            private long childID;
            private DateTime contractExpiredTime;
            private DateTime contractSignedTime;
            private bool isContractSigned;
            private bool isMotherAndNannyMets;
            private bool isWagePerHour;
            private long motherID;
            private long nannyID;
            private double wagePerHour;
            private double wagePerMonth;
            private bool[] isSearchingInDay = new bool[7];
            private int[][] workingTimes = new int[7][];

            #endregion

            #region Properties

            public long ChildID
            {
                get => this.childID; set => this.childID = value >= 100000000 && value < 1000000000 ? value : throw new ArgumentOutOfRangeException(nameof(this.ChildID));
            }
            public DateTime ContractExpiredTime
            {
                get => this.contractExpiredTime; set => this.contractExpiredTime = value;
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
            public long MotherID
            {
                get => this.motherID; set => this.motherID = value >= 100000000 && value < 1000000000 ? value : throw new ArgumentOutOfRangeException(nameof(this.MotherID));
            }
            public long NannyID
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
            public bool[] IsSearchingInDay
            {
                get => this.isSearchingInDay;
                set => this.isSearchingInDay = value;
            }
            public int[][] WorkingTimes
            {
                get => this.workingTimes;
                set => this.workingTimes = value;
            }

            #endregion

            #region Constructors

            public Contract(long iD = 0) : base(iD)
            {
                ;
            }
            public Contract(long id, Nanny nanny, Mother mother, Child child, bool isWagePerHour, DateTime signedTime, DateTime expiredTime, bool[] isSearchingInDay, int[][] workingTimes, bool isMotherAndNannyMets = false, bool isContractSigned = false) : base(id)
            {
                this.NannyID = nanny.ID;
                this.MotherID = mother.ID;
                this.ChildID = child.ID;
                this.IsContractSigned = isContractSigned;
                this.IsMotherAndNannyMets = isMotherAndNannyMets;
                this.WagePerHour = nanny.WagePerHour;
                this.WagePerMonth = nanny.WagePerMonth;
                this.IsWagePerHour = nanny.IsAcceptingHourlyWage ? isWagePerHour : isWagePerHour ? throw new ArgumentException(nameof(this.IsWagePerHour)) : isWagePerHour;
                this.ContractSignedTime = signedTime;
                this.ContractExpiredTime = expiredTime;
            }

            #endregion

            #region Methods

            public override string ToString() => $"Contract ID:{this.ID}, nanny ID:{this.NannyID}, child ID:{this.ChildID}, signed at:{this.ContractSignedTime}, deprecated:{this.ContractExpiredTime < DateTime.Now}";

            bool IEquatable<Contract>.Equals(Contract other) => other != null && this.ID == other.ID || this.NannyID == other.NannyID && this.ChildID == other.ChildID;

            #endregion
        }

        #endregion
    }
}
