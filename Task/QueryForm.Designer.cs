namespace Task
{
    partial class QueryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbWriteQuery = new System.Windows.Forms.TextBox();
            this.TbQueryConsole = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.tbOnColmpleteMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.SuspendLayout();
            // 
            // TbWriteQuery
            // 
            this.TbWriteQuery.Location = new System.Drawing.Point(12, 28);
            this.TbWriteQuery.Multiline = true;
            this.TbWriteQuery.Name = "TbWriteQuery";
            this.TbWriteQuery.Size = new System.Drawing.Size(776, 117);
            this.TbWriteQuery.TabIndex = 0;
            // 
            // TbQueryConsole
            // 
            this.TbQueryConsole.Location = new System.Drawing.Point(11, 445);
            this.TbQueryConsole.Margin = new System.Windows.Forms.Padding(4);
            this.TbQueryConsole.Multiline = true;
            this.TbQueryConsole.Name = "TbQueryConsole";
            this.TbQueryConsole.ReadOnly = true;
            this.TbQueryConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbQueryConsole.Size = new System.Drawing.Size(776, 39);
            this.TbQueryConsole.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Write a query:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Query Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 425);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Console:";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(621, 151);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(167, 23);
            this.btnRun.TabIndex = 24;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dgResults
            // 
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Location = new System.Drawing.Point(12, 199);
            this.dgResults.Name = "dgResults";
            this.dgResults.RowHeadersWidth = 51;
            this.dgResults.RowTemplate.Height = 24;
            this.dgResults.Size = new System.Drawing.Size(776, 223);
            this.dgResults.TabIndex = 25;
            // 
            // tbOnColmpleteMessage
            // 
            this.tbOnColmpleteMessage.Location = new System.Drawing.Point(11, 492);
            this.tbOnColmpleteMessage.Margin = new System.Windows.Forms.Padding(4);
            this.tbOnColmpleteMessage.Multiline = true;
            this.tbOnColmpleteMessage.Name = "tbOnColmpleteMessage";
            this.tbOnColmpleteMessage.ReadOnly = true;
            this.tbOnColmpleteMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOnColmpleteMessage.Size = new System.Drawing.Size(776, 39);
            this.tbOnColmpleteMessage.TabIndex = 26;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.tbOnColmpleteMessage);
            this.Controls.Add(this.dgResults);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TbQueryConsole);
            this.Controls.Add(this.TbWriteQuery);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbWriteQuery;
        private System.Windows.Forms.TextBox TbQueryConsole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRun;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.TextBox tbOnColmpleteMessage;
    }
}