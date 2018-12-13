using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LotteryTest
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtIds.Lines.Length == 0)
            {
                MessageBox.Show("请导入抽奖号！", "温馨提示");
                return;
            }

            if (nudCount.Value <= 0)
            {
                MessageBox.Show("请输出正确的抽奖数量！", "温馨提示");
                return;
            }
            var maxCount = txtIds.Lines.Length * 1000;
            var values = txtIds.Lines.Select(p => new { 标识 = p, 抽奖号 = new Random(Guid.NewGuid().GetHashCode()).Next(maxCount) }).OrderBy(p => p.抽奖号).Take((int)nudCount.Value).ToList();
            lbResult.DataSource = values;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCreate100_Click(object sender, EventArgs e) => txtIds.Lines = Enumerable.Range(1, 100).Select(p => "Test" + p).ToArray();

        private void btnImport_Click(object sender, EventArgs e) => ofdTxt.ShowDialog();

        private void ofdTxt_FileOk(object sender, System.ComponentModel.CancelEventArgs e) => txtIds.Lines = File.ReadAllLines(ofdTxt.FileName).Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();
    }
}
