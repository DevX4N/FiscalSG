using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Fiscal.Classes;

namespace Fiscal
{
    public class Estoque
    {
        [DisplayName("CONTROLE")]
        public int Controle { get; set; }

        [DisplayName("PRODUTO")]
        public string Produto { get; set; }

        [DisplayName("TIPOBARRA")]
        public string TipoBarra { get; set; }

        [DisplayName("CODBARRAS")]
        public string CodigoBarras { get; set; }

        [DisplayName("UNIDADE")]
        public string Unidade { get; set; }

        [DisplayName("PRECOCUSTO")]
        public string PrecoCusto { get; set; }

        [DisplayName("PERCLUCRO")]
        public decimal? PercentualLucro { get; set; }

        [DisplayName("PRECOVENDA")]
        public decimal? PrecoVenda { get; set; }

        [DisplayName("CODGRUPO")]
        public string CodigoGrupo { get; set; }

        [DisplayName("GRUPO")]
        public string Grupo { get; set; }

        [DisplayName("CODFORNECEDOR")]
        public string CodigoFornecedor { get; set; }

        [DisplayName("FORNECEDOR")]
        public string Fornecedor { get; set; }

        [DisplayName("TAMANHO")]
        public string Tamanho { get; set; }

        [DisplayName("PESO")]
        public decimal? Peso { get; set; }

        [DisplayName("CUSTOULTIMACOMPRA")]
        public decimal? CustoUltimaCompra { get; set; }

        [DisplayName("CUSTOMEDIO")]
        public decimal? CustoMedio { get; set; }

        [DisplayName("QTDETOTALCOMPRADA")]
        public decimal? QuantidadeTotalComprada { get; set; }

        [DisplayName("QTDETOTALVENDIDA")]
        public decimal? QuantidadeTotalVendida { get; set; }

        [DisplayName("DATAULTIMACOMPRA")]
        public DateTime? DataUltimaCompra { get; set; }

        [DisplayName("DATAULTIMAVENDA")]
        public DateTime? DataUltimaVenda { get; set; }

        [DisplayName("DATAHORACADASTRO")]
        public DateTime? DataHoraCadastro { get; set; }

        [DisplayName("QTDEMINIMA")]
        public decimal? QuantidadeMinima { get; set; }

        [DisplayName("QTDEMAXIMA")]
        public decimal? QuantidadeMaxima { get; set; }

        [DisplayName("QTDE")]
        public decimal? Quantidade { get; set; }

        [DisplayName("ATIVO")]
        public string Ativo { get; set; }

        [DisplayName("NCM")]
        public decimal? NCM { get; set; }

        [DisplayName("PERCREDITOCICMS")]
        public decimal? PercentualCreditoICMS { get; set; }

        [DisplayName("USAGRADE")]
        public string UsaGrade { get; set; }

        [DisplayName("USASERIAL")]
        public string UsaSerial { get; set; }

        [DisplayName("ORIGEM")]
        public string Origem { get; set; }

        [DisplayName("CODTRIBUTACAOIPI")]
        public string CodigoTributacaoIPI { get; set; }

        [DisplayName("TRIBUTACAOIPI")]
        public string TributacaoIPI { get; set; }

        [DisplayName("CODTRIBUTACAOPIS")]
        public string CodigoTributacaoPIS { get; set; }

        [DisplayName("CODTRIBUTACAOCOFINS")]
        public string CodigoTributacaoCOFINS { get; set; }

        [DisplayName("TRIBUTACAOPIS")]
        public string TributacaoPIS { get; set; }

        [DisplayName("TRIBUTACAOCOFINS")]
        public string TributacaoCOFINS { get; set; }

        [DisplayName("TIPOTRIBUTACAO")]
        public string TipoTributacao { get; set; }

        [DisplayName("PERCICMSSTINTERNA")]
        public decimal? PercentualICMSSTInterna { get; set; }

        [DisplayName("PERCMVAORIGINAL")]
        public string PercentualMVAOriginal { get; set; }

        [DisplayName("POSSUIICMSST")]
        public string PossuiICMSST { get; set; }

