//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/17
// 変更履歴 ：
//   - 2025/06/17 新規作成（ログイン画面 UI）
//   - 2025/06/22 レイアウト・フォント調整（ボタン、ラベル、テキストボックス）
//   - 2025/06/27 textBox2にパスワードマスク処理を追加（UseSystemPasswordChar）
//   - 2025/07/05 コメント詳細化と配置位置の再整理
// ソース概要：
//   Form1 はログイン画面として機能し、IDとパスワード入力を受け付ける。
//   ユーザーが正しい資格情報を入力すると、システムのメニュー画面に遷移する。
//   本ファイルは Visual Studio のフォームデザイナによって自動生成される UI 構成コードを含む。
//=================================================================

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 使用しているコンポーネント（UI部品）を格納するコンテナ
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべて破棄してメモリリークを防止する
        /// </summary>
        /// <param name="disposing">
        /// true：マネージドリソースを含めてすべて破棄、false：アンマネージドのみ破棄
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // コンポーネントの破棄
            }
            base.Dispose(disposing); // 基底クラスのDispose呼び出し
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// フォームのレイアウトとUI部品を初期化するメソッド
        /// Visual Studio のデザイナによって自動生成される
        /// </summary>
        private void InitializeComponent()
        {
            // --- コントロールの生成とプロパティ設定 ---
            this.button1 = new System.Windows.Forms.Button();   // ログインボタン
            this.label1 = new System.Windows.Forms.Label();     // IDラベル
            this.label2 = new System.Windows.Forms.Label();     // パスワードラベル
            this.textBox1 = new System.Windows.Forms.TextBox(); // ID入力欄
            this.textBox2 = new System.Windows.Forms.TextBox(); // パスワード入力欄
            this.SuspendLayout(); // レイアウト処理一時停止（パフォーマンス向上）

            // 
            // button1（ログインボタン）
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.button1.Location = new System.Drawing.Point(665, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 107);
            this.button1.TabIndex = 0;
            this.button1.Text = "ログイン";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click); // 認証イベント

            // 
            // label1（IDラベル）
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label1.Location = new System.Drawing.Point(87, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";

            // 
            // label2（パスワードラベル）
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label2.Location = new System.Drawing.Point(46, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "パスワード";

            // 
            // textBox1（ID入力欄）
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.textBox1.Location = new System.Drawing.Point(302, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(686, 61);
            this.textBox1.TabIndex = 3;

            // 
            // textBox2（パスワード入力欄）
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.textBox2.Location = new System.Drawing.Point(302, 335);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(686, 61);
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSystemPasswordChar = true; // 入力値をマスク表示（●など）

            // 
            // Form1（ログインフォーム本体）
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 621);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "ログイン画面";
            this.ResumeLayout(false);
            this.PerformLayout(); // コントロールの自動レイアウト再開
        }

        #endregion

        // --- フィールド（コントロール定義） ---
        private System.Windows.Forms.Button button1;   // ログインボタン
        private System.Windows.Forms.Label label1;     // ID ラベル
        private System.Windows.Forms.Label label2;     // パスワード ラベル
        private System.Windows.Forms.TextBox textBox1; // ID 入力欄
        private System.Windows.Forms.TextBox textBox2; // パスワード入力欄
    }
}
