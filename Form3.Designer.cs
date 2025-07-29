//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/20
// 変更履歴 ：
//   - 2025/06/20 新規作成（利用者メニュー画面 UI）
//   - 2025/06/25 計算式追加・履歴閲覧ボタンを実装
//   - 2025/07/05 コメント詳細化、配置とサイズ調整
// ソース概要：
//   Form3 は利用者用のメニュー画面として機能する。
//   情報入力、新しい計算式の登録、履歴の閲覧、ログアウトといった操作にアクセス可能。
//   本ファイルは Visual Studio のフォームデザイナによって自動生成される UI 構成コードを含む。
//=================================================================

namespace WindowsFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// 使用中のデザイナー生成コンポーネントのコンテナ
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースを破棄し、メモリリークを防止
        /// </summary>
        /// <param name="disposing">
        /// true：マネージドリソースを含めて解放 / false：アンマネージドのみ
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
            // --- 各ボタンの定義 ---
            this.button1 = new System.Windows.Forms.Button(); // 情報入力
            this.button2 = new System.Windows.Forms.Button(); // 計算式追加
            this.button3 = new System.Windows.Forms.Button(); // 履歴閲覧
            this.button4 = new System.Windows.Forms.Button(); // ログアウト

            this.SuspendLayout(); // レイアウトの一時停止

            // 
            // button1（情報入力）
            // 
            this.button1.Location = new System.Drawing.Point(245, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(794, 129);
            this.button1.TabIndex = 0;
            this.button1.Text = "情報入力";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // 
            // button2（新しい計算式の追加）
            // 
            this.button2.Location = new System.Drawing.Point(245, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(794, 129);
            this.button2.TabIndex = 1;
            this.button2.Text = "新しい計算式の追加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // 
            // button3（履歴閲覧）
            // 
            this.button3.Location = new System.Drawing.Point(245, 491);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(794, 129);
            this.button3.TabIndex = 2;
            this.button3.Text = "履歴閲覧";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);

            // 
            // button4（ログアウト）
            // 
            this.button4.Location = new System.Drawing.Point(245, 677);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(794, 129);
            this.button4.TabIndex = 3;
            this.button4.Text = "ログアウト";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);

            // 
            // Form3（利用者メニュー画面）
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 890);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "利用者メニュー";
            this.ResumeLayout(false);
        }

        #endregion

        // --- UIコントロールのフィールド定義 ---
        private System.Windows.Forms.Button button1; // 情報入力ボタン
        private System.Windows.Forms.Button button2; // 新しい計算式の追加ボタン
        private System.Windows.Forms.Button button3; // 履歴閲覧ボタン
        private System.Windows.Forms.Button button4; // ログアウトボタン
    }
}

