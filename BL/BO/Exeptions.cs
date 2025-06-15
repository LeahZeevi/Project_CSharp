using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [Serializable]
    public class BlIdNotExistsException : Exception
    {
        public BlIdNotExistsException(string massage) : base(massage) { }
        public BlIdNotExistsException(string massage, Exception innerException) : base(massage, innerException) { }
    }
    [Serializable]
    public class BLIdExistsException : Exception
    {
        public BLIdExistsException(string massage) : base(massage) { }
        public BLIdExistsException(string massage, Exception innerException) : base(massage, innerException) { }
    }
    //חריגה של קלט לא תקין
    [Serializable]
    public class BLInputExistsException : Exception
    {
        public BLInputExistsException(string massage) : base(massage) { }
        public BLInputExistsException(string massage, Exception innerException) : base(massage, innerException) { }
    }

    // חריגה עבור ניסיון לבצע פעולה לא חוקית במצב נתון
    [Serializable]
    public class BLIllegalOperationException : Exception
    {
        public BLIllegalOperationException(string? message) : base(message) { }
        public BLIllegalOperationException(string message, Exception innerException) : base(message, innerException) { }
    }

    // חריגה עבור מקרה בו נתונים חסרים או לא שלמים כאשר הם נדרשים
    [Serializable]
    public class BLMissingDataException : Exception
    {
        public BLMissingDataException(string? message) : base(message) { }
        public BLMissingDataException(string message, Exception innerException) : base(message, innerException) { }
    }
}

