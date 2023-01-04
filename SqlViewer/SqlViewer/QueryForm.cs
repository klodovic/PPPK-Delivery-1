using SqlViewer.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlViewer
{
    public partial class QueryForm : Form
    {
        public QueryForm(object selectedDatabase)
        {
            InitializeComponent();
            txtQueryStatement.Text = "USE " + selectedDatabase.ToString() + Environment.NewLine + "SELECT * FROM ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (string.IsNullOrEmpty(txtQueryStatement.Text))
            {
                lblInfo.Text = "Please, enter query statement and try again!!";
                return;
            }

            DataTable dataTable = RepositoryFactory.GetRepository().GetQueryResults(txtQueryStatement.Text.Trim(), OnInfoMessage, OnStatementCompleted);
            dgResults.DataSource = dataTable;
        }

        private void OnInfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            txtServerMessage.Text = e.Message;
        }

        private void OnStatementCompleted(object sender, StatementCompletedEventArgs e)
        {
            txtServerMessage.Text = $"({e.RecordCount} rows affected)" + Environment.NewLine + "Completion time: " + DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffff");
        }
    }
}
