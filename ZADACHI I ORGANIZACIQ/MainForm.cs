using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TaskTracker;

namespace ZADACHI_I_ORGANIZACIQ
{
    public partial class MainForm : Form
    {
        private readonly TaskManager _mgr;
        public MainForm(TaskManager mgr)
        {
            InitializeComponent();
            _mgr = mgr;
            InitRuntimeStuff();
        }

        // --- динамични настройки и събития ---
        private void InitRuntimeStuff()
        {
            // Запълни ComboBox ако е празен (за случай, че UI е създаден в кода)
            if (cmbPriority.Items.Count == 0)
                cmbPriority.Items.AddRange(new[] { "Всички", "Нисък", "Среден", "Висок" });
            cmbPriority.SelectedIndex = 0;

            // Събития
            btnAddTask.Click += BtnAddTask_Click;
            cmbPriority.SelectedIndexChanged += (_, __) => RefreshGrid();
            chkShowPending.CheckedChanged += (_, __) => RefreshGrid();
            chkShowCompleted.CheckedChanged += (_, __) => RefreshGrid();

            gridTasks.CellDoubleClick += GridTasks_CellDoubleClick;
            gridTasks.RowPrePaint += GridTasks_RowPrePaint;

            // Първо зареждане
            RefreshGrid();
        }

        private void BtnAddTask_Click(object? sender, EventArgs e)
        {
            using var dlg = new TaskDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _mgr.Add(dlg.Task);
                RefreshGrid();
            }
        }

        private void GridTasks_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var task = (Task)gridTasks.Rows[e.RowIndex].DataBoundItem;
            _mgr.ToggleCompleted(task);
            RefreshGrid();
        }

        private void GridTasks_RowPrePaint(object? sender, DataGridViewRowPrePaintEventArgs e)
        {
            var task = (Task)gridTasks.Rows[e.RowIndex].DataBoundItem;
            gridTasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = task.TaskColor;
        }

        private void RefreshGrid()
        {
            Priority? pr = cmbPriority.SelectedIndex switch
            {
                1 => Priority.Low,
                2 => Priority.Medium,
                3 => Priority.High,
                _ => null
            };

            gridTasks.DataSource = new BindingSource
            {
                DataSource = new List<Task>(_mgr.Filter(
                    chkShowCompleted.Checked,
                    chkShowPending.Checked,
                    pr))
            };
        }
    }
}
