using ReceitaFederal.Domain.Entities;

namespace ReceitaFederal.Infrastructure.Repositories.Contracts;

public interface IEmpresaRepository
{
    Task<ICollection<Empresa>> ObterPorNomeAsync(string nome);
    Task<Empresa> ObterPorCnpjAsync(string cnpj);
}
