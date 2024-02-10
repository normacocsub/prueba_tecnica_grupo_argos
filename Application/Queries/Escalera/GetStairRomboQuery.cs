using Domain.Shared;
using MediatR;

namespace Application.Queries;

public class GetStairRomboQuery : IRequest<IClassResponse<string>>
{
    public int Number { get; set; }
}