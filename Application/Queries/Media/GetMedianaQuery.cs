using Domain.Shared;
using MediatR;

namespace Application.Queries;

public class GetMedianaQuery : IRequest<IClassResponse<float>>
{
    public List<float> Numbers { get; set; }
}