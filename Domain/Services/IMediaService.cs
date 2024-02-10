using Domain.Shared;

namespace Domain.Services;

public interface IMediaService
{
    public Task<IClassResponse<float>> GetMedia(List<float> numbers);
    public Task<IClassResponse<float>> GetMediaArmonica(List<float> numbers);
    public Task<IClassResponse<float>> GetMediana(List<float> numbers);
}