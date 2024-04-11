using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Fiscal
{
    public class Clientes
    {
        [DisplayName("CONTROLE")]
        public int? Controle { get; set; }

        [DisplayName("CLIENTE")]
        public string Cliente { get; set; }

        [DisplayName("ENDERECO")]
        public string Endereco { get; set; }

        [DisplayName("COMPLEMENTO")]
        public string Complemento { get; set; }

        [DisplayName("BAIRRO")]
        public string Bairro { get; set; }

        [DisplayName("CODCIDADE")]
        public int? CodCidade { get; set; }

        [DisplayName("CIDADE")]
        public string Cidade { get; set; }

        [DisplayName("UF")]
        public string UF { get; set; }

        [DisplayName("PAIS")]
        public string Pais { get; set; }

        [DisplayName("CEP")]
        public string CEP { get; set; }

        [DisplayName("NATURALIDADE")]
        public string Naturalidade { get; set; }

        [DisplayName("TIPOCLIENTE")]
        public string TipoCliente { get; set; }

        [DisplayName("RG")]
        public string RG { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }

        [DisplayName("IE")]
        public string IE { get; set; }

        [DisplayName("IM")]
        public string IM { get; set; }

        [DisplayName("DATANASCIMENTO")]
        public DateTime? DataNascimento { get; set; }

        [DisplayName("DATAHORACADASTRO")]
        public DateTime? DataHoraCadastro { get; set; }

        [DisplayName("PAI")]
        public string Pai { get; set; }

        [DisplayName("MAE")]
        public string Mae { get; set; }

        [DisplayName("TELEFONE")]
        public string Telefone { get; set; }

        [DisplayName("CELULAR")]
        public string Celular { get; set; }

        [DisplayName("EMAIL")]
        public string Email { get; set; }

        [DisplayName("ESTADOCIVIL")]
        public string EstadoCivil { get; set; }

        [DisplayName("ATIVO")]
        public string Ativo { get; set; }

        [DisplayName("FANTASIA")]
        public string Fantasia { get; set; }

        [DisplayName("OBS")]
        public string Obs { get; set; }

        [DisplayName("LIMITECREDITO")]
        public decimal? LimiteCredito { get; set; }

        [DisplayName("NOMECONJUGE")]
        public string NomeConjuge { get; set; }

        [DisplayName("DATAULTIMAVENDA")]
        public DateTime? DataUltimaVenda { get; set; }

        [DisplayName("DIASSEMCOMPRAR")]
        public int? DiasSemComprar { get; set; }

        [DisplayName("CODCONVENIO")]
        public int? CodConvenio { get; set; }

        [DisplayName("CONVENIO")]
        public string Convenio { get; set; }

        [DisplayName("PROFISSAO")]
        public string Profissao { get; set; }

        [DisplayName("EMPRESAQUETRABALHA")]
        public string EmpresaQueTrabalha { get; set; }

        [DisplayName("FONETRABALHO")]
        public string FoneTrabalho { get; set; }

        [DisplayName("RENDAMENSAL")]
        public decimal? RendaMensal { get; set; }

        [DisplayName("TOTALVENDIDO")]
        public decimal? TotalVendido { get; set; }

        [DisplayName("NACIONALIDADE")]
        public string Nacionalidade { get; set; }

        [DisplayName("NUMERO")]
        public string Numero { get; set; }

        [DisplayName("CODCONSULTASPC")]
        public int? CodConsultasPC { get; set; }

        [DisplayName("SEXO")]
        public string Sexo { get; set; }

        [DisplayName("CODIGOCIDADEIBGE")]
        public string CodigoCidadeIBGE { get; set; }

        [DisplayName("CODEMITENTE")]
        public int? CodEmitente { get; set; }

        [DisplayName("NOMECONTATOJURIDICA")]
        public string NomeContatoJuridica { get; set; }

        [DisplayName("EMAIL2")]
        public string Email2 { get; set; }

        [DisplayName("STATUS")]
        public string Status { get; set; }

        [DisplayName("MD5L")]
        public string MD5L { get; set; }

        [DisplayName("SERIAL")]
        public string Serial { get; set; }

        [DisplayName("CODGRUPO")]
        public int? CodGrupo { get; set; }

        [DisplayName("GRUPO")]
        public string Grupo { get; set; }

        [DisplayName("FOTO")]
        public string Foto { get; set; }

        [DisplayName("TRIBUTACAO")]
        public string Tributacao { get; set; }

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

        [DisplayName("ISSMUNICIPIO")]
        public string ISSMunicipio { get; set; }

        [DisplayName("DADOSADICIONAIS")]
        public string DadosAdicionais { get; set; }

        [DisplayName("SITE")]
        public string Site { get; set; }

        [DisplayName("CODIGOPAIS")]
        public string CodigoPais { get; set; }

        [DisplayName("CSOSN")]
        public string CSOSN { get; set; }

        [DisplayName("PERCICMSPROPRIOST")]
        public decimal? PercICMSProprioST { get; set; }

        [DisplayName("PERCMVAORIGINAL")]
        public decimal? PercMVAOriginal { get; set; }

        [DisplayName("PERCICMSSTINTERNA")]
        public decimal? PercICMSSTInterna { get; set; }

        [DisplayName("PERCREDUCAOBCST")]
        public decimal? PercReducaoBCST { get; set; }

        [DisplayName("DESCRICAOCSOSN")]
        public string DescricaoCSOSN { get; set; }

        [DisplayName("CODIGOCSTORIGEM")]
        public string CodigoCSTOrigem { get; set; }

        [DisplayName("ORIGEM")]
        public string Origem { get; set; }

        [DisplayName("POSSUIICMSST")]
        public string PossuiICMSST { get; set; }

        [DisplayName("ISENTO")]
        public string Isento { get; set; }

        [DisplayName("TRIBUTADO")]
        public string Tributado { get; set; }

        [DisplayName("CODCSTORIGEM")]
        public string CodCSTOrigem { get; set; }

        [DisplayName("MENSAGEMFISCAL")]
        public string MensagemFiscal { get; set; }

        [DisplayName("CODTABELAPRECO")]
        public int? CodTabelaPreco { get; set; }

        [DisplayName("TABELAPRECO")]
        public string TabelaPreco { get; set; }

        [DisplayName("CODVENDEDOR")]
        public int? CodVendedor { get; set; }

        [DisplayName("VENDEDOR")]
        public string Vendedor { get; set; }

        [DisplayName("CODPARCELAPREDEFINIDA")]
        public int? CodParcelaPredefinida { get; set; }

        [DisplayName("PARCELAPREDEFINIDA")]
        public string ParcelaPredefinida { get; set; }

        [DisplayName("CODTRANSPORTADORA")]
        public int? CodTransportadora { get; set; }

        [DisplayName("TRANSPORTADORA")]
        public string Transportadora { get; set; }

        [DisplayName("VALORFRETE")]
        public decimal? ValorFrete { get; set; }

        [DisplayName("MD5O")]
        public string MD5O { get; set; }

        [DisplayName("SUFRAMA")]
        public string SUFRAMA { get; set; }

        [DisplayName("PERCFCP")]
        public decimal? PercFCP { get; set; }

        [DisplayName("PERCREDUCAOBC")]
        public decimal? PercReducaoBC { get; set; }

        [DisplayName("CSTCSOSNAPLICAR")]
        public string CSTCSOSNAPLICAR { get; set; }

        [DisplayName("SINCRONIZADO")]
        public string Sincronizado { get; set; }

        [DisplayName("UTILIZARCASHBACK")]
        public string UtilizarCashback { get; set; }

    }

    public class ClienteEntityTypeConfiguration : IEntityTypeConfiguration<Clientes>
    {
       public void Configure(EntityTypeBuilder<Clientes> builder)
        {
            builder.ToTable("TCLIENTE");
            builder.HasKey(e => e.Controle);
            builder.Property(e => e.Controle).HasColumnName("CONTROLE").IsRequired();
            builder.Property(e => e.Cliente).HasColumnName("CLIENTE");
            builder.Property(e => e.Endereco).HasColumnName("ENDERECO");
            builder.Property(e => e.Complemento).HasColumnName("COMPLEMENTO");
            builder.Property(e => e.Bairro).HasColumnName("BAIRRO");
            builder.Property(e => e.CodCidade).HasColumnName("CODCIDADE");
            builder.Property(e => e.Cidade).HasColumnName("CIDADE");
            builder.Property(e => e.UF).HasColumnName("UF");
            builder.Property(e => e.Pais).HasColumnName("PAIS");
            builder.Property(e => e.CEP).HasColumnName("CEP");
            builder.Property(e => e.Naturalidade).HasColumnName("NATURALIDADE");
            builder.Property(e => e.TipoCliente).HasColumnName("TIPOCLIENTE");
            builder.Property(e => e.RG).HasColumnName("RG");
            builder.Property(e => e.CPF).HasColumnName("CPF");
            builder.Property(e => e.CNPJ).HasColumnName("CNPJ");
            builder.Property(e => e.IE).HasColumnName("IE");
            builder.Property(e => e.IM).HasColumnName("IM");
            builder.Property(e => e.DataNascimento).HasColumnName("DATANASCIMENTO");
            builder.Property(e => e.DataHoraCadastro).HasColumnName("DATAHORACADASTRO");
            builder.Property(e => e.Pai).HasColumnName("PAI");
            builder.Property(e => e.Mae).HasColumnName("MAE");
            builder.Property(e => e.Telefone).HasColumnName("TELEFONE");
            builder.Property(e => e.Celular).HasColumnName("CELULAR");
            builder.Property(e => e.Email).HasColumnName("EMAIL");
            builder.Property(e => e.EstadoCivil).HasColumnName("ESTADOCIVIL");
            builder.Property(e => e.Ativo).HasColumnName("ATIVO");
            builder.Property(e => e.Fantasia).HasColumnName("FANTASIA");
            builder.Property(e => e.Obs).HasColumnName("OBS");
            builder.Property(e => e.LimiteCredito).HasColumnName("LIMITECREDITO");
            builder.Property(e => e.NomeConjuge).HasColumnName("NOMECONJUGE");
            builder.Property(e => e.DataUltimaVenda).HasColumnName("DATAULTIMAVENDA");
            builder.Property(e => e.DiasSemComprar).HasColumnName("DIASSEMCOMPRAR");
            builder.Property(e => e.CodConvenio).HasColumnName("CODCONVENIO");
            builder.Property(e => e.Convenio).HasColumnName("CONVENIO");
            builder.Property(e => e.Profissao).HasColumnName("PROFISSAO");
            builder.Property(e => e.EmpresaQueTrabalha).HasColumnName("EMPRESAQUETRABALHA");
            builder.Property(e => e.FoneTrabalho).HasColumnName("FONETRABALHO");
            builder.Property(e => e.RendaMensal).HasColumnName("RENDAMENSAL");
            builder.Property(e => e.TotalVendido).HasColumnName("TOTALVENDIDO");
            builder.Property(e => e.Nacionalidade).HasColumnName("NACIONALIDADE");
            builder.Property(e => e.Numero).HasColumnName("NUMERO");
            builder.Property(e => e.CodConsultasPC).HasColumnName("CODCONSULTASPC");
            builder.Property(e => e.Sexo).HasColumnName("SEXO");
            builder.Property(e => e.CodigoCidadeIBGE).HasColumnName("CODIGOCIDADEIBGE");
            builder.Property(e => e.CodEmitente).HasColumnName("CODEMITENTE");
            builder.Property(e => e.NomeContatoJuridica).HasColumnName("NOMECONTATOJURIDICA");
            builder.Property(e => e.Email2).HasColumnName("EMAIL2");
            builder.Property(e => e.Status).HasColumnName("STATUS");
            builder.Property(e => e.MD5L).HasColumnName("MD5L");
            builder.Property(e => e.Serial).HasColumnName("SERIAL");
            builder.Property(e => e.CodGrupo).HasColumnName("CODGRUPO");
            builder.Property(e => e.Grupo).HasColumnName("GRUPO");
            builder.Property(e => e.Foto).HasColumnName("FOTO");
            builder.Property(e => e.Tributacao).HasColumnName("TRIBUTACAO");
            builder.Property(e => e.Campo1).HasColumnName("CAMPO1");
            builder.Property(e => e.Campo2).HasColumnName("CAMPO2");
            builder.Property(e => e.Campo3).HasColumnName("CAMPO3");
            builder.Property(e => e.Campo4).HasColumnName("CAMPO4");
            builder.Property(e => e.Campo5).HasColumnName("CAMPO5");
            builder.Property(e => e.Campo6).HasColumnName("CAMPO6");
            builder.Property(e => e.Campo7).HasColumnName("CAMPO7");
            builder.Property(e => e.Campo8).HasColumnName("CAMPO8");
            builder.Property(e => e.Campo9).HasColumnName("CAMPO9");
            builder.Property(e => e.Campo10).HasColumnName("CAMPO10");
            builder.Property(e => e.ISSMunicipio).HasColumnName("ISSMUNICIPIO");
            builder.Property(e => e.DadosAdicionais).HasColumnName("DADOSADICIONAIS");
            builder.Property(e => e.Site).HasColumnName("SITE");
            builder.Property(e => e.CodigoPais).HasColumnName("CODIGOPAIS");
            builder.Property(e => e.CSOSN).HasColumnName("CSOSN");
            builder.Property(e => e.PercICMSProprioST).HasColumnName("PERCICMSPROPRIOST");
            builder.Property(e => e.PercMVAOriginal).HasColumnName("PERCMVAORIGINAL");
            builder.Property(e => e.PercICMSSTInterna).HasColumnName("PERCICMSSTINTERNA");
            builder.Property(e => e.PercReducaoBCST).HasColumnName("PERCREDUCAOBCST");
            builder.Property(e => e.DescricaoCSOSN).HasColumnName("DESCRICAOCSOSN");
            builder.Property(e => e.CodigoCSTOrigem).HasColumnName("CODIGOCSTORIGEM");
            builder.Property(e => e.Origem).HasColumnName("ORIGEM");
            builder.Property(e => e.PossuiICMSST).HasColumnName("POSSUIICMSST");
            builder.Property(e => e.Isento).HasColumnName("ISENTO");
            builder.Property(e => e.Tributado).HasColumnName("TRIBUTADO");
            builder.Property(e => e.CodCSTOrigem).HasColumnName("CODCSTORIGEM");
            builder.Property(e => e.MensagemFiscal).HasColumnName("MENSAGEMFISCAL");
            builder.Property(e => e.CodTabelaPreco).HasColumnName("CODTABELAPRECO");
            builder.Property(e => e.TabelaPreco).HasColumnName("TABELAPRECO");
            builder.Property(e => e.CodVendedor).HasColumnName("CODVENDEDOR");
            builder.Property(e => e.Vendedor).HasColumnName("VENDEDOR");
            builder.Property(e => e.CodParcelaPredefinida).HasColumnName("CODPARCELAPREDEFINIDA");
            builder.Property(e => e.ParcelaPredefinida).HasColumnName("PARCELAPREDEFINIDA");
            builder.Property(e => e.CodTransportadora).HasColumnName("CODTRANSPORTADORA");
            builder.Property(e => e.Transportadora).HasColumnName("TRANSPORTADORA");
            builder.Property(e => e.ValorFrete).HasColumnName("VALORFRETE");
            builder.Property(e => e.MD5O).HasColumnName("MD5O");
            builder.Property(e => e.SUFRAMA).HasColumnName("SUFRAMA");
            builder.Property(e => e.PercFCP).HasColumnName("PERCFCP");
            builder.Property(e => e.PercReducaoBC).HasColumnName("PERCREDUCAOBC");
            builder.Property(e => e.CSTCSOSNAPLICAR).HasColumnName("CSTCSOSNAPLICAR");
            builder.Property(e => e.Sincronizado).HasColumnName("SINCRONIZADO");
            builder.Property(e => e.UtilizarCashback).HasColumnName("UTILIZARCASHBACK");

        }
    }
}
