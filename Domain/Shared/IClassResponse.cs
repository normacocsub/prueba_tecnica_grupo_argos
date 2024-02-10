namespace Domain.Shared;

public interface IClassResponse<T>
{
    T? Data { get; set; }
    IEnumerable<T>? DataCollection { get; set; }
    string? ErrorMessage { get; set; }
    int StatusCode { get; set; }
    bool IsSuccess { get; set; }
    IClassResponse<T> SetSuccess(T data, int statusCode);
    IClassResponse<T> SetSuccess(IEnumerable<T> dataCollection, int statusCode);
    IClassResponse<T> SetError(string errorMessage, int statusCode);
}