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
            chkShowComplete = new CheckBox();
            gridTasks = new DataGridView();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridTasks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.FromArgb(0, 192, 192);
            btnAddTask.Dock = DockStyle.Top;
            btnAddTask.Location = new Point(0, 0);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(800, 34);
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
            filterPanel.Size = new Size(800, 34);
            filterPanel.TabIndex = 1;
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Всички", " Нисък ", "Среден", "Висок" });
            cmbPriority.Location = new Point(354, 74);
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
            chkShowPending.Location = new Point(450, 78);
            chkShowPending.Name = "chkShowPending";
            chkShowPending.Size = new Size(122, 19);
            chkShowPending.TabIndex = 3;
            chkShowPending.Text = "Показвай текущи";
            chkShowPending.UseVisualStyleBackColor = false;
            // 
            // chkShowComplete
            // 
            chkShowComplete.AutoSize = true;
            chkShowComplete.BackColor = Color.FromArgb(192, 0, 0);
            chkShowComplete.Checked = true;
            chkShowComplete.CheckState = CheckState.Checked;
            chkShowComplete.Location = new Point(205, 78);
            chkShowComplete.Name = "chkShowComplete";
            chkShowComplete.Size = new Size(143, 19);
            chkShowComplete.TabIndex = 4;
            chkShowComplete.Text = "Показвай завършени";
            chkShowComplete.UseVisualStyleBackColor = false;
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
            gridTasks.Size = new Size(800, 297);
            gridTasks.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(348, 297);
            dataGridView1.TabIndex = 6;
            // 
            // MainForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(gridTasks);
            Controls.Add(chkShowComplete);
            Controls.Add(chkShowPending);
            Controls.Add(cmbPriority);
            Controls.Add(filterPanel);
            Controls.Add(btnAddTask);
            Name = "MainForm1";
            Text = "MainForm1";
            ((System.ComponentModel.ISupportInitialize)gridTasks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddTask;
        private FlowLayoutPanel filterPanel;
        private ComboBox cmbPriority;
        private CheckBox chkShowPending;
        private CheckBox chkShowComplete;
        private DataGridView gridTasks;
        private DataGridView dataGridView1;
    }
}