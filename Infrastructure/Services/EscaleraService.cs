using Domain.Services;
using Domain.Shared;

namespace Infrastructure.Services;


public class EscaleraService(IClassResponse<string> classResponse) : IEscaleraService
{
    public Task<IClassResponse<string>> GetStairCase(int number)
    {
        try
        {
            var result = "";
            for (var i = 1; i <= number; i++)
            {
                result += new string(' ', number - i) + new string('#', i) + "\n";
            }
            return Task.FromResult(classResponse.SetSuccess(result, 200));
        }
        catch (Exception e)
        {
            return Task.FromResult(classResponse.SetError($"Error: {e.Message}", 500));
        }
    }

    public Task<IClassResponse<string>> GetStairInvertCase(int number)
    {
        try
        {
            var result = "";
            for (var i = number; i >= 1; i--)
            {
                result += new string(' ', number - i) + new string('#', i) + "\n";
            }
            return Task.FromResult(classResponse.SetSuccess(result, 200));
        }
        catch (Exception e)
        {
            return Task.FromResult(classResponse.SetError($"Error: {e.Message}", 500));
        }
    }

    public Task<IClassResponse<string>> GetStairRomboCase(int number)
    {
        try
        {
            var result = "";
            var count = number;
            for (var i = 1; i <= number; i++)
            {
                if (i > 1) count += 2;
                var numberOfHashes = count;
                if (i == 1) numberOfHashes = number;
                var numberOfSpacesBefore = number - i;
                result += new string(' ', numberOfSpacesBefore) + new string('#', numberOfHashes) + new string(' ', numberOfSpacesBefore) +  "\n";
            }

        
            for (var i = number - 1; i >= 1; i--)
            {
                count -= 2;
                var numberOfHashes = count;
                var numberOfSpacesBefore = number - i;
                result += new string(' ', numberOfSpacesBefore) + new string('#', numberOfHashes) + new string(' ', numberOfSpacesBefore) + "\n";
            }
            return Task.FromResult(classResponse.SetSuccess(result, 200));
        }
        catch (Exception e)
        {
            return Task.FromResult(classResponse.SetError($"Error: {e.Message}", 500));
        }
    }
}