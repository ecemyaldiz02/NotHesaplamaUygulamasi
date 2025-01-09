using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Hesaplama_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hesaplama_Click(object sender, EventArgs e)
        {
            double ortalama = (Convert.ToDouble(txt_BirinciNot.Text) + Convert.ToDouble(txt_IkinciNot.Text))/2;
            lbl_OrtSonuc.Text = ortalama.ToString();
        }
    }
}
