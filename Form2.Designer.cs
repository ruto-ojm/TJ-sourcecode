//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/18
// 変更履歴 ：
//   - 2025/06/18 新規作成（メニュー画面 UI）
//   - 2025/06/24 「会員管理」ボタンの追加とレイアウト修正
//   - 2025/07/05 コメント詳細化およびレイアウト整理
// ソース概要：
//   Form2 はログイン後のメニュー画面として機能する。
//   ユーザーはこの画面から新規登録・会員管理・ログアウトの各操作に進むことができる。
//   本ファイルは Visual Studio のフォームデザイナによって自動生成される UI 構成コードを含む。
//=================================================================

namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// 使用されているコンポーネント（UIコントロール）を格納するコンテナ
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをクリーンアップ（解放）するメソッド
        /// </summary>
        /// <param name="disposing">
        /// true：マネージドリソースも破棄する / false：アンマネージドのみ破棄
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // 登録済みコンポーネントの破棄
            }
            base.Dispose(disposing); // 基底クラスの破棄処理呼び出し
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// フォームのUI部品を初期化するためのメソッド
        /// ※デザイナーにより自動生成されるので、直接編集しないこと
        /// </summary>
        private void InitializeComponent()
        {
            // --- 各ボタンの生成と初期設定 ---
            this.button1 = new System.Windows.Forms.Button(); // 新規ユーザ登録
            this.button2 = new System.Windows.Forms.Button(); // 会員管理
            this.button3 = new System.Windows.Forms.Button(); // ログアウト

            this.SuspendLayout(); // レイアウトの一時停止

            // 
            // button1（新規ユーザ登録ボタン）
            // 
            this.button1.Location = new System.Drawing.Point(290, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(757, 103);
            this.button1.TabIndex = 0;
            this.button1.Text = "新規ユーザ登録";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click); // 登録画面へ遷移

            // 
            // button2（会員管理ボタン）
            // 
            this.button2.Location = new System.Drawing.Point(290, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(757, 103);
            this.button2.TabIndex = 1;
            this.button2.Text = "会員管理";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click); // 会員管理画面へ遷移

            // 
            // button3（ログアウトボタン）
            // 
            this.button3.Location = new System.Drawing.Point(290, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(757, 103);
            this.button3.TabIndex = 3;
            this.button3.Text = "ログアウト";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click); // ログイン画面へ戻る

            // 
            // Form2（メニュー画面）
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 671);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "メニュー画面";
            this.ResumeLayout(false);
        }

        #endregion

        // --- フォーム上の UI コントロール定義 ---
        private System.Windows.Forms.Button button1; // 新規ユーザ登録ボタン
        private System.Windows.Forms.Button button2; // 会員管理ボタン
        private System.Windows.Forms.Button button3; // ログアウトボタン
    }
}

