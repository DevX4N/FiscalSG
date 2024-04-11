using Fiscal.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Remoting.Contexts;

namespace Fiscal
{
    public class Registro00
    {

        public SpedFiscal spedFiscal;
        // Função pra remover os caracteres especiais
        public static string SoNumeros(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            texto = Regex.Replace(texto, @"[^0-9]", "");

            return texto;
        }

        public void BlocosSped()
        {
          

            using (var context = new DataContext.Contexto())
            {
                DateTime DataIni = spedFiscal.dataInicial.Value;
                DateTime DataFim = spedFiscal.dataFinal.Value;
               

                var emit = context.Emitente.FirstOrDefault();
                var dadoContabilistas = context.DadoContabilista.FirstOrDefault();
                var fornecedores = context.Fornecedor.ToList();
                var estoque = context.Estoque.ToList();
              
                IQueryable<Compras> compras = context.Compras.Where(compra =>compra.DataRecebimento >= DataIni && compra.DataRecebimento <= DataFim);
                
                var Nfc = context.NFC.Where(NFC => NFC.DataEmissao >= DataIni && NFC.DataEmissao <= DataFim);

                var DadosVendaNF = context.NFE.Where(vendnfe => vendnfe.DataEmissao >= DataIni && vendnfe.DataEmissao <= DataFim);

                var Cliente = context.Clientes.AsQueryable();

                string registro00;

                #region Registro 0000

               

                registro00 = "|0000|";
                if(spedFiscal.arquivoOrige.Checked == true)
                {
                    registro00 += "0" + "|";
                } 
                else if (spedFiscal.arquivoSubs.Checked == true)
                {
                    registro00 += "1" + "|";
                }
                registro00 += spedFiscal.TextLeiaut.Text + "|";
                registro00 += DataIni.ToString("ddMMyyyy") + "|";
                registro00 += DataFim.ToString("ddMMyyyy") + "|";
                registro00 += emit.RAZAOSOCIAL + "|";
                registro00 += SoNumeros(emit.CNPJ) + "|";
                registro00 += emit.UF + "|";
                registro00 += emit.IE + "|";
                registro00 += emit.CNAE + "|";
                registro00 += emit.IM + "|";
                if(spedFiscal.perfilA.Checked == true)
                {
                    registro00 += "A" + "|";
                }
                else if(spedFiscal.perfilB.Checked == true)
                {
                    registro00 += "B" + "|";
                }
                else if(spedFiscal.perfilC.Checked == true)
                {
                    registro00 += "C" + "|";
                }

                registro00 += "" + "" + Environment.NewLine;

                #endregion

                #region Registro 0001

                registro00 += "|0001|" + "0|" + Environment.NewLine;

                #endregion

                #region Registro 0005

                registro00 += "|0005|" + emit.NOMEFANTASIA + "|";
                registro00 += SoNumeros(emit.CEP) + "|";
                registro00 += emit.ENDERECO + "|";
                registro00 += emit.NUMERO + "|";
                registro00 += emit.COMPLEMENTO + "|";
                registro00 += emit.BAIRRO + "|";
                registro00 += SoNumeros(emit.TELEFONE) + "|";
                registro00 += emit.EMAIL + "|" + Environment.NewLine;

                #endregion 

                #region Registro 0100

                registro00 += "|0100|" + dadoContabilistas.NOME + "|";
                registro00 += dadoContabilistas.CPF + "|";
                registro00 += dadoContabilistas.CRC + "|";
                registro00 += dadoContabilistas.CEP + "|";
                registro00 += dadoContabilistas.ENDERECO + "|";
                registro00 += dadoContabilistas.NUMERO + "|";
                registro00 += dadoContabilistas.COMPLEMENTO + "|";
                registro00 += dadoContabilistas.BAIRRO + "|";
                registro00 += dadoContabilistas.TELEFONE + "|";
                registro00 += dadoContabilistas.FAX + "|";
                registro00 += dadoContabilistas.EMAIL + "|";
                registro00 += dadoContabilistas.CODMUNCIPIO + "|";

                #endregion

                #region Registro 0150


                var comprasFornecedores = compras.Join(fornecedores, compra => compra.CodFornecedor, fornecedor => fornecedor.Controle, (compra, fornecedor) => new
                {
                    compra.DataEmissao,
                    fornecedor.Controle,
                    fornecedor.RazaoSocial,
                    fornecedor.CodigoPais,
                    fornecedor.CNPJ,
                    fornecedor.CPF,
                    fornecedor.IE,
                    fornecedor.CodigoCidadeIBGE,
                    fornecedor.Suframa,
                    fornecedor.Endereco,
                    fornecedor.Numero,
                    fornecedor.Complemento,
                    fornecedor.Bairro,
                    compra.Confirmada
                });

                foreach (var forn in compras)
                {
                    var fornecedor = context.Fornecedor.Where(f => f.Controle == forn.CodFornecedor).FirstOrDefault();
                    if(fornecedor != null) 
                    {
                        registro00 += "\n|150|" + fornecedor.Controle + "|" + fornecedor.RazaoSocial;
                        registro00 += "|" + fornecedor.CodigoPais + "|";
                        registro00 += SoNumeros(fornecedor.CNPJ) + "|";
                        registro00 += fornecedor.IE + "|";
                        registro00 += fornecedor.CodigoCidadeIBGE + "|";
                        registro00 += fornecedor.Endereco + "|";
                        registro00 += fornecedor.Numero + "|";
                        registro00 += fornecedor.Complemento + "|";
                        registro00 += fornecedor.Bairro + "|";
                    }
                }

               

                var SelectClieNF = DadosVendaNF.Join(Cliente, dadosVendaNF => dadosVendaNF.CodCliente, cliente => cliente.Controle, (dadosVendaNF, cliente) => new
                {
                    dadosVendaNF.DataEmissao,
                    cliente.Controle,
                    cliente.Cliente,
                    cliente.CodigoPais,
                    cliente.CNPJ,
                    cliente.CPF,
                    cliente.IE,
                    cliente.CodigoCidadeIBGE,
                    cliente.SUFRAMA,
                    cliente.Endereco,
                    cliente.Numero,
                    cliente.Complemento,
                    cliente.Bairro,
                    dadosVendaNF.StatusEnvio
                });

                foreach (var vendanf in DadosVendaNF)
                {
                    var clientes = context.Clientes.Where(c => c.Controle == vendanf.CodCliente).FirstOrDefault();
                    registro00 += "\n|150|" + clientes.Controle + "|" + clientes.Cliente;
                    registro00 += "|" + clientes.CodigoPais + "|";
                    registro00 += SoNumeros(clientes.CNPJ) + "|";
                    registro00 += clientes.IE + "|";
                    registro00 += clientes.CodigoCidadeIBGE + "|";
                    registro00 += clientes.Endereco + "|";
                    registro00 += clientes.Numero + "|";
                    registro00 += clientes.Complemento + "|";
                    registro00 += clientes.Bairro + "|";
                }


                var selectNfce = Nfc.Join(Cliente, NFC => NFC.CodCliente, Clientes => Clientes.Controle, (NFC, Clientes) => new
                {
                    NFC.DataEmissao,
                    Clientes.Controle,
                    Clientes.Cliente,
                    Clientes.CodigoPais,
                    Clientes.CNPJ,
                    Clientes.CPF,
                    Clientes.IE,
                    Clientes.CodigoCidadeIBGE,
                    Clientes.SUFRAMA,
                    Clientes.Endereco,
                    Clientes.Numero,
                    Clientes.Complemento,
                    Clientes.Bairro,
                    NFC.StatusEnvio
                });

                var distincSelectClieNFC = selectNfce.GroupBy(e => new
                {
                    e.Controle,
                    e.Cliente,
                    e.CodigoPais,
                    e.CNPJ,
                    e.CPF,
                    e.IE,
                    e.CodigoCidadeIBGE,
                    e.SUFRAMA,
                    e.Endereco,
                    e.Numero,
                    e.Complemento,
                    e.Bairro
                }).Select(group => group.FirstOrDefault());

                foreach (var vendanfc in Nfc)
                {
                    var clientes = context.Clientes.Where(c => c.Controle == vendanfc.CodCliente).FirstOrDefault();
                    registro00 += "\n|150|" + clientes.Controle + "|" + clientes.Cliente;
                    registro00 += "|" + clientes.CodigoPais + "|";
                    registro00 += SoNumeros(clientes.CNPJ) + "|";
                    registro00 += clientes.IE + "|";
                    registro00 += clientes.CodigoCidadeIBGE + "|";
                    registro00 += clientes.Endereco + "|";
                    registro00 += clientes.Numero + "|";
                    registro00 += clientes.Complemento + "|";
                    registro00 += clientes.Bairro + "|";
                }

                #endregion

                #region Registro 0200

                foreach (var DadosEstoque in estoque)
                {   
                    registro00 += "\n|0200|" + DadosEstoque.Controle + "|" + DadosEstoque.Produto + "|" + DadosEstoque.CodigoBarras + "" + "|" +DadosEstoque.Unidade + "|";
                    registro00 += DadosEstoque.CodigoAplicacaoProduto + "|" + DadosEstoque.NCM + "" + "" + "" + DadosEstoque.AliquotaICMSECF + "|" + DadosEstoque.CEST + "|";
                }

                #endregion

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "Arquivo de testo (*.txt)|.txt";
                saveFileDialog1.Title = "Salvar Arquivo SPED";
                saveFileDialog1.FileName = "SPED" + DateTime.Now.ToString("yyyyMMdd");
                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivo = saveFileDialog1.FileName;
                    try
                    {

                        File.WriteAllText(caminhoArquivo, registro00);

                        MessageBox.Show("SPED gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao gerar o arquivo SPED:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
