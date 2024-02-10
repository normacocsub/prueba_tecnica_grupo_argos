using Domain.Services;
using Domain.Shared;

namespace Infrastructure.Services;

public class MediaService(IClassResponse<int> classResponse) : IMediaService
{
    public Task<IClassResponse<int>> GetMedia()
    {
        return Task.FromResult(classResponse.SetSuccess(10, 200));
    }
}