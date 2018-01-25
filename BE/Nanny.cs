namespace dotNet5778_Project_5337_7178
{
    namespace BE
    {
        using System;

        /// <summary>
        /// Defines the <see cref="Nanny" />
        /// </summary>
        public class Nanny : Human
        {
            #region Fields

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
            private double[,] workingTimes = new double[7, 2];

            #endregion

            #region Properties

            public double Experience
            {
                get => this.experience; set => this.experience = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(this.Experience));
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
                get => this.phoneNumber; set => this.phoneNumber = value;
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
            public double[,] WorkingTimes
            {
                get => this.workingTimes; set => this.workingTimes = value;
            }
            public int Floor
            {
                get => this.floor;
                set => this.floor = value;
            }
            public bool IsAcceptingHourlyWage
            {
                get => this.isAcceptingHourlyWage;
                set => this.isAcceptingHourlyWage = value;
            }
            public bool IsElevatorBuilding
            {
                get => this.isElevatorBuilding;
                set => this.isElevatorBuilding = value;
            }
            public bool IsVacationBasedOnTamat
            {
                get => this.isVacationBasedOnTamat;
                set => this.isVacationBasedOnTamat = value;
            }

            #endregion

            /// <summary>
            /// Initializes a new instance of the <see cref="Nanny"/> class.
            /// </summary>
            /// <param name="iD">The <see cref="int"/></param>
            /// <param name="dateOfBirth">The <see cref="DateTime"/></param>
            /// <param name="firstName">The <see cref="string"/></param>
            /// <param name="lastName">The <see cref="string"/></param>
            /// <param name="experience">The <see cref="double"/></param>
            /// <param name="address">The <see cref="string"/></param>
            /// <param name="phoneNumber">The <see cref="string"/></param>
            /// <param name="workingTimes">The <see cref="double[,]"/></param>
            /// <param name="isWorkingInDay">The <see cref="bool[]"/></param>
            /// <param name="isAcceptingHourlyWage">The <see cref="bool"/></param>
            /// <param name="isElevatorBuilding">The <see cref="bool"/></param>
            /// <param name="isVacationBasedOnTamat">The <see cref="bool"/></param>
            /// <param name="floor">The <see cref="int"/></param>
            /// <param name="maxAgeApprovel">The <see cref="int"/></param>
            /// <param name="maxNumOfChildrens">The <see cref="int"/></param>
            /// <param name="minAgeApprovel">The <see cref="int"/></param>
            /// <param name="recommendion">The <see cref="string"/></param>
            /// <param name="wagePerHour">The <see cref="double"/></param>
            /// <param name="wagePerMonth">The <see cref="double"/></param>
            /// <param name="isFemale">The <see cref="bool"/></param>
            public Nanny(long iD, DateTime dateOfBirth, string firstName, string lastName, double experience, string address, string phoneNumber, double[,] workingTimes, bool[] isWorkingInDay, bool isAcceptingHourlyWage = false, bool isElevatorBuilding = true, bool isVacationBasedOnTamat = true, int floor = 0, int maxAgeApprovel = 36, int maxNumOfChildrens = 6, int minAgeApprovel = 3, string recommendion = "", double wagePerHour = 25, double wagePerMonth = 5000, bool isFemale = true) : base(iD, dateOfBirth, firstName, lastName, isFemale, address)
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
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="Nanny"/> class.
            /// </summary>
            /// <param name="iD">The <see cref="long"/></param>
            public Nanny(long iD = 0) : base(iD)
            {
                ;
            }
        }
    }
}
