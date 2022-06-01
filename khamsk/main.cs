using khamsk.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace khamsk
{
    public partial class formKSK : Form
    {
        public formKSK()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            IsServerConnected(getDB._connectionString);
        }
        private static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Kết Nối Server Thất Bại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                    return false;
                }
            }
        }

        private void kSKTT14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KSKTT14 kSKTT = new KSKTT14();
            kSKTT.TopMost = true;
            kSKTT.Show();
        }

        private void kSKLAIXEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KSKLX kSKLX = new KSKLX();
            kSKLX.TopMost = true;
            kSKLX.Show();
        }
    }
}
