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
            private string recommendion;
            private double wagePerHour;
            private double wagePerMonth;
            private double[,] workingTimes = new double[7, 2];

            #endregion

            #region Properties

            public double Experience
            {
                get => this.Experience; set => this.Experience = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(this.Experience));
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
                get => this.isWorkingInDay; set => this.isWorkingInDay = value;
            }
            public int MaxAgeApprovel
            {
                get => this.MaxAgeApprovel; set => this.MaxAgeApprovel = value >= this.MinAgeApprovel ? value : throw new ArgumentOutOfRangeException(nameof(this.MaxAgeApprovel));
            }
            public int MaxNumOfChildrens
            {
                get => this.MaxNumOfChildrens; set => this.MaxNumOfChildrens = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(this.MaxNumOfChildrens));
            }
            public int MinAgeApprovel
            {
                get => this.MinAgeApprovel; set => this.MinAgeApprovel = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(this.MinAgeApprovel));
            }
            public string Recommendion
            {
                get => this.Recommendion; set => this.Recommendion = value ?? throw new ArgumentNullException(nameof(this.Recommendion));
            }
            public double WagePerHour
            {
                get => this.WagePerHour; set => this.WagePerHour = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(this.WagePerHour));
            }
            public double WagePerMonth
            {
                get => this.WagePerMonth; set => this.WagePerMonth = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(this.WagePerMonth));
            }
            public double[,] WorkingTimes
            {
                get => this.workingTimes; set => this.workingTimes = value;
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
            public Nanny(int iD, DateTime dateOfBirth, string firstName, string lastName, double experience, string address, string phoneNumber, double[,] workingTimes, bool[] isWorkingInDay, bool isAcceptingHourlyWage = false, bool isElevatorBuilding = true, bool isVacationBasedOnTamat = true, int floor = 0, int maxAgeApprovel = 36, int maxNumOfChildrens = 6, int minAgeApprovel = 3, string recommendion = "", double wagePerHour = 25, double wagePerMonth = 5000, bool isFemale = true) : base(iD, dateOfBirth, firstName, lastName, isFemale, address, phoneNumber)
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
