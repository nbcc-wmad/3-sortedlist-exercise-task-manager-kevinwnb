using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortedListExTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<DateTime, string> tasks = new Dictionary<DateTime, string>();

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            bool errors = false;
            if (txtTask.Text == string.Empty)
            {
                MessageBox.Show("You must enter a task", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errors = true;
            }

            DateTime key = dtpTaskDate.Value;
            string value = txtTask.Text;

            if (errors == false)
            {
                if (tasks.ContainsKey(key))
                {
                    MessageBox.Show("Only one task per date is allowed", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tasks.Add(key.Date, value);
                    lstTasks.Items.Add(key.Date);
                }
            }
        }

        private void LstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex != -1)
            {
               lblTaskDetails.Text = tasks[Convert.ToDateTime(lstTasks.SelectedItem)];
            }
        }

        private void BtnRemoveTask_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a task to remove", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tasks.Remove((DateTime)lstTasks.SelectedItem);
            lstTasks.Items.RemoveAt(lstTasks.SelectedIndex);
            lblTaskDetails.Text = string.Empty;
        }

        private void BtnPrintAll_Click(object sender, EventArgs e)
        {
            string output = string.Empty;
            foreach (var item in tasks)
            {
                output += item.Key.ToShortDateString() + " " + item.Value + "\n";
            }
            MessageBox.Show(output);
        }
    }
}
