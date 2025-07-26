//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/17
// 変更履歴 ：
//   - 2025/06/17 新規作成（初版）
//   - 2025/06/22 ヘルプボタン追加
//   - 2025/06/27 操作マニュアルへのリンクを追加
//   - 2025/07/01 利用者ログ取得処理の追加
// ソース概要：
//   一般利用者用のメニュー画面。利用者向けの操作に対応する。
//=================================================================

using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // ボタン1：情報入力画面（Form4）へ遷移
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(); // 入力画面を生成
            form4.Show();              // 表示
            this.Close();              // 現在のフォームを閉じる（Hideよりリソース解放）
        }

        // ボタン2：関数登録画面（Form7）へ遷移
        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(); // 関数登録フォームを生成
            form7.Show();
            this.Close();
        }

        // ボタン3：履歴閲覧画面（Form6）へ遷移
        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(); // 履歴画面を生成
            form6.Show();
            this.Close();
        }

        // ボタン4：ログアウト → ログイン画面（Form1）へ戻る
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // ログインフォームを生成
            form1.Show();
            this.Close();
        }
    }
}
