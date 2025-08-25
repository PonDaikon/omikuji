//おみくじ
string[] omikuji = new string[5];
omikuji[0] = "0大吉";
omikuji[1] = "1中吉";
omikuji[2] = "2吉";
omikuji[3] = "3凶";
omikuji[4] = "4大凶";

//string[] omikuji = { "0大吉", "1中吉", "2吉", "3凶","4大凶" };

//各おみくじを何回引いたかを格納する配列
int[] count = new int[5];

//Randomクラスを実体化して変数randが機能を参照できる
Random rand = new Random();
int result = rand.Next(0, 5);//0以上5未満のランダムを取得して変数resultに代入

Console.WriteLine(omikuji[result]);