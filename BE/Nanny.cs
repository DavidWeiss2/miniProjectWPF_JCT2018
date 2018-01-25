namespace dotNet5778_Project_5337_7178
{
    namespace BE
    {
        using System;

        #region Classes

        /// <summary>
        /// Defines the <see cref="Nanny" />
        /// </summary>
        public class Nanny : Human
        {
            #region Fields

            private string bankInfo;
            private double experience;
            private int floor;
            private bool isAcceptingHourlyWage;
            private bool isElevatorBuilding;
            private bool isVacationBasedOnTamat;
            private bool[] isWorkingInDay = new bool[7];
            private int maxAgeApprovel;
            private int maxNumOfChildrens;
            private int minAgeApprovel;
            private string phoneNumber;
            private string recommendion;
            private double wagePerHour;
            private double wagePerMonth;
            private int[,] workingTimes = new int[7, 2];

            #endregion

            #region Properties

            public string BankInfo
            {
                get => this.bankInfo;
                set => this.bankInfo = value;
            }
            public double Experience
            {
                get => this.experience; set => this.experience = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(this.Experience));
            }
            public int Floor
            {
                get => this.floor; set => this.floor = value;
            }
            public bool IsAcceptingHourlyWage
            {
                get => this.isAcceptingHourlyWage; set => this.isAcceptingHourlyWage = value;
            }
            public bool IsElevatorBuilding
            {
                get => this.isElevatorBuilding; set => this.isElevatorBuilding = value;
            }
            public bool IsVacationBasedOnTamat
            {
                get => this.isVacationBasedOnTamat; set => this.isVacationBasedOnTamat = value;
            }
            public bool[] IsWorkingInDay
            {
                get => this.isWorkingInDay; set => this.isWorkingInDay = value;
            }
            public int MaxAgeApprovel
            {
                get => this.maxAgeApprovel; set => this.maxAgeApprovel = value >= this.minAgeApprovel ? value : throw new ArgumentOutOfRangeException(nameof(this.MaxAgeApprovel));
            }
            public int MaxNumOfChildrens
            {
                get => this.maxNumOfChildrens; set => this.maxNumOfChildrens = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(this.MaxNumOfChildrens));
            }
            public int MinAgeApprovel
            {
                get => this.minAgeApprovel; set => this.minAgeApprovel = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(this.MinAgeApprovel));
            }
            public string PhoneNumber
            {
                get => this.phoneNumber; set => this.phoneNumber = value ?? throw new ArgumentNullException(nameof(this.PhoneNumber));
            }
            public string Recommendion
            {
                get => this.recommendion; set => this.recommendion = value ?? throw new ArgumentNullException(nameof(this.Recommendion));
            }
            public double WagePerHour
            {
                get => this.wagePerHour; set => this.wagePerHour = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(this.WagePerHour));
            }
            public double WagePerMonth
            {
                get => this.wagePerMonth; set => this.wagePerMonth = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(this.WagePerMonth));
            }
            public int[,] WorkingTimes
            {
                get => this.workingTimes; set => this.workingTimes = value;
            }

            #endregion

            #region Constructors

            public Nanny(long iD = 0) : base(iD)
            {
                ;
            }
            public Nanny(long iD, DateTime dateOfBirth, string firstName, string lastName, double experience, string address, string phoneNumber, int[,] workingTimes, bool[] isWorkingInDay, string bankInfo, bool isAcceptingHourlyWage = false, bool isElevatorBuilding = true, bool isVacationBasedOnTamat = true, int floor = 0, int maxAgeApprovel = 36, int maxNumOfChildrens = 6, int minAgeApprovel = 3, string recommendion = "", double wagePerHour = 25, double wagePerMonth = 5000, bool isFemale = true) : base(iD, dateOfBirth, firstName, lastName, isFemale, address)
            {
                this.Experience = experience;
                this.Floor = floor;
                this.IsAcceptingHourlyWage = isAcceptingHourlyWage;
                this.IsElevatorBuilding = isElevatorBuilding;
                this.IsVacationBasedOnTamat = isVacationBasedOnTamat;
                this.MaxAgeApprovel = maxAgeApprovel;
                this.MaxNumOfChildrens = maxNumOfChildrens;
                this.MinAgeApprovel = minAgeApprovel;
                this.Recommendion = recommendion;
                this.WagePerHour = wagePerHour;
                this.WagePerMonth = wagePerMonth;
                this.IsWorkingInDay = isWorkingInDay;
                this.WorkingTimes = workingTimes;
                this.PhoneNumber = phoneNumber;
                this.BankInfo = bankInfo;
            }

            #endregion
        }

        #endregion
    }
}
