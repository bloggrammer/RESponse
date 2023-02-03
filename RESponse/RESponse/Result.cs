namespace RESponse;
public class Result
{
    public Result(bool isSuccess, StatusCode code)
    {
        Succeeded = isSuccess;
        Status = code;
    }

    public bool Succeeded { get; set; }
    public bool NotSucceeded => !Succeeded;
    public StatusCode Status { get; set; }
}

public class Result<TResult> : Result
{
    public Result(TResult result, bool isSuccess, StatusCode code) : base(isSuccess, code) => Data = result;
    public Result(bool isSuccess, StatusCode code) : base(isSuccess, code) { }
    public TResult Data { get; }
}
