using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace QuizApp
{
    public class QuizProblem
    {
        //ファイルパス
        private string fileName = "C: /Users/User/Desktop/hirae/QuizApp/QuizSheet.csv";

        // コンストラクタ
        public QuizProblem()
        {
        }

        //ランダムで引数のリストからnum分の問題を返す
        public string[][] Random(int num, List<string[]> list)
        {
            // シャッフル
            string[][] ary1 = list.OrderBy(i => Guid.NewGuid()).ToArray();
            // 指定した要素数を取り出すための配列を作成する
            string[][] ary2 = new string[num][];
            // 指定された範囲をコピーする
            Array.Copy(ary1, 0, ary2, 0,num);

            return ary2;
        }

        //ファイルパスゲット
        public string GetFileName()
        {
            return fileName;
        }

        //csvファイル読み込み関数
        public List<string[]> CsvReader(string fileName)
        {
            //ファイル読み込み
            StreamReader sr = new StreamReader(@fileName);
            List<string[]> lists = new List<string[]>();

            // 末尾まで繰り返す
            while (!sr.EndOfStream)
            {
                // CSVファイルの一行を読み込む
                string line = sr.ReadLine();

                // 読み込んだ一行をカンマ毎に分けて配列に格納する
                string[] values = line.Split(',');

                // 配列からリストに格納する
                lists.Add(values);

                // 読み込めてるか確認。コンソールに表示される。
                Console.WriteLine(String.Join(" ", values));
            }
            return lists;
        }
    }
}
