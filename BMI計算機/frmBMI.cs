using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI計算機
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
            this.KeyPreview = true;
            // 將 Enter 鍵對應為按下 btnRun
            this.AcceptButton = this.btnRun;
            // 將 Escape 鍵對應為按下 btnClear
            this.CancelButton = this.btnClear;
            // 在 txtHeight 的 KeyDown 事件中，按「向下鍵」跳到 txtWeight
            this.txtHeight.PreviewKeyDown += txtHeight_PreviewKeyDown;
            this.txtHeight.KeyDown += txtHeight_KeyDown;
            // 在 txtWeight 的 KeyDown 事件中，按「向上鍵」跳回 txtHeight
            this.txtWeight.PreviewKeyDown += txtWeight_PreviewKeyDown;
            this.txtWeight.KeyDown += txtWeight_KeyDown; 
            // 初始化錯誤訊息 Label
            this.lblError.Text = "";
            this.lblError.ForeColor = Color.Red;
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            lblError.Text = ""; // 每次計算前清空錯誤訊息
            bool isHeightValid = Double.TryParse(this.txtHeight.Text, out double height);
            bool isWeightValid = Double.TryParse(this.txtWeight.Text, out double weight);

            // 驗證身高
            if (!isHeightValid || height <= 0)
            {
                lblError.Text = "請輸入有效且大於零的身高數值。";
                this.txtHeight.Focus();
                this.txtHeight.SelectAll();
                return;
            }

            // 驗證體重
            if (!isWeightValid || weight <= 0)
            {
                lblError.Text = "請輸入有效且大於零的體重數值。";
                this.txtWeight.Focus();
                this.txtWeight.SelectAll();
                return;
            }

            //將身高從公分轉換為公尺
            height = height / 100;

            //計算BMI
            double bmi = weight / (height * height);

            string[] strResultList = { "體重過輕", "健康體位", "體重過重", "輕度肥胖", "中度肥胖", "重度肥胖" };
            Color[] colorList =
            {
                Color.FromArgb(60, 120, 160),
                Color.FromArgb(60, 140, 100),
                Color.FromArgb(160, 140, 60),
                Color.FromArgb(160, 110, 60),
                Color.FromArgb(160, 80, 80),
                Color.FromArgb(120, 90, 150)
};

            int iResultIndex;
            if (bmi < 18.5) iResultIndex = 0;
            else if (bmi < 24) iResultIndex = 1;
            else if (bmi < 27) iResultIndex = 2;
            else if (bmi < 30) iResultIndex = 3;
            else if (bmi < 35) iResultIndex = 4;
            else iResultIndex = 5;

            this.lblResult.Text = $"{bmi:F2} ({strResultList[iResultIndex]})";
            this.lblResult.BackColor = colorList[iResultIndex];
        }
        private void ClearInput()
        {
            this.txtHeight.Text = "";
            this.txtWeight.Text = "";
            this.lblResult.Text = "";
            this.lblResult.BackColor = Color.Transparent;
            this.lblError.Text = "";
            // 把焦點回到身高欄位
            this.txtHeight.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("是否清除所有資料？", "確認清除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ClearInput();
            }
        }
        private void frmBMI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                var result = MessageBox.Show("是否清除所有資料？", "確認清除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ClearInput();
                }
            }
        }
        // 在身高欄位按「向下鍵」跳到體重
        private void txtHeight_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.IsInputKey = true;
            }
        }
        private void txtHeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;
                this.txtWeight.Focus();
                this.txtWeight.SelectAll();
            }
        }
        // 在體重欄位按「向上鍵」跳到身高
        private void txtWeight_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                e.IsInputKey = true;
            }
        }
        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true;
                this.txtHeight.Focus();
                this.txtHeight.SelectAll();
            }
        }
    }
}
