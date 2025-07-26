//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/17
// 変更履歴 ：
//   - 2025/06/17 新規作成（初版）
//   - 2025/06/22 一覧に並び替え機能を追加
//   - 2025/06/27 削除ボタンのアイコン変更
//   - 2025/07/01 表示レイアウトの改善と列幅調整
// ソース概要：
//   登録された交通情報を一覧表示する画面。削除操作が可能。
//=================================================================

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        // 入力値（交通量、車線数、歩行者数）を保持するフィールド
        private int x, y, z;

        // 計算に使用する関数のリスト（FunctionInfoクラスで名前と処理を保持）
        private List<FunctionInfo> functions;

        // Form4 から呼び出されるメインのコンストラクタ
        public Form5(int x, int y, int z)
        {
            InitializeComponent();

            // 結果表示用のテキストボックス設定
            textBox1.ReadOnly = true;                 // 編集不可
            textBox1.Multiline = true;                // 複数行対応
            textBox1.ScrollBars = ScrollBars.Vertical; // 縦スクロールを表示
            textBox1.BackColor = SystemColors.Control; // 背景をシステム標準色に
            textBox1.BorderStyle = BorderStyle.None;  // 枠線をなくす
            textBox1.TabStop = false;                 // タブ移動対象から除外

            // 入力値をフィールドへ格納（あとで使用）
            this.x = x;
            this.y = y;
            this.z = z;

            // 使用する関数の初期化
            // FunctionInfo(string name, Func<int, int, int, double> func)
            functions = new List<FunctionInfo>()
            {
                new FunctionInfo("加算", (a, b, c) => a + b + c),        // 単純な足し算
                new FunctionInfo("乗算", (a, b, c) => a * b * c),        // 掛け算（体積的な意味）
                // 他に必要な関数があればここに追加可能
            };

            // 結果表示の処理を実行（テキストボックスへ表示）
            DisplayResults();
        }

        // Form4 から呼び出されるオーバーロード：dummy は使わずにオーバーロード識別用
        public Form5(int x, int y, int z, int dummy) : this(x, y, z)
        {
            // dummy 引数は意味を持たず、別の呼び出し口として区別するためだけに存在
        }

        // 入力値と計算結果をテキストボックスに表示する処理
        private void DisplayResults()
        {
            var sb = new StringBuilder();

            // 入力値のラベル付き表示
            sb.AppendLine($"入力値: X={x}, Y={y}, Z={z}");
            sb.AppendLine("最適化結果:");

            // それぞれの関数を実行して結果を文字列として蓄積
            foreach (var func in functions)
            {
                double result = func.Calculate(x, y, z);  // 関数の実行
                sb.AppendLine($"{func.Name}: {result}"); // 関数名と結果を表示
            }

            // テキストボックスに表示内容を設定
            textBox1.Text = sb.ToString();
        }

        // 戻るボタンがクリックされた時：利用者メニューに戻る
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // 利用者用メニューを新規生成
            form3.Show();              // 表示
            this.Close();              // この結果表示フォームを閉じる（非表示でなく破棄）
        }
    }
}
