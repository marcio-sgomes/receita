using MediatR;
using ReceitaFederal.Infrastructure.Repositories.Contracts;

namespace ReceitaFederal.Services.Features.Empresa.UseCases;

public class ObterPorNomeHandler(IEmpresaRepository _repository) 
    : IRequestHandler<ObterPorNomeQuery, ICollection<ObterPorNomeResult>>
{
    public async Task<ICollection<ObterPorNomeResult>> Handle(ObterPorNomeQuery query, CancellationToken cancellationToken)
    {
        var result = await _repository.ObterPorNomeAsync(query.Nome);

        if (result.Count == 0)
            throw new Exception("NotFound");

        return [.. result.Select(e => 
            new ObterPorNomeResult
            {
                CnpjBasico = e.CnpjBasico,
                RazaoSocial = e.RazaoSocial,
                NaturezaJuridica = e.NaturezaJuridica,
                QualificacaoResponsavel = e.QualificacaoResponsavel,
                CapitalSocial = e.CapitalSocial,
                PorteEmpresa = e.PorteEmpresa,
                EnteFederativoResponsavel = e.EnteFederativoResponsavel
            }
        )];
    }
}