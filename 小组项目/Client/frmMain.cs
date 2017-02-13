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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 拼音点歌
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label6_Click(object sender, EventArgs e)
        {
            frmOrderBySongName name = new frmOrderBySongName();
            name.ShowDialog();
        }
        /// <summary>
        /// 歌星点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label7_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 分类点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label8_Click(object sender, EventArgs e)
        {
            frmOrderBysongType type = new frmOrderBysongType();
            type.ShowDialog();
        }
        /// <summary>
        /// 语种点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label9_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ＤＩＳＣＯ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label5_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 歌曲排行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 手写点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 其他
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 重播
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label20_Click(object sender, EventArgs e)
        {
            main_player.Ctlcontrols.stop();
            main_player.Ctlcontrols.play();
        }
        /// <summary>
        /// 暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label21_Click(object sender, EventArgs e)
        {
            main_player.Ctlcontrols.pause();
        }
        /// <summary>
        /// 切歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label22_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 音量减
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label24_Click(object sender, EventArgs e)
        {
            main_player.settings.volume -= 5;
        }
        /// <summary>
        /// 音量加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label25_Click(object sender, EventArgs e)
        {
            main_player.settings.volume += 5;
        }
        /// <summary>
        /// 静音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label23_Click(object sender, EventArgs e)
        {
            if (lblJing.Text == "静音")
            {
                main_player.settings.mute = false;
                lblJing.ForeColor = Color.Red;
            }
            else if (lblJing.ForeColor == Color.Red) {

                main_player.settings.mute = true;
                lblJing.ForeColor = Color.Black;
            }
            
        }
        /// <summary>
        /// 主菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label23_Click_1(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            main_player.URL = "";
        }
    }
}
