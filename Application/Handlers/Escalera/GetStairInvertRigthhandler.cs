using Application.Queries;
using Domain.Services;
using Domain.Shared;
using MediatR;

namespace Application.Handlers;

public class GetStairInvertRigthhandler(IEscaleraService service, IClassResponse<string> classResponse) : IRequestHandler<GetStairInvertRigthQuery, IClassResponse<string>>
{
    public async Task<IClassResponse<string>> Handle(GetStairInvertRigthQuery request, CancellationToken cancellationToken)
    {
        var response = await service.GetStairInvertCase(request.Number);
        return response.IsSuccess ? classResponse.SetSuccess(response.Data!, response.StatusCode) : classResponse.SetError(response.ErrorMessage!, response.StatusCode);
    }
}