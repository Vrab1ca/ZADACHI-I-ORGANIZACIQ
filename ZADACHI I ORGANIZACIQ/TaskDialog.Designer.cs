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
            textBox1 = new TextBox();
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
            btnAddTask.Size = new Size(800, 73);
            btnAddTask.TabIndex = 0;
            btnAddTask.Tag = "btnAddTask";
            btnAddTask.Text = "Добави задача";
            btnAddTask.UseVisualStyleBackColor = false;
            // 
            // filterPanel
            // 
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(0, 73);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(800, 100);
            filterPanel.TabIndex = 1;
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Всички ", "Нисък", "Среден", "Висок" });
            cmbPriority.Location = new Point(12, 142);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(160, 23);
            cmbPriority.TabIndex = 2;
            // 
            // chkShowPending
            // 
            chkShowPending.AutoSize = true;
            chkShowPending.BackColor = Color.Green;
            chkShowPending.CheckAlign = ContentAlignment.TopLeft;
            chkShowPending.Location = new Point(508, 129);
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
            chkShowCompleted.Location = new Point(636, 129);
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
            gridTasks.Location = new Point(304, 179);
            gridTasks.Name = "gridTasks";
            gridTasks.Size = new Size(496, 250);
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.Controls.Add(txtTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 248);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(306, 100);
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
            // textBox1
            // 
            textBox1.Location = new Point(3, 43);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // TaskDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(chkShowPending);
            Controls.Add(gridTasks);
            Controls.Add(chkShowCompleted);
            Controls.Add(cmbPriority);
            Controls.Add(filterPanel);
            Controls.Add(btnAddTask);
            Name = "TaskDialog";
            Text = "TaskDialog";
            ((System.ComponentModel.ISupportInitialize)gridTasks).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox textBox1;
    }
}