namespace BL.BO
{

    /// <summary>
    /// חריגה של מזהה לא קיים
    /// </summary>
    [Serializable]
    public class BlIdNotFoundException : Exception
    {
        public BlIdNotFoundException(string? message) : base(message) { }
        public BlIdNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }


    /// <summary>
    /// חריגה כשאין מספיק במלאי
    /// </summary>
    [Serializable]
    public class BlOutOfStockException : Exception
    {
        public BlOutOfStockException(string? message) : base(message) { }
        public BlOutOfStockException(string message, Exception innerException) : base(message, innerException) { }
    }


}
