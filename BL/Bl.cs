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
            DS.Dal_imp dal_Imp = new DS.Dal_imp();
            #region Methods

            /// <summary>
            /// The addChild
            /// </summary>
            /// <param name="id">The <see cref="string"/></param>
            /// <param name="idMother">The <see cref="string"/></param>
            /// <param name="monthsOld">The <see cref="string"/></param>
            /// <param name="isDisabled">The <see cref="string"/></param>
            /// <returns>The <see cref="string"/></returns>
            string addChild(string id, string idMother, string monthsOld, string isDisabled, string firstName, string lastName, string isFemale, string disableInfo)
            {
                string errorBuffer = "";
                if (!inRange(id, 0, 999999999, false))
                    append(ref errorBuffer, "Invalid ID");
                if (!inRange(idMother, 0, 999999999, false))
                    append(ref errorBuffer, "Invalid Mother ID");

                if (!inRange(monthsOld, 0, 216))
                    append(ref errorBuffer, "Invalid Months Old");
                if (!inRange(isDisabled, 0, 1, true))
                    append(ref errorBuffer, "Invalid 'has special needs'");

                if (errorBuffer == "") //Success befor trying to add
                {
                    try
                    {
                        BE.Mother mother= dal_Imp.Mother.GetListOfT().Find(i => i == new BE.Mother(long.Parse(idMother)));
                        dal_Imp.Child.Add(new BE.Child(long.Parse(id), DateTime.Now.AddMonths(-Int16.Parse(monthsOld)), firstName, lastName, isFemale=="1", mother, mother.Address, isDisabled == "1", disableInfo));
                    }
                    catch (Exception e)
                    {
                        append(ref errorBuffer, e.Message);
                    }
                }

                return errorBuffer;
            }

            /// <summary>
            /// The addContract
            /// </summary>
            /// <param name="id">The <see cref="string"/></param>
            /// <param name="idNanny">The <see cref="string"/></param>
            /// <param name="idChild">The <see cref="string"/></param>
            /// <param name="isSigned">The <see cref="string"/></param>
            /// <param name="sallery">The <see cref="string"/></param>
            /// <param name="perHourBool">The <see cref="string"/></param>
            /// <param name="dateFrom">The <see cref="string"/></param>
            /// <param name="dateUntil">The <see cref="string"/></param>
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
            string addContract(string id, string idNanny, string idChild, string isSigned, string sallery, string perHourBool,
               string dateFrom, string dateUntil, string day1, string day2, string day3, string day4, string day5,
               string day6, string day7, string dayTimeFrom1, string dayTimeUntil1, string dayTimeFrom2,
               string dayTimeUntil2, string dayTimeFrom3, string dayTimeUntil3, string dayTimeFrom4, string dayTimeUntil4,
               string dayTimeFrom5, string dayTimeUntil5, string dayTimeFrom6, string dayTimeUntil6,
               string dayTimeFrom7, string dayTimeUntil7)
            {
                string errorBuffer = "";
                if (!inRange(id, 0, 999999999, false))
                    append(ref errorBuffer, "Invalid Nanny ID");
                if (!inRange(idNanny, 0, 999999999, false))
                    append(ref errorBuffer, "Invalid Nanny ID");
                if (!inRange(idChild, 0, 999999999, false))
                    append(ref errorBuffer, "Invalid Child ID");
                if (!inRange(sallery, 0, 10000000))
                    append(ref errorBuffer, "Invalid Sallery");
                if (!inRange(perHourBool, 0, 1, true))
                    append(ref errorBuffer, "Invalid is 'Per Hour'");

                if (!DateFromUntilValidation(dateFrom, dateUntil))
                    append(ref errorBuffer, "Date Range Invalid!"); //Must be valid YYYYMMDD

                if (!timeFromUntilValidation(day1, dayTimeFrom1, dayTimeUntil1))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day2, dayTimeFrom2, dayTimeUntil2))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day3, dayTimeFrom3, dayTimeUntil3))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day4, dayTimeFrom4, dayTimeUntil4))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day5, dayTimeFrom5, dayTimeUntil5))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day6, dayTimeFrom6, dayTimeUntil6))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day7, dayTimeFrom7, dayTimeUntil7))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until

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
                if (!inRange(id, 0, 999999999, false))
                    append(ref errorBuffer, "Invalid ID");
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
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day3, dayTimeFrom3, dayTimeUntil3))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day4, dayTimeFrom4, dayTimeUntil4))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day5, dayTimeFrom5, dayTimeUntil5))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day6, dayTimeFrom6, dayTimeUntil6))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day7, dayTimeFrom7, dayTimeUntil7))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until


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
            /// The addNanny
            /// </summary>
            /// <param name="id">The <see cref="string"/></param>
            /// <param name="familyName">The <see cref="string"/></param>
            /// <param name="firstName">The <see cref="string"/></param>
            /// <param name="birthDate">The <see cref="string"/></param>
            /// <param name="phone">The <see cref="string"/></param>
            /// <param name="street">The <see cref="string"/></param>
            /// <param name="streetNumber">The <see cref="string"/></param>
            /// <param name="city">The <see cref="string"/></param>
            /// <param name="hasElevator">The <see cref="string"/></param>
            /// <param name="experianceYears">The <see cref="string"/></param>
            /// <param name="maxChildren">The <see cref="string"/></param>
            /// <param name="minAge">The <see cref="string"/></param>
            /// <param name="maxAge">The <see cref="string"/></param>
            /// <param name="hourRate">The <see cref="string"/></param>
            /// <param name="perHourRate">The <see cref="string"/></param>
            /// <param name="monthRate">The <see cref="string"/></param>
            /// <param name="vicationDays">The <see cref="string"/></param>
            /// <param name="recommandations">The <see cref="string"/></param>
            /// <param name="bankISBN">The <see cref="string"/></param>
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
            string addNanny(string id, string familyName, string firstName, string birthDate, string phone, string street,
            string streetNumber, string city, string hasElevator, string experianceYears,
            string maxChildren, string minAge, string maxAge, string hourRate, string perHourRate, string monthRate,
            string vicationDays, string recommandations, string bankISBN, string day1, string day2, string day3, string day4, string day5,
            string day6, string day7, string dayTimeFrom1, string dayTimeUntil1, string dayTimeFrom2,
            string dayTimeUntil2, string dayTimeFrom3, string dayTimeUntil3, string dayTimeFrom4, string dayTimeUntil4,
            string dayTimeFrom5, string dayTimeUntil5, string dayTimeFrom6, string dayTimeUntil6,
            string dayTimeFrom7, string dayTimeUntil7)
            {
                string errorBuffer = "";
                if (!inRange(id, 0, 999999999, false))
                    append(ref errorBuffer, "Invalid ID");
                if (!inRange(familyName, 1, 100, true))
                    append(ref errorBuffer, "Invalid First Name");
                if (!inRange(firstName, 1, 100, true))
                    append(ref errorBuffer, "Invalid Family Name");
                if (!inRange(phone, 1, 20, true))
                    append(ref errorBuffer, "Invalid phone Number");
                if (!inRange(street, 1, 100, true))
                    append(ref errorBuffer, "Invalid street name");
                if (!inRange(streetNumber, 1, 10, true))
                    append(ref errorBuffer, "Invalid street number");
                if (!inRange(city, 1, 100, true))
                    append(ref errorBuffer, "Invalid city");
                if (!inRange(maxChildren, 0, 999999999, false))
                    append(ref errorBuffer, "Invalid maxChildren");
                if (!inRange(minAge, 0, 216, false))
                    append(ref errorBuffer, "Invalid minAge");
                if (!inRange(maxAge, 0, 216, false))
                    append(ref errorBuffer, "Invalid maxAge");
                if (!inRange(hourRate, 0, 99999, false))
                    append(ref errorBuffer, "Invalid hourRate");
                if (!inRange(monthRate, 0, 9999999, false))
                    append(ref errorBuffer, "Invalid monthRate");
                if (!inRange(perHourRate, 0, 1))
                    append(ref errorBuffer, "Invalid 'perHourRate'");
                if (!validateDate(birthDate))
                    append(ref errorBuffer, "Invalid birth Date");
                if (!inRange(experianceYears, 0, 90))
                    append(ref errorBuffer, "Invalid years of experiance");
                if (!inRange(hasElevator, 0, 1))
                    append(ref errorBuffer, "Invalid 'has Elevator'");
                if (!inRange(recommandations, 0, 99999, true))
                    append(ref errorBuffer, "Invalid recommandations");
                if (!inRange(bankISBN, 0, 64, true))
                    append(ref errorBuffer, "Invalid recommandations");
                if (!timeFromUntilValidation(day1, dayTimeFrom1, dayTimeUntil1))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day2, dayTimeFrom2, dayTimeUntil2))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day3, dayTimeFrom3, dayTimeUntil3))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day4, dayTimeFrom4, dayTimeUntil4))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day5, dayTimeFrom5, dayTimeUntil5))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day6, dayTimeFrom6, dayTimeUntil6))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!timeFromUntilValidation(day7, dayTimeFrom7, dayTimeUntil7))
                    append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until


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
            /// The DateFromUntilValidation
            /// </summary>
            /// <param name="dFrom">The <see cref="string"/></param>
            /// <param name="dUntil">The <see cref="string"/></param>
            /// <returns>The <see cref="bool"/></returns>
            bool DateFromUntilValidation(string dFrom, string dUntil)
            {
                if (!validateDate(dFrom) || !validateDate(dUntil))
                    return false; //Make sure dates are valid
                if (Int32.Parse(dFrom) > Int32.Parse(dUntil))
                    return false; // Make sure From is not after Until
                return true;
            }

            //////
            /// <summary>
            /// The getDistance
            /// </summary>
            /// <param name="nannyId">The <see cref="string"/></param>
            /// <param name="motherId">The <see cref="string"/></param>
            /// <returns>The <see cref="string"/></returns>
            string getDistance(string nannyId, string motherId)
            {
                string outputBuffer = "";
                if (!inRange(nannyId, 0, 999999999, false))
                    append(ref outputBuffer, "Invalid ID");
                if (!inRange(motherId, 0, 999999999, false))
                    append(ref outputBuffer, "Invalid Mother ID");

                if (outputBuffer == "") //Success befor trying to add
                {
                    ////////Get The Distance!

                    //outputBuffer = "distance" (as string)
                }

                return outputBuffer;
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
            /// The validateDate
            /// </summary>
            /// <param name="date">The <see cref="string"/></param>
            /// <returns>The <see cref="bool"/></returns>
            private bool validateDate(string date) //I Want to get format "YYYYMMDD"
            {
                if (!inRange(date, 8, 8, true))
                    return false; //not ####
                if (!inRange(date[0].ToString() + date[1].ToString() + date[2].ToString() + date[3].ToString(), 1970, 2030))
                    return false; //YYYY
                if (!inRange(date[4].ToString() + date[5].ToString(), 1, 12))
                    return false; //MM
                if (!inRange(date[6].ToString() + date[7].ToString(), 1, 31))
                    return false;//DD
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
