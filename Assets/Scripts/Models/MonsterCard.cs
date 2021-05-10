using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MonsterCard : Card
{
    public int power;
    public Line line;
    public bool isHeroCard;
    

    public MonsterCard() { }

    public MonsterCard(int _id, string _name, int _power, Effect _effect, Line _line, Camp _camp, string _description, bool _isHeroCard = false)
    {
        id = _id;
        cardName = _name;
        power = _power;
        effect = _effect;
        line = _line;
        camp = _camp;
        description = _description;
        isHeroCard = _isHeroCard;
    }

    public override GameObject GeneralInstant()
    {
        GameObject newCard = Object.Instantiate(Prefabs.GetInstance().MonsterCardPrefab);
        MonsterCardController mcc = newCard.GetComponent<MonsterCardController>();
        mcc.setCard(this);
        mcc.CardInit();
        return newCard;
    }
}
