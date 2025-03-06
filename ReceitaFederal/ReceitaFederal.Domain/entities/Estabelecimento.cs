using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitaFederal.Domain.entities
{
    internal class Estabelecimento
    {
        public Guid Id { get; set; }
        public string? CnpjBasico { get; set; }
        public string? CnpjOrdem { get; set; }
        public string? CnpjDv { get; set; }
        public string? IdentificadorMatrizFilial { get; set; }
        public string? NomeFantasia { get; set; }
        public string? SituacaoCadastral { get; set; }
        public DateTime DataSituacaoCadastral { get; set; }
        public string? MotivoSituacaoCadastral { get; set; }
        public string? NomeCidadeExterior { get; set; }
        public string? Pais { get; set; }
        public DateTime DataInicioAtividade { get; set; }
        public string? CnaeFiscalPrincipal { get; set; }
        public string? CnaeFiscalSecundaria { get; set; }
        public string? TipoLogradouro { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cep { get; set; }
        public string? Uf { get; set; }
        public string? Municipio { get; set; }
        public string? Ddd1 { get; set; }
        public string? Telefone1 { get; set; }
        public string? Ddd2 { get; set; }
        public string? Telefone2 { get; set; }
        public string? DddFax { get; set; }
        public string? Fax { get; set; }
        public string? CorreioEletronico { get; set; }
        public string? SituacaoEspecial { get; set; }
        public DateTime DataSituacaoEspecial { get; set; }
    }
}
