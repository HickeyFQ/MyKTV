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
    public partial class frmOrderBysongType : Form
    {
        public frmOrderBysongType()
        {
            InitializeComponent();
        }
        public int type = 0;
        /// <summary>
        /// 情歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            type = 2;
        }
        /// <summary>
        /// 民谣
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {
            type = 3;
        }
        /// <summary>
        ///流行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            type = 1;
        }
        /// <summary>
        /// 京剧
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label6_Click(object sender, EventArgs e)
        {
            type = 4;
        }
        /// <summary>
        /// 革命军歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label5_Click(object sender, EventArgs e)
        {
            type = 5;
        }
        /// <summary>
        /// 生日歌曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label4_Click(object sender, EventArgs e)
        {
            type = 6;
        }
    }
}
