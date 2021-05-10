using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCard : Card
{
    

    public SpellCard() { }

    public SpellCard(int _id, string _name, Effect _effect, Camp _camp, string _description)
    {
        id = _id;
        cardName = _name;
        effect = _effect;
        camp = _camp;
        description = _description;
    }

    public override GameObject GeneralInstant()
    {
        GameObject newCard = Object.Instantiate(Prefabs.GetInstance().SpellCardPrefab);
        return newCard;
        //throw new System.NotImplementedException();
    }
}
