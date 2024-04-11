using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Fiscal
{


    public partial class Fiscal : Form
    {
        public string connectionString;

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

        public Fiscal()
        {
            InitializeComponent();
        }



        private void Fiscal_Load(object sender, EventArgs e)
        {
            btnContabilista.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnContabilista.Width, btnContabilista.Height, 7, 7));

            btnConfig.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnConfig.Width, btnConfig.Height, 7, 7));

            btnSair.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSair.Width, btnSair.Height, 7, 7));

            btnSintegra.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSintegra.Width, btnSintegra.Height, 10, 10));

            btnSpedFiscal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSpedFiscal.Width, btnSpedFiscal.Height, 10, 10));

            btnSpedContribuicoes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSpedContribuicoes.Width, btnSpedContribuicoes.Height, 10, 10));

            btnLcdpr.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLcdpr.Width, btnLcdpr.Height, 10, 10));

        }

        private void btnContabilista_Click(object sender, EventArgs e)
        {
            Contabilista contabilista = new Contabilista();
            contabilista.ShowDialog();
        }


        private void btnSpedFiscal_Click(object sender, EventArgs e)
        {
            SpedFiscal spedFiscal = new SpedFiscal();
            spedFiscal.ShowDialog();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSintegra_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Em desenvolvimento!");
            }
            catch
            {

            }
        }

        private void btnSpedContribuicoes_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Em desenvolvimento!");
            }
            catch
            {

            }
        }

        private void btnLcdpr_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Em desenvolvimento!");
            }
            catch
            {

            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Em desenvolvimento!");
            }
            catch
            {

            }
        }
    }
}
