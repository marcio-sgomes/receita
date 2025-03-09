using Microsoft.EntityFrameworkCore;
using ReceitaFederal.Domain.Entities;
using ReceitaFederal.Infrastructure.Persistence.Contexts;
using ReceitaFederal.Infrastructure.Repositories.Contracts;

namespace ReceitaFederal.Infrastructure.Repositories;

public class EmpresaRepository(ReceitaFederalContext _context) : IEmpresaRepository
{
    public async Task<Empresa> ObterPorCnpjAsync(string cnpj)
        => await _context.Empresas
            .AsNoTracking()
            .FirstOrDefaultAsync(e => e.CnpjBasico!.Equals(cnpj)) 
                ?? throw new Exception($"Empresa com CNPJ {cnpj} não encontrada.");

    public async Task<ICollection<Empresa>> ObterPorNomeAsync(string nome)
        => await _context.Empresas
            .AsNoTracking()
            .Where(e => e.RazaoSocial!.ToLower().Contains(nome.ToLower()))
            .ToListAsync();
}