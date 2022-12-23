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
            this.orgnTBx = new System.Windows.Forms.RichTextBox();
            this.md5ChkBx = new System.Windows.Forms.CheckBox();
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
            this.openFileBtn = new System.Windows.Forms.Button();
            this.upcChkBx = new System.Windows.Forms.CheckBox();
            this.delFileBtn = new System.Windows.Forms.Button();
            this.fileNameTBx = new System.Windows.Forms.TextBox();
            this.hexChkBx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // orgnTBx
            // 
            this.orgnTBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orgnTBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orgnTBx.Location = new System.Drawing.Point(115, 12);
            this.orgnTBx.Name = "orgnTBx";
            this.orgnTBx.Size = new System.Drawing.Size(660, 64);
            this.orgnTBx.TabIndex = 0;
            this.orgnTBx.Text = "";
            this.orgnTBx.Click += new System.EventHandler(this.orgnTBx_Click);
            this.orgnTBx.TextChanged += new System.EventHandler(this.orgnTBx_TextChanged);
            // 
            // md5ChkBx
            // 
            this.md5ChkBx.AutoSize = true;
            this.md5ChkBx.Location = new System.Drawing.Point(12, 129);
            this.md5ChkBx.Name = "md5ChkBx";
            this.md5ChkBx.Size = new System.Drawing.Size(77, 17);
            this.md5ChkBx.TabIndex = 1;
            this.md5ChkBx.Text = "MD5 Hash";
            this.md5ChkBx.UseVisualStyleBackColor = true;
            this.md5ChkBx.CheckedChanged += new System.EventHandler(this.md5ChkBx_CheckedChanged);
            // 
            // md5TBx
            // 
            this.md5TBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.md5TBx.Location = new System.Drawing.Point(115, 126);
            this.md5TBx.Multiline = true;
            this.md5TBx.Name = "md5TBx";
            this.md5TBx.ReadOnly = true;
            this.md5TBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.md5TBx.Size = new System.Drawing.Size(579, 20);
            this.md5TBx.TabIndex = 4;
            this.md5TBx.Text = "Your MD5 hash will appear here";
            // 
            // md5CpyBtn
            // 
            this.md5CpyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.md5CpyBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.md5CpyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.md5CpyBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.md5CpyBtn.Location = new System.Drawing.Point(700, 124);
            this.md5CpyBtn.Name = "md5CpyBtn";
            this.md5CpyBtn.Size = new System.Drawing.Size(75, 23);
            this.md5CpyBtn.TabIndex = 5;
            this.md5CpyBtn.Text = "COPY";
            this.md5CpyBtn.UseVisualStyleBackColor = false;
            this.md5CpyBtn.Click += new System.EventHandler(this.md5CpyBtn_Click);
            // 
            // sha1CpyBtn
            // 
            this.sha1CpyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sha1CpyBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sha1CpyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sha1CpyBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.sha1CpyBtn.Location = new System.Drawing.Point(700, 160);
            this.sha1CpyBtn.Name = "sha1CpyBtn";
            this.sha1CpyBtn.Size = new System.Drawing.Size(75, 23);
            this.sha1CpyBtn.TabIndex = 8;
            this.sha1CpyBtn.Text = "COPY";
            this.sha1CpyBtn.UseVisualStyleBackColor = false;
            this.sha1CpyBtn.Click += new System.EventHandler(this.sha1CpyBtn_Click);
            // 
            // sha1TBx
            // 
            this.sha1TBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sha1TBx.Location = new System.Drawing.Point(115, 162);
            this.sha1TBx.Multiline = true;
            this.sha1TBx.Name = "sha1TBx";
            this.sha1TBx.ReadOnly = true;
            this.sha1TBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sha1TBx.Size = new System.Drawing.Size(579, 20);
            this.sha1TBx.TabIndex = 7;
            this.sha1TBx.Text = "Your SHA-1 hash will appear here";
            // 
            // sha1ChkBx
            // 
            this.sha1ChkBx.AutoSize = true;
            this.sha1ChkBx.Location = new System.Drawing.Point(12, 164);
            this.sha1ChkBx.Name = "sha1ChkBx";
            this.sha1ChkBx.Size = new System.Drawing.Size(85, 17);
            this.sha1ChkBx.TabIndex = 6;
            this.sha1ChkBx.Text = "SHA-1 Hash";
            this.sha1ChkBx.UseVisualStyleBackColor = true;
            this.sha1ChkBx.CheckedChanged += new System.EventHandler(this.sha1ChkBx_CheckedChanged);
            // 
            // sha256CpyBtn
            // 
            this.sha256CpyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sha256CpyBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sha256CpyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sha256CpyBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.sha256CpyBtn.Location = new System.Drawing.Point(700, 196);
            this.sha256CpyBtn.Name = "sha256CpyBtn";
            this.sha256CpyBtn.Size = new System.Drawing.Size(75, 23);
            this.sha256CpyBtn.TabIndex = 11;
            this.sha256CpyBtn.Text = "COPY";
            this.sha256CpyBtn.UseVisualStyleBackColor = false;
            this.sha256CpyBtn.Click += new System.EventHandler(this.sha256CpyBtn_Click);
            // 
            // sha256TBx
            // 
            this.sha256TBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sha256TBx.Location = new System.Drawing.Point(115, 198);
            this.sha256TBx.Multiline = true;
            this.sha256TBx.Name = "sha256TBx";
            this.sha256TBx.ReadOnly = true;
            this.sha256TBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sha256TBx.Size = new System.Drawing.Size(579, 20);
            this.sha256TBx.TabIndex = 10;
            this.sha256TBx.Text = "Your SHA-256 hash will appear here";
            // 
            // sha256ChkBx
            // 
            this.sha256ChkBx.AutoSize = true;
            this.sha256ChkBx.Location = new System.Drawing.Point(12, 202);
            this.sha256ChkBx.Name = "sha256ChkBx";
            this.sha256ChkBx.Size = new System.Drawing.Size(97, 17);
            this.sha256ChkBx.TabIndex = 9;
            this.sha256ChkBx.Text = "SHA-256 Hash";
            this.sha256ChkBx.UseVisualStyleBackColor = true;
            this.sha256ChkBx.CheckedChanged += new System.EventHandler(this.sha256ChkBx_CheckedChanged);
            // 
            // sha512CpyBtn
            // 
            this.sha512CpyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sha512CpyBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sha512CpyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sha512CpyBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.sha512CpyBtn.Location = new System.Drawing.Point(700, 268);
            this.sha512CpyBtn.Name = "sha512CpyBtn";
            this.sha512CpyBtn.Size = new System.Drawing.Size(75, 23);
            this.sha512CpyBtn.TabIndex = 17;
            this.sha512CpyBtn.Text = "COPY";
            this.sha512CpyBtn.UseVisualStyleBackColor = false;
            this.sha512CpyBtn.Click += new System.EventHandler(this.sha512CpyBtn_Click);
            // 
            // sha512TBx
            // 
            this.sha512TBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sha512TBx.Location = new System.Drawing.Point(115, 270);
            this.sha512TBx.Multiline = true;
            this.sha512TBx.Name = "sha512TBx";
            this.sha512TBx.ReadOnly = true;
            this.sha512TBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sha512TBx.Size = new System.Drawing.Size(579, 20);
            this.sha512TBx.TabIndex = 16;
            this.sha512TBx.Text = "Your SHA-512 hash will appear here";
            // 
            // sha512ChkBx
            // 
            this.sha512ChkBx.AutoSize = true;
            this.sha512ChkBx.Location = new System.Drawing.Point(12, 275);
            this.sha512ChkBx.Name = "sha512ChkBx";
            this.sha512ChkBx.Size = new System.Drawing.Size(97, 17);
            this.sha512ChkBx.TabIndex = 15;
            this.sha512ChkBx.Text = "SHA-512 Hash";
            this.sha512ChkBx.UseVisualStyleBackColor = true;
            this.sha512ChkBx.CheckedChanged += new System.EventHandler(this.sha512ChkBx_CheckedChanged);
            // 
            // sha384CpyBtn
            // 
            this.sha384CpyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sha384CpyBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sha384CpyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sha384CpyBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.sha384CpyBtn.Location = new System.Drawing.Point(700, 232);
            this.sha384CpyBtn.Name = "sha384CpyBtn";
            this.sha384CpyBtn.Size = new System.Drawing.Size(75, 23);
            this.sha384CpyBtn.TabIndex = 14;
            this.sha384CpyBtn.Text = "COPY";
            this.sha384CpyBtn.UseVisualStyleBackColor = false;
            this.sha384CpyBtn.Click += new System.EventHandler(this.sha384CpyBtn_Click);
            // 
            // sha384TBx
            // 
            this.sha384TBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sha384TBx.Location = new System.Drawing.Point(115, 234);
            this.sha384TBx.Multiline = true;
            this.sha384TBx.Name = "sha384TBx";
            this.sha384TBx.ReadOnly = true;
            this.sha384TBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sha384TBx.Size = new System.Drawing.Size(579, 20);
            this.sha384TBx.TabIndex = 13;
            this.sha384TBx.Text = "Your SHA-384 hash will appear here";
            // 
            // sha384ChkBx
            // 
            this.sha384ChkBx.AutoSize = true;
            this.sha384ChkBx.Location = new System.Drawing.Point(12, 237);
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
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "INSERT TEXT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "OR";
            // 
            // openFileBtn
            // 
            this.openFileBtn.BackColor = System.Drawing.Color.MistyRose;
            this.openFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openFileBtn.ForeColor = System.Drawing.Color.Magenta;
            this.openFileBtn.Location = new System.Drawing.Point(115, 86);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(75, 23);
            this.openFileBtn.TabIndex = 20;
            this.openFileBtn.Text = "OPEN FILE";
            this.openFileBtn.UseVisualStyleBackColor = false;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // upcChkBx
            // 
            this.upcChkBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.upcChkBx.AutoSize = true;
            this.upcChkBx.Location = new System.Drawing.Point(698, 306);
            this.upcChkBx.Name = "upcChkBx";
            this.upcChkBx.Size = new System.Drawing.Size(78, 17);
            this.upcChkBx.TabIndex = 21;
            this.upcChkBx.Text = "Uppercase";
            this.upcChkBx.UseVisualStyleBackColor = true;
            this.upcChkBx.CheckedChanged += new System.EventHandler(this.upcChkBx_CheckedChanged);
            // 
            // delFileBtn
            // 
            this.delFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delFileBtn.BackColor = System.Drawing.Color.Firebrick;
            this.delFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delFileBtn.ForeColor = System.Drawing.Color.White;
            this.delFileBtn.Location = new System.Drawing.Point(701, 84);
            this.delFileBtn.Name = "delFileBtn";
            this.delFileBtn.Size = new System.Drawing.Size(75, 23);
            this.delFileBtn.TabIndex = 22;
            this.delFileBtn.Text = "DELETE FILE";
            this.delFileBtn.UseVisualStyleBackColor = false;
            this.delFileBtn.Click += new System.EventHandler(this.delFileBtn_Click);
            // 
            // fileNameTBx
            // 
            this.fileNameTBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTBx.Location = new System.Drawing.Point(196, 86);
            this.fileNameTBx.Multiline = true;
            this.fileNameTBx.Name = "fileNameTBx";
            this.fileNameTBx.ReadOnly = true;
            this.fileNameTBx.Size = new System.Drawing.Size(499, 20);
            this.fileNameTBx.TabIndex = 23;
            // 
            // hexChkBx
            // 
            this.hexChkBx.AutoSize = true;
            this.hexChkBx.Location = new System.Drawing.Point(14, 50);
            this.hexChkBx.Name = "hexChkBx";
            this.hexChkBx.Size = new System.Drawing.Size(83, 17);
            this.hexChkBx.TabIndex = 24;
            this.hexChkBx.Text = "HEX Format";
            this.hexChkBx.UseVisualStyleBackColor = true;
            this.hexChkBx.CheckedChanged += new System.EventHandler(this.hexChkBx_CheckedChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(787, 332);
            this.Controls.Add(this.hexChkBx);
            this.Controls.Add(this.fileNameTBx);
            this.Controls.Add(this.delFileBtn);
            this.Controls.Add(this.upcChkBx);
            this.Controls.Add(this.openFileBtn);
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
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.CheckBox upcChkBx;
        private System.Windows.Forms.Button delFileBtn;
        private System.Windows.Forms.TextBox fileNameTBx;
        private System.Windows.Forms.CheckBox hexChkBx;
    }
}

