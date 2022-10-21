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
using Task.Dal;
using Task.Models;

namespace Task
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }
        
        private void btnRun_Click(object sender, EventArgs e)
        {
            String query = TbWriteQuery.Text;
            if (String.IsNullOrWhiteSpace(query))
            {
                return;
            }
            QueryResult result = RepositoryFactory.GetRepository().GetQueryResults(query, MainForm.currentDB.Name);
            dgResults.DataSource = result.DataTable;
            TbQueryConsole.Text = result.Message;
            tbOnColmpleteMessage.Text = result.OnCompleteMessage;
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