        [DisplayName("ISENTO")]
        public string Isento { get; set; }

        [DisplayName("PERCICMSPROPRIOST")]
        public string PercentualICMSProprioST { get; set; }

        [DisplayName("IAT")]
        public string IAT { get; set; }

        [DisplayName("IPPT")]
        public string IPPT { get; set; }

        [DisplayName("TRIBUTADO")]
        public string Tributado { get; set; }

        [DisplayName("CSOSN")]
        public string CSOSN { get; set; }

        [DisplayName("DESCRICAOCSOSN")]
        public string DescricaoCSOSN { get; set; }

        [DisplayName("PESADO")]
        public string Pesado { get; set; }

        [DisplayName("BASECALCULOICMSSTRETIDO")]
        public decimal? BaseCalculoICMSSTRetido { get; set; }

        [DisplayName("VALORICMSSTRETIDO")]
        public decimal? ValorICMSSTRetido { get; set; }

        [DisplayName("ALIQUOTAICMSECF")]
        public decimal? AliquotaICMSECF { get; set; }

        [DisplayName("FOTO")]
        public string Foto { get; set; }

        [DisplayName("MD5")]
        public string MD5 { get; set; }

        [DisplayName("MENSAGEMNFE")]
        public string MensagemNFE { get; set; }

        [DisplayName("CODMENSAGEMNFE")]
        public string CodigoMensagemNFE { get; set; }

        [DisplayName("CODUNIDADEMEDIDA")]
        public string CodUnidadeMedida { get; set; }

        [DisplayName("CODAPLICACAOPRODUTO")]
        public int? CodigoAplicacaoProduto { get; set; }

        [DisplayName("APLICACAOPRODUTO")]
        public string AplicacaoProduto { get; set; }

        [DisplayName("MD5E2")]
        public string MD5E2 { get; set; }

        [DisplayName("QTDEINICIAL")]
        public decimal? QuantidadeInicial { get; set; }

        [DisplayName("ALIQUOTAISS")]
        public decimal? AliquotaISS { get; set; }

        [DisplayName("CODIMPOSTOMEDIO")]
        public string CodigoImpostoMedio { get; set; }

        [DisplayName("PERCIMPOSTOMEDIO")]
        public decimal? PercentualImpostoMedio { get; set; }

        [DisplayName("CODCSTORIGEM")]
        public string CodigoCSTOrigem { get; set; }

        [DisplayName("CODIGOCSTORIGEM")]
        public string CODIGOCSTORIGEM { get; set; }

        [DisplayName("CODEMITENTE")]
        public string CodigoEmitente { get; set; }

        [DisplayName("DIASVALIDADEPRODUTO")]
        public string DiasValidadeProduto { get; set; }

        [DisplayName("FATORCONVERSAO")]
        public string FatorConversao { get; set; }

        [DisplayName("TRIBUTACAOSERVICO")]
        public string TributacaoServico { get; set; }

        [DisplayName("REDUCAOBASECALCULOSERVICO")]
        public string ReducaoBaseCalculoServico { get; set; }

        [DisplayName("STATUS")]
        public string Status { get; set; }

        [DisplayName("DESCRICAOCOMPLEMENTAR")]
        public string DescricaoComplementar { get; set; }

        [DisplayName("REFERENCIA")]
        public string Referencia { get; set; }

        [DisplayName("PRECOVENDAUSS")]
        public decimal? PrecoVendaUSS { get; set; }

        [DisplayName("PERCMAXIMODESCONTO")]
        public decimal? PercentualMaximoDesconto { get; set; }

        [DisplayName("VALORCOMISSAOFIXO")]
        public decimal? ValorComissaoFixo { get; set; }

        [DisplayName("PERCCOMISSAO")]
        public decimal? PercentualComissao { get; set; }

        [DisplayName("PRECOMINIMOUSS")]
        public decimal? PrecoMinimoUSS { get; set; }

        [DisplayName("PRECOMINIMO")]
        public decimal? PrecoMinimo { get; set; }

        [DisplayName("CODCOMPRA")]
        public string CodigoCompra { get; set; }

        [DisplayName("VALORCONVERSAO")]
        public decimal? ValorConversao { get; set; }

