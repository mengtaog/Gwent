using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SpellCardController : CardController
{
    public SpellCard card;

    private void Start()
    {
        card = (SpellCard)CardDatabase.cardList[no];
        CardInit();
    }

    public override void setCard(Card _card)
    {
        card = (SpellCard)_card;
    }

    public override void PlayCard()
    {
        throw new System.NotImplementedException();
    }

    public override void CardInit()
    {
        cardName.text = card.cardName;
        description.text = card.description;
        //card face
        Image image = cardBody.GetComponent<Image>();
        image.sprite = Resources.Load<Sprite>("CardImages\\" + card.camp.ToString() + "\\" + card.cardName);
        

        //effect icon
        image = cardEffect.transform.DeepFind("Effect").gameObject.GetComponent<Image>();
        if (card.effect != Effect.empty) image.sprite = Resources.Load<Sprite>("EffectIcons\\" + "card_effect_" + card.effect.ToString());
        else cardEffect.SetActive(false);
    }
}
