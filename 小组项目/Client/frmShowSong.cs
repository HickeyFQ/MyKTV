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
    public partial class frmShowSong : Form
    {
        public frmShowSong()
        {
            InitializeComponent();
        }

        public static int i = 0;
        DataSet ds = new DataSet();
        public string sql = string.Format("select s.song_name,singer_info.singer_name FROM song_info s ,singer_info where s.singer_id=singer_info.singer_id  and songtype_id={0}", i);
        
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmShowSong_Load(object sender, EventArgs e)
        {
            
            BindSong();
        }
        /// <summary>
        /// 输出歌曲
        /// </summary>
        private void BindSong()
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql,DBHelper.Conn);
           
            adapter.Fill(ds,"Info");
            DataView dv = new DataView(ds.Tables["Info"]);
            if (dv.Count==0)
            {
                MessageBox.Show("您要查找的歌曲尚未添加");
            } 
            dgvInfo.DataSource = ds.Tables["Info"];
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 双击 添加歌曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInfo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string songName= dgvInfo.SelectedRows[0].Cells[0].Value.ToString();
            Playsong song = new Playsong();
            song.ADD(songName);
        }
    }
}
