//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/21
// 変更履歴 ：
//   - 2025/06/21 新規作成（交通情報入力フォーム UI）
//   - 2025/06/28 結果表示処理と戻るボタンの配置修正
//   - 2025/07/05 コメント詳細化とフィールド名の明確化
// ソース概要：
//   Form4 は交通情報（位置、交通量、車線数、歩行者量）を入力するための画面。
//   入力された値に基づいて結果を表示したり、メニュー画面へ戻ったりする操作が可能。
//   本ファイルは Visual Studio のデザイナーによって生成される UI 初期化コードを含む。
//=================================================================

namespace WindowsFormsApp1
{
    partial class Form4
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
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// デザイナーによって生成された UI 初期化処理
        /// フォームのレイアウトやイベントハンドラ登録を行う
        /// </summary>
        private void InitializeComponent()
        {
            // --- UIコントロールのインスタンス化 ---
            this.button1 = new System.Windows.Forms.Button(); // 結果閲覧
            this.button2 = new System.Windows.Forms.Button(); // メニューに戻る
            this.textBox1 = new System.Windows.Forms.TextBox(); // 位置情報入力欄
            this.textBox2 = new System.Windows.Forms.TextBox(); // 交通量入力欄
            this.textBox3 = new System.Windows.Forms.TextBox(); // 車線数入力欄
            this.textBox4 = new System.Windows.Forms.TextBox(); // 歩行者量入力欄
            this.label1 = new System.Windows.Forms.Label(); // 位置情報ラベル
            this.label2 = new System.Windows.Forms.Label(); // 交通量ラベル
            this.label3 = new System.Windows.Forms.Label(); // 車線数ラベル
            this.label4 = new System.Windows.Forms.Label(); // 歩行者量ラベル

            this.SuspendLayout(); // レイアウトの一時停止

            // 
            // button1（結果閲覧ボタン）
            // 
            this.button1.Location = new System.Drawing.Point(245, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 97);
            this.button1.TabIndex = 0;
            this.button1.Text = "結果閲覧";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // 
            // button2（メニューに戻るボタン）
            // 
            this.button2.Location = new System.Drawing.Point(756, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 97);
            this.button2.TabIndex = 1;
            this.button2.Text = "メニューに戻る";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // 
            // textBox1（位置情報入力欄）
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox1.Location = new System.Drawing.Point(376, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(638, 55);
            this.textBox1.TabIndex = 2;

            // 
            // textBox2（交通量入力欄）
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox2.Location = new System.Drawing.Point(376, 217);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(638, 55);
            this.textBox2.TabIndex = 3;

            // 
            // textBox3（車線数入力欄）
            // 
            this.textBox3.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox3.Location = new System.Drawing.Point(376, 336);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(638, 55);
            this.textBox3.TabIndex = 4;

            // 
            // textBox4（歩行者量入力欄）
            // 
            this.textBox4.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBox4.Location = new System.Drawing.Point(376, 453);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(638, 55);
            this.textBox4.TabIndex = 5;

            // 
            // label1（位置情報ラベル）
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(105, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "位置情報 :";

            // 
            // label2（交通量ラベル）
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label2.Location = new System.Drawing.Point(153, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "交通量 :";

            // 
            // label3（車線数ラベル）
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label3.Location = new System.Drawing.Point(153, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "車線数 :";

            // 
            // label4（歩行者量ラベル）
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label4.Location = new System.Drawing.Point(105, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 48);
            this.label4.TabIndex = 9;
            this.label4.Text = "歩行者量 :";

            // 
            // Form4（交通情報入力画面）
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 758);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "交通情報入力";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // --- UIコントロールのフィールド定義 ---
        private System.Windows.Forms.Button button1;   // 結果閲覧ボタン
        private System.Windows.Forms.Button button2;   // メニューに戻るボタン
        private System.Windows.Forms.TextBox textBox1; // 位置情報入力欄
        private System.Windows.Forms.TextBox textBox2; // 交通量入力欄
        private System.Windows.Forms.TextBox textBox3; // 車線数入力欄
        private System.Windows.Forms.TextBox textBox4; // 歩行者量入力欄
        private System.Windows.Forms.Label label1;     // 位置情報ラベル
        private System.Windows.Forms.Label label2;     // 交通量ラベル
        private System.Windows.Forms.Label label3;     // 車線数ラベル
        private System.Windows.Forms.Label label4;     // 歩行者量ラベル
    }
}

