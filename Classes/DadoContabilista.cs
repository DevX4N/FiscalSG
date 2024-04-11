using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Fiscal.Classes
{
    public class DadoContabilista
    {
        [DisplayName("Código")]
        public int Controle { get; set; }
        [DisplayName("Nome")]
        public string NOME { get; set; }
      
        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("CRC")]
        public string CRC { get; set; }

        [DisplayName("CNPJ")]
        public string CNPJ {  get; set; }

        [DisplayName("CEP")]
        public string CEP { get; set; }

        [DisplayName("ENDERECO")]
        public string ENDERECO { get; set; }

        [DisplayName("NUMERO")]
        public string NUMERO {  get; set; }

        [DisplayName("COMPLEMENTO")]
        public string COMPLEMENTO { get; set; }

        [DisplayName("BAIRRO")]
        public string BAIRRO {  get; set; }

        [DisplayName("TELEFONE")]
        public string TELEFONE { get; set; }

        [DisplayName("FAX")]
        public string FAX {  get; set; }

        [DisplayName("EMAIL")]
        public string EMAIL {get; set; }

        [DisplayName("CODMUNCIPIO")]
        public string CODMUNCIPIO { get; set; }

        [DisplayName("CODCONTAANALITICA")]
        public string CODCONTAANALITICA { get; set; }

        public class DadoContabilistaEntityTypeConfiguration : IEntityTypeConfiguration<DadoContabilista>
        {
            public void Configure(EntityTypeBuilder<DadoContabilista> builder)
            {
                builder.ToTable("TDADOCONTABILISTA");

                builder.HasKey(e => e.Controle);

                builder.Property(e => e.Controle).HasColumnName("CONTROLE").IsRequired();

                builder.Property(e => e.NOME).HasColumnName("NOME");

                builder.Property(e => e.CNPJ).HasColumnName("CNPJ");

                builder.Property(e => e.CPF).HasColumnName("CPF");

                builder.Property(e => e.CRC).HasColumnName("CRC");

                builder.Property(e => e.CEP).HasColumnName("CEP");

                builder.Property(e => e.ENDERECO).HasColumnName("ENDERECO");

                builder.Property(e => e.NUMERO).HasColumnName("NUMERO");

                builder.Property(e => e.COMPLEMENTO).HasColumnName("COMPLEMENTO");

                builder.Property(e => e.BAIRRO).HasColumnName("BAIRRO");

                builder.Property(e => e.TELEFONE).HasColumnName("TELEFONE");

                builder.Property(e => e.FAX).HasColumnName("FAX");

                builder.Property(e => e.EMAIL).HasColumnName("EMAIL");

                builder.Property(e => e.CODMUNCIPIO).HasColumnName("CODMUNCIPIO");

                builder.Property(e => e.CODCONTAANALITICA).HasColumnName("CODCONTAANALITICA");
            }
        }

    }
}