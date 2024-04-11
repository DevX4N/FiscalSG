using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiscal.Classes;


namespace Fiscal
{
    public partial class Contabilista : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeft,
        int nTop,
        int nRigth,
        int nBottom,
        int nWidthEllipse,
        int nHeightEllipse
    );

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwn, int attr, int[] attrValue, int attriSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
            {
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            }
        }

        public Contabilista()
        {
            InitializeComponent();
        }



        private void Contabilista_Load(object sender, EventArgs e)
        {
            btnContabilistaGravar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnContabilistaGravar.Width, btnContabilistaGravar.Height, 7, 7));

            using (var dc = new DataContext.Contexto())
            {
                var dados = dc.DadoContabilista.FirstOrDefault();

                txtNomeContador.Text = dados.NOME;
                txtContadorCNPJ.Text = dados.CNPJ;
                txtCPFContador.Text = dados.CPF;
                txtContadorCRC.Text = dados.CRC;
                txtContadorCep.Text = dados.CEP;
                txtContadorEndereco.Text = dados.ENDERECO;
                txtContadorNumero.Text = dados.NUMERO;
                txtContadorComple.Text = dados.COMPLEMENTO;
                txtContadorTel.Text = dados.TELEFONE;
                txtContadorFax.Text = dados.FAX;
                txtContadorEmail.Text = dados.EMAIL;
                txtContadorIBGE.Text = dados.CODMUNCIPIO;
                txtContadorCAnalitica.Text = dados.CODCONTAANALITICA;

            }
        }
        private void btnContabilistaGravar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
