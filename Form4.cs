//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/17
// 変更履歴 ：
//   - 2025/06/17 新規作成（初版）
//   - 2025/06/22 入力バリデーション処理追加
//   - 2025/06/27 保存完了メッセージの追加
//   - 2025/07/01 UIの調整とカラー変更
// ソース概要：
//   交通情報の登録を行う画面。地点名・交通量などを入力して保存する。
//=================================================================

using System;
using System.Windows.Forms;
using WindowsFormsApp1; // InputHistory クラスを参照するために必要

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // ボタン1：入力値を登録して計算結果表示画面（Form5）へ遷移
        private void button1_Click(object sender, EventArgs e)
        {
            // 地点名（場所）を取得。Trimで前後の空白除去
            string location = textBox1.Text.Trim();

            // テキストボックスから交通量（整数）を取得。失敗すればエラーメッセージ表示
            if (!int.TryParse(textBox2.Text, out int traffic))
            {
                MessageBox.Show("交通量は整数で入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 車線数の取得（整数変換）
            if (!int.TryParse(textBox3.Text, out int lanes))
            {
                MessageBox.Show("車線数は整数で入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 歩行者数の取得（整数変換）
            if (!int.TryParse(textBox4.Text, out int pedestrians))
            {
                MessageBox.Show("歩行者量は整数で入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 入力値を FunctionEntry オブジェクトとして履歴に追加
            InputHistory.History.Add(new FunctionEntry(location, traffic, lanes, pedestrians));

            // 入力値を用いて最適化計算結果を表示する画面に遷移
            var form5 = new Form5(traffic, lanes, pedestrians, 0); // dummy は区別用（実際は使わない）
            form5.Show();
            this.Hide(); // 現在の入力画面は非表示
        }

        // ボタン2：利用者メニュー（Form3）に戻る
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