        [DisplayName("VALORFRETE")]
        public decimal? ValorFrete { get; set; }

        [DisplayName("VALOROUTROS")]
        public decimal? ValorOutros { get; set; }

        [DisplayName("VALORICMSST")]
        public decimal? ValorICMSST { get; set; }

        [DisplayName("VALORIPI")]
        public decimal? ValorIPI { get; set; }

        [DisplayName("VALORUNITARIOCOMPRA")]
        public decimal? ValorUnitarioCompra { get; set; }

        [DisplayName("PERCPIS")]
        public decimal? PercentualPIS { get; set; }

        [DisplayName("PERCCOFINS")]
        public decimal? PercentualCOFINS { get; set; }

        [DisplayName("CAMPO1")]
        public string Campo1 { get; set; }

        [DisplayName("CAMPO2")]
        public string Campo2 { get; set; }

        [DisplayName("CAMPO3")]
        public string Campo3 { get; set; }

        [DisplayName("CAMPO4")]
        public string Campo4 { get; set; }

        [DisplayName("CAMPO5")]
        public string Campo5 { get; set; }

        [DisplayName("CAMPO6")]
        public string Campo6 { get; set; }

        [DisplayName("CAMPO7")]
        public string Campo7 { get; set; }

        [DisplayName("CAMPO8")]
        public string Campo8 { get; set; }

        [DisplayName("CAMPO9")]
        public string Campo9 { get; set; }

        [DisplayName("CAMPO10")]
        public string Campo10 { get; set; }

        [DisplayName("MARCA")]
        public string Marca { get; set; }

        [DisplayName("PERCREDUCAOBC")]
        public decimal? PercentualReducaoBC { get; set; }

        [DisplayName("PERCREDUCAOBCST")]
        public decimal? PercentualReducaoBCST { get; set; }

        [DisplayName("CODSUBGRUPO")]
        public string CodigoSubGrupo { get; set; }

        [DisplayName("SUBGRUPO")]
        public string SubGrupo { get; set; }

        [DisplayName("CONTROLARVALIDADE")]
        public string ControlarValidade { get; set; }

        [DisplayName("CODMARCA")]
        public string CodigoMarca { get; set; }

        [DisplayName("PRECOREVENDA")]
        public decimal? PrecoRevenda { get; set; }

        [DisplayName("PERCIPI")]
        public string PercentualIPI { get; set; }

        [DisplayName("CFOP")]
        public string CFOP { get; set; }

        [DisplayName("UNIDADECONVERSAOVENDA")]
        public string UnidadeConversaoVenda { get; set; }

        [DisplayName("VALORCONVERSAOVENDA")]
        public string ValorConversaoVenda { get; set; }

        [DisplayName("CODTABELAPRECO")]
        public decimal? CodTabelaPreco { get; set; }

        [DisplayName("NOMETABELAPRECO")]
        public string NomeTabelaPreco { get; set; }

        [DisplayName("PERCIMPOSTOMEDIOESTADUAL")]
        public decimal? PercentualImpostoMedioEstadual { get; set; }

        [DisplayName("PERCIMPOSTOMEDIOMUNICIPAL")]
        public decimal? PercentualImpostoMedioMunicipal { get; set; }

        [DisplayName("CODIGOENQUADRAMENTOIPI")]
        public string CodigoEnquadramentoIPI { get; set; }

        [DisplayName("CEST")]
        public string CEST { get; set; }

        [DisplayName("QTDEEMPRODUCAO")]
        public decimal? QuantidadeEmProducao { get; set; }

        [DisplayName("QTDEPEDIDOVENDA")]
        public decimal? QuantidadePedidoVenda { get; set; }

        [DisplayName("QTDEPEDIDOCOMPRA")]
        public decimal? QuantidadePedidoCompra { get; set; }

        [DisplayName("QTDERESERVADA")]
        public decimal? QuantidadeReservada { get; set; }

        [DisplayName("QTDEREAL")]
        public decimal? QuantidadeReal { get; set; }

        [DisplayName("QTDEEMPRODUCAOMP")]
        public decimal? QuantidadeEmProducaoMP { get; set; }

