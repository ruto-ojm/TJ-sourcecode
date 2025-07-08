//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/24
// 変更履歴 ：
//   - 2025/06/24 新規作成（関数登録画面 UI）
//   - 2025/06/30 TrackBar連動および入力欄との同期処理対応
//   - 2025/07/05 コメント整備とフィールド構成の見直し
// ソース概要：
//   Form7 は関数登録画面であり、関数名と3つの変数を登録する構成。
//   各変数に対応する入力欄とスライダーを持ち、スライダーとテキストボックスを同期。
//   「保存」ボタンで入力を FunctionEntry として記録し、「戻る」ボタンでメニューに戻る。
//   本ファイルは Visual Studio デザイナによって生成される UI 初期化コードを含む。
//=================================================================

namespace WindowsFormsApp1
{
    partial class Form7
    {
        // ---------------------------------------------
        // 使用中のデザイナー生成コンポーネントのコンテナ
        // ---------------------------------------------
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
        /// フォームの各コントロールの配置・設定・イベントを定義
        /// </summary>
        private void InitializeComponent()
        {
            // --- テキストボックス定義（関数名・変数入力用） ---

            this.textBox1 = new System.Windows.Forms.TextBox(); // 変数1の値入力欄
            this.textBox2 = new System.Windows.Forms.TextBox(); // 変数2の値入力欄
            this.textBox3 = new System.Windows.Forms.TextBox(); // 変数3の値入力欄
            this.textBox4 = new System.Windows.Forms.TextBox(); // 関数名入力欄

            // --- ラベル定義 ---

            this.label1 = new System.Windows.Forms.Label(); // 変数1ラベル
            this.label2 = new System.Windows.Forms.Label(); // 変数2ラベル
            this.label3 = new System.Windows.Forms.Label(); // 関数名ラベル
            this.label4 = new System.Windows.Forms.Label(); // 変数3ラベル

            // --- スライダー定義（変数ごとの値操作用） ---

            this.trackBar1 = new System.Windows.Forms.TrackBar(); // 変数1スライダー
            this.trackBar2 = new System.Windows.Forms.TrackBar(); // 変数2スライダー
            this.trackBar3 = new System.Windows.Forms.TrackBar(); // 変数3スライダー

            // --- ボタン定義 ---

            this.button1 = new System.Windows.Forms.Button(); // メニューに戻るボタン
            this.button2 = new System.Windows.Forms.Button(); // 入力内容を保存するボタン

            // --- トラックバー初期化処理 ---
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();

            this.SuspendLayout(); // レイアウトの一時停止

            // ----------------------------
            // textBox1（変数1の入力欄）
            // ----------------------------
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox1.Location = new System.Drawing.Point(392, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 47);
            this.textBox1.TabIndex = 0;

            // ----------------------------
            // textBox2（変数2の入力欄）
            // ----------------------------
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox2.Location = new System.Drawing.Point(392, 399);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 47);
            this.textBox2.TabIndex = 1;

            // ----------------------------
            // textBox4（関数名の入力欄）
            // ----------------------------
            this.textBox4.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox4.Location = new System.Drawing.Point(392, 52);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(607, 47);
            this.textBox4.TabIndex = 9;

            // ----------------------------
            // textBox3（変数3の入力欄）
            // ----------------------------
            this.textBox3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox3.Location = new System.Drawing.Point(392, 662);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(205, 47);
            this.textBox3.TabIndex = 10;

            // ----------------------------
            // label1（変数1のラベル）
            // ----------------------------
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(84, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "変数1";

            // ----------------------------
            // label2（変数2のラベル）
            // ----------------------------
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(84, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "変数2";

            // ----------------------------
            // label3（関数名のラベル）
            // ----------------------------
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(87, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "関数名";

            // ----------------------------
            // label4（変数3のラベル）
            // ----------------------------
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label4.Location = new System.Drawing.Point(84, 665);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 40);
            this.label4.TabIndex = 11;
            this.label4.Text = "変数3";

            // ----------------------------
            // trackBar1（変数1用スライダー）
            // ----------------------------
            this.trackBar1.Location = new System.Drawing.Point(91, 254);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(944, 90);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll); // スライドイベント処理

            // ----------------------------
            // trackBar2（変数2用スライダー）
            // ----------------------------
            this.trackBar2.Location = new System.Drawing.Point(91, 506);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(944, 90);
            this.trackBar2.TabIndex = 5;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);

            // ----------------------------
            // trackBar3（変数3用スライダー）
            // ----------------------------
            this.trackBar3.Location = new System.Drawing.Point(91, 780);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(944, 90);
            this.trackBar3.TabIndex = 12;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);

            // ----------------------------
            // button1（戻るボタン）
            // ----------------------------
            this.button1.Location = new System.Drawing.Point(717, 880);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 90);
            this.button1.TabIndex = 6;
            this.button1.Text = "メニューに戻る";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // ----------------------------
            // button2（保存ボタン）
            // ----------------------------
            this.button2.Location = new System.Drawing.Point(191, 880);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 90);
            this.button2.TabIndex = 7;
            this.button2.Text = "保存する";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // ----------------------------
            // Form7（関数登録画面）
            // ----------------------------
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 1000); // フォーム全体サイズ
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form7";
            this.Text = "関数登録フォーム"; // タイトルバーに表示される文字

            // トラックバー初期化終了
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);  // レイアウト再開
            this.PerformLayout();      // 自動レイアウト適用
        }

        #endregion

        // --- UIコントロールのフィールド定義 ---
        private System.Windows.Forms.TextBox textBox1; // 変数1入力欄
        private System.Windows.Forms.TextBox textBox2; // 変数2入力欄
        private System.Windows.Forms.TextBox textBox3; // 変数3入力欄
        private System.Windows.Forms.TextBox textBox4; // 関数名入力欄
        private System.Windows.Forms.Label label1;     // 変数1ラベル
        private System.Windows.Forms.Label label2;     // 変数2ラベル
        private System.Windows.Forms.Label label3;     // 関数名ラベル
        private System.Windows.Forms.Label label4;     // 変数3ラベル
        private System.Windows.Forms.TrackBar trackBar1; // 変数1調整スライダー
        private System.Windows.Forms.TrackBar trackBar2; // 変数2調整スライダー
        private System.Windows.Forms.TrackBar trackBar3; // 変数3調整スライダー
        private System.Windows.Forms.Button button1;   // メニューへ戻るボタン
        private System.Windows.Forms.Button button2;   // 保存ボタン
    }
}
