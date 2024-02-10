using Application.Queries;
using Domain.Services;
using Domain.Shared;
using MediatR;

namespace Application.Handlers;

public class GetStairRigthHandler(IEscaleraService service, IClassResponse<string> classResponse) : IRequestHandler<GetStairRigthQuery, IClassResponse<string>>
{
    public async Task<IClassResponse<string>> Handle(GetStairRigthQuery request, CancellationToken cancellationToken)
    {
        var response = await service.GetStairCase(request.Number);
        return response.IsSuccess ? classResponse.SetSuccess(response.Data!, response.StatusCode) : classResponse.SetError(response.ErrorMessage!, response.StatusCode);
    }
}