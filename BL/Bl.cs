namespace dotNet5778_Project_5337_7178
{
    namespace BL
    {
        using System;

        /// <summary>
        /// Defines the <see cref="Bl" />
        /// </summary>
        public class Bl
        {
            #region Methods

            /// <summary>
            /// The addMother
            /// </summary>
            /// <param name="id">The <see cref="string"/></param>
            /// <param name="familyName">The <see cref="string"/></param>
            /// <param name="firstName">The <see cref="string"/></param>
            /// <param name="cellPhone">The <see cref="string"/></param>
            /// <param name="phone">The <see cref="string"/></param>
            /// <param name="street">The <see cref="string"/></param>
            /// <param name="streetNumber">The <see cref="string"/></param>
            /// <param name="city">The <see cref="string"/></param>
            /// <param name="day1">The <see cref="string"/></param>
            /// <param name="day2">The <see cref="string"/></param>
            /// <param name="day3">The <see cref="string"/></param>
            /// <param name="day4">The <see cref="string"/></param>
            /// <param name="day5">The <see cref="string"/></param>
            /// <param name="day6">The <see cref="string"/></param>
            /// <param name="day7">The <see cref="string"/></param>
            /// <param name="dayTimeFrom1">The <see cref="string"/></param>
            /// <param name="dayTimeUntil1">The <see cref="string"/></param>
            /// <param name="dayTimeFrom2">The <see cref="string"/></param>
            /// <param name="dayTimeUntil2">The <see cref="string"/></param>
            /// <param name="dayTimeFrom3">The <see cref="string"/></param>
            /// <param name="dayTimeUntil3">The <see cref="string"/></param>
            /// <param name="dayTimeFrom4">The <see cref="string"/></param>
            /// <param name="dayTimeUntil4">The <see cref="string"/></param>
            /// <param name="dayTimeFrom5">The <see cref="string"/></param>
            /// <param name="dayTimeUntil5">The <see cref="string"/></param>
            /// <param name="dayTimeFrom6">The <see cref="string"/></param>
            /// <param name="dayTimeUntil6">The <see cref="string"/></param>
            /// <param name="dayTimeFrom7">The <see cref="string"/></param>
            /// <param name="dayTimeUntil7">The <see cref="string"/></param>
            /// <returns>The <see cref="string"/></returns>
            string addMother(string id, string familyName, string firstName, string cellPhone, string phone, string street,
                string streetNumber, string city, string day1, string day2, string day3, string day4, string day5,
                string day6, string day7, string dayTimeFrom1, string dayTimeUntil1, string dayTimeFrom2,
                string dayTimeUntil2, string dayTimeFrom3, string dayTimeUntil3, string dayTimeFrom4, string dayTimeUntil4,
                string dayTimeFrom5, string dayTimeUntil5, string dayTimeFrom6, string dayTimeUntil6,
                string dayTimeFrom7, string dayTimeUntil7)
            {
                string errorBuffer = "";
                if (!inRange(familyName, 1, 100, true))
                    append(ref errorBuffer, "Invalid First Name");
                if (!inRange(firstName, 1, 100, true))
                    append(ref errorBuffer, "Invalid Family Name");
                if (!inRange(cellPhone, 1, 20, true))
                    append(ref errorBuffer, "Invalid Cell Phone Number");
                if (!inRange(phone, 1, 20, true))
                    append(ref errorBuffer, "Invalid phone Number");
                if (!inRange(street, 1, 100, true))
                    append(ref errorBuffer, "Invalid street name");
                if (!inRange(streetNumber, 1, 10, true))
                    append(ref errorBuffer, "Invalid street number");
                if (!inRange(city, 1, 100, true))
                    append(ref errorBuffer, "Invalid city");

                if (!timeFromUntilValidation(day1, dayTimeFrom1, dayTimeUntil1))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day2, dayTimeFrom2, dayTimeUntil2))
                    append(ref errorBuffer, "Timeframe of day2 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day3, dayTimeFrom3, dayTimeUntil3))
                    append(ref errorBuffer, "Timeframe of day3 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day4, dayTimeFrom4, dayTimeUntil4))
                    append(ref errorBuffer, "Timeframe of day4 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day5, dayTimeFrom5, dayTimeUntil5))
                    append(ref errorBuffer, "Timeframe of day5 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day6, dayTimeFrom6, dayTimeUntil6))
                    append(ref errorBuffer, "Timeframe of day6 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day7, dayTimeFrom7, dayTimeUntil7))
                    append(ref errorBuffer, "Timeframe of day7 Incorrect!"); //Must be 0000 To 2359, From <= Until


                if (errorBuffer == "") //Success befor trying to add
                {
                    //TRY:
                    //// pack up shit for add function

                    //// call Add function

                    //Catch Error:
                    //// errorBuffer = "error details";
                }

                return errorBuffer;
            }

            /// <summary>
            /// The append
            /// </summary>
            /// <param name="text">The <see cref="string"/></param>
            /// <param name="addText">The <see cref="string"/></param>
            void append(ref string text, string addText)
            {
                if (text != "")
                    text += "\n";
                text += addText;
            }

            /// <summary>
            /// The inRange
            /// </summary>
            /// <param name="data">The <see cref="string"/></param>
            /// <param name="min">The <see cref="int"/></param>
            /// <param name="max">The <see cref="int"/></param>
            /// <param name="charLen">The <see cref="bool"/></param>
            /// <returns>The <see cref="bool"/></returns>
            bool inRange(string data, int min, int max, bool charLen = false)
            {
                int value = 0;
                if (!charLen && !int.TryParse(data, out value))
                    return false;
                value = (charLen ? data.Length : value);
                return (value >= min && value <= max);
            }

            /// <summary>
            /// The timeFromUntilValidation
            /// </summary>
            /// <param name="dayBool">The <see cref="string"/></param>
            /// <param name="tFrom">The <see cref="string"/></param>
            /// <param name="tUntil">The <see cref="string"/></param>
            /// <returns>The <see cref="bool"/></returns>
            bool timeFromUntilValidation(string dayBool, string tFrom, string tUntil)
            {
                if (!inRange(dayBool, 0, 1))
                    return false;
                if (!validateTime(tFrom) || !validateTime(tUntil))
                    return false; //Make sure times are valid
                if (Int32.Parse(tFrom) > Int32.Parse(tUntil))
                    return false; // Make sure Time From is not after Until
                return true;
            }

            /// <summary>
            /// The validateTime
            /// </summary>
            /// <param name="time">The <see cref="string"/></param>
            /// <returns>The <see cref="bool"/></returns>
            private bool validateTime(string time)
            {
                if (!inRange(time, 4, 4, true))
                    return false; //not ####
                if (!inRange(time[0].ToString() + time[1].ToString(), 0, 23))
                    return false;
                if (!inRange(time[2].ToString() + time[3].ToString(), 0, 59))
                    return false;
                return true;
            }

            #endregion
        }
    }
}
