//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/22
// 変更履歴 ：
//   - 2025/06/22 新規作成（計算結果表示画面）
//   - 2025/06/28 戻るボタンと表示欄のフォント・サイズ調整
//   - 2025/07/05 コメント整理と構造明確化
//   - 2025/07/10 レイアウトの微調整とコードの可読性向上
// ソース概要：
//   Form5 は他画面で入力・処理された計算結果を表示するための画面。
//   結果を読みやすく提示し、ユーザーが前の画面に戻れる構成を提供。
//   本ファイルは Visual Studio のデザイナーによって生成される UI 初期化コードを含む。
//=================================================================

namespace WindowsFormsApp1
{
    partial class Form5
    {
        /// <summary>
        /// 使用中のデザイナー生成コンポーネントのコンテナ
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースを破棄し、メモリリークを防止
        /// </summary>
        /// <param name="disposing">
        /// true：マネージドリソースも含めて解放 / false：アンマネージドのみ
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // コンポーネントの破棄
            }
            base.Dispose(disposing); // 基底クラスの破棄処理
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// デザイナーによって生成された UI 初期化処理
        /// フォームのレイアウトやイベントハンドラ登録を行う
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();     // 結果ラベル
            this.textBox1 = new System.Windows.Forms.TextBox(); // 結果表示欄
            this.button1 = new System.Windows.Forms.Button();   // 戻るボタン

            this.SuspendLayout(); // レイアウトの一時停止

            // 
            // label1（結果ラベル）
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(129, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "結果";

            // 
            // textBox1（結果表示欄）
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox1.Location = new System.Drawing.Point(137, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(830, 400);
            this.textBox1.TabIndex = 1;

            // 
            // button1（戻るボタン）
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.button1.Location = new System.Drawing.Point(434, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 97);
            this.button1.TabIndex = 2;
            this.button1.Text = "戻る";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // 
            // Form5（結果表示画面）
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 722);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "計算結果表示"; // 明確な画面タイトル
            this.ResumeLayout(false);
            this.PerformLayout(); // テキストボックス等の再レイアウトを適用
        }

        #endregion

        // --- UIコントロールのフィールド定義 ---
        private System.Windows.Forms.Label label1;      // 結果ラベル
        private System.Windows.Forms.TextBox textBox1;  // 結果表示用テキストボックス
        private System.Windows.Forms.Button button1;    // 戻るボタン
    }
}
