using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiscal
{
    public class NFC
    {
        [DisplayName("CONTROLE")]
        public string Controle { get; set; }

        [DisplayName("DATAEHORACADASTRO")]
        public DateTime? DataEHoraCadastro { get; set; }

        [DisplayName("DATAEMISSAO")]
        public DateTime? DataEmissao { get; set; }

        [DisplayName("NUMERONFCCE")]
        public string NumeroNFCCe { get; set; }

        [DisplayName("NUMEROSAT")]
        public string NumeroSAT { get; set; }

        [DisplayName("TIPOAMBIENTE")]
        public string TipoAmbiente { get; set; }

        [DisplayName("CHAVENFCE")]
        public string ChaveNFCE { get; set; }

        [DisplayName("PROTOCOLO")]
        public string Protocolo { get; set; }

        [DisplayName("PROTOCOLOCANCELAMENTO")]
        public string ProtocoloCancelamento { get; set; }

        [DisplayName("CODIGOSTATUS")]
        public int? CodigoStatus { get; set; }

        [DisplayName("STATUSENVIO")]
        public string StatusEnvio { get; set; }

        [DisplayName("INUTILIZADA")]
        public string Inutilizada { get; set; }

        [DisplayName("CODCLIENTE")]
        public int? CodCliente { get; set; }

        [DisplayName("CLIENTE")]
        public string Cliente { get; set; }

        [DisplayName("CODFUNCIONARIO")]
        public int? CodFuncionario { get; set; }

        [DisplayName("FUNCIONARIO")]
        public string Funcionario { get; set; }

        [DisplayName("CODCENTROCUSTO")]
        public int? CodCentroCusto { get; set; }

        [DisplayName("CENTROCUSTO")]
        public string CentroCusto { get; set; }

        [DisplayName("VALORPRODUTO")]
        public decimal? ValorProduto { get; set; }

        [DisplayName("PERCACRESCIMO")]
        public decimal? PercAcrescimo { get; set; }

        [DisplayName("VALORACRESCIMO")]
        public decimal? ValorAcrescimo { get; set; }

        [DisplayName("PERCDESCONTO")]
        public decimal? PercDesconto { get; set; }

        [DisplayName("VALORDESCONTO")]
        public decimal? ValorDesconto { get; set; }

        [DisplayName("VALORDESCONTOITEM")]
        public decimal? ValorDescontoItem { get; set; }

        [DisplayName("VALORBCICMS")]
        public decimal? ValorBCICMS { get; set; }

        [DisplayName("VALORICMS")]
        public decimal? ValorICMS { get; set; }

        [DisplayName("VALORBCST")]
        public decimal? ValorBCST { get; set; }

        [DisplayName("VALORST")]
        public decimal? ValorST { get; set; }

        [DisplayName("VALORPIS")]
        public decimal? ValorPIS { get; set; }

        [DisplayName("VALORCOFINS")]
        public decimal? ValorCOFINS { get; set; }

        [DisplayName("VALORSEGURO")]
        public decimal? ValorSeguro { get; set; }

        [DisplayName("VALOROUTROS")]
        public decimal? ValorOutros { get; set; }

        [DisplayName("VALOROUTROSITEM")]
        public decimal? ValorOutrosItem { get; set; }

        [DisplayName("VALORBCSERVICO")]
        public decimal? ValorBCServico { get; set; }

        [DisplayName("VALORISS")]
        public decimal? ValorISS { get; set; }

        [DisplayName("VALORSERVICO")]
        public decimal? ValorServico { get; set; }

        [DisplayName("VALORTOTALNFCE")]
        public decimal? ValorTotalNFCE { get; set; }

        [DisplayName("NATUREZAOPERACAO")]
        public string NaturezaOperacao { get; set; }

        [DisplayName("MODELO")]
        public string Modelo { get; set; }

        [DisplayName("SERIE")]
        public string Serie { get; set; }

        [DisplayName("DATASAIDAENTRADA")]
        public DateTime? DataSaidaEntrada { get; set; }

        [DisplayName("HORASAIDAENTRADA")]
        public TimeSpan? HoraSaidaEntrada { get; set; }

        [DisplayName("TIPOEMISSAO")]
        public string TipoEmissao { get; set; }

        [DisplayName("FONECLIENTE")]
        public string FoneCliente { get; set; }

        [DisplayName("CEPCLIENTE")]
        public string CEPCliente { get; set; }

        [DisplayName("ENDERECOCLIENTE")]
        public string EnderecoCliente { get; set; }

        [DisplayName("COMPLEMENTOCLIENTE")]
        public string ComplementoCliente { get; set; }

        [DisplayName("UFCLIENTE")]
        public string UFCliente { get; set; }

        [DisplayName("CIDADECLIENTE")]
        public string CidadeCliente { get; set; }

        [DisplayName("CODCIDADEIBGECLIENTE")]
        public int? CodCidadeIBGECliente { get; set; }

        [DisplayName("CPFCLIENTE")]
        public string CPFCliente { get; set; }

        [DisplayName("CNPJCLIENTE")]
        public string CNPJCliente { get; set; }

        [DisplayName("IMCLIENTE")]
        public string IMCliente { get; set; }

        [DisplayName("CNAECLIENTE")]
        public string CNAECliente { get; set; }

        [DisplayName("NUMEROCLIENTE")]
        public string NumeroCliente { get; set; }

        [DisplayName("BAIRROCLIENTE")]
        public string BairroCliente { get; set; }

        [DisplayName("JUSTIFICATIVACANCELAMENTO")]
        public string JustificativaCancelamento { get; set; }

        [DisplayName("DATAEHORACANCELAMENTO")]
        public DateTime? DataEHoraCancelamento { get; set; }

        [DisplayName("EMAIL")]
        public string Email { get; set; }

        [DisplayName("CODCOMANDA")]
        public int? CodComanda { get; set; }

        [DisplayName("CODDAV")]
        public int? CodDAV { get; set; }

        [DisplayName("CODPREVENDA")]
        public int? CodPreVenda { get; set; }

        [DisplayName("NUMERODAV")]
        public int? NumeroDAV { get; set; }

        [DisplayName("VALORTROCO")]
        public decimal? ValorTroco { get; set; }

        [DisplayName("CODOS")]
        public int? CodOS { get; set; }

        [DisplayName("JAFATURADO")]
        public string JaFaturado { get; set; }

        [DisplayName("SAT")]
        public string SAT { get; set; }

        [DisplayName("INFORMACAOADICIONAL")]
        public string InformacaoAdicional { get; set; }

        [DisplayName("IDENTIFICACAO")]
        public string Identificacao { get; set; }

        [DisplayName("OBS")]
        public string Obs { get; set; }

        [DisplayName("CODOPERADOR")]
        public int? CodOperador { get; set; }

        [DisplayName("OPERADOR")]
        public string Operador { get; set; }

        [DisplayName("MD5J1")]
        public string MD5J1 { get; set; }

        [DisplayName("INDICADOR")]
        public string Indicador { get; set; }

        [DisplayName("CHAVEANTERIORCONTINGENCIA")]
        public string ChaveAnteriorContingencia { get; set; }

        [DisplayName("IDPAGAMENTOVFP")]
        public int? IDPagamentoVFP { get; set; }

        [DisplayName("IDRESPOSTAFISCAL")]
        public int? IDRespostaFiscal { get; set; }

        [DisplayName("VERIFICADO")]
        public string Verificado { get; set; }

        [DisplayName("CNF")]
        public string CNF { get; set; }

        [DisplayName("STATUSCONTINGENCIA")]
        public string StatusContingencia { get; set; }

        [DisplayName("SINCRONIZADO")]
        public string Sincronizado { get; set; }

        [DisplayName("CODNOTAMANUAL")]
        public int? CodNotaManual { get; set; }

        [DisplayName("IDESTRANGEIRO")]
        public int? IDEstrangeiro { get; set; }
    }

    public class NFCEntityTypeConfiguration : IEntityTypeConfiguration<NFC>
    {
        public void Configure(EntityTypeBuilder<NFC> builder)
        {
            builder.ToTable("TVENDANFCE");
            builder.HasKey(e => e.Controle);
            builder.Property(e => e.Controle).HasColumnName("CONTROLE");
            builder.Property(e => e.DataEHoraCadastro).HasColumnName("DATAEHORACADASTRO");
            builder.Property(e => e.DataEmissao).HasColumnName("DATAEMISSAO");
            builder.Property(e => e.NumeroNFCCe).HasColumnName("NUMERONFCCE");
            builder.Property(e => e.NumeroSAT).HasColumnName("NUMEROSAT");
            builder.Property(e => e.TipoAmbiente).HasColumnName("TIPOAMBIENTE");
            builder.Property(e => e.ChaveNFCE).HasColumnName("CHAVENFCE");
            builder.Property(e => e.Protocolo).HasColumnName("PROTOCOLO");
            builder.Property(e => e.ProtocoloCancelamento).HasColumnName("PROTOCOLOCANCELAMENTO");
            builder.Property(e => e.CodigoStatus).HasColumnName("CODIGOSTATUS");
            builder.Property(e => e.StatusEnvio).HasColumnName("STATUSENVIO");
            builder.Property(e => e.Inutilizada).HasColumnName("INUTILIZADA");
            builder.Property(e => e.CodCliente).HasColumnName("CODCLIENTE");
            builder.Property(e => e.Cliente).HasColumnName("CLIENTE");
            builder.Property(e => e.CodFuncionario).HasColumnName("CODFUNCIONARIO");
            builder.Property(e => e.Funcionario).HasColumnName("FUNCIONARIO");
            builder.Property(e => e.CodCentroCusto).HasColumnName("CODCENTROCUSTO");
            builder.Property(e => e.CentroCusto).HasColumnName("CENTROCUSTO");
            builder.Property(e => e.ValorProduto).HasColumnName("VALORPRODUTO");
            builder.Property(e => e.PercAcrescimo).HasColumnName("PERCACRESCIMO");
            builder.Property(e => e.ValorAcrescimo).HasColumnName("VALORACRESCIMO");
            builder.Property(e => e.PercDesconto).HasColumnName("PERCDESCONTO");
            builder.Property(e => e.ValorDesconto).HasColumnName("VALORDESCONTO");
            builder.Property(e => e.ValorDescontoItem).HasColumnName("VALORDESCONTOITEM");
            builder.Property(e => e.ValorBCICMS).HasColumnName("VALORBCICMS");
            builder.Property(e => e.ValorICMS).HasColumnName("VALORICMS");
            builder.Property(e => e.ValorBCST).HasColumnName("VALORBCST");
            builder.Property(e => e.ValorST).HasColumnName("VALORST");
            builder.Property(e => e.ValorPIS).HasColumnName("VALORPIS");
            builder.Property(e => e.ValorCOFINS).HasColumnName("VALORCOFINS");
            builder.Property(e => e.ValorSeguro).HasColumnName("VALORSEGURO");
            builder.Property(e => e.ValorOutros).HasColumnName("VALOROUTROS");
            builder.Property(e => e.ValorOutrosItem).HasColumnName("VALOROUTROSITEM");
            builder.Property(e => e.ValorBCServico).HasColumnName("VALORBCSERVICO");
            builder.Property(e => e.ValorISS).HasColumnName("VALORISS");
            builder.Property(e => e.ValorServico).HasColumnName("VALORSERVICO");
            builder.Property(e => e.ValorTotalNFCE).HasColumnName("VALORTOTALNFCE");
            builder.Property(e => e.NaturezaOperacao).HasColumnName("NATUREZAOPERACAO");
            builder.Property(e => e.Modelo).HasColumnName("MODELO");
            builder.Property(e => e.Serie).HasColumnName("SERIE");
            builder.Property(e => e.DataSaidaEntrada).HasColumnName("DATASAIDAENTRADA");
            builder.Property(e => e.HoraSaidaEntrada).HasColumnName("HORASAIDAENTRADA");
            builder.Property(e => e.TipoEmissao).HasColumnName("TIPOEMISSAO");
            builder.Property(e => e.FoneCliente).HasColumnName("FONECLIENTE");
            builder.Property(e => e.CEPCliente).HasColumnName("CEPCLIENTE");
            builder.Property(e => e.EnderecoCliente).HasColumnName("ENDERECOCLIENTE");
            builder.Property(e => e.ComplementoCliente).HasColumnName("COMPLEMENTOCLIENTE");
            builder.Property(e => e.UFCliente).HasColumnName("UFCLIENTE");
            builder.Property(e => e.CidadeCliente).HasColumnName("CIDADECLIENTE");
            builder.Property(e => e.CodCidadeIBGECliente).HasColumnName("CODCIDADEIBGECLIENTE");
            builder.Property(e => e.CPFCliente).HasColumnName("CPFCLIENTE");
            builder.Property(e => e.CNPJCliente).HasColumnName("CNPJCLIENTE");
            builder.Property(e => e.IMCliente).HasColumnName("IMCLIENTE");
            builder.Property(e => e.CNAECliente).HasColumnName("CNAECLIENTE");
            builder.Property(e => e.NumeroCliente).HasColumnName("NUMEROCLIENTE");
            builder.Property(e => e.BairroCliente).HasColumnName("BAIRROCLIENTE");
            builder.Property(e => e.JustificativaCancelamento).HasColumnName("JUSTIFICATIVACANCELAMENTO");
            builder.Property(e => e.DataEHoraCancelamento).HasColumnName("DATAEHORACANCELAMENTO");
            builder.Property(e => e.Email).HasColumnName("EMAIL");
            builder.Property(e => e.CodComanda).HasColumnName("CODCOMANDA");
            builder.Property(e => e.CodDAV).HasColumnName("CODDAV");
            builder.Property(e => e.CodPreVenda).HasColumnName("CODPREVENDA");
            builder.Property(e => e.NumeroDAV).HasColumnName("NUMERODAV");
            builder.Property(e => e.ValorTroco).HasColumnName("VALORTROCO");
            builder.Property(e => e.CodOS).HasColumnName("CODOS");
            builder.Property(e => e.JaFaturado).HasColumnName("JAFATURADO");
            builder.Property(e => e.SAT).HasColumnName("SAT");
            builder.Property(e => e.InformacaoAdicional).HasColumnName("INFORMACAOADICIONAL");
            builder.Property(e => e.Identificacao).HasColumnName("IDENTIFICACAO");
            builder.Property(e => e.Obs).HasColumnName("OBS");
            builder.Property(e => e.CodOperador).HasColumnName("CODOPERADOR");
            builder.Property(e => e.Operador).HasColumnName("OPERADOR");
            builder.Property(e => e.MD5J1).HasColumnName("MD5J1");
            builder.Property(e => e.Indicador).HasColumnName("INDICADOR");
            builder.Property(e => e.ChaveAnteriorContingencia).HasColumnName("CHAVEANTERIORCONTINGENCIA");
            builder.Property(e => e.IDPagamentoVFP).HasColumnName("IDPAGAMENTOVFP");
            builder.Property(e => e.IDRespostaFiscal).HasColumnName("IDRESPOSTAFISCAL");
            builder.Property(e => e.Verificado).HasColumnName("VERIFICADO");
            builder.Property(e => e.CNF).HasColumnName("CNF");
            builder.Property(e => e.StatusContingencia).HasColumnName("STATUSCONTINGENCIA");
            builder.Property(e => e.Sincronizado).HasColumnName("SINCRONIZADO");
            builder.Property(e => e.CodNotaManual).HasColumnName("CODNOTAMANUAL");
            builder.Property(e => e.IDEstrangeiro).HasColumnName("IDESTRANGEIRO");
        }
    }

}
