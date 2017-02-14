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
        frmShowSong songInfo = new frmShowSong();
        
        /// <summary>
        /// 情歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
             frmShowSong.i = 2;
            songInfo.ShowDialog();
        }
        /// <summary>
        /// 民谣
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {
            frmShowSong.i = 3;
            songInfo.ShowDialog();
        }
        /// <summary>
        ///流行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            frmShowSong.i = 1;
            songInfo.ShowDialog();
        }
        /// <summary>
        /// 京剧
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label6_Click(object sender, EventArgs e)
        {
            frmShowSong.i = 4;
            songInfo.ShowDialog();
        }
        /// <summary>
        /// 革命军歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label5_Click(object sender, EventArgs e)
        {
            frmShowSong.i = 5;
            songInfo.ShowDialog();
        }
        /// <summary>
        /// 生日歌曲
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label4_Click(object sender, EventArgs e)
        {
            frmShowSong.i = 6;
            songInfo.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.ShowDialog();
        }
    }
}
