namespace SqlViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTables = new System.Windows.Forms.ListBox();
            this.lstProcedures = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstTableColumns = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstViews = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstViewColumns = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXMLTables = new System.Windows.Forms.Button();
            this.btnSelectTables = new System.Windows.Forms.Button();
            this.btnSelectViews = new System.Windows.Forms.Button();
            this.btnXMLViews = new System.Windows.Forms.Button();
            this.lstProcedureParameters = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProcedureDefinition = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Databases:";
            // 
            // cbDatabases
            // 
            this.cbDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(105, 25);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(197, 24);
            this.cbDatabases.TabIndex = 1;
            this.cbDatabases.SelectedIndexChanged += new System.EventHandler(this.cbDatabases_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tables:";
            // 
            // lstTables
            // 
            this.lstTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstTables.FormattingEnabled = true;
            this.lstTables.ItemHeight = 16;
            this.lstTables.Location = new System.Drawing.Point(24, 80);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(274, 308);
            this.lstTables.TabIndex = 3;
            this.lstTables.SelectedIndexChanged += new System.EventHandler(this.lstTables_SelectedIndexChanged);
            // 
            // lstProcedures
            // 
            this.lstProcedures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstProcedures.FormattingEnabled = true;
            this.lstProcedures.ItemHeight = 16;
            this.lstProcedures.Location = new System.Drawing.Point(24, 429);
            this.lstProcedures.Name = "lstProcedures";
            this.lstProcedures.Size = new System.Drawing.Size(274, 308);
            this.lstProcedures.TabIndex = 5;
            this.lstProcedures.SelectedIndexChanged += new System.EventHandler(this.lstProcedures_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Procedures:";
            // 
            // lstTableColumns
            // 
            this.lstTableColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstTableColumns.FormattingEnabled = true;
            this.lstTableColumns.ItemHeight = 16;
            this.lstTableColumns.Location = new System.Drawing.Point(439, 80);
            this.lstTableColumns.Name = "lstTableColumns";
            this.lstTableColumns.Size = new System.Drawing.Size(217, 308);
            this.lstTableColumns.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(436, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Table Columns:";
            // 
            // lstViews
            // 
            this.lstViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstViews.FormattingEnabled = true;
            this.lstViews.ItemHeight = 16;
            this.lstViews.Location = new System.Drawing.Point(671, 80);
            this.lstViews.Name = "lstViews";
            this.lstViews.Size = new System.Drawing.Size(249, 308);
            this.lstViews.TabIndex = 9;
            this.lstViews.SelectedIndexChanged += new System.EventHandler(this.lstViews_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(668, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Views:";
            // 
            // lstViewColumns
            // 
            this.lstViewColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstViewColumns.FormattingEnabled = true;
            this.lstViewColumns.ItemHeight = 16;
            this.lstViewColumns.Location = new System.Drawing.Point(1059, 80);
            this.lstViewColumns.Name = "lstViewColumns";
            this.lstViewColumns.Size = new System.Drawing.Size(253, 308);
            this.lstViewColumns.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(1056, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "View Columns:";
            // 
            // btnXMLTables
            // 
            this.btnXMLTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnXMLTables.Location = new System.Drawing.Point(315, 270);
            this.btnXMLTables.Name = "btnXMLTables";
            this.btnXMLTables.Size = new System.Drawing.Size(105, 51);
            this.btnXMLTables.TabIndex = 12;
            this.btnXMLTables.Text = "XML";
            this.btnXMLTables.UseVisualStyleBackColor = true;
            this.btnXMLTables.Click += new System.EventHandler(this.btnXMLClick);
            // 
            // btnSelectTables
            // 
            this.btnSelectTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectTables.Location = new System.Drawing.Point(315, 337);
            this.btnSelectTables.Name = "btnSelectTables";
            this.btnSelectTables.Size = new System.Drawing.Size(105, 51);
            this.btnSelectTables.TabIndex = 13;
            this.btnSelectTables.Text = "Select";
            this.btnSelectTables.UseVisualStyleBackColor = true;
            this.btnSelectTables.Click += new System.EventHandler(this.btnSelectClick);
            // 
            // btnSelectViews
            // 
            this.btnSelectViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectViews.Location = new System.Drawing.Point(935, 337);
            this.btnSelectViews.Name = "btnSelectViews";
            this.btnSelectViews.Size = new System.Drawing.Size(105, 51);
            this.btnSelectViews.TabIndex = 15;
            this.btnSelectViews.Text = "Select";
            this.btnSelectViews.UseVisualStyleBackColor = true;
            this.btnSelectViews.Click += new System.EventHandler(this.btnSelectClick);
            // 
            // btnXMLViews
            // 
            this.btnXMLViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnXMLViews.Location = new System.Drawing.Point(935, 270);
            this.btnXMLViews.Name = "btnXMLViews";
            this.btnXMLViews.Size = new System.Drawing.Size(105, 51);
            this.btnXMLViews.TabIndex = 14;
            this.btnXMLViews.Text = "XML";
            this.btnXMLViews.UseVisualStyleBackColor = true;
            this.btnXMLViews.Click += new System.EventHandler(this.btnXMLClick);
            // 
            // lstProcedureParameters
            // 
            this.lstProcedureParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstProcedureParameters.FormattingEnabled = true;
            this.lstProcedureParameters.ItemHeight = 16;
            this.lstProcedureParameters.Location = new System.Drawing.Point(1059, 429);
            this.lstProcedureParameters.Name = "lstProcedureParameters";
            this.lstProcedureParameters.Size = new System.Drawing.Size(253, 308);
            this.lstProcedureParameters.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(1056, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Procedure parameters:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(312, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Procedure definition:";
            // 
            // txtProcedureDefinition
            // 
            this.txtProcedureDefinition.Location = new System.Drawing.Point(315, 429);
            this.txtProcedureDefinition.Multiline = true;
            this.txtProcedureDefinition.Name = "txtProcedureDefinition";
            this.txtProcedureDefinition.Size = new System.Drawing.Size(725, 308);
            this.txtProcedureDefinition.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(1237, 749);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnQuery.Location = new System.Drawing.Point(1059, 749);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(172, 33);
            this.btnQuery.TabIndex = 21;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1332, 794);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtProcedureDefinition);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstProcedureParameters);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSelectViews);
            this.Controls.Add(this.btnXMLViews);
            this.Controls.Add(this.btnSelectTables);
            this.Controls.Add(this.btnXMLTables);
            this.Controls.Add(this.lstViewColumns);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstViews);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstTableColumns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstProcedures);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstTables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDatabases);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SqlViewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.ListBox lstProcedures;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstTableColumns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstViews;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstViewColumns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXMLTables;
        private System.Windows.Forms.Button btnSelectTables;
        private System.Windows.Forms.Button btnSelectViews;
        private System.Windows.Forms.Button btnXMLViews;
        private System.Windows.Forms.ListBox lstProcedureParameters;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProcedureDefinition;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnQuery;
    }
}