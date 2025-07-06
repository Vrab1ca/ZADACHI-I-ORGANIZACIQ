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
            SuspendLayout();
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.Coral;
            btnAddTask.Dock = DockStyle.Top;
            btnAddTask.Location = new Point(0, 0);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(800, 23);
            btnAddTask.TabIndex = 0;
            btnAddTask.Tag = "btnAddTask";
            btnAddTask.Text = "Добави задача";
            btnAddTask.UseVisualStyleBackColor = false;
            // 
            // filterPanel
            // 
            filterPanel.Dock = DockStyle.Top;
            filterPanel.Location = new Point(0, 23);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(800, 100);
            filterPanel.TabIndex = 1;
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(490, 182);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(121, 23);
            cmbPriority.TabIndex = 2;
            // 
            // TaskDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbPriority);
            Controls.Add(filterPanel);
            Controls.Add(btnAddTask);
            Name = "TaskDialog";
            Text = "TaskDialog";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddTask;
        private FlowLayoutPanel filterPanel;
        private ComboBox cmbPriority;
    }
}