//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/25
// 変更履歴 ：
//   - 2025/06/25 新規作成（初版）
//   - 2025/06/30 ToString() をログ用途向けに調整
//   - 2025/07/05 コメントを整理・詳細化
// ソース概要：
//   関数登録や履歴管理のためのデータ構造を提供するクラス。
//   関数名および3つの整数パラメータ（例：交通量、車線数、歩行者数）を保持し、
//   表示やログ記録向けに文字列化機能（ToString）も備える。
//=================================================================

public class FunctionEntry
{
    /// <summary>
    /// 関数の名称を表すプロパティ。
    /// 例：「加算関数」「信号制御関数」など。
    /// </summary>
    public string FunctionName { get; set; }

    /// <summary>
    /// 関数に渡される最初の整数値。
    /// 一般的に「交通量」や「入力値1」などの意味合いで使用。
    /// </summary>
    public int Value1 { get; set; }

    /// <summary>
    /// 関数に渡される2番目の整数値。
    /// 例えば「車線数」や「入力値2」として利用される。
    /// </summary>
    public int Value2 { get; set; }

    /// <summary>
    /// 関数に渡される3番目の整数値。
    /// 「歩行者数」や「入力値3」として用いられ、基本的には必須項目として扱われる。
    /// </summary>
    public int Value3 { get; set; }

    /// <summary>
    /// コンストラクタ：FunctionEntry オブジェクトを初期化する。
    /// 関数名と3つの数値パラメータを受け取り、それぞれのプロパティに設定する。
    /// </summary>
    /// <param name="name">関数名</param>
    /// <param name="val1">1番目のパラメータ</param>
    /// <param name="val2">2番目のパラメータ</param>
    /// <param name="val3">3番目のパラメータ</param>
    public FunctionEntry(string name, int val1, int val2, int val3)
    {
        FunctionName = name;
        Value1 = val1;
        Value2 = val2;
        Value3 = val3;
    }

    /// <summary>
    /// このオブジェクトの内容をわかりやすい文字列に変換する。
    /// UI上のリスト表示やログ出力などに活用される。
    /// 例： "加算関数(10, 20, 30)"
    /// </summary>
    /// <returns>関数名と3つの数値を含む文字列</returns>
    public override string ToString()
    {
        return $"{FunctionName}({Value1}, {Value2}, {Value3})";
    }
}




