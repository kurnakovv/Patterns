
namespace Command
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.UndoSaveBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.UndoPrintBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.UndoOpenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(775, 371);
            this.textBox1.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(12, 415);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UndoSaveBtn
            // 
            this.UndoSaveBtn.Location = new System.Drawing.Point(93, 415);
            this.UndoSaveBtn.Name = "UndoSaveBtn";
            this.UndoSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.UndoSaveBtn.TabIndex = 5;
            this.UndoSaveBtn.Text = "Undo save";
            this.UndoSaveBtn.UseVisualStyleBackColor = true;
            this.UndoSaveBtn.Click += new System.EventHandler(this.UndoSaveBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(315, 415);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(75, 23);
            this.PrintBtn.TabIndex = 6;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // UndoPrintBtn
            // 
            this.UndoPrintBtn.Location = new System.Drawing.Point(396, 415);
            this.UndoPrintBtn.Name = "UndoPrintBtn";
            this.UndoPrintBtn.Size = new System.Drawing.Size(75, 23);
            this.UndoPrintBtn.TabIndex = 7;
            this.UndoPrintBtn.Text = "Undo print";
            this.UndoPrintBtn.UseVisualStyleBackColor = true;
            this.UndoPrintBtn.Click += new System.EventHandler(this.UndoPrintBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(632, 415);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 8;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // UndoOpenBtn
            // 
            this.UndoOpenBtn.Location = new System.Drawing.Point(713, 415);
            this.UndoOpenBtn.Name = "UndoOpenBtn";
            this.UndoOpenBtn.Size = new System.Drawing.Size(75, 23);
            this.UndoOpenBtn.TabIndex = 9;
            this.UndoOpenBtn.Text = "Undo open";
            this.UndoOpenBtn.UseVisualStyleBackColor = true;
            this.UndoOpenBtn.Click += new System.EventHandler(this.UndoOpenBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UndoOpenBtn);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.UndoPrintBtn);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.UndoSaveBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button UndoSaveBtn;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button UndoPrintBtn;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button UndoOpenBtn;
    }
}

