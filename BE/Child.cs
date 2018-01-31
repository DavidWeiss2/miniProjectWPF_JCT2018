namespace BE
{
    using System;

    #region Classes

    /// <summary>
    /// Defines the <see cref="Child" />
    /// </summary>
    public class Child : Human
    {
        #region Fields
        #endregion

        #region Properties

        public string DisableInfo
        {
            get; set;
        } = "";
        public bool IsDisabled
        {
            get;set;
        }
        public long MotherId
        {
            get;set;
        }

        #endregion

        #region Constructors

        public Child(long id) : base(id)
        {
            ;
        }
        public Child() : base(0) { }
       

        #endregion
    }

    #endregion
}
