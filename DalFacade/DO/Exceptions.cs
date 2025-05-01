
namespace DO;

[Serializable]
 
public class dal_idNotFound :Exception
{
    public dal_idNotFound(string? message) : base(message) { }
}

public class dal_idIdExist : Exception
{
    public dal_idIdExist(string? message) : base(message) { }

}
public class dal_objcectNotFound : Exception
{
    public dal_objcectNotFound(string? message) : base(message) { }

}




