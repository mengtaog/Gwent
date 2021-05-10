using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Card 
{
    public int id;
    public string cardName;
    public Effect effect;
    public Camp camp;
    public string description;

    public abstract GameObject GeneralInstant();
   
}
