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

namespace ChapterEight8_2
{
    public partial class frmTitles : Form
    {
        SqlConnection booksConnection;
        SqlCommand titlesCommand;
        SqlDataAdapter titlesAdapter;
        DataTable titlesTable;
        public frmTitles()
        {
            InitializeComponent();
        }

        private void frmTitles_Load(object sender, EventArgs e)
        {
            if(dlgOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    booksConnection = new SqlConnection($@"Data Source=.\SQLEXPRESS; AttachDbFilename={Application.StartupPath + "books.mdf"};
                                                    Integrated Security=True; Connect Timeout=30; User Instance=True");
                    booksConnection.Open();
                    //titlesCommand = new SqlCommand("Select * from ")
                }
                catch
                {

                }
            }
        }

        private void frmTitles_FormClosing(object sender, FormClosingEventArgs e)
        {
            booksConnection.Dispose();
            titlesCommand.Dispose();
            titlesAdapter.Dispose();
            titlesTable.Dispose();
        }
    }
}
