using Domain.Services;
using Domain.Shared;

namespace Infrastructure.Services;

public class MediaService(IClassResponse<float> classResponse) : IMediaService
{
    public Task<IClassResponse<float>> GetMedia(List<float> numbers)
    {
        try
        {
            var result = numbers.Count / numbers.Sum();
            return Task.FromResult(classResponse.SetSuccess(result, 200));
        }
        catch (Exception e)
        {
            return Task.FromResult(classResponse.SetError($"Error: {e.Message}", 500));
        }
    }

    public Task<IClassResponse<float>> GetMediaArmonica(List<float> numbers)
    {
        try
        {
            var result = numbers.Sum(item => 1 / item) / numbers.Count;
            return Task.FromResult(classResponse.SetSuccess(result, 200));
        }
        catch (Exception e)
        {
            return Task.FromResult(classResponse.SetError($"Error: {e.Message}", 500));
        }
    }

    public Task<IClassResponse<float>> GetMediana(List<float> numbers)
    {
        try
        {
            float result;
            if (numbers.Count % 2 == 0)
            {
                result = (numbers[numbers.Count / 2 - 1] + numbers[numbers.Count / 2]) / 2;
            }
            else
            {
                result = numbers[numbers.Count / 2];
            }
            return Task.FromResult(classResponse.SetSuccess(result, 200));
        }
        catch (Exception e)
        {
            return Task.FromResult(classResponse.SetError($"Error: {e.Message}", 500));
        }
        
    }
}