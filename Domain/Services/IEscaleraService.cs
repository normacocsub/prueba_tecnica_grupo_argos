using Domain.Shared;

namespace Domain.Services;

public interface IEscaleraService
{
    public Task<IClassResponse<string>> GetStairCase(int number);
    public Task<IClassResponse<string>> GetStairInvertCase(int number);
    public Task<IClassResponse<string>> GetStairRomboCase(int number);
}