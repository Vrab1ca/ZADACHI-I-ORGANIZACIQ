using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskTracker
{
    public partial class MainForm1 : Form
    {
        private readonly TaskManager _mgr;
        public MainForm1(TaskManager mgr)
        {
            InitializeComponent();
            _mgr = mgr;
            WireEvents();
            RefreshGrid();
        }

        private void WireEvents()
        {
            btnAddTask.Click += (_, __) => ShowTaskDialog();

            cmbPriority.SelectedIndexChanged += (_, __) => RefreshGrid();
            chkShowPending.CheckedChanged += (_, __) => RefreshGrid();
            chkShowCompleted.CheckedChanged += (_, __) => RefreshGrid();

            gridTasks.CellDoubleClick += (_, e) =>
            {
                if (e.RowIndex < 0) return;
                var task = (Task)gridTasks.Rows[e.RowIndex].DataBoundItem;
                _mgr.ToggleCompleted(task);
                RefreshGrid();
            };

            gridTasks.RowPrePaint += (_, e) =>
            {
                var task = (Task)gridTasks.Rows[e.RowIndex].DataBoundItem;
                gridTasks.Rows[e.RowIndex].DefaultCellStyle.BackColor = task.TaskColor;
            };
        }

        private void ShowTaskDialog()
        {
            using var dlg = new TaskDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _mgr.Add(dlg.Task);
                RefreshGrid();
            }
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