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

            string AddChild(string id, string monthsOld, string firstName, string lastName, string isFemale, string idMother, string isDisabled, string disableInfo)
            {
                string errorBuffer = "";
                if (!InRange(id, 0, 999999999, false))
                    Append(ref errorBuffer, "Invalid ID");
                if (!InRange(idMother, 0, 999999999, false))
                    Append(ref errorBuffer, "Invalid Mother ID");

                if (!InRange(monthsOld, 0, 216))
                    Append(ref errorBuffer, "Invalid Months Old");
                if (!InRange(isDisabled, 0, 1, true))
                    Append(ref errorBuffer, "Invalid 'has special needs'");

                if (errorBuffer == "") //Success befor trying to add
                {
                    try
                    {
                        BE.Mother mother= this.dal_Imp.GetMother(idMother);
                        this.dal_Imp.Child.Add(new BE.Child(id.ToLong(), DateTime.Now.AddMonths(monthsOld.ToInt()), firstName, lastName, isFemale.ToBool(), mother, mother.Address, isDisabled.ToBool(), disableInfo));
                    }
                    catch (Exception e)
                    {
                        Append(ref errorBuffer, e.Message);
                    }
                }

                return errorBuffer;
            }


            string AddContract(string idNanny, string idChild, string isSigned, string sallery, string perHourBool, string dateFrom,
                string dateUntil, string day1, string dayTimeFrom1, string dayTimeUntil1, string day2, string dayTimeFrom2, string dayTimeUntil2,
                string day3, string dayTimeFrom3, string dayTimeUntil3, string day4, string dayTimeFrom4,
                string dayTimeUntil4, string day5, string dayTimeFrom5, string dayTimeUntil5, string day6,
                string dayTimeFrom6, string dayTimeUntil6, string day7, string dayTimeFrom7,
                string dayTimeUntil7)
            {
                string errorBuffer = "";
                if (!InRange(idNanny, 0, 999999999, false))
                    Append(ref errorBuffer, "Invalid Nanny ID");
                if (!InRange(idChild, 0, 999999999, false))
                    Append(ref errorBuffer, "Invalid Child ID");
                if (!InRange(sallery, 0, 10000000))
                    Append(ref errorBuffer, "Invalid Sallery");
                if (!InRange(perHourBool, 0, 1, true))
                    Append(ref errorBuffer, "Invalid is 'Per Hour'");

                if (!DateFromUntilValidation(dateFrom, dateUntil))
                    Append(ref errorBuffer, "Date Range Invalid!"); //Must be valid YYYYMMDD

                if (!TimeFromUntilValidation(day1, dayTimeFrom1, dayTimeUntil1))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day2, dayTimeFrom2, dayTimeUntil2))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day3, dayTimeFrom3, dayTimeUntil3))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day4, dayTimeFrom4, dayTimeUntil4))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day5, dayTimeFrom5, dayTimeUntil5))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day6, dayTimeFrom6, dayTimeUntil6))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day7, dayTimeFrom7, dayTimeUntil7))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until

                if (errorBuffer == "") //Success befor trying to add
                {
                    try
                    {
                        BE.Nanny nanny = this.dal_Imp.GetNanny(idNanny);
                        BE.Child child = this.dal_Imp.GetChild(idChild);
                        BE.Mother mother = this.dal_Imp.GetMother(child.MotherID);
                        this.dal_Imp.Contract.Add(new BE.Contract(nanny,mother,child,perHourBool.ToBool(),MonthsUntilExpired);
                    }
                    catch (Exception ex)
                    {

                        throw;
                    }
                }
                return errorBuffer;
            }

            string AddMother(string id, string familyName, string firstName, string cellPhone, string phone, string street,
                string streetNumber, string city, string day1, string day2, string day3, string day4, string day5,
                string day6, string day7, string dayTimeFrom1, string dayTimeUntil1, string dayTimeFrom2,
                string dayTimeUntil2, string dayTimeFrom3, string dayTimeUntil3, string dayTimeFrom4, string dayTimeUntil4,
                string dayTimeFrom5, string dayTimeUntil5, string dayTimeFrom6, string dayTimeUntil6,
                string dayTimeFrom7, string dayTimeUntil7)
            {
                string errorBuffer = "";
                if (!InRange(id, 0, 999999999, false))
                    Append(ref errorBuffer, "Invalid ID");
                if (!InRange(familyName, 1, 100, true))
                    Append(ref errorBuffer, "Invalid First Name");
                if (!InRange(firstName, 1, 100, true))
                    Append(ref errorBuffer, "Invalid Family Name");
                if (!InRange(cellPhone, 1, 20, true))
                    Append(ref errorBuffer, "Invalid Cell Phone Number");
                if (!InRange(phone, 1, 20, true))
                    Append(ref errorBuffer, "Invalid phone Number");
                if (!InRange(street, 1, 100, true))
                    Append(ref errorBuffer, "Invalid street name");
                if (!InRange(streetNumber, 1, 10, true))
                    Append(ref errorBuffer, "Invalid street number");
                if (!InRange(city, 1, 100, true))
                    Append(ref errorBuffer, "Invalid city");

                if (!TimeFromUntilValidation(day1, dayTimeFrom1, dayTimeUntil1))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day2, dayTimeFrom2, dayTimeUntil2))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day3, dayTimeFrom3, dayTimeUntil3))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day4, dayTimeFrom4, dayTimeUntil4))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day5, dayTimeFrom5, dayTimeUntil5))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day6, dayTimeFrom6, dayTimeUntil6))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day7, dayTimeFrom7, dayTimeUntil7))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until


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
            
            /// <returns>The <see cref="string"/></returns>
            string AddNanny(string id, string familyName, string firstName, string birthDate, string phone, string street,
            string streetNumber, string city, string hasElevator, string experianceYears,
            string maxChildren, string minAge, string maxAge, string hourRate, string perHourRate, string monthRate,
            string vicationDays, string recommandations, string bankISBN, string day1, string day2, string day3, string day4, string day5,
            string day6, string day7, string dayTimeFrom1, string dayTimeUntil1, string dayTimeFrom2,
            string dayTimeUntil2, string dayTimeFrom3, string dayTimeUntil3, string dayTimeFrom4, string dayTimeUntil4,
            string dayTimeFrom5, string dayTimeUntil5, string dayTimeFrom6, string dayTimeUntil6,
            string dayTimeFrom7, string dayTimeUntil7)
            {
                string errorBuffer = "";
                if (!InRange(id, 0, 999999999, false))
                    Append(ref errorBuffer, "Invalid ID");
                if (!InRange(familyName, 1, 100, true))
                    Append(ref errorBuffer, "Invalid First Name");
                if (!InRange(firstName, 1, 100, true))
                    Append(ref errorBuffer, "Invalid Family Name");
                if (!InRange(phone, 1, 20, true))
                    Append(ref errorBuffer, "Invalid phone Number");
                if (!InRange(street, 1, 100, true))
                    Append(ref errorBuffer, "Invalid street name");
                if (!InRange(streetNumber, 1, 10, true))
                    Append(ref errorBuffer, "Invalid street number");
                if (!InRange(city, 1, 100, true))
                    Append(ref errorBuffer, "Invalid city");
                if (!InRange(maxChildren, 0, 999999999, false))
                    Append(ref errorBuffer, "Invalid maxChildren");
                if (!InRange(minAge, 0, 216, false))
                    Append(ref errorBuffer, "Invalid minAge");
                if (!InRange(maxAge, 0, 216, false))
                    Append(ref errorBuffer, "Invalid maxAge");
                if (!InRange(hourRate, 0, 99999, false))
                    Append(ref errorBuffer, "Invalid hourRate");
                if (!InRange(monthRate, 0, 9999999, false))
                    Append(ref errorBuffer, "Invalid monthRate");
                if (!InRange(perHourRate, 0, 1))
                    Append(ref errorBuffer, "Invalid 'perHourRate'");
                if (!ValidateDate(birthDate))
                    Append(ref errorBuffer, "Invalid birth Date");
                if (!InRange(experianceYears, 0, 90))
                    Append(ref errorBuffer, "Invalid years of experiance");
                if (!InRange(hasElevator, 0, 1))
                    Append(ref errorBuffer, "Invalid 'has Elevator'");
                if (!InRange(recommandations, 0, 99999, true))
                    Append(ref errorBuffer, "Invalid recommandations");
                if (!InRange(bankISBN, 0, 64, true))
                    Append(ref errorBuffer, "Invalid recommandations");
                if (!TimeFromUntilValidation(day1, dayTimeFrom1, dayTimeUntil1))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day2, dayTimeFrom2, dayTimeUntil2))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day3, dayTimeFrom3, dayTimeUntil3))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day4, dayTimeFrom4, dayTimeUntil4))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day5, dayTimeFrom5, dayTimeUntil5))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day6, dayTimeFrom6, dayTimeUntil6))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until
                if (!TimeFromUntilValidation(day7, dayTimeFrom7, dayTimeUntil7))
                    Append(ref errorBuffer, "Timeframe of day1 Incorrect!"); //Must be 0000 To 2359, From <= Until


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
            void Append(ref string text, string addText)
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
                if (!ValidateDate(dFrom) || !ValidateDate(dUntil))
                    return false; //Make sure dates are valid
                if (int.Parse(dFrom) > int.Parse(dUntil))
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
            string GetDistance(string nannyId, string motherId)
            {
                string outputBuffer = "";
                if (!InRange(nannyId, 0, 999999999, false))
                    Append(ref outputBuffer, "Invalid ID");
                if (!InRange(motherId, 0, 999999999, false))
                    Append(ref outputBuffer, "Invalid Mother ID");

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
            bool InRange(string data, int min, int max, bool charLen = false)
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
            bool TimeFromUntilValidation(string dayBool, string tFrom, string tUntil)
            {
                if (!InRange(dayBool, 0, 1))
                    return false;
                if (!ValidateTime(tFrom) || !ValidateTime(tUntil))
                    return false; //Make sure times are valid
                if (int.Parse(tFrom) > int.Parse(tUntil))
                    return false; // Make sure Time From is not after Until
                return true;
            }

            /// <summary>
            /// The validateDate
            /// </summary>
            /// <param name="date">The <see cref="string"/></param>
            /// <returns>The <see cref="bool"/></returns>
            private bool ValidateDate(string date) //I Want to get format "YYYYMMDD"
            {
                if (!InRange(date, 8, 8, true))
                    return false; //not ####
                if (!InRange(date[0].ToString() + date[1].ToString() + date[2].ToString() + date[3].ToString(), 1970, 2030))
                    return false; //YYYY
                if (!InRange(date[4].ToString() + date[5].ToString(), 1, 12))
                    return false; //MM
                if (!InRange(date[6].ToString() + date[7].ToString(), 1, 31))
                    return false;//DD
                return true;
            }

            /// <summary>
            /// The validateTime
            /// </summary>
            /// <param name="time">The <see cref="string"/></param>
            /// <returns>The <see cref="bool"/></returns>
            private bool ValidateTime(string time)
            {
                if (!InRange(time, 4, 4, true))
                    return false; //not ####
                if (!InRange(time[0].ToString() + time[1].ToString(), 0, 23))
                    return false;
                if (!InRange(time[2].ToString() + time[3].ToString(), 0, 59))
                    return false;
                return true;
            }
            #endregion
        }

        internal static class Parsers
        {
            public static int ToInt(this string str) => int.Parse(str);
            public static long ToLong(this string str) => long.Parse(str);
            public static bool ToBool(this string str) => str == "1" || str == "0" ? str == "1" : bool.Parse(str);
            public static BE.Child ToChild(this string str) => new BE.Child(str.ToLong());
            public static BE.Child GetChild(this DS.Dal_imp dal_imp,string id) => dal_imp.Child.GetListOfT().Find(cid=>cid==id.ToChild());
            public static BE.Nanny ToNanny(this string str) => new BE.Nanny(str.ToLong());
            public static BE.Nanny GetNanny(this DS.Dal_imp dal_imp, string id) => dal_imp.Nanny.GetListOfT().Find(cid => cid == id.ToNanny());
            public static BE.Contract ToContract(this string str) => new BE.Contract(str.ToLong());
            public static BE.Contract GetContract(this DS.Dal_imp dal_imp, string id) => dal_imp.Contract.GetListOfT().Find(cid => cid == id.ToContract());
            public static BE.Mother ToMother(this string str) => new BE.Mother(str.ToLong());
            public static BE.Mother GetMother(this DS.Dal_imp dal_imp, string id) => dal_imp.Mother.GetListOfT().Find(cid => cid == id.ToMother());
            public static BE.Mother GetMother(this DS.Dal_imp dal_imp, long id) => dal_imp.GetMother(id.ToString());
        }
    }
}
