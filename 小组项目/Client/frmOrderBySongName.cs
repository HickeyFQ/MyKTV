using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmOrderBySongName : Form
    {
        public frmOrderBySongName()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 回删
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label43_Click(object sender, EventArgs e)
        {
            string name= this.lbl_name.Text;

            this.lbl_name.Text = name.Substring(0, name.Length - 1);
        }
        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label44_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text = "";
        }

        private void A_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "A";
        }

        private void B_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "B";
        
        }

        private void C_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "C";
        }

        private void D_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "D";
        }

        private void E_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "E";
        }

        private void F_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "F";
        }

        private void G_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "G";
        }

        private void H_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "H";
        }

        private void I_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "I";
        }

        private void J_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "J";
        }

        private void K_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "K";
        }

        private void L_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "L";
        }

        private void M_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "M";
        }

        private void N_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "N";
        }

        private void O_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "O";
        }

        private void P_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "P";
        }

        private void Q_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "Q";
        }

        private void R_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "R";
        }

        private void S_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "S";
        }

        private void T_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "T";
        }

        private void U_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "U";
        }

        private void V_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "V";
        }

        private void W_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "W";
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "X";
        }

        private void Y_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "Y";
        }

        private void Z_Click(object sender, EventArgs e)
        {
            this.lbl_name.Text += "Z";
        }
    }
}
