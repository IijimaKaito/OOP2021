using System.Collections.Generic;
using System.IO;
using static Test01.Student;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);



        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<ScoreCounter> score= new List<ScoreCounter>();//学生データリストオブジェクトを生成
            string[] lines = File.ReadAllLines(filePath);//ファイルから一気に読み込む
            foreach (string line in lines) {//読み込んだ行の数だけ繰り返す
                string[] items = line.Split(',');
                int height;
                if (int.TryParse(Subject,out height)) {

                } else {

                }
                ScoreCounter scoreCounter = new Student { 
                    
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                score.Add(scoreCounter);
            }
            return score;






        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _score) {
                if (dict.ContainsKey(sale.Name))
                    //コレクションへ名前を登録
                    dict[sale.Name] += sale.Amount;
                else
                    //コレクションへ店舗を登録
                    dict[sale.ShopName] = sale.Amount;

            }
            return dict;
        }





    }
    }
}
