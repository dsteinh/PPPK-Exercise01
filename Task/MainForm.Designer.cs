namespace Task
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.CbDatabases = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LbTables = new System.Windows.Forms.ListBox();
            this.LbTableColumns = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LbViews = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LbViewColumns = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LbProcParams = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LbProcedures = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbProcDefinition = new System.Windows.Forms.TextBox();
            this.BtnXMLTables = new System.Windows.Forms.Button();
            this.BtnSelectTables = new System.Windows.Forms.Button();
            this.BtnSelectViews = new System.Windows.Forms.Button();
            this.BtnXMLViews = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Databases";
            // 
            // CbDatabases
            // 
            this.CbDatabases.FormattingEnabled = true;
            this.CbDatabases.Location = new System.Drawing.Point(151, 36);
            this.CbDatabases.Margin = new System.Windows.Forms.Padding(4);
            this.CbDatabases.Name = "CbDatabases";
            this.CbDatabases.Size = new System.Drawing.Size(255, 24);
            this.CbDatabases.TabIndex = 1;
            this.CbDatabases.SelectedIndexChanged += new System.EventHandler(this.CbDatabases_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tables";
            // 
            // LbTables
            // 
            this.LbTables.FormattingEnabled = true;
            this.LbTables.ItemHeight = 16;
            this.LbTables.Location = new System.Drawing.Point(151, 101);
            this.LbTables.Margin = new System.Windows.Forms.Padding(4);
            this.LbTables.Name = "LbTables";
            this.LbTables.Size = new System.Drawing.Size(255, 244);
            this.LbTables.TabIndex = 3;
            this.LbTables.SelectedIndexChanged += new System.EventHandler(this.LbTables_SelectedIndexChanged);
            // 
            // LbTableColumns
            // 
            this.LbTableColumns.FormattingEnabled = true;
            this.LbTableColumns.ItemHeight = 16;
            this.LbTableColumns.Location = new System.Drawing.Point(548, 101);
            this.LbTableColumns.Margin = new System.Windows.Forms.Padding(4);
            this.LbTableColumns.Name = "LbTableColumns";
            this.LbTableColumns.Size = new System.Drawing.Size(255, 244);
            this.LbTableColumns.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Table columns";
            // 
            // LbViews
            // 
            this.LbViews.FormattingEnabled = true;
            this.LbViews.ItemHeight = 16;
            this.LbViews.Location = new System.Drawing.Point(952, 101);
            this.LbViews.Margin = new System.Windows.Forms.Padding(4);
            this.LbViews.Name = "LbViews";
            this.LbViews.Size = new System.Drawing.Size(255, 244);
            this.LbViews.TabIndex = 7;
            this.LbViews.SelectedIndexChanged += new System.EventHandler(this.LbViews_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(863, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Views";
            // 
            // LbViewColumns
            // 
            this.LbViewColumns.FormattingEnabled = true;
            this.LbViewColumns.ItemHeight = 16;
            this.LbViewColumns.Location = new System.Drawing.Point(1340, 101);
            this.LbViewColumns.Margin = new System.Windows.Forms.Padding(4);
            this.LbViewColumns.Name = "LbViewColumns";
            this.LbViewColumns.Size = new System.Drawing.Size(255, 244);
            this.LbViewColumns.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1236, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "View columns";
            // 
            // LbProcParams
            // 
            this.LbProcParams.FormattingEnabled = true;
            this.LbProcParams.ItemHeight = 16;
            this.LbProcParams.Location = new System.Drawing.Point(1340, 453);
            this.LbProcParams.Margin = new System.Windows.Forms.Padding(4);
            this.LbProcParams.Name = "LbProcParams";
            this.LbProcParams.Size = new System.Drawing.Size(255, 244);
            this.LbProcParams.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1240, 453);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Proc. params";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 453);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Proc. definition";
            // 
            // LbProcedures
            // 
            this.LbProcedures.FormattingEnabled = true;
            this.LbProcedures.ItemHeight = 16;
            this.LbProcedures.Location = new System.Drawing.Point(151, 453);
            this.LbProcedures.Margin = new System.Windows.Forms.Padding(4);
            this.LbProcedures.Name = "LbProcedures";
            this.LbProcedures.Size = new System.Drawing.Size(255, 244);
            this.LbProcedures.TabIndex = 11;
            this.LbProcedures.SelectedIndexChanged += new System.EventHandler(this.LbProcedures_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 453);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Procedures";
            // 
            // TbProcDefinition
            // 
            this.TbProcDefinition.Location = new System.Drawing.Point(548, 443);
            this.TbProcDefinition.Margin = new System.Windows.Forms.Padding(4);
            this.TbProcDefinition.Multiline = true;
            this.TbProcDefinition.Name = "TbProcDefinition";
            this.TbProcDefinition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbProcDefinition.Size = new System.Drawing.Size(659, 254);
            this.TbProcDefinition.TabIndex = 18;
            // 
            // BtnXMLTables
            // 
            this.BtnXMLTables.Location = new System.Drawing.Point(416, 255);
            this.BtnXMLTables.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXMLTables.Name = "BtnXMLTables";
            this.BtnXMLTables.Size = new System.Drawing.Size(100, 41);
            this.BtnXMLTables.TabIndex = 19;
            this.BtnXMLTables.Text = "XML";
            this.BtnXMLTables.UseVisualStyleBackColor = true;
            // 
            // BtnSelectTables
            // 
            this.BtnSelectTables.Location = new System.Drawing.Point(415, 303);
            this.BtnSelectTables.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSelectTables.Name = "BtnSelectTables";
            this.BtnSelectTables.Size = new System.Drawing.Size(100, 41);
            this.BtnSelectTables.TabIndex = 20;
            this.BtnSelectTables.Text = "Select";
            this.BtnSelectTables.UseVisualStyleBackColor = true;
            // 
            // BtnSelectViews
            // 
            this.BtnSelectViews.Location = new System.Drawing.Point(1215, 303);
            this.BtnSelectViews.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSelectViews.Name = "BtnSelectViews";
            this.BtnSelectViews.Size = new System.Drawing.Size(100, 41);
            this.BtnSelectViews.TabIndex = 22;
            this.BtnSelectViews.Text = "Select";
            this.BtnSelectViews.UseVisualStyleBackColor = true;
            // 
            // BtnXMLViews
            // 
            this.BtnXMLViews.Location = new System.Drawing.Point(1216, 255);
            this.BtnXMLViews.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXMLViews.Name = "BtnXMLViews";
            this.BtnXMLViews.Size = new System.Drawing.Size(100, 41);
            this.BtnXMLViews.TabIndex = 21;
            this.BtnXMLViews.Text = "XML";
            this.BtnXMLViews.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "Write a Query";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1635, 752);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSelectViews);
            this.Controls.Add(this.BtnXMLViews);
            this.Controls.Add(this.BtnSelectTables);
            this.Controls.Add(this.BtnXMLTables);
            this.Controls.Add(this.TbProcDefinition);
            this.Controls.Add(this.LbProcParams);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LbProcedures);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LbViewColumns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbViews);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbTableColumns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbTables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbDatabases);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAIN FORM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbDatabases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LbTables;
        private System.Windows.Forms.ListBox LbTableColumns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LbViews;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LbViewColumns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LbProcParams;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox LbProcedures;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbProcDefinition;
        private System.Windows.Forms.Button BtnXMLTables;
        private System.Windows.Forms.Button BtnSelectTables;
        private System.Windows.Forms.Button BtnSelectViews;
        private System.Windows.Forms.Button BtnXMLViews;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

