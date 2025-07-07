using System.Drawing;
using System.Windows.Forms;

namespace TaskTracker
{
    partial class TaskDialog
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtTitle;
        private TextBox txtDescr;
        private DateTimePicker dtpDue;
        private ComboBox cmbPrio;
        private Button btnColor;
        private Button btnOK;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTitle = new TextBox();
            this.txtDescr = new TextBox();
            this.dtpDue = new DateTimePicker();
            this.cmbPrio = new ComboBox();
            this.btnColor = new Button();
            this.btnOK = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();

            // txtTitle
            this.txtTitle.Location = new Point(12, 12);
            this.txtTitle.Width = 250;

            // txtDescr
            this.txtDescr.Location = new Point(12, 41);
            this.txtDescr.Multiline = true;
            this.txtDescr.Size = new Size(250, 60);

            // dtpDue
            this.dtpDue.Location = new Point(12, 110);

            // cmbPrio
            this.cmbPrio.Location = new Point(12, 139);
            this.cmbPrio.DropDownStyle = ComboBoxStyle.DropDownList;

            // btnColor
            this.btnColor.Location = new Point(12, 168);
            this.btnColor.Text = "Цвят…";

            // btnOK
            this.btnOK.Text = "Запази";
            this.btnOK.DialogResult = DialogResult.OK;
            this.btnOK.Location = new Point(106, 210);

            // btnCancel
            this.btnCancel.Text = "Отказ";
            this.btnCancel.DialogResult = DialogResult.Cancel;
            this.btnCancel.Location = new Point(187, 210);

            // TaskDialog
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new Size(280, 250);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Нова задача";

            this.Controls.AddRange(new Control[]
            {
                txtTitle, txtDescr, dtpDue, cmbPrio,
                btnColor, btnOK, btnCancel
            });

            this.ResumeLayout(false);
        }
    }
}