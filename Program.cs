//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/17
// 変更履歴 ：
//   - 2025/06/17 新規作成（初版）
//   - 2025/06/22 InputHistory の読み込み処理を追加
//   - 2025/07/05 コメントの詳細化と整理
// ソース概要：
//   Windows Forms アプリケーションのエントリーポイント。
//   アプリ起動時にスタイル設定・履歴読込・フォーム起動などの初期処理を行う。
//=================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// アプリケーションの起動処理を担うクラス。
    /// Mainメソッドを含み、フォームの初期化や履歴の読み込みなどを行う。
    /// </summary>
    static class Program
    {
        /// <summary>
        /// アプリケーションのエントリーポイント。
        /// Windows Forms の初期設定を行い、初期フォーム（Form1）を表示する。
        /// </summary>
        [STAThread] // STAThread属性：COMコンポーネントを扱うためのスレッドモデル（UIスレッド）
        static void Main()
        {
            // Windows XP以降のビジュアルスタイルをフォームやボタンに適用
            Application.EnableVisualStyles();

            // テキスト描画の方式を GDI+ に設定（より正確なフォントレンダリング）
            Application.SetCompatibleTextRenderingDefault(false);

            // アプリケーション起動時に、履歴ファイル（history.txt）を読み込んでメモリに復元
            InputHistory.Load();

            // 最初に表示するフォームを Form1（ログイン画面）に指定してアプリを起動
            Application.Run(new Form1());
        }
    }
}


