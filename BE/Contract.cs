
namespace BE
{
    using System;
    using System.Collections.Generic;

    #region Classes

    /// <summary>
    /// Defines the <see cref="Contract" />
    /// </summary>
    public class Contract : Id, IEqualityComparer<Contract>
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
            get => this.childID; set => this.childID = value.IsInHumanRange(nameof(this.ChildID));
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
            get => this.motherID; set => this.motherID = value.IsInHumanRange(nameof(this.MotherID));
        }
        public long NannyID
        {
            get => this.nannyID; set => this.nannyID = value.IsInHumanRange(nameof(this.NannyID));
        }
        public double WagePerHour
        {
            get => this.wagePerHour; set => this.wagePerHour = (double)value.IsInRange(value>0,nameof(this.WagePerHour),"","0");
        }
        public double WagePerMonth
        {
            get => this.wagePerMonth; set => this.wagePerMonth = (double)value.IsInRange(value > 0, nameof(this.WagePerMonth), "", "0");
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
        bool IEqualityComparer<Contract>.Equals(Contract x, Contract y) => x.ID == y.ID || x.ChildID == y.ChildID && x.NannyID == y.NannyID;
        int IEqualityComparer<Contract>.GetHashCode(Contract obj) => obj.ID.GetHashCode();


        #endregion
    }

    #endregion
}
