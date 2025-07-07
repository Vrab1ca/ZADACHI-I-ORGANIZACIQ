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
            // MainForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddTask);
            Name = "MainForm1";
            Text = "MainForm1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddTask;
    }
}