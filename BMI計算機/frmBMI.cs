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
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            bool isHeightValid = Double.TryParse(this.txtHeight.Text, out double height);
            bool isWeightValid = Double.TryParse(this.txtWeight.Text, out double weight);

            //驗證身高輸入
            if (isHeightValid)
            {
                if (height <= 0)
                {
                    MessageBox.Show("身高必須大於零。", "身高值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //將焦點設置回身高輸入框並選取全部文字，方便使用者重新輸入
                    this.txtHeight.Focus();
                    this.txtHeight.SelectAll();
                    return;
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的身高數值。", "身高值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //將焦點設置回身高輸入框並選取全部文字，方便使用者重新輸入
                this.txtHeight.Focus();
                this.txtHeight.SelectAll();
                return;
            }

            //驗證體重輸入
            if (isWeightValid)
            {
                if (weight <= 0)
                {
                    MessageBox.Show("體重必須大於零。", "體重值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //將焦點設置回體重輸入框並選取全部文字，方便使用者重新輸入
                    this.txtWeight.Focus();
                    this.txtWeight.SelectAll();
                    return;
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的體重數值。", "體重值錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //將焦點設置回體重輸入框並選取全部文字，方便使用者重新輸入
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

            //顯示BMI結果
            string strResult = "";
            Color colorResult = Color.Black;
            int iResultIndex = 0;

            if (bmi < 18.5)
            {
                iResultIndex = 0;
            }
            else if (bmi >= 18.5 && bmi < 24)
            {
                iResultIndex = 1;
            }
            else if (bmi >= 24 && bmi < 27)
            {
                iResultIndex = 2;
            }
            else if (bmi >= 27 && bmi < 30)
            {
                iResultIndex = 3;
            }
            else if (bmi >= 30 && bmi < 35)
            {
                iResultIndex = 4;
            }
            else
            {
                iResultIndex = 5;
            }

            strResult = strResultList[iResultIndex];
            colorResult = colorList[iResultIndex];

            this.lblResult.Text = $"{bmi:F2} ({strResult})";
            this.lblResult.BackColor = colorResult;
        }
        private void ClearInput()
        {
            this.txtHeight.Text = "";
            this.txtWeight.Text = "";
            this.lblResult.Text = "";
            this.lblResult.BackColor = Color.Transparent;

            // 把焦點回到身高欄位
            this.txtHeight.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void frmBMI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ClearInput();
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
