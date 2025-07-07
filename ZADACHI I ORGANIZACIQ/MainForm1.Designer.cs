namespace ZADACHI_I_ORGANIZACIQ
{
    partial class MainForm1
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
            gridTasks1 = new DataGridView();
            colDesc = new DataGridViewTextBoxColumn();
            colDue = new DataGridViewTextBoxColumn();
            colPrio = new DataGridViewTextBoxColumn();
            colDone = new DataGridViewCheckBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridTasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridTasks1).BeginInit();
            SuspendLayout();
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.FromArgb(0, 192, 192);
            btnAddTask.Dock = DockStyle.Top;
            btnAddTask.Location = new Point(0, 0);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(1005, 34);
            btnAddTask.TabIndex = 0;
            btnAddTask.Text = "Добави задача";
            btnAddTask.UseVisualStyleBackColor = false;
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.NavajoWhite;
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(0, 34);
            filterPanel.Name = "filterPanel";
            filterPanel.Padding = new Padding(6, 5, 0, 0);
            filterPanel.Size = new Size(1005, 34);
            filterPanel.TabIndex = 1;
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Всички", " Нисък ", "Среден", "Висок" });
            cmbPriority.Location = new Point(451, 74);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(90, 23);
            cmbPriority.TabIndex = 2;
            cmbPriority.SelectedIndexChanged += cmbPriority_SelectedIndexChanged;
            // 
            // chkShowPending
            // 
            chkShowPending.AutoSize = true;
            chkShowPending.BackColor = Color.Green;
            chkShowPending.Checked = true;
            chkShowPending.CheckState = CheckState.Checked;
            chkShowPending.Location = new Point(547, 76);
            chkShowPending.Name = "chkShowPending";
            chkShowPending.Size = new Size(122, 19);
            chkShowPending.TabIndex = 3;
            chkShowPending.Text = "Показвай текущи";
            chkShowPending.UseVisualStyleBackColor = false;
            // 
            // chkShowCompleted
            // 
            chkShowCompleted.AutoSize = true;
            chkShowCompleted.BackColor = Color.FromArgb(192, 0, 0);
            chkShowCompleted.Checked = true;
            chkShowCompleted.CheckState = CheckState.Checked;
            chkShowCompleted.Location = new Point(302, 78);
            chkShowCompleted.Name = "chkShowCompleted";
            chkShowCompleted.Size = new Size(143, 19);
            chkShowCompleted.TabIndex = 4;
            chkShowCompleted.Text = "Показвай завършени";
            chkShowCompleted.UseVisualStyleBackColor = false;
            chkShowCompleted.CheckedChanged += chkShowComplete_CheckedChanged;
            // 
            // gridTasks
            // 
            gridTasks.AllowUserToAddRows = false;
            gridTasks.BackgroundColor = Color.PaleTurquoise;
            gridTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTasks.Dock = DockStyle.Bottom;
            gridTasks.Location = new Point(0, 153);
            gridTasks.Name = "gridTasks";
            gridTasks.ReadOnly = true;
            gridTasks.Size = new Size(1005, 401);
            gridTasks.TabIndex = 5;
            // 
            // gridTasks1
            // 
            gridTasks1.AllowUserToAddRows = false;
            gridTasks1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTasks1.Columns.AddRange(new DataGridViewColumn[] { colDesc, colDue, colPrio, colDone, colTitle });
            gridTasks1.Location = new Point(0, 153);
            gridTasks1.Name = "gridTasks1";
            gridTasks1.ReadOnly = true;
            gridTasks1.Size = new Size(541, 401);
            gridTasks1.TabIndex = 6;
            // 
            // colDesc
            // 
            colDesc.HeaderText = "Описание";
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            // 
            // colDue
            // 
            colDue.HeaderText = "Краен срок";
            colDue.Name = "colDue";
            colDue.ReadOnly = true;
            // 
            // colPrio
            // 
            colPrio.HeaderText = "Приоритет";
            colPrio.Name = "colPrio";
            colPrio.ReadOnly = true;
            // 
            // colDone
            // 
            colDone.HeaderText = "Готово";
            colDone.Name = "colDone";
            colDone.ReadOnly = true;
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Заглавие";
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // MainForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 554);
            Controls.Add(gridTasks1);
            Controls.Add(gridTasks);
            Controls.Add(chkShowCompleted);
            Controls.Add(chkShowPending);
            Controls.Add(cmbPriority);
            Controls.Add(filterPanel);
            Controls.Add(btnAddTask);
            Name = "MainForm1";
            Text = "MainForm1";
            ((System.ComponentModel.ISupportInitialize)gridTasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridTasks1).EndInit();
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
        private DataGridView gridTasks1;
        private DataGridViewTextBoxColumn colDesc;
        private DataGridViewTextBoxColumn colDue;
        private DataGridViewTextBoxColumn colPrio;
        private DataGridViewCheckBoxColumn colDone;
        private DataGridViewTextBoxColumn colTitle;
    }
}