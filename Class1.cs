using System.Windows.Forms;

namespace ClassLibrary1
{
    // 公開靜態類別，提供給外部應用程式呼叫
    public static class CustomMessageBox
    {
        /// <summary>
        /// 顯示自訂的訊息框。
        /// </summary>
        public static DialogResult Show(string message, string caption)
        {
            // 1. 實例化自訂視窗
            CustomMessageBoxForm messageBox = new CustomMessageBoxForm();

            // 2. 設置訊息和標題
            messageBox.SetMessage(message, caption);

            // 3. 顯示模態對話框，並返回結果
            return messageBox.ShowDialog();
        }

        // 額外提供一個只有訊息參數的重載方法
        public static DialogResult Show(string message)
        {
            return Show(message, "系統提示");
        }
    }
}