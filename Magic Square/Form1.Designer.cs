namespace Magic_Square
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.Answer1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Answer2 = new System.Windows.Forms.RichTextBox();
            this.Answer3 = new System.Windows.Forms.RichTextBox();
            this.Answer4 = new System.Windows.Forms.RichTextBox();
            this.Answer5 = new System.Windows.Forms.RichTextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.title);
            this.panel2.Location = new System.Drawing.Point(29, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 100);
            this.panel2.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Teal;
            this.title.Font = new System.Drawing.Font("Forte", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Transparent;
            this.title.Location = new System.Drawing.Point(128, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(404, 52);
            this.title.TabIndex = 0;
            this.title.Text = "MAGIC SQUARE";
            // 
            // Answer1
            // 
            this.Answer1.Font = new System.Drawing.Font("Bradley Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer1.Location = new System.Drawing.Point(29, 192);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(648, 49);
            this.Answer1.TabIndex = 1;
            this.Answer1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter any number and see magic";
            // 
            // ok
            // 
            this.ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok.Location = new System.Drawing.Point(602, 163);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 3;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // number
            // 
            this.number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.number.Location = new System.Drawing.Point(212, 163);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 20);
            this.number.TabIndex = 0;
            this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Answer2
            // 
            this.Answer2.Location = new System.Drawing.Point(29, 247);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(648, 43);
            this.Answer2.TabIndex = 4;
            this.Answer2.Text = "";
            // 
            // Answer3
            // 
            this.Answer3.Location = new System.Drawing.Point(29, 296);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(648, 44);
            this.Answer3.TabIndex = 5;
            this.Answer3.Text = "";
            // 
            // Answer4
            // 
            this.Answer4.Location = new System.Drawing.Point(29, 346);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(648, 45);
            this.Answer4.TabIndex = 6;
            this.Answer4.Text = "";
            // 
            // Answer5
            // 
            this.Answer5.Location = new System.Drawing.Point(29, 396);
            this.Answer5.Name = "Answer5";
            this.Answer5.Size = new System.Drawing.Size(648, 43);
            this.Answer5.TabIndex = 7;
            this.Answer5.Text = "";
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Location = new System.Drawing.Point(521, 163);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.ok;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(705, 451);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Answer5);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.number);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.RichTextBox Answer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TextBox number;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RichTextBox Answer2;
        private System.Windows.Forms.RichTextBox Answer3;
        private System.Windows.Forms.RichTextBox Answer4;
        private System.Windows.Forms.RichTextBox Answer5;
        private System.Windows.Forms.Button Exit;
    }
}

