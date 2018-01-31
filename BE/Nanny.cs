
namespace BE
{
    using System;

    #region Classes

    /// <summary>
    /// Defines the <see cref="Nanny" />
    /// </summary>
    public class Nanny : Human
    {

        #region Properties

        public string BankInfo
        {
            get; set;
        } = "";
        public double Experience
        {
            get; set;
        }
        public int Floor
        {
            get; set;
        }
        public bool IsAcceptingHourlyWage
        {
            get; set;
        }
        public bool IsElevatorBuilding
        {
            get; set;
        }
        public bool IsVacationBasedOnTamat
        {
            get; set;
        }
        public bool[] IsWorkingInDay
        {
            get; set;
        }
        public int MaxAgeApprovel
        {
            get; set;
        }
        public int MaxNumOfChildrens
        {
            get; set;
        }
        public int MinAgeApprovel
        {
            get; set;
        }
        public string PhoneNumber
        {
            get; set;
        } = "";
        public string Recommendion
        {
            get; set;
        } = "";
        public double WagePerHour
        {
            get; set;
        }
        public double WagePerMonth
        {
            get; set;
        }
        public int[,] WorkingTimes
        {
            get; set;
        }

        #endregion

        #region Constructors

        public Nanny(long id = 0) : base(id) { }

        #endregion
    }

    #endregion
}
