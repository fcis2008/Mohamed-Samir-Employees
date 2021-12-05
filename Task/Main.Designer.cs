
namespace Task
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmployeeFilePath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonLoadEmployees = new System.Windows.Forms.Button();
            this.ColumnEmployee1ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmployee2ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCommonProjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDaysWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee file path";
            // 
            // textBoxEmployeeFilePath
            // 
            this.textBoxEmployeeFilePath.Location = new System.Drawing.Point(126, 20);
            this.textBoxEmployeeFilePath.Name = "textBoxEmployeeFilePath";
            this.textBoxEmployeeFilePath.ReadOnly = true;
            this.textBoxEmployeeFilePath.Size = new System.Drawing.Size(395, 20);
            this.textBoxEmployeeFilePath.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(537, 20);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 20);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.ShowHelp = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEmployee1ID,
            this.ColumnEmployee2ID,
            this.ColumnCommonProjectID,
            this.ColumnDaysWorked});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(88, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(464, 271);
            this.dataGridView1.TabIndex = 3;
            // 
            // buttonLoadEmployees
            // 
            this.buttonLoadEmployees.Location = new System.Drawing.Point(269, 52);
            this.buttonLoadEmployees.Name = "buttonLoadEmployees";
            this.buttonLoadEmployees.Size = new System.Drawing.Size(96, 23);
            this.buttonLoadEmployees.TabIndex = 4;
            this.buttonLoadEmployees.Text = "Load employees";
            this.buttonLoadEmployees.UseVisualStyleBackColor = true;
            this.buttonLoadEmployees.Click += new System.EventHandler(this.ButtonLoadEmployees_Click);
            // 
            // ColumnEmployee1ID
            // 
            this.ColumnEmployee1ID.DataPropertyName = "Employee1ID";
            this.ColumnEmployee1ID.HeaderText = "Employee 1 ID";
            this.ColumnEmployee1ID.Name = "ColumnEmployee1ID";
            this.ColumnEmployee1ID.ReadOnly = true;
            this.ColumnEmployee1ID.Width = 120;
            // 
            // ColumnEmployee2ID
            // 
            this.ColumnEmployee2ID.DataPropertyName = "Employee2ID";
            this.ColumnEmployee2ID.HeaderText = "Employee 2 ID";
            this.ColumnEmployee2ID.Name = "ColumnEmployee2ID";
            this.ColumnEmployee2ID.ReadOnly = true;
            this.ColumnEmployee2ID.Width = 120;
            // 
            // ColumnCommonProjectID
            // 
            this.ColumnCommonProjectID.DataPropertyName = "CommonProjectID";
            this.ColumnCommonProjectID.HeaderText = "Common project ID";
            this.ColumnCommonProjectID.Name = "ColumnCommonProjectID";
            this.ColumnCommonProjectID.ReadOnly = true;
            this.ColumnCommonProjectID.Width = 120;
            // 
            // ColumnDaysWorked
            // 
            this.ColumnDaysWorked.DataPropertyName = "DaysWorked";
            this.ColumnDaysWorked.HeaderText = "Days worked";
            this.ColumnDaysWorked.Name = "ColumnDaysWorked";
            this.ColumnDaysWorked.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 370);
            this.Controls.Add(this.buttonLoadEmployees);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxEmployeeFilePath);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmployeeFilePath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLoadEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployee1ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployee2ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCommonProjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDaysWorked;
    }
}

