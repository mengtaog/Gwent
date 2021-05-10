using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    private void Awake()
    {
        cardList.Add(new MonsterCard(0, "ciri", 15, Effect.empty, Line.melee, Camp.neutral, "~~~~~~~~~~~~~~~~", true));
        cardList.Add(new MonsterCard(1, "ballista2", 5, Effect.empty, Line.siege, Camp.northern, "ruo ji", false));
        cardList.Add(new MonsterCard(2, "ballista1", 5, Effect.empty, Line.siege, Camp.northern, "ruo ji", false));
        cardList.Add(new MonsterCard(3, "avallach", 0, Effect.spy, Line.melee, Camp.neutral, "~~~~~~~~~~~~~~~~", true));
        cardList.Add(new MonsterCard(4, "commando", 5, Effect.agile, Line.melee, Camp.northern, "军团智昏官", false));
        cardList.Add(new MonsterCard(5, "medic", 5, Effect.nurse, Line.siege, Camp.northern, "学医救不了帝国人", false));
        cardList.Add(new SpellCard(6, "clear", Effect.clear_sky, Camp.neutral, "放晴"));
    }
}
