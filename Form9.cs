//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/17
// 変更履歴 ：
//   - 2025/06/17 新規作成（初版）
//   - 2025/06/22 一覧にソート機能を追加
//   - 2025/06/27 編集ダイアログのバグ修正
//   - 2025/07/01 削除確認メッセージの改善
// ソース概要：
//   登録済みユーザーの一覧管理画面。編集や削除操作も提供する。
//=================================================================

using System;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            DisplayUsers(); // 起動時に現在登録されているユーザー一覧を表示
        }

        // ユーザー一覧を listBoxUsers に表示する
        private void DisplayUsers()
        {
            listBoxUsers.Items.Clear(); // 既存の項目をすべてクリア

            // ユーザー情報を 1件ずつリストに追加
            foreach (var user in UserRepository.GetAllUsers())
            {
                // 表示形式：ID - 氏名 (メールアドレス)
                listBoxUsers.Items.Add($"{user.Id} - {user.Name} ({user.Email})");
            }
        }

        // 削除ボタンの処理：選択されたユーザーを削除
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // ユーザーが選択されていなければ警告
            if (listBoxUsers.SelectedIndex == -1)
            {
                MessageBox.Show("削除するユーザーを選択してください。", "未選択", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // リストの表示内容からIDを取り出す
            // 表示形式 "userId - 名前 (email)" の先頭部分を分離
            string selectedLine = listBoxUsers.SelectedItem.ToString();
            string selectedId = selectedLine.Split('-')[0].Trim();

            // 削除確認のダイアログを表示
            DialogResult result = MessageBox.Show($"ID: {selectedId} を削除しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // 指定されたIDのユーザーを削除し、リスト表示を更新
                UserRepository.RemoveUser(selectedId);
                DisplayUsers();
            }
        }

        // 戻るボタンの処理：管理者メニュー（Form2）へ戻る
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // 管理者メニュー画面を新しく生成
            form2.Show();              // 表示
            this.Close();              // このフォームは閉じて破棄（戻るだけなので再利用不要）
        }
    }
}