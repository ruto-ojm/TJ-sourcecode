//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/25
// 変更履歴 ：
//   - 2025/06/25 初版作成（新規ユーザー登録UIの実装）
//   - 2025/06/29 管理者登録チェックボックス追加・UI調整
//   - 2025/07/08 コメント整理と登録・戻るボタンイベント紐付け確認
// ソース概要：
//   Form8 は新規ユーザーをシステムに登録する画面。
//   入力欄は ID、パスワード、名前、メールアドレス、および管理者登録の有無チェック。
//   「登録」ボタンで情報をUserManagerに保存し、「戻る」ボタンで前画面へ遷移。
//   入力情報の検証処理などは Form8.cs 側で実装される。
//=================================================================

namespace WindowsFormsApp1
{
    partial class Form8
    {
        // ---------------------------------------------
        // 使用中のデザイナー生成コンポーネントのコンテナ
        // ---------------------------------------------
        private System.ComponentModel.IContainer components = null;

        // --- UIコントロールのフィールド定義（各種入力欄とラベル） ---
        private System.Windows.Forms.Label labelId;            // 「ID」の入力ラベル
        private System.Windows.Forms.Label labelPassword;      // 「パスワード」の入力ラベル
        private System.Windows.Forms.Label labelName;          // 「名前」の入力ラベル
        private System.Windows.Forms.Label labelEmail;         // 「メールアドレス」の入力ラベル

        private System.Windows.Forms.TextBox textBoxId;        // ユーザーIDの入力欄
        private System.Windows.Forms.TextBox textBoxPassword;  // パスワードの入力欄（非表示対応）
        private System.Windows.Forms.TextBox textBoxName;      // 名前の入力欄
        private System.Windows.Forms.TextBox textBoxEmail;     // メールアドレスの入力欄

        private System.Windows.Forms.CheckBox checkBoxIsAdmin; // 管理者登録の有無を選択するチェックボックス
        private System.Windows.Forms.Button buttonRegister;    // 登録ボタン（入力情報を登録）
        private System.Windows.Forms.Button buttonBack;        // 戻るボタン（前の画面に戻る）

        /// <summary>
        /// 使用中のリソースを破棄し、メモリリークを防止
        /// </summary>
        /// <param name="disposing">
        /// true：マネージドリソースも含めて解放 / false：アンマネージドのみ
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose(); // コンポーネントの破棄
            base.Dispose(disposing); // 基底クラスの破棄処理
        }

        /// <summary>
        /// デザイナーによって生成された UI 初期化処理
        /// 入力フォームの配置、ラベル、イベントハンドラを設定する
        /// </summary>
        private void InitializeComponent()
        {
            // --- ID ラベル ---
            this.labelId = new System.Windows.Forms.Label();
            this.labelId.AutoSize = true;                              // テキストの長さに自動調整
            this.labelId.Location = new System.Drawing.Point(30, 30);  // 左上に配置
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(40, 20);
            this.labelId.Text = "ID：";                            // 表示文字列

            // --- ID 入力欄（ユーザーがIDを入力）---
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxId.Location = new System.Drawing.Point(140, 27); // ラベルの右隣に配置
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(200, 27);      // 標準的な入力欄サイズ

            // --- パスワード ラベル ---
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(30, 70);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(88, 20);
            this.labelPassword.Text = "パスワード：";

            // --- パスワード入力欄（文字は非表示）---
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPassword.Location = new System.Drawing.Point(140, 67);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(200, 27);
            this.textBoxPassword.UseSystemPasswordChar = true; // 入力文字を「●」などにマスク

            // --- 名前 ラベル ---
            this.labelName = new System.Windows.Forms.Label();
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(30, 110);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 20);
            this.labelName.Text = "名前：";

            // --- 名前入力欄（ユーザー本名やニックネームを入力）---
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxName.Location = new System.Drawing.Point(140, 107);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 27);

            // --- メール ラベル ---
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(30, 150);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(68, 20);
            this.labelEmail.Text = "メール：";

            // --- メールアドレス入力欄（形式チェックは別途処理）---
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxEmail.Location = new System.Drawing.Point(140, 147);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 27);

            // --- 管理者登録 チェックボックス ---
            this.checkBoxIsAdmin = new System.Windows.Forms.CheckBox();
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.Location = new System.Drawing.Point(140, 185);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new System.Drawing.Size(92, 24);
            this.checkBoxIsAdmin.Text = "管理者登録"; // チェックで管理者として登録
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;

            // --- 登録ボタン（入力情報の検証・登録処理へ）---
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonRegister.Location = new System.Drawing.Point(140, 220);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(90, 35);
            this.buttonRegister.Text = "登録";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click); // 登録イベント

            // --- 戻るボタン（ログイン画面や前の画面へ戻る）---
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonBack.Location = new System.Drawing.Point(250, 220);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(90, 35);
            this.buttonBack.Text = "戻る";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click); // 戻るイベント

            // --- フォーム全体の設定 ---
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);              // DPIに応じたスケーリング
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 280);                      // ウィンドウサイズ
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.checkBoxIsAdmin);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F);                  // UIフォント
            this.Name = "Form8";                                                      // フォーム内部名称
            this.Text = "新規ユーザー登録";                                          // タイトルバーのテキスト
            this.ResumeLayout(false); // レイアウトの一時停止解除
            this.PerformLayout();     // 自動レイアウト適用
        }
    }
}


