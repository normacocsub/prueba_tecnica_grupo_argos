using Domain.Shared;

namespace Infrastructure.Shared;

public class ClassResponse <T> : IClassResponse<T>
{
    public T? Data { get; set; }
    public IEnumerable<T>? DataCollection { get; set; }
    public string? ErrorMessage { get; set; }
    public int StatusCode { get; set; } = 200;
    public bool IsSuccess { get; set; }

    public IClassResponse<T> SetSuccess(T data, int statusCode)
    {
        return new ClassResponse<T>
        {
            Data = data,
            StatusCode = statusCode,
            IsSuccess = true
        };
    }

    public IClassResponse<T> SetSuccess(IEnumerable<T> dataCollection, int statusCode)
    {
        return new ClassResponse<T>
        {
            DataCollection = dataCollection,
            StatusCode = statusCode,
            IsSuccess = true
        };
    }

    public IClassResponse<T> SetError(string errorMessage, int statusCode)
    {
        return new ClassResponse<T>
        {
            ErrorMessage = errorMessage,
            StatusCode = statusCode,
            IsSuccess = false
        };
    }

    
    
}