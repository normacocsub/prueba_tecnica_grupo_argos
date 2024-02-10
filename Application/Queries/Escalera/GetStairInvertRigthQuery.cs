using Domain.Shared;
using MediatR;

namespace Application.Queries;

public class GetStairInvertRigthQuery : IRequest<IClassResponse<string>>
{
    public int Number { get; set; }
}