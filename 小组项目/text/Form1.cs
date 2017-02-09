using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
           
            player.Ctlcontrols.play();//歌曲播放
            
        }
        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            player.URL = @"D:\FFOutput\c8fe7b35c6f25299f67bf0f03e66a16a-f4v-h264-aac-259.mp4";
        }
        /// <summary>
        /// 暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text=="播放")
            {
                player.Ctlcontrols.play();//播放
                button2.Text = "暂停";
            }
            else if (button2.Text=="暂停")
            {
                player.Ctlcontrols.pause();//暂停
                button2.Text = "播放";
            }
            
        }
        /// <summary>
        /// 音量加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            player.settings.volume++;
            this.label1.Text = player.settings.volume.ToString();
        }
        /// <summary>
        /// 音量减
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            player.settings.volume--;
            this.label1.Text = player.settings.volume.ToString();
        }
        /// <summary>
        /// 重播
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();//停止
            player.Ctlcontrols.play();//播放

        }
        /// <summary>
        /// 静音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            player.settings.mute = true;//是否静音
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.fullScreen = true;//是否全屏
        }
    }
}
