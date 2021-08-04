using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using System.Text;

public class RandomComment : MonoBehaviour
{
    private static readonly string[] COMMENTS = new string[] { " カレーライス", "  オムライス ", "  ハンバーグ " , "  お好み焼き ", "八宝菜はどう？", "  オムレツ～ ", "  焼きそば～ ", "天津飯はどう？", " 炊き込みご飯", "  豚の角煮～ ", "  生姜焼き～ ", "  トンカツ～ ", "親子丼はどう？", "  チャーハン～ ", "  野菜炒め～ ", "  キムチ鍋～ ", " 豚丼食べたい", "  肉じゃが！！ ", " ポテトサラダ", " サバの塩焼き", "  グラタン～ ", "海鮮丼はどう？", "  麻婆豆腐！！ ", " 餃子食べたい", "  ナポリタン ", "  ロコモコ丼 ", " 牛丼食べたい", " ピザ食べたい", " 寿司食べたい", "おでんはどう？" };
    public Text text;

    void Start()
    {
        //COMMENTSの中から一つをランダムで取得する
        string comment = COMMENTS.ElementAt(Random.Range(0, COMMENTS.Count()));
        text.text = string.Format(comment);

        Debug.Log(comment);
    }

}