        [DisplayName("UNIDADEMEDIDAETIQUETA")]
        public string UnidadeMedidaEtiqueta { get; set; }

        [DisplayName("FATORCONVERSAOETIQUETA")]
        public decimal? FatorConversaoEtiqueta { get; set; }

        [DisplayName("CODIGOANP")]
        public string CodigoANP { get; set; }

        [DisplayName("DESCRICAOANP")]
        public string DescricaoANP { get; set; }

        [DisplayName("PERCGLPCOMB")]
        public decimal? PercentualGLPComb { get; set; }

        [DisplayName("PERCGNNCOMB")]
        public decimal? PercentualGNNComb { get; set; }

        [DisplayName("PERCGNICOMB")]
        public decimal? PercentualGNIComb { get; set; }

        [DisplayName("VALORPARTIDACOMB")]
        public decimal? ValorPartidaComb { get; set; }

        [DisplayName("CNPJFABRICANTE")]
        public string CNPJFabricante { get; set; }

        [DisplayName("CODBENEFICIOFISCAL")]
        public string CodigoBeneficioFiscal { get; set; }

        [DisplayName("CODIGOANVISA")]
        public string CodigoANVISA { get; set; }

        [DisplayName("SELOIPI")]
        public string SeloIPI { get; set; }

        [DisplayName("ALIQUOTAFCP")]
        public decimal? AliquotaFCP { get; set; }

        [DisplayName("PERCFCPST")]
        public decimal? PercentualFCPST { get; set; }

        [DisplayName("CODUNIDADETRIBUTAVEL")]
        public string CodUnidadeTributavel { get; set; }

        [DisplayName("UNIDADETRIBUTAVEL")]
        public string UnidadeTributavel { get; set; }

        [DisplayName("QTDETRIBUTAVEL")]
        public int? QuantidadeTributavel { get; set; }

        [DisplayName("DESMONTARNAVENDA")]
        public int? DesmontarNaVenda { get; set; }

        [DisplayName("ALIQUOTAICMSSTRET")]
        public decimal? AliquotaICMSSTRet { get; set; }

        [DisplayName("VALORBCICMSSTRET")]
        public decimal? ValorBCICMSSTRet { get; set; }

        [DisplayName("VALORICMSSTRET")]
        public decimal? ValorICMSSTRet { get; set; }

        [DisplayName("ALIQUOTAICMSEFET")]
        public decimal? AliquotaICMSEfet { get; set; }

        [DisplayName("PERCREDUCAOICMSEFET")]
        public decimal? PercentualReducaoICMSEfet { get; set; }

        [DisplayName("VALORBCICMSEFET")]
        public decimal? ValorBCICMSEfet { get; set; }

        [DisplayName("VALORICMSEFET")]
        public decimal? ValorICMSEfet { get; set; }

        [DisplayName("VALORICMSSUBSTITUTO")]
        public decimal? ValorICMSSubstituto { get; set; }

        [DisplayName("CODBARRASCAIXA")]
        public string CodigoBarrasCaixa { get; set; }

        [DisplayName("ENVIARDADOS")]
        public int? EnviarDados { get; set; }

        [DisplayName("VALORPMC")]
        public decimal? ValorPMC { get; set; }

        [DisplayName("MD5O")]
        public string MD5O { get; set; }

        [DisplayName("MD5S")]
        public string MD5S { get; set; }

        [DisplayName("VALORFCPST")]
        public decimal? ValorFCPST { get; set; }

        [DisplayName("LOCALIZACAO")]
        public string Localizacao { get; set; }

        [DisplayName("VOLUME")]
        public int? Volume { get; set; }

        [DisplayName("MOSTRARCOZINHA")]
        public string MostrarCozinha { get; set; }

        [DisplayName("CODBARRASINTERNO")]
        public string CodigoBarrasInterno { get; set; }

        [DisplayName("CODBARRASTRIB")]
        public string CodigoBarrasTrib { get; set; }

        [DisplayName("VACINA")]
        public string Vacina { get; set; }

