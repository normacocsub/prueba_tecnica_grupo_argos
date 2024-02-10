using Domain.Shared;

namespace Domain.Services;

public interface IMediaService
{
    public Task<IClassResponse<int>> GetMedia();
}