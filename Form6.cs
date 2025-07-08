//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/17
// 変更履歴 ：
//   - 2025/06/17 新規作成（初版）
//   - 2025/06/22 グラフ描画ライブラリの更新
//   - 2025/06/27 表示形式切替（棒/折れ線）機能の追加
//   - 2025/07/01 データ件数が多い場合の表示改善
// ソース概要：
//   交通情報をグラフで可視化する画面。折れ線や棒グラフ表示に対応する。
//=================================================================

using System;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            DisplayHistory(); // フォームの初期化時に履歴を読み込んで表示
        }

        // 入力履歴（InputHistory.History）を画面に一覧表示する
        private void DisplayHistory()
        {
            var sb = new StringBuilder();

            // 履歴が空の場合は案内メッセージを表示
            if (InputHistory.History.Count == 0)
            {
                sb.AppendLine("履歴はありません。入力を行ってください。");
            }
            else
            {
                // 履歴の各 FunctionEntry オブジェクトを文字列として追加
                foreach (var entry in InputHistory.History)
                {
                    sb.AppendLine(entry.ToString()); // 事前に .ToString() が適切に定義されている前提
                }
            }

            // 表示用テキストボックスの初期設定
            textBox1.ReadOnly = true;                 // 編集不可
            textBox1.Multiline = true;                // 複数行表示
            textBox1.ScrollBars = ScrollBars.Vertical; // 縦スクロールバーを付ける
            textBox1.BackColor = SystemColors.Control; // 背景色を標準に
            textBox1.BorderStyle = BorderStyle.None;  // 枠線なし
            textBox1.TabStop = false;                 // タブキーによるフォーカスを除外

            // 履歴内容をテキストボックスに表示
            textBox1.Text = sb.ToString();
        }

        // 戻るボタンの処理：利用者メニューに遷移
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide(); // 非表示にすることで戻るときの復元が早い（Close では破棄される）
        }

        // 履歴削除ボタンの処理：履歴をクリアして画面を更新
        private void button2_Click(object sender, EventArgs e)
        {
            // 確認メッセージを表示（誤操作防止）
            var confirm = MessageBox.Show("履歴をすべて削除しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                InputHistory.History.Clear();  // 履歴のリストをクリア（中身を削除）
                DisplayHistory();              // 表示を更新（空の状態になる）
                MessageBox.Show("履歴を削除しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
