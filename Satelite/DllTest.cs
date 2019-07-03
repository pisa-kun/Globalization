using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using Satelite.Properties; // Resourceファイル使用

namespace Satelite
{
    /// <summary>
    /// staticクラスなのでインスタンスを生成する必要はない
    /// Resource.Embedder をNugetからインストール
    /// サテライトファイル(言語dll)をdllに出力成功
    /// </summary>
    public static class SateLiteTest
    {
        /// <summary>
        /// dllの生成テスト
        /// プロパティ → アプリケーション → 出力「クラスライブラリ」
        /// OSの言語を表示後、リソースファイルのデータを出力
        /// 言語を英語に切り替え後、リソースファイルのデータが切り替わっているか確認
        /// </summary>
        /// <param name="str"></param>
        public static void HelloWorld(string str)
        {
            // 現在のカルチャを表示
            // 日本語
            Console.WriteLine("CurrentCulture: {0}",
               Thread.CurrentThread.CurrentCulture.Name);
            Console.WriteLine("CurrentUICulture: {0}",
                Thread.CurrentThread.CurrentUICulture.Name);

            Console.WriteLine("Method Call");

            Console.WriteLine(Resources.Hello);
            Console.WriteLine(Resources.World);

            // 英語に変更
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            Console.WriteLine("CurrentCulture: {0}",
                Thread.CurrentThread.CurrentCulture.Name);
            Console.WriteLine("CurrentUICulture: {0}",
                Thread.CurrentThread.CurrentUICulture.Name);

            Console.WriteLine("Method Call");

            Console.WriteLine(Resources.Hello);
            Console.WriteLine(Resources.World);
        }

    }
}
