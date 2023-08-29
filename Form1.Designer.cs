namespace BeforePostingIFP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtMaxChar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCopyOriginal = new System.Windows.Forms.Button();
            this.btnCopyFirstComment = new System.Windows.Forms.Button();
            this.btnCopySecondComment = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecondComment = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnPastOriginal = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaxChar
            // 
            resources.ApplyResources(this.txtMaxChar, "txtMaxChar");
            this.txtMaxChar.Name = "txtMaxChar";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaxChar);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtOriginal
            // 
            resources.ApplyResources(this.txtOriginal, "txtOriginal");
            this.txtOriginal.Name = "txtOriginal";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtFirstComment
            // 
            this.txtFirstComment.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.txtFirstComment, "txtFirstComment");
            this.txtFirstComment.Name = "txtFirstComment";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnCopyOriginal
            // 
            this.btnCopyOriginal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.btnCopyOriginal, "btnCopyOriginal");
            this.btnCopyOriginal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCopyOriginal.Name = "btnCopyOriginal";
            this.btnCopyOriginal.UseVisualStyleBackColor = false;
            this.btnCopyOriginal.Click += new System.EventHandler(this.btnCopyOriginal_Click);
            // 
            // btnCopyFirstComment
            // 
            this.btnCopyFirstComment.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.btnCopyFirstComment, "btnCopyFirstComment");
            this.btnCopyFirstComment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCopyFirstComment.Name = "btnCopyFirstComment";
            this.btnCopyFirstComment.UseVisualStyleBackColor = false;
            this.btnCopyFirstComment.Click += new System.EventHandler(this.btnCopyFirstComment_Click);
            // 
            // btnCopySecondComment
            // 
            this.btnCopySecondComment.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.btnCopySecondComment, "btnCopySecondComment");
            this.btnCopySecondComment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCopySecondComment.Name = "btnCopySecondComment";
            this.btnCopySecondComment.UseVisualStyleBackColor = false;
            this.btnCopySecondComment.Click += new System.EventHandler(this.btnCopySecondComment_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtSecondComment
            // 
            this.txtSecondComment.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.txtSecondComment, "txtSecondComment");
            this.txtSecondComment.Name = "txtSecondComment";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btnConvert, "btnConvert");
            this.btnConvert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnPastOriginal
            // 
            this.btnPastOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.btnPastOriginal, "btnPastOriginal");
            this.btnPastOriginal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPastOriginal.Name = "btnPastOriginal";
            this.btnPastOriginal.UseVisualStyleBackColor = false;
            this.btnPastOriginal.Click += new System.EventHandler(this.btnPastOriginal_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.btnClearAll, "btnClearAll");
            this.btnClearAll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // txtTags
            // 
            this.txtTags.BackColor = System.Drawing.SystemColors.InactiveCaption;
            resources.ApplyResources(this.txtTags, "txtTags");
            this.txtTags.Name = "txtTags";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTags);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnPastOriginal);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnCopySecondComment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSecondComment);
            this.Controls.Add(this.btnCopyFirstComment);
            this.Controls.Add(this.btnCopyOriginal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaxChar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCopyOriginal;
        private System.Windows.Forms.Button btnCopyFirstComment;
        private System.Windows.Forms.Button btnCopySecondComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecondComment;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnPastOriginal;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.TextBox txtTags;
    }
}