        [DisplayName("PERCDESCONTOCAIXA")]
        public decimal? PercentualDescontoCaixa { get; set; }

        [DisplayName("SINCRONIZADO")]
        public string Sincronizado { get; set; }

        [DisplayName("PERCCASHBACK")]
        public decimal? PercentualCashback { get; set; }
    }

    public class EstoqueEntityConfiguration : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.ToTable("TESTOQUE");
            builder.HasKey(a => a.Controle);
            builder.Property(a => a.Controle).HasColumnName("CONTROLE");
            builder.Property(a => a.Produto).HasColumnName("PRODUTO");
            builder.Property(a => a.TipoBarra).HasColumnName("TIPOBARRA");
            builder.Property(a => a.CodigoBarras).HasColumnName("CODBARRAS");
            builder.Property(a => a.Unidade).HasColumnName("UNIDADE");
            builder.Property(a => a.PrecoCusto).HasColumnName("PRECOCUSTO");
            builder.Property(a => a.PercentualLucro).HasColumnName("PERCLUCRO");
            builder.Property(a => a.PrecoVenda).HasColumnName("PRECOVENDA");
            builder.Property(a => a.CodigoGrupo).HasColumnName("CODGRUPO");
            builder.Property(a => a.Grupo).HasColumnName("GRUPO");
            builder.Property(a => a.CodigoFornecedor).HasColumnName("CODFORNECEDOR");
            builder.Property(a => a.Fornecedor).HasColumnName("FORNECEDOR");
            builder.Property(a => a.Tamanho).HasColumnName("TAMANHO");
            builder.Property(a => a.Peso).HasColumnName("PESO");
            builder.Property(a => a.CustoUltimaCompra).HasColumnName("CUSTOULTIMACOMPRA");
            builder.Property(a => a.CustoMedio).HasColumnName("CUSTOMEDIO");
            builder.Property(a => a.QuantidadeTotalComprada).HasColumnName("QTDETOTALCOMPRADA");
            builder.Property(a => a.QuantidadeTotalVendida).HasColumnName("QTDETOTALVENDIDA");
            builder.Property(a => a.DataUltimaCompra).HasColumnName("DATAULTIMACOMPRA");
            builder.Property(a => a.DataUltimaVenda).HasColumnName("DATAULTIMAVENDA");
            builder.Property(a => a.DataHoraCadastro).HasColumnName("DATAHORACADASTRO");
            builder.Property(a => a.QuantidadeMinima).HasColumnName("QTDEMINIMA");
            builder.Property(a => a.QuantidadeMaxima).HasColumnName("QTDEMAXIMA");
            builder.Property(a => a.Quantidade).HasColumnName("QTDE");
            builder.Property(a => a.Ativo).HasColumnName("ATIVO");
            builder.Property(a => a.NCM).HasColumnName("NCM");
            builder.Property(a => a.PercentualCreditoICMS).HasColumnName("PERCREDITOCICMS");
            builder.Property(a => a.UsaGrade).HasColumnName("USAGRADE");
            builder.Property(a => a.UsaSerial).HasColumnName("USASERIAL");
            builder.Property(a => a.Origem).HasColumnName("ORIGEM");
            builder.Property(a => a.CodigoTributacaoIPI).HasColumnName("CODTRIBUTACAOIPI");
            builder.Property(a => a.TributacaoIPI).HasColumnName("TRIBUTACAOIPI");
            builder.Property(a => a.CodigoTributacaoPIS).HasColumnName("CODTRIBUTACAOPIS");
            builder.Property(a => a.CodigoTributacaoCOFINS).HasColumnName("CODTRIBUTACAOCOFINS");
            builder.Property(a => a.TributacaoPIS).HasColumnName("TRIBUTACAOPIS");
            builder.Property(a => a.TributacaoCOFINS).HasColumnName("TRIBUTACAOCOFINS");
            builder.Property(a => a.TipoTributacao).HasColumnName("TIPOTRIBUTACAO");
            builder.Property(a => a.PercentualICMSSTInterna).HasColumnName("PERCICMSSTINTERNA");
            builder.Property(a => a.PercentualMVAOriginal).HasColumnName("PERCMVAORIGINAL");
            builder.Property(a => a.PossuiICMSST).HasColumnName("POSSUIICMSST");
            builder.Property(a => a.Isento).HasColumnName("ISENTO");
            builder.Property(a => a.PercentualICMSProprioST).HasColumnName("PERCICMSPROPRIOST");
            builder.Property(a => a.IAT).HasColumnName("IAT");
            builder.Property(a => a.IPPT).HasColumnName("IPPT");
            builder.Property(a => a.Tributado).HasColumnName("TRIBUTADO");
            builder.Property(a => a.CSOSN).HasColumnName("CSOSN");
            builder.Property(a => a.DescricaoCSOSN).HasColumnName("DESCRICAOCSOSN");
            builder.Property(a => a.Pesado).HasColumnName("PESADO");
            builder.Property(a => a.BaseCalculoICMSSTRetido).HasColumnName("BASECALCULOICMSSTRETIDO");
            builder.Property(a => a.ValorICMSSTRetido).HasColumnName("VALORICMSSTRETIDO");
            builder.Property(a => a.AliquotaICMSECF).HasColumnName("ALIQUOTAICMSECF");
            builder.Property(a => a.Foto).HasColumnName("FOTO");
            builder.Property(a => a.MD5).HasColumnName("MD5");
            builder.Property(a => a.MensagemNFE).HasColumnName("MENSAGEMNFE");
            builder.Property(a => a.CodigoMensagemNFE).HasColumnName("CODMENSAGEMNFE");
            builder.Property(a => a.CodUnidadeMedida).HasColumnName("CODUNIDADEMEDIDA");
            builder.Property(a => a.CodigoAplicacaoProduto).HasColumnName("CODAPLICACAOPRODUTO");
            builder.Property(a => a.AplicacaoProduto).HasColumnName("APLICACAOPRODUTO");
            builder.Property(a => a.MD5E2).HasColumnName("MD5E2");
            builder.Property(a => a.QuantidadeInicial).HasColumnName("QTDEINICIAL");
            builder.Property(a => a.AliquotaISS).HasColumnName("ALIQUOTAISS");
            builder.Property(a => a.CodigoImpostoMedio).HasColumnName("CODIMPOSTOMEDIO");
            builder.Property(a => a.PercentualImpostoMedio).HasColumnName("PERCIMPOSTOMEDIO");
            builder.Property(a => a.CodigoCSTOrigem).HasColumnName("CODCSTORIGEM");
            builder.Property(a => a.CODIGOCSTORIGEM).HasColumnName("CODIGOCSTORIGEM");
            builder.Property(a => a.CodigoEmitente).HasColumnName("CODEMITENTE");
            builder.Property(a => a.DiasValidadeProduto).HasColumnName("DIASVALIDADEPRODUTO");
            builder.Property(a => a.FatorConversao).HasColumnName("FATORCONVERSAO");
            builder.Property(a => a.TributacaoServico).HasColumnName("TRIBUTACAOSERVICO");
            builder.Property(a => a.ReducaoBaseCalculoServico).HasColumnName("REDUCAOBASECALCULOSERVICO");
            builder.Property(a => a.Status).HasColumnName("STATUS");
            builder.Property(a => a.DescricaoComplementar).HasColumnName("DESCRICAOCOMPLEMENTAR");
            builder.Property(a => a.Referencia).HasColumnName("REFERENCIA");
            builder.Property(a => a.PrecoVendaUSS).HasColumnName("PRECOVENDAUSS");
            builder.Property(a => a.PercentualMaximoDesconto).HasColumnName("PERCMAXIMODESCONTO");
            builder.Property(a => a.ValorComissaoFixo).HasColumnName("VALORCOMISSAOFIXO");
            builder.Property(a => a.PercentualComissao).HasColumnName("PERCCOMISSAO");
            builder.Property(a => a.PrecoMinimoUSS).HasColumnName("PRECOMINIMOUSS");
            builder.Property(a => a.PrecoMinimo).HasColumnName("PRECOMINIMO");
            builder.Property(a => a.CodigoCompra).HasColumnName("CODCOMPRA");
            builder.Property(a => a.ValorConversao).HasColumnName("VALORCONVERSAO");
            builder.Property(a => a.ValorFrete).HasColumnName("VALORFRETE");
            builder.Property(a => a.ValorOutros).HasColumnName("VALOROUTROS");
            builder.Property(a => a.ValorICMSST).HasColumnName("VALORICMSST");
            builder.Property(a => a.ValorIPI).HasColumnName("VALORIPI");
            builder.Property(a => a.ValorUnitarioCompra).HasColumnName("VALORUNITARIOCOMPRA");
            builder.Property(a => a.PercentualPIS).HasColumnName("PERCPIS");
            builder.Property(a => a.PercentualCOFINS).HasColumnName("PERCCOFINS");
            builder.Property(a => a.Campo1).HasColumnName("CAMPO1");
            builder.Property(a => a.Campo2).HasColumnName("CAMPO2");
            builder.Property(a => a.Campo3).HasColumnName("CAMPO3");
            builder.Property(a => a.Campo4).HasColumnName("CAMPO4");
            builder.Property(a => a.Campo5).HasColumnName("CAMPO5");
            builder.Property(a => a.Campo6).HasColumnName("CAMPO6");
            builder.Property(a => a.Campo7).HasColumnName("CAMPO7");
            builder.Property(a => a.Campo8).HasColumnName("CAMPO8");
            builder.Property(a => a.Campo9).HasColumnName("CAMPO9");
            builder.Property(a => a.Campo10).HasColumnName("CAMPO10");
            builder.Property(a => a.Marca).HasColumnName("MARCA");
            builder.Property(a => a.PercentualReducaoBC).HasColumnName("PERCREDUCAOBC");
            builder.Property(a => a.PercentualReducaoBCST).HasColumnName("PERCREDUCAOBCST");
            builder.Property(a => a.CodigoSubGrupo).HasColumnName("CODSUBGRUPO");
            builder.Property(a => a.SubGrupo).HasColumnName("SUBGRUPO");
            builder.Property(a => a.ControlarValidade).HasColumnName("CONTROLARVALIDADE");
            builder.Property(a => a.CodigoMarca).HasColumnName("CODMARCA");
            builder.Property(a => a.PrecoRevenda).HasColumnName("PRECOREVENDA");
            builder.Property(a => a.PercentualIPI).HasColumnName("PERCIPI");
            builder.Property(a => a.CFOP).HasColumnName("CFOP");
            builder.Property(a => a.UnidadeConversaoVenda).HasColumnName("UNIDADECONVERSAOVENDA");
            builder.Property(a => a.ValorConversaoVenda).HasColumnName("VALORCONVERSAOVENDA");
            builder.Property(a => a.CodTabelaPreco).HasColumnName("CODTABELAPRECO");
            builder.Property(a => a.NomeTabelaPreco).HasColumnName("NOMETABELAPRECO");
            builder.Property(a => a.PercentualImpostoMedioEstadual).HasColumnName("PERCIMPOSTOMEDIOESTADUAL");
            builder.Property(a => a.PercentualImpostoMedioMunicipal).HasColumnName("PERCIMPOSTOMEDIOMUNICIPAL");
            builder.Property(a => a.CodigoEnquadramentoIPI).HasColumnName("CODIGOENQUADRAMENTOIPI");
            builder.Property(a => a.CEST).HasColumnName("CEST");
            builder.Property(a => a.QuantidadeEmProducao).HasColumnName("QTDEEMPRODUCAO");
            builder.Property(a => a.QuantidadePedidoVenda).HasColumnName("QTDEPEDIDOVENDA");
            builder.Property(a => a.QuantidadePedidoCompra).HasColumnName("QTDEPEDIDOCOMPRA");
            builder.Property(a => a.QuantidadeReservada).HasColumnName("QTDERESERVADA");
            builder.Property(a => a.QuantidadeReal).HasColumnName("QTDEREAL");
            builder.Property(a => a.QuantidadeEmProducaoMP).HasColumnName("QTDEEMPRODUCAOMP");
            builder.Property(a => a.UnidadeMedidaEtiqueta).HasColumnName("UNIDADEMEDIDAETIQUETA");
            builder.Property(a => a.FatorConversaoEtiqueta).HasColumnName("FATORCONVERSAOETIQUETA");
            builder.Property(a => a.CodigoANP).HasColumnName("CODIGOANP");
            builder.Property(a => a.DescricaoANP).HasColumnName("DESCRICAOANP");
            builder.Property(a => a.PercentualGLPComb).HasColumnName("PERCGLPCOMB");
            builder.Property(a => a.PercentualGNNComb).HasColumnName("PERCGNNCOMB");
            builder.Property(a => a.PercentualGNIComb).HasColumnName("PERCGNICOMB");
            builder.Property(a => a.ValorPartidaComb).HasColumnName("VALORPARTIDACOMB");
            builder.Property(a => a.CNPJFabricante).HasColumnName("CNPJFABRICANTE");
            builder.Property(a => a.CodigoBeneficioFiscal).HasColumnName("CODBENEFICIOFISCAL");
            builder.Property(a => a.CodigoANVISA).HasColumnName("CODIGOANVISA");
            builder.Property(a => a.SeloIPI).HasColumnName("SELOIPI");
            builder.Property(a => a.AliquotaFCP).HasColumnName("ALIQUOTAFCP");
            builder.Property(a => a.PercentualFCPST).HasColumnName("PERCFCPST");
            builder.Property(a => a.CodUnidadeTributavel).HasColumnName("CODUNIDADETRIBUTAVEL");
            builder.Property(a => a.UnidadeTributavel).HasColumnName("UNIDADETRIBUTAVEL");
            builder.Property(a => a.QuantidadeTributavel).HasColumnName("QTDETRIBUTAVEL");
            builder.Property(a => a.DesmontarNaVenda).HasColumnName("DESMONTARNAVENDA");
            builder.Property(a => a.AliquotaICMSSTRet).HasColumnName("ALIQUOTAICMSSTRET");
            builder.Property(a => a.ValorBCICMSSTRet).HasColumnName("VALORBCICMSSTRET");
            builder.Property(a => a.ValorICMSSTRet).HasColumnName("VALORICMSSTRET");
            builder.Property(a => a.AliquotaICMSEfet).HasColumnName("ALIQUOTAICMSEFET");
            builder.Property(a => a.PercentualReducaoICMSEfet).HasColumnName("PERCREDUCAOICMSEFET");
            builder.Property(a => a.ValorBCICMSEfet).HasColumnName("VALORBCICMSEFET");
            builder.Property(a => a.ValorICMSEfet).HasColumnName("VALORICMSEFET");
            builder.Property(a => a.ValorICMSSubstituto).HasColumnName("VALORICMSSUBSTITUTO");
            builder.Property(a => a.CodigoBarrasCaixa).HasColumnName("CODBARRASCAIXA");
            builder.Property(a => a.EnviarDados).HasColumnName("ENVIARDADOS");
            builder.Property(a => a.ValorPMC).HasColumnName("VALORPMC");
            builder.Property(a => a.MD5O).HasColumnName("MD5O");
            builder.Property(a => a.MD5S).HasColumnName("MD5S");
            builder.Property(a => a.ValorFCPST).HasColumnName("VALORFCPST");
            builder.Property(a => a.Localizacao).HasColumnName("LOCALIZACAO");
            builder.Property(a => a.Volume).HasColumnName("VOLUME");
            builder.Property(a => a.MostrarCozinha).HasColumnName("MOSTRARCOZINHA");
            builder.Property(a => a.CodigoBarrasInterno).HasColumnName("CODBARRASINTERNO");
            builder.Property(a => a.CodigoBarrasTrib).HasColumnName("CODBARRASTRIB");
            builder.Property(a => a.Vacina).HasColumnName("VACINA");
            builder.Property(a => a.PercentualDescontoCaixa).HasColumnName("PERCDESCONTOCAIXA");
            builder.Property(a => a.Sincronizado).HasColumnName("SINCRONIZADO");
            builder.Property(a => a.PercentualCashback).HasColumnName("PERCCASHBACK");
        }

    }
}
