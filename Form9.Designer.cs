//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/26
// 変更履歴 ：
//   - 2025/06/26 初版作成（会員管理画面 UI 構築）
//   - 2025/07/01 listBox にユーザー一覧を表示する仕様を追加
//   - 2025/07/08 コメントとボタン位置の調整
// ソース概要：
//   Form9 は登録されたユーザー一覧を表示・管理する画面。
//   listBoxUsers に現在のユーザーを一覧表示し、選択したユーザーを「削除」ボタンで削除可能。
//   「戻る」ボタンでメインメニューなどの前画面へ戻る。
//   削除処理や画面遷移はそれぞれ buttonDelete_Click, buttonBack_Click にて実装。
//=================================================================

namespace WindowsFormsApp1
{
    partial class Form9
    {
        // ---------------------------------------------
        // 使用中のデザイナー生成コンポーネントのコンテナ
        // ---------------------------------------------
        private System.ComponentModel.IContainer components = null;

        // --- UIコントロールのフィールド定義 ---
        private System.Windows.Forms.ListBox listBoxUsers;  // ユーザー一覧を表示するリストボックス
        private System.Windows.Forms.Button buttonBack;     // 前の画面へ戻るボタン
        private System.Windows.Forms.Button buttonDelete;   // 選択したユーザーを削除するボタン

        /// <summary>
        /// 使用中のリソースを破棄し、メモリリークを防止
        /// </summary>
        /// <param name="disposing">
        /// true：マネージドリソースも含めて解放 / false：アンマネージドのみ
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose(); // コンポーネント破棄
            base.Dispose(disposing); // 基底クラスの破棄処理
        }

        /// <summary>
        /// デザイナーによって生成された UI 初期化処理
        /// フォーム上のコントロール配置・イベントの定義を行う
        /// </summary>
        private void InitializeComponent()
        {
            // --- ユーザー一覧表示リストボックス ---
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.listBoxUsers.Font = new System.Drawing.Font("Yu Gothic UI", 10F);   // 読みやすいフォントサイズ
            this.listBoxUsers.FormattingEnabled = true;                              // データを動的に追加可能
            this.listBoxUsers.ItemHeight = 23;                                       // 各行の高さ
            this.listBoxUsers.Location = new System.Drawing.Point(30, 30);           // 上部に配置
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(400, 188);              // 一覧表示に十分なサイズ
            this.listBoxUsers.TabIndex = 0;

            // --- 削除ボタン（選択されたユーザーを削除）---
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonDelete.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.buttonDelete.Location = new System.Drawing.Point(30, 240);          // リストの下に左寄せで配置
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 35);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click); // 削除イベント処理へ

            // --- 戻るボタン（前のメニューに戻る）---
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonBack.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.buttonBack.Location = new System.Drawing.Point(330, 240);           // 右下に配置
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 35);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "戻る";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click); // 戻るイベント処理へ

            // --- Form9（会員管理画面）の基本設定 ---
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);             // DPIに応じた拡大縮小
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 320);                      // フォームサイズ
            this.Controls.Add(this.buttonDelete);                                     // 削除ボタンを追加
            this.Controls.Add(this.buttonBack);                                       // 戻るボタンを追加
            this.Controls.Add(this.listBoxUsers);                                     // ユーザー一覧を追加
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F);                  // 全体フォント設定
            this.Name = "Form9";                                                      // フォームのクラス名
            this.Text = "会員管理";                                                   // タイトルバーに表示される文字列
            this.ResumeLayout(false);                                                 // レイアウト再開
        }
    }
}
