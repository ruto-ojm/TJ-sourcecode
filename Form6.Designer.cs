//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/23
// 変更履歴 ：
//   - 2025/06/23 新規作成（履歴表示画面 UI）
//   - 2025/06/29 履歴削除ボタンとレイアウト調整を追加
//   - 2025/07/05 コメントを詳細化し、コントロール構成を整理
// ソース概要：
//   Form6 はユーザーの入力履歴を閲覧・削除するための画面。
//   履歴は読み取り専用のテキストボックスに表示され、
//   メニューへの遷移や履歴のクリアが可能な構成。
//   本ファイルは Visual Studio のデザイナによって生成される UI 初期化コードを含む。
//=================================================================

namespace WindowsFormsApp1
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();     // 履歴閲覧タイトル
            this.textBox1 = new System.Windows.Forms.TextBox(); // 履歴表示欄
            this.button1 = new System.Windows.Forms.Button();   // メニューに戻るボタン
            this.button2 = new System.Windows.Forms.Button();   // 履歴削除ボタン

            this.SuspendLayout(); // レイアウトの一時停止

            // 
            // label1（履歴閲覧）
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(128, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "履歴閲覧";

            // 
            // textBox1（履歴表示欄）
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox1.Location = new System.Drawing.Point(136, 181);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(825, 401);
            this.textBox1.TabIndex = 1;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.TabStop = false;

            // 
            // button1（メニューに戻る）
            // 
            this.button1.Location = new System.Drawing.Point(643, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "メニューに戻る";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // 
            // button2（履歴削除）
            // 
            this.button2.Location = new System.Drawing.Point(136, 616);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 72);
            this.button2.TabIndex = 3;
            this.button2.Text = "履歴を削除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // 
            // Form6（履歴表示画面）
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 731);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "履歴表示";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // --- UIコントロールのフィールド定義 ---
        private System.Windows.Forms.Label label1;      // 履歴タイトルラベル
        private System.Windows.Forms.TextBox textBox1;  // 履歴表示欄
        private System.Windows.Forms.Button button1;    // メニューに戻るボタン
        private System.Windows.Forms.Button button2;    // 履歴削除ボタン
    }
}


