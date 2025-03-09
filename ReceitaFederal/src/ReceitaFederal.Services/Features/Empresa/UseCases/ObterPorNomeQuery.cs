using MediatR;

namespace ReceitaFederal.Services.Features.Empresa.UseCases;

public record ObterPorNomeQuery : IRequest<ICollection<ObterPorNomeResult>>
{
    public string Nome { get; set; } = string.Empty;
}