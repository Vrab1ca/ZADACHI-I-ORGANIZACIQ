namespace ZADACHI_I_ORGANIZACIQ
{
    partial class TaskDialog
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
            btnAddTask = new Button();
            filterPanel = new FlowLayoutPanel();
            cmbPriority = new ComboBox();
            chkShowPending = new CheckBox();
            chkShowCompleted = new CheckBox();
            gridTasks = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Due = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            Done = new DataGridViewCheckBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtTitle = new TextBox();
            txtDescr = new TextBox();
            dtpDue = new DateTimePicker();
            cmbPrio = new ComboBox();
            btnColor = new Button();
            btnOK = new Button();
            filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridTasks).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.Coral;
            btnAddTask.Dock = DockStyle.Top;
            btnAddTask.Location = new Point(0, 0);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(1267, 73);
            btnAddTask.TabIndex = 0;
            btnAddTask.Tag = "btnAddTask";
            btnAddTask.Text = "Добави задача";
            btnAddTask.UseVisualStyleBackColor = false;
            // 
            // filterPanel
            // 
            filterPanel.Controls.Add(cmbPriority);
            filterPanel.Controls.Add(chkShowPending);
            filterPanel.Controls.Add(chkShowCompleted);
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(0, 73);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(1267, 100);
            filterPanel.TabIndex = 1;
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Всички ", "Нисък", "Среден", "Висок" });
            cmbPriority.Location = new Point(3, 3);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(160, 23);
            cmbPriority.TabIndex = 2;
            // 
            // chkShowPending
            // 
            chkShowPending.AutoSize = true;
            chkShowPending.BackColor = Color.Green;
            chkShowPending.CheckAlign = ContentAlignment.TopLeft;
            chkShowPending.Location = new Point(169, 3);
            chkShowPending.Name = "chkShowPending";
            chkShowPending.Size = new Size(122, 19);
            chkShowPending.TabIndex = 3;
            chkShowPending.Text = "Показвай текущи";
            chkShowPending.UseVisualStyleBackColor = false;
            // 
            // chkShowCompleted
            // 
            chkShowCompleted.AutoSize = true;
            chkShowCompleted.BackColor = Color.FromArgb(0, 192, 192);
            chkShowCompleted.Location = new Point(297, 3);
            chkShowCompleted.Name = "chkShowCompleted";
            chkShowCompleted.Size = new Size(143, 19);
            chkShowCompleted.TabIndex = 5;
            chkShowCompleted.Text = "Показвай завършени";
            chkShowCompleted.UseVisualStyleBackColor = false;
            // 
            // gridTasks
            // 
            gridTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTasks.Columns.AddRange(new DataGridViewColumn[] { Title, Description, Due, Priority, Done });
            gridTasks.Location = new Point(723, 179);
            gridTasks.Name = "gridTasks";
            gridTasks.Size = new Size(544, 373);
            gridTasks.TabIndex = 6;
            gridTasks.CellContentClick += gridTasks_CellContentClick;
            // 
            // Title
            // 
            Title.HeaderText = "DataPropertyName Title";
            Title.Name = "Title";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Due
            // 
            Due.HeaderText = "DueDate\n\n";
            Due.Name = "Due";
            // 
            // Priority
            // 
            Priority.HeaderText = "Priority";
            Priority.Name = "Priority";
            // 
            // Done
            // 
            Done.HeaderText = "IsCompleted ";
            Done.Name = "Done";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 203F));
            tableLayoutPanel1.Controls.Add(txtTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(txtDescr, 0, 1);
            tableLayoutPanel1.Controls.Add(btnColor, 2, 0);
            tableLayoutPanel1.Controls.Add(btnOK, 2, 1);
            tableLayoutPanel1.Controls.Add(dtpDue, 1, 0);
            tableLayoutPanel1.Controls.Add(cmbPrio, 1, 1);
            tableLayoutPanel1.Location = new Point(0, 179);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.Size = new Size(717, 373);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(192, 192, 0);
            txtTitle.Location = new Point(3, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Заглавие";
            // 
            // txtDescr
            // 
            txtDescr.BackColor = Color.Coral;
            txtDescr.Location = new Point(3, 149);
            txtDescr.Multiline = true;
            txtDescr.Name = "txtDescr";
            txtDescr.Size = new Size(100, 23);
            txtDescr.TabIndex = 1;
            txtDescr.Text = "Описание";
            txtDescr.TextChanged += txtDescr_TextChanged;
            // 
            // dtpDue
            // 
            dtpDue.Location = new Point(260, 3);
            dtpDue.Name = "dtpDue";
            dtpDue.Size = new Size(212, 23);
            dtpDue.TabIndex = 2;
            // 
            // cmbPrio
            // 
            cmbPrio.FormattingEnabled = true;
            cmbPrio.Items.AddRange(new object[] { "Low", " Medium", "High" });
            cmbPrio.Location = new Point(260, 149);
            cmbPrio.Name = "cmbPrio";
            cmbPrio.Size = new Size(121, 23);
            cmbPrio.TabIndex = 3;
            cmbPrio.Text = "Приоритет";
            // 
            // btnColor
            // 
            btnColor.BackColor = Color.Aquamarine;
            btnColor.Location = new Point(517, 3);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(75, 23);
            btnColor.TabIndex = 4;
            btnColor.Text = "Цвят";
            btnColor.UseVisualStyleBackColor = false;
            btnColor.Click += btnColor_Click;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.LightSteelBlue;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(517, 149);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 5;
            btnOK.Text = "Запази";
            btnOK.UseVisualStyleBackColor = false;
            // 
            // TaskDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 624);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(gridTasks);
            Controls.Add(filterPanel);
            Controls.Add(btnAddTask);
            Name = "TaskDialog";
            Text = "TaskDialog";
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridTasks).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddTask;
        private FlowLayoutPanel filterPanel;
        private ComboBox cmbPriority;
        private CheckBox chkShowPending;
        private CheckBox chkShowCompleted;
        private DataGridView gridTasks;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Due;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewCheckBoxColumn Done;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtTitle;
        private TextBox txtDescr;
        private DateTimePicker dtpDue;
        private ComboBox cmbPrio;
        private Button btnColor;
        private Button btnOK;
    }
}