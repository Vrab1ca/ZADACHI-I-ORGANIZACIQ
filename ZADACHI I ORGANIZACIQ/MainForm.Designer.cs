namespace TaskTracker
{
    partial class MainForm1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.FlowLayoutPanel filterPanel;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.CheckBox chkShowPending;
        private System.Windows.Forms.CheckBox chkShowCompleted;
        private System.Windows.Forms.DataGridView gridTasks;

        /// <inheritdoc/>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.filterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.chkShowPending = new System.Windows.Forms.CheckBox();
            this.chkShowCompleted = new System.Windows.Forms.CheckBox();
            this.gridTasks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).BeginInit();
            this.filterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTask
            // 
            this.btnAddTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddTask.Height = 34;
            this.btnAddTask.Text = "Добави задача";
            this.btnAddTask.Name = "btnAddTask";
            // 
            // filterPanel
            // 
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Height = 36;
            this.filterPanel.Padding = new System.Windows.Forms.Padding(6, 5, 0, 0);
            this.filterPanel.Controls.Add(this.cmbPriority);
            this.filterPanel.Controls.Add(this.chkShowPending);
            this.filterPanel.Controls.Add(this.chkShowCompleted);
            this.filterPanel.Name = "filterPanel";
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.Items.AddRange(new object[] { "Всички", "Нисък", "Среден", "Висок" });
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Width = 90;
            // 
            // chkShowPending
            // 
            this.chkShowPending.Text = "Показвай текущи";
            this.chkShowPending.Checked = true;
            this.chkShowPending.Name = "chkShowPending";
            // 
            // chkShowCompleted
            // 
            this.chkShowCompleted.Text = "Показвай завършени";
            this.chkShowCompleted.Checked = true;
            this.chkShowCompleted.Name = "chkShowCompleted";
            // 
            // gridTasks
            // 
            this.gridTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTasks.ReadOnly = true;
            this.gridTasks.AllowUserToAddRows = false;
            this.gridTasks.AutoGenerateColumns = false;
            this.gridTasks.Name = "gridTasks";
            // колони
            var colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn
            {
                HeaderText = "Заглавие",
                DataPropertyName = "Title",
                Width = 180
            };
            var colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn
            {
                HeaderText = "Описание",
                DataPropertyName = "Description",
                Width = 250
            };
            var colDue = new System.Windows.Forms.DataGridViewTextBoxColumn
            {
                HeaderText = "Краен срок",
                DataPropertyName = "DueDate",
                Width = 90
            };
            var colPrio = new System.Windows.Forms.DataGridViewTextBoxColumn
            {
                HeaderText = "Приоритет",
                DataPropertyName = "Priority",
                Width = 70
            };
            var colDone = new System.Windows.Forms.DataGridViewCheckBoxColumn
            {
                HeaderText = "Готово",
                DataPropertyName = "IsCompleted",
                Width = 60
            };
            this.gridTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colTitle, colDesc, colDue, colPrio, colDone });
            // 
            // MainForm1
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.gridTasks);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.btnAddTask);
            this.Text = "Task Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).EndInit();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
    }
}