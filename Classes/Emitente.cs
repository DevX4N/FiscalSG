using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal.Classes
{
    public class Emitente
    {

        [DisplayName("Código")]
        public int? Controle { get; set; }

        [DisplayName("NOMEFANTASIA")]
        public string NOMEFANTASIA { get; set; }

        [DisplayName("RAZAOSOCIAL")]
        public string RAZAOSOCIAL { get; set; }

        [DisplayName("ENDERECO")]
        public string ENDERECO { get; set; }

        [DisplayName("COMPLEMENTO")]
        public string COMPLEMENTO { get; set; }

        [DisplayName("BAIRRO")]
        public string BAIRRO { get; set; }

        [DisplayName("CODCIDADE")]
        public int? CODCIDADE { get; set; }

        [DisplayName("CIDADE")]
        public string CIDADE { get; set; }

        [DisplayName("UF")]
        public string UF { get; set; }

        [DisplayName("CEP")]
        public string CEP { get; set; }

        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }

        [DisplayName("IE")]
        public string IE { get; set; }

        [DisplayName("IM")]
        public string IM { get; set; }

        [DisplayName("DATAHORACADASTRO")]
        public DateTime? DATAHORACADASTRO { get; set; }

        [DisplayName("OBS")]
        public string OBS { get; set; }

        [DisplayName("TELEFONE")]
        public string TELEFONE { get; set; }

        [DisplayName("CELULAR")]
        public string CELULAR { get; set; }

        [DisplayName("EMAIL")]
        public string EMAIL { get; set; }

        [DisplayName("FAX")]
        public string FAX { get; set; }

        [DisplayName("ATIVIDADE")]
        public string ATIVIDADE { get; set; }

        [DisplayName("CNAE")]
        public string CNAE { get; set; }

        [DisplayName("CRT")]
        public string CRT { get; set; }

        [DisplayName("DATAFUNDACAOEMPRESA")]
        public DateTime? DATAFUNDACAOEMPRESA { get; set; }

        [DisplayName("LOGOTIPO")]
        public string LOGOTIPO { get; set; }


        [DisplayName("PAIS")]
        public string PAIS { get; set; }

        [DisplayName("NUMERO")]
        public string NUMERO { get; set; }

        [DisplayName("PERCICMS")]
        public decimal? PERCICMS { get; set; }

        [DisplayName("CODICMS")]
        public string CODICMS { get; set; }

        [DisplayName("CODCIDADEIBGE")]
        public string CODCIDADEIBGE { get; set; }

        [DisplayName("DATAMOVIMENTO")]
        public DateTime? DATAMOVIMENTO { get; set; }

        [DisplayName("HORAPRIMEIRODOCUMENTOECF")]
        public TimeSpan? HORAPRIMEIRODOCUMENTOECF { get; set; }

        [DisplayName("SUFRAMA")]
        public string SUFRAMA { get; set; }

        [DisplayName("SERIEECF")]
        public string SERIEECF { get; set; }

        [DisplayName("MARCAECF")]
        public string MARCAECF { get; set; }

        [DisplayName("MODELOECF")]
         public string MODELOECF { get; set; }

        [DisplayName("TIPOECF")]
        public string TIPOECF { get; set; }

        [DisplayName("MD5")]
        public string MD5 { get; set; }

        [DisplayName("VERIFICADORFB")]
        public string VERIFICADORFB { get; set; }

        [DisplayName("DATAHORAVERIFICACAORFB")]
        public DateTime? DATAHORAVERIFICACAORFB { get; set; }

        [DisplayName("CAPTCHARFB")]
        public string CAPTCHARFB { get; set; }

        [DisplayName("RETORNORFB")]
        public string RETORNORFB { get; set; }

        [DisplayName("AUTORIZADOUSO")]
        public string AUTORIZADOUSO { get; set; }

        [DisplayName("MD5CNPJRAZAOUFRFB")]
        public string MD5CNPJRAZAOUFRFB { get; set; }

        [DisplayName("SERIALINSTALADO")]
        public string SERIALINSTALADO { get; set; }

        [DisplayName("ALIQUOTAISSQN")]
        public decimal? ALIQUOTAISSQN { get; set; }

        [DisplayName("CODIMPOSTOISS")]
        public int? CODIMPOSTOISS { get; set; }

        [DisplayName("NOTALEGALDF")]
        public string NOTALEGALDF { get; set; }

        [DisplayName("E3SERIEECF")]
        public string E3SERIEECF { get; set; }

        [DisplayName("E3TIPOECF")]
        public string E3TIPOECF { get; set; }

        [DisplayName("E3MARCAECF")]
        public string E3MARCAECF { get; set; }

        [DisplayName("E3MODELOECF")]
        public string E3MODELOECF { get; set; }

        [DisplayName("ATACADOEVAREJO")]
        public string ATACADOEVAREJO { get; set; }

        [DisplayName("MD5BOS")]
        public string MD5BOS { get; set; }

        [DisplayName("MD5P")]
        public string MD5P { get; set; }

        [DisplayName("MD5L")]
        public string MD5L { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("MD5V")]
        public string MD5V { get; set; }

        [DisplayName("RNTRC")]
        public string RNTRC { get; set; }

        [DisplayName("REGIMETRIBUTARIOISSQN")]
        public string REGIMETRIBUTARIOISSQN { get; set; }

        [DisplayName("MD5B")]
        public string MD5B { get; set; }

        [DisplayName("SITE")]
        public string SITE { get; set; }

        [DisplayName("CNPJCONTADOR")]
        public string CNPJCONTADOR { get; set; }

        [DisplayName("VERSAOSERVIDOR")]
        public string VERSAOSERVIDOR { get; set; }

        [DisplayName("RELEASESERVIDOR")]
        public string RELEASESERVIDOR { get; set; }

        [DisplayName("CHAVEPP")]
        public string CHAVEPP { get; set; }

        [DisplayName("CONTROLESG")]
        public string CONTROLESG { get; set; }

        [DisplayName("MD5PAF")]
        public string MD5PAF { get; set; }

        [DisplayName("OC")]
        public string OC { get; set; }

        [DisplayName("DATAIE")]
        public DateTime? DATAIE { get; set; }

        [DisplayName("SITE2")]
        public string SITE2 { get; set; }

        [DisplayName("NUMEROCREDENCIAMENTO")]
        public string NUMEROCREDENCIAMENTO { get; set; }

        [DisplayName("POSSUIIESUBSTITUTO")]
        public string POSSUIIESUBSTITUTO { get; set; }

        [DisplayName("ATUALIZARESTOQUE")]
        public string ATUALIZARESTOQUE { get; set; }

        [DisplayName("COMPARANDO")]
        public string COMPARANDO { get; set; }

        [DisplayName("ESTABELECIMENTOUNICO")]
        public string ESTABELECIMENTOUNICO { get; set; }

        [DisplayName("MD5CAD")]
        public string MD5CAD { get; set; }

        [DisplayName("ATUALIZARDATAVENDACOMPRA")]
        public string ATUALIZARDATAVENDACOMPRA { get; set; }

        [DisplayName("RESERVARPRODALUGUELCONDI")]
        public string RESERVARPRODALUGUELCONDI { get; set; }

        [DisplayName("ATUALIZARESTOQUEPARCIAL")]
        public string ATUALIZARESTOQUEPARCIAL { get; set; }

        [DisplayName("UTILIZARBAIXAMP")]
        public string UTILIZARBAIXAMP { get; set; }

        [DisplayName("NUMLICENCA")]
        public string NUMLICENCA { get; set; }

        [DisplayName("NUMAUTESPECIAL")]
        public string NUMAUTESPECIAL { get; set; }

        [DisplayName("NUMAUTFUNCIONAMENTO")]
        public string NUMAUTFUNCIONAMENTO { get; set; }

        [DisplayName("MD5I")]
        public string MD5I { get; set; }

        [DisplayName("SINCRONIZADO")]
        public string SINCRONIZADO { get; set; }

        [DisplayName("CODATIVIDADE")]
        public int? CODATIVIDADE { get; set; }

        [DisplayName("EMPRESAUUIDTEF")]
        public string EMPRESAUUIDTEF { get; set; }

        public class EmitenteEntityTypeConfiguration :
            IEntityTypeConfiguration<Emitente>
        {
            public void Configure(EntityTypeBuilder<Emitente> builder)
            {
                builder.ToTable("TEMITENTE");

                builder.HasKey(b =>  b.Controle);

                builder.Property(b => b.Controle).HasColumnName("CONTROLE").IsRequired();

                builder.Property(b => b.NOMEFANTASIA).HasColumnName("NOMEFANTASIA").IsRequired();

                builder.Property(b => b.RAZAOSOCIAL).HasColumnName("RAZAOSOCIAL").IsRequired();

                builder.Property(b => b.ENDERECO).HasColumnName("ENDERECO");

                builder.Property(b => b.COMPLEMENTO).HasColumnName("COMPLEMENTO");

                builder.Property(b => b.BAIRRO).HasColumnName("BAIRRO");

                builder.Property(b => b.CODCIDADE).HasColumnName("CODCIDADE");

                builder.Property(b => b.CIDADE).HasColumnName("CIDADE");

                builder.Property(b => b.UF).HasColumnName("UF");

                builder.Property(b => b.CEP).HasColumnName("CEP");

                builder.Property(b => b.CNPJ).HasColumnName("CNPJ");

                builder.Property(b => b.IE).HasColumnName("IE");
                
                builder.Property(b => b.IM).HasColumnName("IM");

                builder.Property(b => b.DATAHORACADASTRO).HasColumnName("DATAHORACADASTRO");

                builder.Property(b => b.OBS).HasColumnName("OBS");

                builder.Property(b => b.TELEFONE).HasColumnName("TELEFONE");

                builder.Property(b => b.CELULAR).HasColumnName("CELULAR");

                builder.Property(b => b.EMAIL).HasColumnName("EMAIL");

                builder.Property(b => b.FAX).HasColumnName("FAX");

                builder.Property(b => b.ATIVIDADE).HasColumnName("ATIVIDADE");

                builder.Property(b => b.CNAE).HasColumnName("CNAE");

                builder.Property(b => b.CRT).HasColumnName("CRT");

                builder.Property(b => b.DATAFUNDACAOEMPRESA).HasColumnName("DATAFUNDACAOEMPRESA");

                builder.Property(b => b.LOGOTIPO).HasColumnName("LOGOTIPO");

                builder.Property(b => b.PAIS).HasColumnName("PAIS");

                builder.Property(b => b.NUMERO).HasColumnName("NUMERO");

                builder.Property(b => b.PERCICMS).HasColumnName("PERCICMS");

                builder.Property(b => b.CODICMS).HasColumnName("CODICMS");

                builder.Property(b => b.CODCIDADEIBGE).HasColumnName("CODCIDADEIBGE");

                builder.Property(b => b.DATAMOVIMENTO).HasColumnName("DATAMOVIMENTO");

                builder.Property(b => b.HORAPRIMEIRODOCUMENTOECF).HasColumnName("HORAPRIMEIRODOCUMENTOECF");

                builder.Property(b => b.SUFRAMA).HasColumnName("SUFRAMA");

                builder.Property(b => b.SERIEECF).HasColumnName("SERIEECF");

                builder.Property(b => b.MARCAECF).HasColumnName("MARCAECF");

                builder.Property(b => b.MODELOECF).HasColumnName("MODELOECF");

                builder.Property(b => b.TIPOECF).HasColumnName("TIPOECF");

                builder.Property(b => b.MD5).HasColumnName("MD5");

                builder.Property(b => b.VERIFICADORFB).HasColumnName("VERIFICADORFB");

                builder.Property(b => b.DATAHORAVERIFICACAORFB).HasColumnName("DATAHORAVERIFICACAORFB");

                builder.Property(b => b.CAPTCHARFB).HasColumnName("CAPTCHARFB")
                     ;
                builder.Property(b => b.RETORNORFB).HasColumnName("RETORNORFB");

                builder.Property(b => b.AUTORIZADOUSO).HasColumnName("AUTORIZADOUSO");

                builder.Property(b => b.MD5CNPJRAZAOUFRFB).HasColumnName("MD5CNPJRAZAOUFRFB");

                builder.Property(b => b.SERIALINSTALADO).HasColumnName("SERIALINSTALADO");

                builder.Property(b => b.ALIQUOTAISSQN).HasColumnName("ALIQUOTAISSQN");

                builder.Property(b => b.CODIMPOSTOISS).HasColumnName("CODIMPOSTOISS");

                builder.Property(b => b.NOTALEGALDF).HasColumnName("NOTALEGALDF");

                builder.Property(b => b.E3SERIEECF).HasColumnName("E3SERIEECF");

                builder.Property(b => b.E3TIPOECF).HasColumnName("E3TIPOECF");

                builder.Property(b => b.E3MODELOECF).HasColumnName("E3MODELOECF");

                builder.Property(b => b.ATACADOEVAREJO).HasColumnName("ATACADOEVAREJO");

                builder.Property(b => b.MD5BOS).HasColumnName("MD5BOS");

                builder.Property(b => b.MD5P).HasColumnName("MD5P");

                builder.Property(b => b.MD5L).HasColumnName("MD5L");

                builder.Property(b => b.CPF).HasColumnName("CPF");

                builder.Property(b => b.MD5V).HasColumnName("MD5V");

                builder.Property(b => b.RNTRC).HasColumnName("RNTRC");

                builder.Property(b => b.REGIMETRIBUTARIOISSQN).HasColumnName("REGIMETRIBUTARIOISSQN");

                builder.Property(b => b.MD5B).HasColumnName("MD5B");

                builder.Property(b => b.CNPJCONTADOR).HasColumnName("CNPJCONTADOR");

                builder.Property(b => b.VERSAOSERVIDOR).HasColumnName("VERSAOSERVIDOR");

                builder.Property(b => b.RELEASESERVIDOR).HasColumnName("RELEASESERVIDOR");

                builder.Property(b => b.CHAVEPP).HasColumnName("CHAVEPP");

                builder.Property(b => b.CONTROLESG).HasColumnName("CONTROLESG");

                builder.Property(b => b.MD5PAF).HasColumnName("MD5PAF");

                builder.Property(b => b.OC).HasColumnName("OC");

                builder.Property(b => b.DATAIE).HasColumnName("DATAIE");

                builder.Property(b => b.SITE2).HasColumnName("SITE2");

                builder.Property(b => b.NUMAUTFUNCIONAMENTO).HasColumnName("NUMAUTFUNCIONAMENTO");

                builder.Property(b => b.POSSUIIESUBSTITUTO).HasColumnName("POSSUIIESUBSTITUTO");

                builder.Property(b => b.ATUALIZARDATAVENDACOMPRA).HasColumnName("ATUALIZARDATAVENDACOMPRA");

                builder.Property(b => b.RESERVARPRODALUGUELCONDI).HasColumnName("RESERVARPRODALUGUELCONDI");

                builder.Property(b => b.ATUALIZARESTOQUEPARCIAL).HasColumnName("ATUALIZARESTOQUEPARCIAL");

                builder.Property(b => b.UTILIZARBAIXAMP).HasColumnName("UTILIZARBAIXAMP");

                builder.Property(b => b.NUMLICENCA).HasColumnName("NUMLICENCA");

                builder.Property(b => b.NUMAUTESPECIAL).HasColumnName("NUMAUTESPECIAL");

                builder.Property(b => b.MD5I).HasColumnName("MD5I");

                builder.Property(b => b.SINCRONIZADO).HasColumnName("SINCRONIZADO");

                builder.Property(b => b.CODATIVIDADE).HasColumnName("CODATIVIDADE");

                builder.Property(b => b.EMPRESAUUIDTEF).HasColumnName("EMPRESAUUIDTEF");
               
            }
        }
    }
}