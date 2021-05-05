namespace Bookmarks
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LinkList = new System.Windows.Forms.FlowLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label_Link = new System.Windows.Forms.Label();
            this.label_Info = new System.Windows.Forms.Label();
            this.label_Input = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "InputLink";
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(53, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 27);
            this.textBox1.TabIndex = 0;
            // 
            // LinkList
            // 
            this.LinkList.Location = new System.Drawing.Point(53, 118);
            this.LinkList.Name = "LinkList";
            this.LinkList.Size = new System.Drawing.Size(250, 250);
            this.LinkList.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(253, 62);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(427, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 27);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(427, 195);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 117);
            this.textBox3.TabIndex = 4;
            // 
            // label_Link
            // 
            this.label_Link.AutoSize = true;
            this.label_Link.Location = new System.Drawing.Point(437, 83);
            this.label_Link.Name = "label_Link";
            this.label_Link.Size = new System.Drawing.Size(49, 20);
            this.label_Link.TabIndex = 5;
            this.label_Link.Text = "Name";
            this.label_Link.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Location = new System.Drawing.Point(437, 160);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(35, 20);
            this.label_Info.TabIndex = 6;
            this.label_Info.Text = "Info";
            // 
            // label_Input
            // 
            this.label_Input.AutoSize = true;
            this.label_Input.Location = new System.Drawing.Point(53, 27);
            this.label_Input.Name = "label_Input";
            this.label_Input.Size = new System.Drawing.Size(73, 20);
            this.label_Input.TabIndex = 7;
            this.label_Input.Text = "new mark";
            // 
            // Form1
            // 
            this.AccessibleName = "InputLink";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.label_Input);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.label_Link);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.LinkList);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "Form1";
            this.Text = "BookMark_Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel LinkList;
        public System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label_Link;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Label label_Input;
    }
}

