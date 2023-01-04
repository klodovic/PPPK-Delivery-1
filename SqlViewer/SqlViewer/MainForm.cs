using SqlViewer.DAL;
using SqlViewer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlViewer
{
    public partial class MainForm : Form
    {
        private const string FileFilter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";
        private const string FileName = "{0}.xml";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbDatabases.DataSource = new List<Databases>(RepositoryFactory.GetRepository().GetDatabases());
        }

        private void cbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            lstTables.DataSource = (cbDatabases.SelectedItem as Databases).Tables;
            lstViews.DataSource = (cbDatabases.SelectedItem as Databases).Views;
            lstProcedures.DataSource = (cbDatabases.SelectedItem as Databases).Procedures;
        }

        private void Clear()
        {
            lstTableColumns.DataSource = null;
            lstViewColumns.DataSource = null;
            lstProcedureParameters.DataSource = null;
            txtProcedureDefinition.Text = string.Empty;
        }

        private void lstTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTableColumns.DataSource = (lstTables.SelectedItem as DBEntity).Columns;
        }

        private void lstViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstViewColumns.DataSource = (lstViews.SelectedItem as DBEntity).Columns;
        }

        private void lstProcedures_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProcedureDefinition.Text = (lstProcedures.SelectedItem as Procedure).Definition;
            lstProcedureParameters.DataSource = (lstProcedures.SelectedItem as Procedure).ProceduresParams;
        }

        private void btnXMLClick(object sender, EventArgs e)
        {
            DBEntity dBEntity;
            switch ((sender as Button).Name)
            {
                case nameof(btnXMLTables):
                    dBEntity = lstTables.SelectedItem as DBEntity;
                    break;
                case nameof(btnXMLViews):
                    dBEntity = lstViews.SelectedItem as DBEntity;
                    break;
                default:
                    throw new Exception("Wrong wiring!!");
            }

            var dialog = new SaveFileDialog()
            {
                FileName = string.Format(FileName, dBEntity.Name),
                Filter = FileFilter
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DataSet ds = RepositoryFactory.GetRepository().CreateDataset(dBEntity);
                ds.WriteXml(dialog.FileName, XmlWriteMode.WriteSchema);
            }
            
        }

        private void btnSelectClick(object sender, EventArgs e)
        {
            DBEntity dBEntity;
            switch ((sender as Button).Name)
            {
                case nameof(btnSelectTables):
                    dBEntity = lstTables.SelectedItem as DBEntity;
                    break;
                case nameof(btnSelectViews):
                    dBEntity = lstViews.SelectedItem as DBEntity;
                    break;
                default:
                    throw new Exception("Wrong wiring!!");
            }
            DataSet ds = RepositoryFactory.GetRepository().CreateDataset(dBEntity);
            new SelectForm(ds.Tables[0]).ShowDialog();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            var selectedDatabase = cbDatabases.SelectedValue;
            new QueryForm(selectedDatabase).Show();
        }
    }
}
