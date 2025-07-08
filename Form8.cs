//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/17
// 変更履歴 ：
//   - 2025/06/17 新規作成（初版）
//   - 2025/06/22 入力項目の必須チェック追加
//   - 2025/06/27 重複IDの検出処理を改善
//   - 2025/07/01 権限選択のUIをドロップダウンに変更
// ソース概要：
//   新規ユーザー登録用の画面。ID、パスワード、権限などを入力して登録する。
//=================================================================

using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        // 登録ボタンがクリックされたときの処理
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // 各テキストボックスから入力値を取得
            string id = textBoxId.Text.Trim();            // ユーザーID（前後空白除去）
            string password = textBoxPassword.Text;       // パスワード
            string name = textBoxName.Text.Trim();        // 氏名
            string email = textBoxEmail.Text.Trim();      // メールアドレス
            bool isAdmin = checkBoxIsAdmin.Checked;       // 管理者として登録するかどうか（チェックボックス）

            // 入力チェック：すべての項目が入力されているか確認
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                // 未入力項目があればエラーメッセージ表示し登録中止
                MessageBox.Show("すべての項目を入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 入力されたIDが既に登録されていないか確認
            if (UserRepository.SearchUser(id) != null)
            {
                // 同一IDが存在する場合は警告表示し登録を拒否
                MessageBox.Show("このIDは既に登録されています。", "登録エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 新しいユーザーオブジェクトを作成（入力情報を渡す）
            User newUser = new User(id, password, isAdmin, name, email);

            // リポジトリへユーザーを追加（CSVファイルにも保存される）
            UserRepository.AddUser(newUser);

            // 登録完了メッセージを表示
            MessageBox.Show("登録が完了しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 入力欄をクリアして初期状態に戻す
            textBoxId.Clear();
            textBoxPassword.Clear();
            textBoxName.Clear();
            textBoxEmail.Clear();
            checkBoxIsAdmin.Checked = false;
        }

        // 戻るボタンがクリックされたとき：管理者メニュー画面に戻る
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // 管理者メニュー画面を新しく生成
            form2.Show();              // 表示
            this.Close();              // この登録画面を閉じる（破棄）
        }
    }
}



