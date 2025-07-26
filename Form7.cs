//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/17
// 変更履歴 ：
//   - 2025/06/17 新規作成（初版）
//   - 2025/06/22 関数の選択肢に加算・最大・平均などを追加
//   - 2025/06/27 計算実行後、結果をラベルに表示するように修正
//   - 2025/07/01 入力欄の初期化処理と簡易エラー表示を追加
// ソース概要：
//   関数の登録を行う画面。パラメータを3つ入力し、任意の関数を登録。
//=================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // Form7クラス：関数登録用フォームの定義
    public partial class Form7 : Form
    {
        // 関数情報を保持するリスト（FunctionEntryは独自のクラス）
        private List<FunctionEntry> functions = new List<FunctionEntry>();

        // コンストラクタ：フォームの初期化処理
        public Form7()
        {
            InitializeComponent(); // コントロール初期化（デザイナで設定された内容）

            // textBox1〜3はtrackBar連動の値表示用：手入力は不可に設定
            textBox1.TabStop = false;                     // Tabキーでフォーカスが当たらないようにする
            textBox1.Cursor = Cursors.Default;            // カーソルを通常に
            textBox1.Enter += (s, e) => this.ActiveControl = null;  // 入力できないようにフォーカス解除

            textBox2.TabStop = false;
            textBox2.Cursor = Cursors.Default;
            textBox2.Enter += (s, e) => this.ActiveControl = null;

            textBox3.TabStop = false;
            textBox3.Cursor = Cursors.Default;
            textBox3.Enter += (s, e) => this.ActiveControl = null;
        }

        // trackBar1の値変更時に対応するtextBox1へ値を反映
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }

        // trackBar2の値変更時に対応するtextBox2へ値を反映
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
        }

        // trackBar3の値変更時に対応するtextBox3へ値を反映
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = trackBar3.Value.ToString();
        }

        // 「登録」ボタンが押されたときの処理（button2_Click）
        private void button2_Click(object sender, EventArgs e)
        {
            string funcName = textBox4.Text.Trim(); // 関数名の取得と前後空白の削除

            // 関数名が空または数字のみ、または空白ならエラー
            if (string.IsNullOrWhiteSpace(funcName) || Regex.IsMatch(funcName, @"^\d+$"))
            {
                MessageBox.Show("関数名には日本語などの意味のある名前を入力してください（数字だけは不可）。", 
                                "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 関数名に少なくとも1文字の日本語（漢字・ひらがな・カタカナ）を含むことを確認
            if (!Regex.IsMatch(funcName, @"\p{IsCJKUnifiedIdeographs}"))
            {
                MessageBox.Show("関数名には少なくとも1文字の日本語を含めてください。",
                                "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // trackBarから現在の値を取得
            int val1 = trackBar1.Value;
            int val2 = trackBar2.Value;
            int val3 = trackBar3.Value;

            // 同じ関数名がすでに登録されていないかをチェック（大文字小文字無視）
            bool nameExists = functions.Any(f => f.FunctionName.Equals(funcName, StringComparison.OrdinalIgnoreCase));
            if (nameExists)
            {
                MessageBox.Show("同じ名前の関数がすでに登録されています。",
                                "重複エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 同じ3つの値を持つ関数が既に存在するかチェック
            bool sameValuesExist = functions.Any(f => f.Value1 == val1 && f.Value2 == val2 && f.Value3 == val3);
            if (sameValuesExist)
            {
                MessageBox.Show("全く同じ変数の関数が登録されています。",
                                "重複エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 新しい関数を作成してリストに追加
            FunctionEntry newFunc = new FunctionEntry(funcName, val1, val2, val3);
            functions.Add(newFunc);

            // 成功メッセージを表示（ToString()でフォーマットされていると想定）
            MessageBox.Show($"関数 '{newFunc}' を登録しました。",
                            "登録成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 関数名入力欄をクリア（他は保持）
            textBox4.Clear();
        }

        // 「戻る」ボタンの処理：Form3を開き、現在のフォームを非表示に
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // Form3のインスタンス生成（メニュー画面など）
            form3.Show();              // Form3を表示
            this.Hide();               // このForm7を非表示にする（閉じない）
        }
    }
}
