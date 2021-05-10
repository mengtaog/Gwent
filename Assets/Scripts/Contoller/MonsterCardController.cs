using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MonsterCardController : CardController
{
    public Text power;
    public GameObject HeroIcon;
    public GameObject cardType;
    public GameObject cardCamp;
    public MonsterCard card;
    

    private void Start()
    {
        //card = (MonsterCard)CardDatabase.cardList[no];
        //CardInit();
        
        
    }

    public override void setCard(Card _card)
    {
        card = (MonsterCard)_card;
        return;
    }

    public override void PlayCard()
    {
        //
        TurnSystem.Instance.EndCurrentTurn();
    }

    public override void CardInit()
    {
        cardName.text = card.cardName;
        description.text = card.description;
        //card face
        Image image = cardBody.GetComponent<Image>();
        image.sprite = Resources.Load<Sprite>("CardImages\\" + card.camp.ToString() + "\\" + card.cardName);
        //camp icon
        if (card.camp == Camp.neutral) cardCamp.SetActive(false);
        else
        {
            image = cardCamp.GetComponent<Image>();
            image.sprite = Resources.Load<Sprite>("CampIcons\\" + card.camp.ToString());
        }
        //effect icon
        image = cardEffect.transform.DeepFind("Effect").gameObject.GetComponent<Image>();
        if (card.effect != Effect.empty) image.sprite = Resources.Load<Sprite>("EffectIcons\\" + "card_effect_" + card.effect.ToString());
        else cardEffect.SetActive(false);
        power.text = card.power.ToString();
        //HeroIcon
        if (card.isHeroCard)
        {
            HeroIcon.SetActive(true);
            power.color = Color.white;
        }
        else HeroIcon.SetActive(false);
        //card type icon
        image = cardType.GetComponent<Image>();
        image.sprite = Resources.Load<Sprite>("TypeIcons\\" + "card_type_" + card.line.ToString());
    }


    

}
