using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isAi;
    public GameObject hands;
    public GameObject deck;
    public ZoneController meleeZoneController;
    public ZoneController rangedZoneController;
    public ZoneController siegeZoneController;

    //
    private DeckController deckController;
    private HandsController handsController;

    private void Awake()
    {
        deckController = deck.GetComponent<DeckController>();
        handsController = hands.GetComponent<HandsController>();
        meleeZoneController = transform.DeepFind("MeleeZone").gameObject.GetComponent<ZoneController>();
        meleeZoneController.pc = this;
        rangedZoneController = transform.DeepFind("RangedZone").gameObject.GetComponent<ZoneController>();
        rangedZoneController.pc = this;
        siegeZoneController = transform.DeepFind("SiegeZone").gameObject.GetComponent<ZoneController>();
        siegeZoneController.pc = this;
        /*
         * if(deckController == null) 
         * if(handsController == null)
        */


    }

    public void DrawCard()
    {
        if (deckController.deck.Count <= 0) return;
        Card card = deckController.PopCard();
        GameObject cardObj = card.GeneralInstant();
        cardObj.GetComponent<DragHandler>().pc = this;
        handsController.PushCard(cardObj);
    }

    public void PlayCard(GameObject cardObj, ZoneController zc)
    {
        if (cardObj.GetComponent<DragHandler>().pc.isAi == TurnSystem.Instance.isYourTurn) return;//can not play card in oppo's turn
        if (zc.pc.isAi == TurnSystem.Instance.isYourTurn) return; //playing card in enemy's zone is forbided except spy(not implement yet)
        DragHandler dragHandler = cardObj.GetComponent<DragHandler>();
        dragHandler.setNewParent();
        cardObj.GetComponent<MonsterCardController>().PlayCard();
        zc.UpdatePower();
    }

}
