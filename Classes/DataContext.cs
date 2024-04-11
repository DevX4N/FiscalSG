using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using FirebirdSql.Data.FirebirdClient;
using static Fiscal.Classes.DadoContabilista;
using static Fiscal.Classes.Emitente;


namespace Fiscal.Classes
{
    public class DataContext : DbContext
    {
        public class ConnectionParams
        {
            public string ConnectionString()
            {
                return $"DataSource=localhost;Database=C:\\SGBR\\Master\\BD\\BASESGMASTER_BET.FDB;Port=3050;User=SYSDBA;Password=masterkey;Charset=UTF8;Dialect=3;Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000";
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new DadoContabilistaEntityTypeConfiguration().Configure(modelBuilder.Entity<DadoContabilista>());


            new EmitenteEntityTypeConfiguration().Configure
                (modelBuilder.Entity<Emitente>());

            new FornecedorEntityTypeConfiguration().Configure
                (modelBuilder.Entity<Fornecedor>());

            new ComprasEntityTypeConfiguration().Configure
                (modelBuilder.Entity<Compras>());

            new NFCEntityTypeConfiguration().Configure
                (modelBuilder.Entity<NFC>());

            new NFEEntityTypeConfiguration().Configure
                (modelBuilder.Entity<NFE>());

            new ClienteEntityTypeConfiguration().Configure
              (modelBuilder.Entity<Clientes>());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseFirebird($"DataSource=localhost;Database=C:\\SGBR\\Master\\BD\\BASESGMASTER_BET.FDB;Port=3050;User=SYSDBA;Password=masterkey;Charset=UTF8;Dialect=3;" +
                $"Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000");

        public class Contexto : DbContext
        {
            public DbSet<Emitente> Emitente { get; set; }
            public DbSet<DadoContabilista> DadoContabilista { get; set; }
            public DbSet<Fornecedor> Fornecedor { get; set; }
            public DbSet<Estoque> Estoque { get; set; }
            public DbSet<Compras> Compras { get; set; }
            public DbSet<NFC> NFC { get; set; }
            public DbSet<NFE> NFE { get; set; }
            public DbSet<Clientes> Clientes { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                new DadoContabilistaEntityTypeConfiguration().Configure(modelBuilder.Entity<DadoContabilista>());

                new EmitenteEntityTypeConfiguration().Configure(modelBuilder.Entity<Emitente>());

                new FornecedorEntityTypeConfiguration().Configure(modelBuilder.Entity<Fornecedor>());

                new EstoqueEntityConfiguration().Configure(modelBuilder.Entity<Estoque>());

                new ComprasEntityTypeConfiguration().Configure(modelBuilder.Entity<Compras>());

                new NFCEntityTypeConfiguration().Configure(modelBuilder.Entity<NFC>());

                new NFEEntityTypeConfiguration().Configure(modelBuilder.Entity<NFE>());

                new ClienteEntityTypeConfiguration().Configure(modelBuilder.Entity<Clientes>());

            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder.UseFirebird($"DataSource=localhost;Database=C:\\SGBR\\Master\\BD\\BASESGMASTER_BET.FDB;Port=3050;User=SYSDBA;Password=masterkey" +
                    $";Charset=UTF8;Dialect=3;Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000");

        }
    }
}
