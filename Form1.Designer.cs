namespace NoteTakingApp
{
    partial class NoteTaking
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
            this.title = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.Title_textBox = new System.Windows.Forms.TextBox();
            this.message_richTextBox = new System.Windows.Forms.RichTextBox();
            this.summary_dataGridView = new System.Windows.Forms.DataGridView();
            this.new_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.read_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.summary_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(16, 40);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(33, 13);
            this.title.TabIndex = 0;
            this.title.Text = "Title: ";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(16, 86);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(56, 13);
            this.message.TabIndex = 1;
            this.message.Text = "Message: ";
            // 
            // Title_textBox
            // 
            this.Title_textBox.Location = new System.Drawing.Point(84, 37);
            this.Title_textBox.Name = "Title_textBox";
            this.Title_textBox.Size = new System.Drawing.Size(124, 20);
            this.Title_textBox.TabIndex = 2;
            // 
            // message_richTextBox
            // 
            this.message_richTextBox.Location = new System.Drawing.Point(84, 86);
            this.message_richTextBox.Name = "message_richTextBox";
            this.message_richTextBox.Size = new System.Drawing.Size(124, 126);
            this.message_richTextBox.TabIndex = 3;
            this.message_richTextBox.Text = "";
            // 
            // summary_dataGridView
            // 
            this.summary_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summary_dataGridView.Location = new System.Drawing.Point(271, 37);
            this.summary_dataGridView.Name = "summary_dataGridView";
            this.summary_dataGridView.Size = new System.Drawing.Size(240, 175);
            this.summary_dataGridView.TabIndex = 4;
            // 
            // new_button
            // 
            this.new_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.new_button.Location = new System.Drawing.Point(19, 264);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(75, 23);
            this.new_button.TabIndex = 6;
            this.new_button.Text = "New";
            this.new_button.UseVisualStyleBackColor = false;
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save_button.Location = new System.Drawing.Point(155, 264);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // read_button
            // 
            this.read_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.read_button.Location = new System.Drawing.Point(299, 264);
            this.read_button.Name = "read_button";
            this.read_button.Size = new System.Drawing.Size(75, 23);
            this.read_button.TabIndex = 6;
            this.read_button.Text = "Read";
            this.read_button.UseVisualStyleBackColor = false;
            this.read_button.Click += new System.EventHandler(this.read_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.delete_button.Location = new System.Drawing.Point(436, 264);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 6;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // NoteTaking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 306);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.read_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.new_button);
            this.Controls.Add(this.summary_dataGridView);
            this.Controls.Add(this.message_richTextBox);
            this.Controls.Add(this.Title_textBox);
            this.Controls.Add(this.message);
            this.Controls.Add(this.title);
            this.Name = "NoteTaking";
            this.Text = "Note Taking App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.summary_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.TextBox Title_textBox;
        private System.Windows.Forms.RichTextBox message_richTextBox;
        private System.Windows.Forms.DataGridView summary_dataGridView;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button read_button;
        private System.Windows.Forms.Button delete_button;
    }
}

