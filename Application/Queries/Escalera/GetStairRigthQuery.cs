using Domain.Shared;
using MediatR;

namespace Application.Queries;

public class GetStairRigthQuery : IRequest<IClassResponse<string>>
{
    public int Number { get; set; }
}