using System.Net;

namespace RESponse;
public class StatusCode
{
    public StatusCode(string message, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
    {
        Message = message;
        Code = statusCode;
    }

    public static StatusCode InvalidArg => new(nameof(InvalidArg));
    public static StatusCode ErrorWhileSavingToDatabase => new(string.Empty, HttpStatusCode.InternalServerError);
    public static StatusCode FileSizeLimit => new(nameof(FileSizeLimit), HttpStatusCode.BadRequest);
    public static StatusCode UnspportedFileType => new(nameof(UnspportedFileType), HttpStatusCode.UnsupportedMediaType);
    public static StatusCode EmptyFile => new(nameof(EmptyFile));
    public static StatusCode OK200 => new(_ok, HttpStatusCode.OK);
    public static StatusCode OK201 => new(_ok, HttpStatusCode.Created);
    public static StatusCode OK202 => new(_ok, HttpStatusCode.Accepted);
    public static StatusCode OK204 => new(_ok, HttpStatusCode.NoContent);

    public override string ToString()
    {
        return $"StatusCode: '{Code}', Message: '{Message}'.";
    }
    public string Message { get; protected set; }
    public HttpStatusCode Code { get; }
    private static readonly string _ok = "Success";

}
