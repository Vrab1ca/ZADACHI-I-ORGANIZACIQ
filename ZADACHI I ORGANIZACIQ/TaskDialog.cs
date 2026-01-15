using System;
using System.Windows.Forms;

namespace TaskTracker
{
    public partial class TaskDialog : Form
    {
        public Task Task { get; } = new();
        public TaskDialog()
        {
            InitializeComponent();
            InitLogic();
        }

        private void InitLogic()
        {
            cmbPrio.Items.AddRange(Enum.GetNames(typeof(Priority)));
            cmbPrio.SelectedIndex = 1; // Medium

            btnColor.Click += (_, __) =>
            {
                using var cd = new ColorDialog();
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    btnColor.BackColor = cd.Color;
                    Task.ColorHtml = cd.Color.ToArgb().ToString();
                }
            };

            btnOK.Click += (_, __) =>
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    MessageBox.Show("Заглавието е задължително!", "Грешка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                    return;
                }

                Task.Title = txtTitle.Text.Trim();
                Task.Description = txtDescr.Text.Trim();
                Task.DueDate = dtpDue.Value.Date;
                Task.Priority = Enum.Parse<Priority>(cmbPrio.SelectedItem!.ToString()!);
            };
        }
    }
}