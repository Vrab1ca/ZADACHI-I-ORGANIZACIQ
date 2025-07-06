namespace ZADACHI_I_ORGANIZACIQ
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            colorDialog = new ColorDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            title = new TextBox();
            Description = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(317, 175);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 0;
            button1.Text = "Добави задача";
            button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(370, 364);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(420, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(550, 154);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(90, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Показвай …";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(809, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(582, 276);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(692, 363);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // title
            // 
            title.BackColor = Color.Teal;
            title.Location = new Point(343, 249);
            title.Name = "title";
            title.Size = new Size(100, 23);
            title.TabIndex = 7;
            // 
            // Description
            // 
            Description.BackColor = Color.Tomato;
            Description.Location = new Point(279, 302);
            Description.Name = "Description";
            Description.Size = new Size(100, 23);
            Description.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 528);
            Controls.Add(Description);
            Controls.Add(title);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private ColorDialog colorDialog;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox title;
        private TextBox Description;
    }
}
