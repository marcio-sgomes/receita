using System;

namespace ReceitaFederal.Services.Features.Empresa.UseCases;

public record ObterPorNomeResult
{
    public string? CnpjBasico { get; set; }
    public string? RazaoSocial { get; set; }
    public string? NaturezaJuridica { get; set; }
    public string? QualificacaoResponsavel { get; set; }
    public decimal CapitalSocial { get; set; }
    public string? PorteEmpresa { get; set; }
    public string? EnteFederativoResponsavel { get; set; }
}
