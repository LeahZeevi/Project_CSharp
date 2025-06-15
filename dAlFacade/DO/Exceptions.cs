

namespace DO;

[Serializable]
public class DalIdNotExistsException : Exception
{
    public DalIdNotExistsException(string massage) : base(massage) { }
    public DalIdNotExistsException(string massage, Exception innerException) : base(massage, innerException) { }
}
[Serializable]
public class DalIdExistsException : Exception
{
    public DalIdExistsException(string massage) : base(massage) { }
    public DalIdExistsException(string massage, Exception innerException) : base(massage, innerException) { }
}
[Serializable]
public class DalNotFound : Exception
{
    public DalNotFound(string massage) : base(massage) { }
    public DalNotFound(string massage,Exception innerException) : base(massage,innerException) { }

}
[Serializable]

public class Dalfailed : Exception
{
    public Dalfailed(string massage) : base(massage) { }
    public Dalfailed(string massage, Exception innerException) : base(massage, innerException) { }

}

