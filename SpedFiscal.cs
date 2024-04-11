using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace Fiscal
{
    public partial class SpedFiscal : Form
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

        public SpedFiscal()
        {
            InitializeComponent();
        }


        private void SpedFiscal_Load(object sender, EventArgs e)
        {
            btnConfirmSped.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnConfirmSped.Width, btnConfirmSped.Height, 10, 10));
        }

        private void btnConfirmSped_Click(object sender, EventArgs e)
        {
            Registro00 registro0000 = new Registro00();
            registro0000.spedFiscal = this;
            registro0000.BlocosSped();
            
        }
    }
}

