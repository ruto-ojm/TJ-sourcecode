//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/25
// 変更履歴 ：
//   - 2025/06/25 新規作成（初版）
//   - 2025/06/30 実行メソッドの名前を Calculate に統一
//   - 2025/07/05 コメントの詳細化とコード整理
// ソース概要：
//   3つの整数値を引数とし、double型の結果を返す関数（最適化用・計算用）を表現するクラス。
//   関数の識別名と処理本体（Func）を一体として管理し、任意の関数を柔軟に登録・評価できる。
//=================================================================

using System;

/// <summary>
/// FunctionInfo クラス
/// - 3引数からなる数値関数（int, int, int → double）を登録・実行するための情報を保持。
/// - 関数名と処理本体（ラムダ式や通常メソッド）をまとめて扱えるようにする設計。
/// - シミュレーション、交通制御、最適化アルゴリズムなどでの利用を想定。
/// </summary>
public class FunctionInfo
{
    /// <summary>
    /// 関数の識別名（表示やログ出力などに利用）
    /// 例：「加算」「車線係数計算」「危険度スコア」など
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// 関数の処理本体を表すデリゲート。
    /// 3つのint値を引数として受け取り、double型の数値結果を返す。
    /// 例： (a, b, c) => (a + b) / (double)c
    /// </summary>
    private Func<int, int, int, double> func;

    /// <summary>
    /// コンストラクタ
    /// 関数の識別名と処理内容（ラムダ式やメソッド）を受け取り、インスタンスを生成。
    /// </summary>
    /// <param name="name">関数名（識別用ラベル）</param>
    /// <param name="func">関数本体（3つのintを引数とし、doubleを返す処理）</param>
    public FunctionInfo(string name, Func<int, int, int, double> func)
    {
        Name = name;       // 関数名を設定（プロパティ）
        this.func = func;  // 実行関数を設定（フィールド）
    }

    /// <summary>
    /// 関数を実行し、結果を返す。
    /// 任意の3つの整数値を引数として関数本体に渡し、double型の計算結果を取得する。
    /// </summary>
    /// <param name="x">1番目の引数</param>
    /// <param name="y">2番目の引数</param>
    /// <param name="z">3番目の引数</param>
    /// <returns>計算結果（double）</returns>
    public double Calculate(int x, int y, int z)
    {
        return func(x, y, z); // 関数本体を呼び出して結果を返す
    }
}
