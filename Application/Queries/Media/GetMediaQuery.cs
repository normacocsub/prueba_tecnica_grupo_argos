using Domain.Shared;
using MediatR;

namespace Application.Queries;

public class GetMediaQuery : IRequest<IClassResponse<float>>
{
    public required List<float> Numbers { get; set; }
}