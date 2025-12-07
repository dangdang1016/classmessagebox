using System;
using System.Drawing; // 🎯 必須要引用，用於 Point 和 Size

using System.Windows.Forms;

namespace ClassLibrary1
{
    // 如果您沒有自動生成的 Designer.cs 檔案，請移除 'partial'
    public class CustomMessageBoxForm : Form
    {
        private Label lblMessage;
        private Button btnOK;

        // 建構函式 (Constructor)
        public CustomMessageBoxForm()
        {
            // 呼叫初始化 UI 元件的方法
            InitializeComponentManual();
        }

        // 手動初始化所有 UI 元件
        private void InitializeComponentManual()
        {
            // 創建 UI 實例
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();

            // --- Form 屬性設定 ---
            this.Text = "訊息";
            this.ClientSize = new System.Drawing.Size(300, 150); // 設定視窗尺寸
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // 固定邊框，不可調整大小
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen; // 視窗置中
            this.AcceptButton = this.btnOK; // 設定按 Enter 鍵等於點擊 OK

            // --- Label (訊息內容) 設定 ---
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(30, 30);
            this.lblMessage.Text = "預設訊息內容";

            // --- Button (OK 按鈕) 設定 ---
            this.btnOK.Location = new System.Drawing.Point(115, 80);
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.Text = "OK";

            // 設置按鈕點擊事件處理器
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);

            // 將控制項加入到 Form 中
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnOK);
        }

        // 🎯 公開方法：供外部呼叫，設置訊息內容和標題
        public void SetMessage(string message, string caption)
        {
            this.Text = caption; // 設置 Form 的標題
            this.lblMessage.Text = message; // 設置 Label 顯示的內容
        }

        // 🚀 事件處理器：按鈕點擊後的行為
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // 返回 OK 結果
            this.Close(); // 關閉視窗
        }
    }
}