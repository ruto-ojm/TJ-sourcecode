//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/17
// 変更履歴 ：
//   - 2025/06/17 新規作成（初版）
//   - 2025/06/22 関数の選択肢に加算・最大・平均などを追加
//   - 2025/06/27 計算実行後、結果をラベルに表示するように修正
//   - 2025/07/01 入力欄の初期化処理と簡易エラー表示を追加
// ソース概要：
//   関数の選択と実行を行う画面。パラメータを3つ入力し、指定関数により計算を行い結果を表示する。
//=================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        // このフォーム内で保持する関数登録の履歴（画面ローカル）
        // 利用者が登録した関数情報を一時的に保存し、重複チェックなどに使用する
        private List<FunctionEntry> functions = new List<FunctionEntry>();

        public Form7()
        {
            InitializeComponent();
        }

        // トラックバー1の値が変更されたとき、対応する値をテキストボックス1にリアルタイム反映
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }

        // トラックバー2 → テキストボックス2に値を表示
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
        }

        // トラックバー3 → テキストボックス3に値を表示（入力名を含むケースもある）
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = trackBar3.Value.ToString();
        }

        // 関数の登録ボタン処理
        private void button2_Click(object sender, EventArgs e)
        {
            // 入力された関数名を取得（前後空白除去）
            string funcName = textBox3.Text.Trim();

            // 入力チェック：関数名が空であればエラー表示
            if (string.IsNullOrEmpty(funcName))
            {
                MessageBox.Show("関数名を入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // トラックバーから取得した値を使って数値引数を取得
            int val1 = trackBar1.Value; // 交通量など
            int val2 = trackBar2.Value; // 車線数など
            int val3 = trackBar3.Value; // 歩行者数など（任意）

            // すでに同じ名前の関数が登録されていないか確認
            // 大文字小文字を無視して比較（例："FuncA" と "funca" は同一とみなす）
            bool nameExists = functions.Any(f => f.FunctionName.Equals(funcName, StringComparison.OrdinalIgnoreCase));
            if (nameExists)
            {
                MessageBox.Show("同じ名前の関数がすでに登録されています。", "重複エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 同じ引数の組み合わせを持つ関数が登録済みかチェック
            // データの重複を避けるため、数値の一致でも警告を出す
            bool sameValuesExist = functions.Any(f => f.Value1 == val1 && f.Value2 == val2 && f.Value3 == val3);
            if (sameValuesExist)
            {
                MessageBox.Show("全く同じ変数の関数が登録されています。", "重複エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 新しい関数エントリを作成し、ローカルリストに追加
            FunctionEntry newFunc = new FunctionEntry(funcName, val1, val2, val3);
            functions.Add(newFunc);

            // 成功メッセージの表示（登録済み情報を文字列で表示）
            MessageBox.Show($"関数 '{newFunc}' を登録しました。", "登録成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 関数名の入力欄を初期化（次の入力に備える）
            textBox3.Clear();
        }

        // 戻るボタンの処理：利用者メニューに戻る
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // メニュー画面を新たに生成
            form3.Show();              // 表示
            this.Hide();               // 非表示にしてフォームを再利用可能に保つ
        }
    }
}
