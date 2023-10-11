using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taksit_Satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double fiyat=0, toplamTutar=0, taksitTutar=0;

            fiyat=Convert.ToDouble(txtFiyat.Text);

            if (rb0.Checked)
            {
                toplamTutar = fiyat;
                taksitTutar = toplamTutar/1;
            }
            else if (rb2.Checked)
            {
                toplamTutar = fiyat * 1.02;
                taksitTutar = toplamTutar / 2;
            }
            else if(rb6.Checked)
            {
                toplamTutar = fiyat * 1.04;
                taksitTutar = toplamTutar / 6;
            }
            else if (rb9.Checked)
            {
                toplamTutar = fiyat * 1.07;
                taksitTutar = toplamTutar / 9;
            }
            else if (rb12.Checked)
            {
                toplamTutar = fiyat * 1.1;
                taksitTutar = toplamTutar / 12;
            }

            lblTutar.Text = "Toplam Tutar: " + toplamTutar;
            lblTaksit.Text = "Taksit: " + taksitTutar;


        }
    }
}
