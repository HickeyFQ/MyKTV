using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
        /// <summary>
        /// 文本改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_name_Enter(object sender, EventArgs e)
        {
            Bindinfo();
        }
        static DataSet ds = new DataSet();
        DataView dv = new DataView( ds.Tables["Info"]);
        int a=0; //标记查询总页数
        int temp = 0;//标记当前是多少页
        private void Bindinfo()
        {
            string sql = string.Format("  select ss.song_name,s.singer_name from song_info ss,singer_info s where ss.singer_id=s.singer_id andsong_ab='{0}'",lbl_name.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(sql,DBHelper.Conn);
            //清空重新填充
            if (ds.Tables["Info"] !=null)  
            {
                ds.Tables["Info"].Clear();
            }
            adapter.Fill(ds, "Info");
            
            a = dv.Count % 6+1;

            for (int i = 0; i < 6; i++)
            {
                lbl_name1.Text = ds.Tables["Info"].Rows[i][0].ToString();
                lbl_singer1.Text = ds.Tables["Info"].Rows[i][1].ToString();

            }
            lbl_ye.Text = string.Format("第{0}/{1}页",1,a);

        }

        private void label40_Click(object sender, EventArgs e)
        {
            temp++; //页数增加
            for (int i = 6*temp; i < 6*temp; i++)
            {
                lbl_name1.Text = ds.Tables["Info"].Rows[i][0].ToString();
                lbl_singer1.Text = ds.Tables["Info"].Rows[i][1].ToString();
            }
            lbl_ye.Text = string.Format("第{0}/{1}页", temp, a);
        }
        #region 添加
        Playsong song = new Playsong();
        /// <summary>
        /// 添加歌曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbl_name1_Click(object sender, EventArgs e)
        {
            song.ADD(lbl_name1.Text);
        }
        #endregion

        private void lbl_name2_Click(object sender, EventArgs e)
        {
            song.ADD(lbl_name2.Text);
        }

        private void lbl_name3_Click(object sender, EventArgs e)
        {
            song.ADD(lbl_name3.Text);
        }

        private void lbl_name4_Click(object sender, EventArgs e)
        {
            song.ADD(lbl_name4.Text);
        }

        private void lbl_name5_Click(object sender, EventArgs e)
        {
            song.ADD(lbl_name5.Text);
        }

        private void lbl_name6_Click(object sender, EventArgs e)
        {
            song.ADD(lbl_name6.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.ShowDialog();
        }
    }
}
