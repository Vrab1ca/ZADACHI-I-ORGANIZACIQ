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
            label1 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            txtDescr = new TextBox();
            label3 = new Label();
            dtpDue = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 0);
            label1.Location = new Point(557, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Заглавие:";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.NavajoWhite;
            txtTitle.Location = new Point(478, 27);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(220, 23);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkRed;
            label2.Location = new Point(559, 62);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Описание:";
            // 
            // txtDescr
            // 
            txtDescr.BackColor = Color.NavajoWhite;
            txtDescr.Location = new Point(541, 80);
            txtDescr.Multiline = true;
            txtDescr.Name = "txtDescr";
            txtDescr.Size = new Size(100, 50);
            txtDescr.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DeepSkyBlue;
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(557, 143);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Краен срок:";
            // 
            // dtpDue
            // 
            dtpDue.Location = new Point(498, 161);
            dtpDue.Name = "dtpDue";
            dtpDue.Size = new Size(200, 23);
            dtpDue.TabIndex = 5;
            // 
            // TaskDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 624);
            Controls.Add(dtpDue);
            Controls.Add(label3);
            Controls.Add(txtDescr);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Name = "TaskDialog";
            Text = "TaskDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private Label label2;
        private TextBox txtDescr;
        private Label label3;
        private DateTimePicker dtpDue;
    }
}