namespace person_log
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.maincontrols = new System.Windows.Forms.GroupBox();
            this.openSelectedLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loglist = new System.Windows.Forms.ListBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.post = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.text_label = new System.Windows.Forms.Label();
            this.textText = new System.Windows.Forms.TextBox();
            this.reader = new System.Windows.Forms.TextBox();
            this.maincontrols.SuspendLayout();
            this.SuspendLayout();
            // 
            // maincontrols
            // 
            this.maincontrols.Controls.Add(this.openSelectedLog);
            this.maincontrols.Controls.Add(this.label1);
            this.maincontrols.Controls.Add(this.loglist);
            this.maincontrols.Controls.Add(this.nameText);
            this.maincontrols.Controls.Add(this.post);
            this.maincontrols.Controls.Add(this.name_label);
            this.maincontrols.Controls.Add(this.text_label);
            this.maincontrols.Controls.Add(this.textText);
            this.maincontrols.Location = new System.Drawing.Point(12, 12);
            this.maincontrols.Name = "maincontrols";
            this.maincontrols.Size = new System.Drawing.Size(447, 418);
            this.maincontrols.TabIndex = 6;
            this.maincontrols.TabStop = false;
            // 
            // openSelectedLog
            // 
            this.openSelectedLog.Location = new System.Drawing.Point(25, 389);
            this.openSelectedLog.Name = "openSelectedLog";
            this.openSelectedLog.Size = new System.Drawing.Size(75, 23);
            this.openSelectedLog.TabIndex = 8;
            this.openSelectedLog.Text = "Open";
            this.openSelectedLog.UseVisualStyleBackColor = true;
            this.openSelectedLog.Click += new System.EventHandler(this.openSelectedLog_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(25, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 2);
            this.label1.TabIndex = 7;
            // 
            // loglist
            // 
            this.loglist.FormattingEnabled = true;
            this.loglist.Location = new System.Drawing.Point(25, 171);
            this.loglist.Name = "loglist";
            this.loglist.Size = new System.Drawing.Size(405, 199);
            this.loglist.TabIndex = 6;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(66, 31);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(139, 20);
            this.nameText.TabIndex = 0;
            // 
            // post
            // 
            this.post.Location = new System.Drawing.Point(25, 105);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(75, 23);
            this.post.TabIndex = 4;
            this.post.Text = "Post";
            this.post.UseVisualStyleBackColor = true;
            this.post.Click += new System.EventHandler(this.post_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(25, 34);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(38, 13);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Name:";
            // 
            // text_label
            // 
            this.text_label.AutoSize = true;
            this.text_label.Location = new System.Drawing.Point(25, 69);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(31, 13);
            this.text_label.TabIndex = 3;
            this.text_label.Text = "Text:";
            // 
            // textText
            // 
            this.textText.Location = new System.Drawing.Point(66, 66);
            this.textText.Name = "textText";
            this.textText.Size = new System.Drawing.Size(364, 20);
            this.textText.TabIndex = 2;
            // 
            // reader
            // 
            this.reader.Location = new System.Drawing.Point(465, 12);
            this.reader.Multiline = true;
            this.reader.Name = "reader";
            this.reader.ReadOnly = true;
            this.reader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reader.Size = new System.Drawing.Size(413, 412);
            this.reader.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.reader);
            this.Controls.Add(this.maincontrols);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.maincontrols.ResumeLayout(false);
            this.maincontrols.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox maincontrols;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button post;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label text_label;
        private System.Windows.Forms.TextBox textText;
        private System.Windows.Forms.Button openSelectedLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox loglist;
        private System.Windows.Forms.TextBox reader;
    }
}