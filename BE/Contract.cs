namespace BE
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Contract" />
    /// </summary>
    public class Contract : Id, IEqualityComparer<Contract>
    {
        #region Properties

        public long ChildId
        {
            get; set;
        }
        public DateTime ContractExpiredTime
        {
            get; set;
        }
        public DateTime ContractSignedTime
        {
            get; set;
        }
        public int[][] GetWorkingTimes
        {
            get; set;
        }
        public bool IsContractSigned
        {
            get; set;
        }
        public bool IsMotherAndNannyMets
        {
            get; set;
        }
        public bool[] IsSearchingInDay
        {
            get; set;
        }
        public bool IsWagePerHour
        {
            get; set;
        }
        public long MotherId
        {
            get; set;
        }
        public long NannyId
        {
            get; set;
        }
        public double WagePerHour
        {
            get; set;
        }
        public double WagePerMonth
        {
            get; set;
        }

        #endregion

        #region Methods

        bool IEqualityComparer<Contract>.Equals(Contract x, Contract y) => x.ID == y.ID || x.ChildId == y.ChildId && x.NannyId == y.NannyId;

        int IEqualityComparer<Contract>.GetHashCode(Contract obj) => obj.ID.GetHashCode();

        public override string ToString() => $"Contract ID:{this.ID}, nanny ID:{this.NannyId}, child ID:{this.ChildId}, signed at:{this.ContractSignedTime}, deprecated:{this.ContractExpiredTime < DateTime.Now}";

        #endregion

        public Contract(long id) : base(id)
        {
        }

        public Contract() : base(0)
        {
        }
    }
}
