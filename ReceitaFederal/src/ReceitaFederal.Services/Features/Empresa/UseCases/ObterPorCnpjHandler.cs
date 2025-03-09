using MediatR;
using ReceitaFederal.Infrastructure.Repositories.Contracts;

namespace ReceitaFederal.Services.Features.Empresa.UseCases;

public record ObterPorCnpjHandler(IEmpresaRepository _repository) 
    : IRequestHandler<ObterPorCnpjQuery, ObterPorCnpjResult>
{
    public async Task<ObterPorCnpjResult> Handle(ObterPorCnpjQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.ObterPorCnpjAsync(request.Cnpj);

        return new ObterPorCnpjResult
        {
            CnpjBasico = result.CnpjBasico,
            RazaoSocial = result.RazaoSocial,
            NaturezaJuridica = result.NaturezaJuridica,
            QualificacaoResponsavel = result.QualificacaoResponsavel,
            CapitalSocial = result.CapitalSocial,
            PorteEmpresa = result.PorteEmpresa,
            EnteFederativoResponsavel = result.EnteFederativoResponsavel
        };
    }
}
