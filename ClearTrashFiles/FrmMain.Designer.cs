﻿namespace ClearTrashFiles
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataFileDir = new System.Windows.Forms.TextBox();
            this.txtSampleFileDir = new System.Windows.Forms.TextBox();
            this.btnDo = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelDir1 = new System.Windows.Forms.Button();
            this.btnSelDir2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据文件目录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "清除文件样本所在目录";
            // 
            // txtDataFileDir
            // 
            this.txtDataFileDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataFileDir.Location = new System.Drawing.Point(146, 12);
            this.txtDataFileDir.Name = "txtDataFileDir";
            this.txtDataFileDir.Size = new System.Drawing.Size(291, 20);
            this.txtDataFileDir.TabIndex = 1;
            // 
            // txtSampleFileDir
            // 
            this.txtSampleFileDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSampleFileDir.Location = new System.Drawing.Point(146, 39);
            this.txtSampleFileDir.Name = "txtSampleFileDir";
            this.txtSampleFileDir.Size = new System.Drawing.Size(291, 20);
            this.txtSampleFileDir.TabIndex = 4;
            // 
            // btnDo
            // 
            this.btnDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDo.Location = new System.Drawing.Point(146, 73);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(291, 23);
            this.btnDo.TabIndex = 6;
            this.btnDo.Text = "开始清理";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnSelDir1
            // 
            this.btnSelDir1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelDir1.Location = new System.Drawing.Point(444, 12);
            this.btnSelDir1.Name = "btnSelDir1";
            this.btnSelDir1.Size = new System.Drawing.Size(75, 23);
            this.btnSelDir1.TabIndex = 2;
            this.btnSelDir1.Text = "选择目录";
            this.btnSelDir1.UseVisualStyleBackColor = true;
            this.btnSelDir1.Click += new System.EventHandler(this.btnSelDir1_Click);
            // 
            // btnSelDir2
            // 
            this.btnSelDir2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelDir2.Location = new System.Drawing.Point(444, 37);
            this.btnSelDir2.Name = "btnSelDir2";
            this.btnSelDir2.Size = new System.Drawing.Size(75, 23);
            this.btnSelDir2.TabIndex = 5;
            this.btnSelDir2.Text = "选择目录";
            this.btnSelDir2.UseVisualStyleBackColor = true;
            this.btnSelDir2.Click += new System.EventHandler(this.btnSelDir2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 108);
            this.Controls.Add(this.btnSelDir2);
            this.Controls.Add(this.btnSelDir1);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.txtSampleFileDir);
            this.Controls.Add(this.txtDataFileDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Clear Trash Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataFileDir;
        private System.Windows.Forms.TextBox txtSampleFileDir;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelDir1;
        private System.Windows.Forms.Button btnSelDir2;
    }
}

