using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitaFederal.Domain.entities
{
    internal class Empresa
    {
        public Guid Id { get; set; }
        public string? CnpjBasico { get; set; }
        public string? RazaoSocial { get; set; }
        public string? NaturezaJuridica { get; set; }
        public string? QualificacaoResponsavel { get; set; }
        public decimal CapitalSocial { get; set; }
        public string? PorteEmpresa { get; set; }
        public string? EnteFederativoResponsavel { get; set; }
    }
}
