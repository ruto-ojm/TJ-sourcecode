//=================================================================
// 作成者   ：TJ
// 初版作成日：2025/06/17
// 変更履歴 ：
//   - 2025/06/17 新規作成（初版）
//   - 2025/06/22 ボタン配置と入力欄サイズの調整
//   - 2025/06/27 パスワード入力欄のマスク処理を追加
//   - 2025/07/01 認証エラーメッセージの文言修正
// ソース概要：
//   ユーザーIDとパスワードによるログイン画面。認証後、権限に応じたメニュー画面へ遷移する。
//=================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ログインボタンがクリックされた時の処理
        private void button1_Click(object sender, EventArgs e)
        {
            // ユーザーが入力したIDとパスワードをそれぞれ取得
            // Trim() によって不要な空白を除去してから扱うことで、入力ミスの軽減を図る
            string id = textBox1.Text.Trim();
            string password = textBox2.Text;

            // 指定されたIDを持つユーザーをユーザーリストから検索
            User user = UserRepository.SearchUser(id);

            // 該当するユーザーが存在しない場合、認証エラーメッセージを表示
            if (user == null)
            {
                MessageBox.Show("IDが存在しません。", "認証エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // パスワードが一致しない場合もエラー表示
            if (user.Password != password)
            {
                MessageBox.Show("IDとパスワードが一致しません。", "認証エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 認証成功後、ユーザーの権限に応じて画面を分岐
            // 管理者の場合は Form2 を、利用者の場合は Form3 を表示
            if (user.IsAdmin)
            {
                Form2 form2 = new Form2(); // 管理者用メニュー画面を生成
                form2.Show();              // 管理者画面を表示
                this.Hide();               // 現在のログイン画面は非表示
            }
            else
            {
                Form3 form3 = new Form3(); // 一般利用者用メニュー画面を生成
                form3.Show();              // 利用者画面を表示
                this.Hide();               // 現在のログイン画面を非表示
            }
        }
    }

    // ユーザー情報を保持するデータモデルクラス
    // ID, パスワード, 管理者フラグ, 氏名, メールアドレスの基本属性を持つ
    public class User
    {
        public string Id { get; }           // ユーザーID（一意に識別）
        public string Password { get; }     // パスワード（セキュリティ上はハッシュ化推奨）
        public bool IsAdmin { get; }        // 管理者フラグ（true=管理者, false=一般）
        public string Name { get; }         // ユーザーの表示名や本名
        public string Email { get; }        // ユーザーの連絡用メールアドレス

        // ユーザーオブジェクトの初期化（氏名やメールは省略可）
        public User(string id, string password, bool isAdmin, string name = "", string email = "")
        {
            Id = id;
            Password = password;
            IsAdmin = isAdmin;
            Name = name;
            Email = email;
        }
    }

    // ユーザーを登録・検索・削除・保存・読込するための静的クラス
    public static class UserRepository
    {
        // データを保存するCSVファイルのパス
        private static readonly string FilePath = "users.csv";

        // アプリ実行中に保持されるメモリ上のユーザー一覧
        private static readonly List<User> _users = new List<User>();

        // クラスが最初に参照された際に一度だけ呼び出される静的コンストラクタ
        static UserRepository()
        {
            LoadUsers(); // ユーザー情報をファイルから読み込む
        }

        // 新しいユーザーを登録する（IDの重複チェックあり）
        public static void AddUser(User user)
        {
            // IDがすでに登録されていないか（大文字小文字を区別しない）
            if (_users.Any(u => u.Id.Equals(user.Id, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("このIDはすでに登録されています。", "登録エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _users.Add(user);  // 新しいユーザーをメモリ上のリストに追加
            SaveUsers();       // 追加後、全データをCSVに保存
        }

        // 指定したIDのユーザー情報を検索して返す（存在しない場合は null）
        public static User SearchUser(string id)
        {
            return _users.Find(u => u.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        // 登録されているすべてのユーザー一覧を返す
        public static List<User> GetAllUsers()
        {
            return _users;
        }

        // ユーザー一覧をファイルに保存（CSV形式）
        private static void SaveUsers()
        {
            using (var writer = new StreamWriter(FilePath, false, Encoding.UTF8))
            {
                foreach (var user in _users)
                {
                    // 1行ずつ「ID,Password,IsAdmin,Name,Email」の形式で書き込む
                    writer.WriteLine($"{user.Id},{user.Password},{user.IsAdmin},{user.Name},{user.Email}");
                }
            }
        }

        // CSVファイルからユーザー情報を読み込む
        private static void LoadUsers()
        {
            if (!File.Exists(FilePath))
            {
                // ファイルが存在しない場合は、初期ユーザー（管理者・利用者）を生成して保存
                _users.Add(new User("admin1", "adminpass", true, "管理者一郎", "admin@example.com"));
                _users.Add(new User("user1", "pass1", false, "田中太郎", "taro@example.com"));
                SaveUsers();
                return;
            }

            // ファイルから全行を読み込み、各ユーザーを分解して登録
            foreach (var line in File.ReadAllLines(FilePath, Encoding.UTF8))
            {
                var parts = line.Split(',');
                if (parts.Length >= 5)
                {
                    var id = parts[0];
                    var password = parts[1];
                    var isAdmin = bool.Parse(parts[2]);
                    var name = parts[3];
                    var email = parts[4];

                    _users.Add(new User(id, password, isAdmin, name, email));
                }
            }
        }

        // 指定されたIDのユーザーを削除し、保存ファイルも更新
        public static void RemoveUser(string id)
        {
            var user = _users.Find(u => u.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
            if (user != null)
            {
                _users.Remove(user);
                SaveUsers();
            }
        }

        // 交通情報などを扱う補助的なデータクラス（将来的に拡張可）
        public class RoadInfo
        {
            public string Location { get; set; }         // 地点名（交差点や道路の名前など）
            public int TrafficVolume { get; set; }       // 車両交通量
            public int LineCount { get; set; }           // 車線数
            public int PedestrianVolume { get; set; }    // 歩行者の数

            public RoadInfo(string location, int traffic, int lines, int pedestrians)
            {
                Location = location;
                TrafficVolume = traffic;
                LineCount = lines;
                PedestrianVolume = pedestrians;
            }
        }
    }
}
