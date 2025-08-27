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


//for (int i = 0; i < 100; i++)
//{
//    int result = rand.Next(0, 5);//0以上5未満のランダムを取得して変数resultに代入

//    //result番目の値を配列からひっぱってきてコンソールに出す
//    Console.WriteLine(omikuji[result]);

//    count[result]++;//resultで引いた結果の番号をカウント
//}

//for (int i = 0; i < 100; i++)
//{
//    Console.WriteLine("今" + (i + 1) + "回目の繰り返しやで");

//}


//大吉を引くまで繰り返すループ
bool end = false; //終わりフラグ
while (end == false)
{
    int result = rand.Next(0, 5);//0以上5未満のランダムを取得して変数resultに代入
                                 //result番目の値を配列からひっぱってきてコンソールに出す
    Console.WriteLine(omikuji[result]);
    count[result]++;//resultで引いた結果の番号をカウント

    if (result == 0)
    {
        //もし大吉を引いたら変数endはtrue
        end = true;
    }


}


//配列countの結果を順番に発表
for (int i = 0; i < count.Length; i++)
{
    Console.WriteLine(omikuji[i] + "は" + count[i] + "回引かれました。");
}




////論理型
//bool end = false; //終わりフラグ
////いつ終わりが来るかわからないループ
//while (end == false) //終わりのフラグが来ない間は繰り返す
//{
//    int dice = rand.Next(0, 7);//0～6のランダム値
//    if (dice == 0)
//    {
//        end = true;
//    }
//    Console.WriteLine("つづく");
