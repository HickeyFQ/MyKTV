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
        private bool voo = false;//标识 播放器
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            voo = false;
        }
        /// <summary>
        /// 歌曲名称点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSongName_Click(object sender, EventArgs e)
        {
            frmOrderBySongName name = new frmOrderBySongName();
            name.ShowDialog();
        }
        /// <summary>
        /// 语种点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTypename_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// 歌曲排行点歌
        /// </summary>  
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void  btnPlay_Click(object sender, EventArgs e)
        {

        }
        /// <   summary>
        /// 单击 Main_Player 播放器
        /// 使其最大化转接到  全屏播放界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_player_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            frmPlay play = new frmPlay();
            play.ShowDialog();
            //if (voo == true)
            //{
            //    Main_player.fullScreen = false;//是否全屏
            //}
            //else if (voo == false)
            //{
            //    Main_player.fullScreen = true;//是否全屏
            //}

        }
    }
}
