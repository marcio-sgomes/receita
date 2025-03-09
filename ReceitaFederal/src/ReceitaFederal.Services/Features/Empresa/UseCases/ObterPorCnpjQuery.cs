using MediatR;

namespace ReceitaFederal.Services.Features.Empresa.UseCases;

public record ObterPorCnpjQuery : IRequest<ObterPorCnpjResult>
{
    public string Cnpj { get; set; } = string.Empty;
}
