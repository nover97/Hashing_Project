namespace Hashing_Project
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
        protected override void Dispose( bool disposing )
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
            this.orgnTBx = new System.Windows.Forms.RichTextBox();
            this.md5ChkBx = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.md5TBx = new System.Windows.Forms.TextBox();
            this.md5CpyBtn = new System.Windows.Forms.Button();
            this.sha1CpyBtn = new System.Windows.Forms.Button();
            this.sha1TBx = new System.Windows.Forms.TextBox();
            this.sha1ChkBx = new System.Windows.Forms.CheckBox();
            this.sha256CpyBtn = new System.Windows.Forms.Button();
            this.sha256TBx = new System.Windows.Forms.TextBox();
            this.sha256ChkBx = new System.Windows.Forms.CheckBox();
            this.sha512CpyBtn = new System.Windows.Forms.Button();
            this.sha512TBx = new System.Windows.Forms.TextBox();
            this.sha512ChkBx = new System.Windows.Forms.CheckBox();
            this.sha384CpyBtn = new System.Windows.Forms.Button();
            this.sha384TBx = new System.Windows.Forms.TextBox();
            this.sha384ChkBx = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orgnTBx
            // 
            this.orgnTBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orgnTBx.Location = new System.Drawing.Point(115, 12);
            this.orgnTBx.Name = "orgnTBx";
            this.orgnTBx.Size = new System.Drawing.Size(681, 64);
            this.orgnTBx.TabIndex = 0;
            this.orgnTBx.Text = "";
            this.orgnTBx.Click += new System.EventHandler(this.orgnTBx_Click);
            this.orgnTBx.TextChanged += new System.EventHandler(this.orgnTBx_TextChanged);
            // 
            // md5ChkBx
            // 
            this.md5ChkBx.AutoSize = true;
            this.md5ChkBx.Location = new System.Drawing.Point(12, 97);
            this.md5ChkBx.Name = "md5ChkBx";
            this.md5ChkBx.Size = new System.Drawing.Size(77, 17);
            this.md5ChkBx.TabIndex = 1;
            this.md5ChkBx.Text = "MD5 Hash";
            this.md5ChkBx.UseVisualStyleBackColor = true;
            this.md5ChkBx.CheckedChanged += new System.EventHandler(this.md5ChkBx_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // md5TBx
            // 
            this.md5TBx.Location = new System.Drawing.Point(115, 94);
            this.md5TBx.Multiline = true;
            this.md5TBx.Name = "md5TBx";
            this.md5TBx.ReadOnly = true;
            this.md5TBx.Size = new System.Drawing.Size(600, 20);
            this.md5TBx.TabIndex = 4;
            this.md5TBx.Text = "Your MD5 hash will appear here";
            // 
            // md5CpyBtn
            // 
            this.md5CpyBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.md5CpyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.md5CpyBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.md5CpyBtn.Location = new System.Drawing.Point(721, 92);
            this.md5CpyBtn.Name = "md5CpyBtn";
            this.md5CpyBtn.Size = new System.Drawing.Size(75, 23);
            this.md5CpyBtn.TabIndex = 5;
            this.md5CpyBtn.Text = "COPY";
            this.md5CpyBtn.UseVisualStyleBackColor = false;
            this.md5CpyBtn.Click += new System.EventHandler(this.md5CpyBtn_Click);
            // 
            // sha1CpyBtn
            // 
            this.sha1CpyBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sha1CpyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sha1CpyBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.sha1CpyBtn.Location = new System.Drawing.Point(721, 128);
            this.sha1CpyBtn.Name = "sha1CpyBtn";
            this.sha1CpyBtn.Size = new System.Drawing.Size(75, 23);
            this.sha1CpyBtn.TabIndex = 8;
            this.sha1CpyBtn.Text = "COPY";
            this.sha1CpyBtn.UseVisualStyleBackColor = false;
            this.sha1CpyBtn.Click += new System.EventHandler(this.sha1CpyBtn_Click);
            // 
            // sha1TBx
            // 
            this.sha1TBx.Location = new System.Drawing.Point(115, 130);
            this.sha1TBx.Multiline = true;
            this.sha1TBx.Name = "sha1TBx";
            this.sha1TBx.ReadOnly = true;
            this.sha1TBx.Size = new System.Drawing.Size(600, 20);
            this.sha1TBx.TabIndex = 7;
            this.sha1TBx.Text = "Your SHA-1 hash will appear here";
            // 
            // sha1ChkBx
            // 
            this.sha1ChkBx.AutoSize = true;
            this.sha1ChkBx.Location = new System.Drawing.Point(12, 132);
            this.sha1ChkBx.Name = "sha1ChkBx";
            this.sha1ChkBx.Size = new System.Drawing.Size(85, 17);
            this.sha1ChkBx.TabIndex = 6;
            this.sha1ChkBx.Text = "SHA-1 Hash";
            this.sha1ChkBx.UseVisualStyleBackColor = true;
            this.sha1ChkBx.CheckedChanged += new System.EventHandler(this.sha1ChkBx_CheckedChanged);
            // 
            // sha256CpyBtn
            // 
            this.sha256CpyBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sha256CpyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sha256CpyBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.sha256CpyBtn.Location = new System.Drawing.Point(721, 164);
            this.sha256CpyBtn.Name = "sha256CpyBtn";
            this.sha256CpyBtn.Size = new System.Drawing.Size(75, 23);
            this.sha256CpyBtn.TabIndex = 11;
            this.sha256CpyBtn.Text = "COPY";
            this.sha256CpyBtn.UseVisualStyleBackColor = false;
            this.sha256CpyBtn.Click += new System.EventHandler(this.sha256CpyBtn_Click);
            // 
            // sha256TBx
            // 
            this.sha256TBx.Location = new System.Drawing.Point(115, 166);
            this.sha256TBx.Multiline = true;
            this.sha256TBx.Name = "sha256TBx";
            this.sha256TBx.ReadOnly = true;
            this.sha256TBx.Size = new System.Drawing.Size(600, 20);
            this.sha256TBx.TabIndex = 10;
            this.sha256TBx.Text = "Your SHA-256 hash will appear here";
            // 
            // sha256ChkBx
            // 
            this.sha256ChkBx.AutoSize = true;
            this.sha256ChkBx.Location = new System.Drawing.Point(12, 170);
            this.sha256ChkBx.Name = "sha256ChkBx";
            this.sha256ChkBx.Size = new System.Drawing.Size(97, 17);
            this.sha256ChkBx.TabIndex = 9;
            this.sha256ChkBx.Text = "SHA-256 Hash";
            this.sha256ChkBx.UseVisualStyleBackColor = true;
            this.sha256ChkBx.CheckedChanged += new System.EventHandler(this.sha256ChkBx_CheckedChanged);
            // 
            // sha512CpyBtn
            // 
            this.sha512CpyBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sha512CpyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sha512CpyBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.sha512CpyBtn.Location = new System.Drawing.Point(721, 236);
            this.sha512CpyBtn.Name = "sha512CpyBtn";
            this.sha512CpyBtn.Size = new System.Drawing.Size(75, 23);
            this.sha512CpyBtn.TabIndex = 17;
            this.sha512CpyBtn.Text = "COPY";
            this.sha512CpyBtn.UseVisualStyleBackColor = false;
            this.sha512CpyBtn.Click += new System.EventHandler(this.sha512CpyBtn_Click);
            // 
            // sha512TBx
            // 
            this.sha512TBx.Location = new System.Drawing.Point(115, 238);
            this.sha512TBx.Multiline = true;
            this.sha512TBx.Name = "sha512TBx";
            this.sha512TBx.ReadOnly = true;
            this.sha512TBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sha512TBx.Size = new System.Drawing.Size(600, 20);
            this.sha512TBx.TabIndex = 16;
            this.sha512TBx.Text = "Your SHA-512 hash will appear here";
            // 
            // sha512ChkBx
            // 
            this.sha512ChkBx.AutoSize = true;
            this.sha512ChkBx.Location = new System.Drawing.Point(12, 243);
            this.sha512ChkBx.Name = "sha512ChkBx";
            this.sha512ChkBx.Size = new System.Drawing.Size(97, 17);
            this.sha512ChkBx.TabIndex = 15;
            this.sha512ChkBx.Text = "SHA-256 Hash";
            this.sha512ChkBx.UseVisualStyleBackColor = true;
            this.sha512ChkBx.CheckedChanged += new System.EventHandler(this.sha512ChkBx_CheckedChanged);
            // 
            // sha384CpyBtn
            // 
            this.sha384CpyBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sha384CpyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sha384CpyBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.sha384CpyBtn.Location = new System.Drawing.Point(721, 200);
            this.sha384CpyBtn.Name = "sha384CpyBtn";
            this.sha384CpyBtn.Size = new System.Drawing.Size(75, 23);
            this.sha384CpyBtn.TabIndex = 14;
            this.sha384CpyBtn.Text = "COPY";
            this.sha384CpyBtn.UseVisualStyleBackColor = false;
            this.sha384CpyBtn.Click += new System.EventHandler(this.sha384CpyBtn_Click);
            // 
            // sha384TBx
            // 
            this.sha384TBx.Location = new System.Drawing.Point(115, 202);
            this.sha384TBx.Multiline = true;
            this.sha384TBx.Name = "sha384TBx";
            this.sha384TBx.ReadOnly = true;
            this.sha384TBx.Size = new System.Drawing.Size(600, 20);
            this.sha384TBx.TabIndex = 13;
            this.sha384TBx.Text = "Your SHA-384 hash will appear here";
            // 
            // sha384ChkBx
            // 
            this.sha384ChkBx.AutoSize = true;
            this.sha384ChkBx.Location = new System.Drawing.Point(12, 205);
            this.sha384ChkBx.Name = "sha384ChkBx";
            this.sha384ChkBx.Size = new System.Drawing.Size(97, 17);
            this.sha384ChkBx.TabIndex = 12;
            this.sha384ChkBx.Text = "SHA-384 Hash";
            this.sha384ChkBx.UseVisualStyleBackColor = true;
            this.sha384ChkBx.CheckedChanged += new System.EventHandler(this.sha384ChkBx_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "INSERT TEXT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "OR";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Magenta;
            this.button1.Location = new System.Drawing.Point(34, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Choose File";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sha512CpyBtn);
            this.Controls.Add(this.sha512TBx);
            this.Controls.Add(this.sha512ChkBx);
            this.Controls.Add(this.sha384CpyBtn);
            this.Controls.Add(this.sha384TBx);
            this.Controls.Add(this.sha384ChkBx);
            this.Controls.Add(this.sha256CpyBtn);
            this.Controls.Add(this.sha256TBx);
            this.Controls.Add(this.sha256ChkBx);
            this.Controls.Add(this.sha1CpyBtn);
            this.Controls.Add(this.sha1TBx);
            this.Controls.Add(this.sha1ChkBx);
            this.Controls.Add(this.md5CpyBtn);
            this.Controls.Add(this.md5TBx);
            this.Controls.Add(this.md5ChkBx);
            this.Controls.Add(this.orgnTBx);
            this.Name = "Form1";
            this.Text = "Hash App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox orgnTBx;
        private System.Windows.Forms.CheckBox md5ChkBx;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox md5TBx;
        private System.Windows.Forms.Button md5CpyBtn;
        private System.Windows.Forms.Button sha1CpyBtn;
        private System.Windows.Forms.TextBox sha1TBx;
        private System.Windows.Forms.CheckBox sha1ChkBx;
        private System.Windows.Forms.Button sha256CpyBtn;
        private System.Windows.Forms.TextBox sha256TBx;
        private System.Windows.Forms.CheckBox sha256ChkBx;
        private System.Windows.Forms.Button sha512CpyBtn;
        private System.Windows.Forms.TextBox sha512TBx;
        private System.Windows.Forms.CheckBox sha512ChkBx;
        private System.Windows.Forms.Button sha384CpyBtn;
        private System.Windows.Forms.TextBox sha384TBx;
        private System.Windows.Forms.CheckBox sha384ChkBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

