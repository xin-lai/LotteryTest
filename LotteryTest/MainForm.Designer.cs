namespace LotteryTest
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtIds = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate100 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.ofdTxt = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIds
            // 
            this.txtIds.Location = new System.Drawing.Point(14, 66);
            this.txtIds.Multiline = true;
            this.txtIds.Name = "txtIds";
            this.txtIds.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIds.Size = new System.Drawing.Size(328, 613);
            this.txtIds.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(446, 94);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(828, 50);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "抽奖";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(526, 35);
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(120, 21);
            this.nudCount.TabIndex = 3;
            this.nudCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 12;
            this.lbResult.Location = new System.Drawing.Point(446, 179);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(828, 496);
            this.lbResult.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "抽奖列表（一行一个）";
            // 
            // btnCreate100
            // 
            this.btnCreate100.Location = new System.Drawing.Point(153, 3);
            this.btnCreate100.Name = "btnCreate100";
            this.btnCreate100.Size = new System.Drawing.Size(189, 23);
            this.btnCreate100.TabIndex = 6;
            this.btnCreate100.Text = "生成100组抽奖列表（用于测试）";
            this.btnCreate100.UseVisualStyleBackColor = true;
            this.btnCreate100.Click += new System.EventHandler(this.btnCreate100_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "抽奖数量";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 3);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(131, 23);
            this.btnImport.TabIndex = 8;
            this.btnImport.Text = "从文本文件导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ofdTxt
            // 
            this.ofdTxt.Filter = "文本文件|*.txt";
            this.ofdTxt.Title = "打开文本文件（一行一个）";
            this.ofdTxt.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdTxt_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 691);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreate100);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtIds);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "送书活动抽奖程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIds;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate100;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog ofdTxt;
    }
}

