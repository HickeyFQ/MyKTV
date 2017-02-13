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

namespace text
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string sqlstr = "Data Source=.;Initial Catalog=MyKTV;Integrated Security=True";
        private void Form2_Load(object sender, EventArgs e)
        {
            BingInfo();
        }
        DataSet ds = new DataSet();
        private void BingInfo()
        {
            SqlConnection conn = new SqlConnection(sqlstr);
            string sql = "select s.song_name,singer_info.singer_name FROM song_info s ,singer_info where s.singer_id=singer_info.singer_id  and songtype_id=2";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(ds, "Info");
            dataGridView1.DataSource = ds.Tables["Info"];
        }
    }
}
