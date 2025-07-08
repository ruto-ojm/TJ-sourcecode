//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/17
// 変更履歴 ：
//   - 2025/06/17 新規作成（初版）
//   - 2025/06/22 管理者メニューに新規登録リンクを追加
//   - 2025/06/27 ユーザーリスト表示の不具合修正
//   - 2025/07/01 レイアウトのレスポンシブ対応
// ソース概要：
//   管理者用のメニュー画面。ユーザー情報や登録機能へのアクセスを提供する。
//=================================================================

using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // ボタン1：新規ユーザー登録画面（Form8）へ遷移
        private void button1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(); // 新規ユーザー登録フォームを作成
            form8.Show();              // 新しいフォームを表示
            this.Hide();               // この管理者メニューを非表示（または Close() も可）
        }

        // ボタン2：会員管理画面（Form9）へ遷移
        private void button2_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(); // 会員管理フォームを作成
            form9.Show();              // 新しいフォームを表示
            this.Hide();
        }

        // ボタン3：ログアウト処理 → ログイン画面（Form1）に戻る
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // ログイン画面を再表示
            form1.Show();
            this.Close();              // 現在のフォームは閉じる
        }
    }
}


