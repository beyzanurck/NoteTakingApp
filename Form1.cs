using System;
using System.Data;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class NoteTaking : Form
    {
        public NoteTaking()
        {
            InitializeComponent();
        }

        DataTable table;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Message", typeof(String));

            summary_dataGridView.DataSource = table;

            summary_dataGridView.ReadOnly = true;
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            Title_textBox.Clear();
            message_richTextBox.Clear();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (Title_textBox.Text.Length == 0)
            {
                MessageBox.Show("please write something");
            }
            else if (table.Rows.Count > 0)
            {
                bool isExist = false;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i].ItemArray[0].ToString() == Title_textBox.Text)
                    {
                        isExist = true;
                    }
                }

                if (isExist)
                {
                    MessageBox.Show("you already added this");
                }
                else
                {
                    table.Rows.Add(Title_textBox.Text, message_richTextBox.Text);
                }
            }
            else
            {
                table.Rows.Add(Title_textBox.Text, message_richTextBox.Text);
            }

            Title_textBox.Clear();
            message_richTextBox.Clear();
        }

        private void read_button_Click(object sender, EventArgs e)
        {
            int index = summary_dataGridView.CurrentCell.RowIndex;

            Title_textBox.Text = table.Rows[index].ItemArray[0].ToString();
            message_richTextBox.Text = table.Rows[index].ItemArray[1].ToString();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (table.Rows.Count>0)
            {
                int index = summary_dataGridView.CurrentCell.RowIndex;

                table.Rows[index].Delete();
                Title_textBox.Clear();
                message_richTextBox.Clear();
            }            
        }
    }
}
