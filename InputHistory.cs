//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/26
// 変更履歴 ：
//   - 2025/06/26 新規作成（初版）
//   - 2025/06/29 ファイル読み込み処理の分岐処理と例外対策を強化
//   - 2025/07/05 コメントを詳細化、履歴初期化処理の整理
// ソース概要：
//   関数入力の履歴（FunctionEntry）を管理する静的クラス。
//   履歴はアプリ起動中のメモリ上と、永続化用のファイル（history.txt）に保存され、
//   入力の追加・保存・読み込み・削除の各機能を提供する。
//=================================================================

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 入力履歴の管理を行う静的クラス。
    /// FunctionEntry のリストとして履歴を保持し、ファイル I/O による永続化にも対応。
    /// </summary>
    public static class InputHistory
    {
        /// <summary>
        /// 実行中に保持される履歴のリスト。
        /// 主にUIや内部処理から参照される。
        /// </summary>
        public static List<FunctionEntry> History { get; } = new List<FunctionEntry>();

        /// <summary>
        /// 履歴保存用ファイルのパス（実行フォルダに保存される "history.txt"）。
        /// </summary>
        private static readonly string filePath = "history.txt";

        /// <summary>
        /// 入力値を履歴として追加し、ファイルにも1件分追記保存する。
        /// 関数名は固定で "入力"。
        /// </summary>
        /// <param name="x">1番目の数値</param>
        /// <param name="y">2番目の数値</param>
        /// <param name="z">3番目の数値</param>
        public static void Add(int x, int y, int z)
        {
            var entry = new FunctionEntry("入力", x, y, z); // 名前付きエントリを作成
            History.Add(entry);      // メモリ上の履歴に追加
            SaveEntry(entry);        // ファイルに1行追加保存
        }

        /// <summary>
        /// FunctionEntry オブジェクト1件を履歴ファイルの末尾に追記する。
        /// 書式：FunctionName: val1, val2, val3（1行1エントリ）
        /// </summary>
        /// <param name="entry">保存対象の FunctionEntry</param>
        private static void SaveEntry(FunctionEntry entry)
        {
            try
            {
                File.AppendAllText(filePath, entry.ToString() + Environment.NewLine);
            }
            catch (Exception ex)
            {
                // 書き込みエラー時もアプリがクラッシュしないようにコンソールにログ出力
                Console.WriteLine("保存失敗: " + ex.Message);
            }
        }

        /// <summary>
        /// 履歴ファイルを読み込み、過去の入力履歴をメモリ上に復元する。
        /// ファイルが存在しない場合は何もせず終了。
        /// </summary>
        public static void Load()
        {
            if (!File.Exists(filePath)) return; // ファイルがなければ処理しない

            var lines = File.ReadAllLines(filePath); // 全行読み込み
            foreach (var line in lines)
            {
                var parts = line.Split(':'); // 区切り文字「:」で分割 → [関数名, "x, y, z"]
                if (parts.Length == 2)
                {
                    var name = parts[0].Trim();
                    var valueStrings = parts[1].Split(',');

                    if (valueStrings.Length == 3)
                    {
                        // 各数値をパース
                        bool successX = int.TryParse(valueStrings[0].Trim(), out int x);
                        bool successY = int.TryParse(valueStrings[1].Trim(), out int y);
                        bool successZ = int.TryParse(valueStrings[2].Trim(), out int z);

                        if (successX && successY && successZ)
                        {
                            // 全ての変換に成功した場合のみ履歴に追加
                            History.Add(new FunctionEntry(name, x, y, z));
                        }
                    }
                }
            }
        }

        /// <summary>
        /// メモリ上の履歴とファイル上の履歴の両方を完全に削除する。
        /// 通常、履歴クリアボタンなどから呼ばれる。
        /// </summary>
        public static void Clear()
        {
            History.Clear(); // メモリ履歴をクリア
            if (File.Exists(filePath)) File.Delete(filePath); // ファイルも存在すれば削除
        }
    }
}

