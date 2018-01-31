
namespace BE
{
    using System;

    #region Classes

    /// <summary>
    /// Defines the <see cref="Mother" />
    /// </summary>
    public class Mother : Human
    {

        #region Properties

        public string AddressOfSerchArea
        {
            get; set;
        } = "";
        public bool[] IsSearchingInDay1l
        {
            get; set;
        }
        public string Notes
        {
            get; set;
        } = "";
        public string PhoneNumber
        {
            get; set;
        } = "";
        public int[,] WorkingTimes1
        {
            get; set;
        }

        #endregion

        #region Constructors

        public Mother(long id = 0) : base(id) { }

        #endregion
    }

    #endregion
}
