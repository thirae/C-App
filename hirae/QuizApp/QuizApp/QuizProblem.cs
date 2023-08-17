using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
using System.Windows.Forms;

namespace QuizApp
{
    public class QuizProblem
    {
        // ファイルパス
        private string fileName = "C: /Users/User/Desktop/hirae/QuizApp/QuizSheet.csv";

        /// <summary>
        /// ランダムで引数のリストからnum分の問題を返すメソッド
        /// </summary>
        /// <param name="num"> 何問問題を出すか決める変数が入った引数</param>
        /// <param name="list"> すべての問題が入ったリストの引数</param>
        /// <returns></returns>
        public string[][] Random(int num, List<string[]> list)
        {
            // すべての問題よりnumが大きかったら
            if (num > list.Count)
            {
                // メッセージボックスを表示する
                MessageBox.Show("値が大きすぎます","エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // シャッフル
            string[][] ary1 = list.OrderBy(i => Guid.NewGuid()).ToArray();
            // 指定した要素数を取り出すための配列を作成する
            string[][] ary2 = new string[num][];
            // 指定された範囲をコピーする
            Array.Copy(ary1, 0, ary2, 0,num);

            return ary2;
        }

        /// <summary>
        /// ファイルのパスをゲットるためのメソッド
        /// </summary>
        /// <returns></returns>
        public string GetFileName()
        {
            return fileName;
        }

        /// <summary>
        /// csvファイル読み込み関数
        /// </summary>
        /// <param name="fileName"> 引数のファイルパスを読み込む</param>
        /// <returns></returns>
        public List<string[]> CsvReader(string fileName)
        {
            // ファイル読み込み
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
            }
            return lists;
        }
    }
}
