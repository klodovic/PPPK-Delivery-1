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
    public partial class SelectForm : Form
    {
        public SelectForm(DataTable dt)
        {
            InitializeComponent();
            Init(dt);
        }

        private void Init(DataTable dt)
        {
            Text = dt.TableName;
            dgResults.DataSource = dt;
        }
    }
}
