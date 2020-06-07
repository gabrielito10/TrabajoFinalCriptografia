using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCriptografia
{
    public partial class frmHash : Form
    {
        AlgoritmoDeEncriptado obj = new AlgoritmoDeEncriptado();
        public frmHash()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            SALT.Text = obj.SALT();
            MD5.Text = obj.MD5(txtMensaje.Text);
            SHA1.Text = obj.SHA1(txtMensaje.Text);
            SHA256.Text = obj.SHA256(txtMensaje.Text);
            SHA384.Text = obj.SHA384(txtMensaje.Text);
            SHA512.Text = obj.SHA512(txtMensaje.Text);
            CIFRADO.Text = obj.SHA512((SALT.Text + (MD5.Text)));

        }
    }
}
