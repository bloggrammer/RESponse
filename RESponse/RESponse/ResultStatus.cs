namespace RESponse;
public static class ResultStatus
{
    public static Result Pass(StatusCode code) => new(true, code);
    public static Result Fail(StatusCode code) => new(false, code);
}

public static class ResultStatus<TResult>
{
    public static Result<TResult> Pass(TResult response, StatusCode code) => new(response, true, code);
    public static Result<TResult> Pass(StatusCode code) => new(true, code);
    public static Result<TResult> Fail(StatusCode code) => new(false, code);
}
