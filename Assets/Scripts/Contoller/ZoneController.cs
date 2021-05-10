using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoneController : MonoBehaviour
{
    public Line line;
    public Text powerText;
    public DropHandler dropHandler;
    public PlayerController pc;

    private int power;

    private void Awake()
    {
        dropHandler = GetComponent<DropHandler>();
        dropHandler.zc = this;
    }

    public bool isFitLine(Line _line)
    {
        if (_line == line) return true;
        else if (_line == Line.melee_ranged && (line == Line.melee || line == Line.ranged)) return true;
        else return false;
    }

    public void UpdatePower()
    {
        int ans = 0;
        foreach(Transform monster in this.transform)
        {
            ans += monster.gameObject.GetComponent<MonsterCardController>().card.power;
        }
        power = ans;
        UpdatePowerText();
    }


    private void UpdatePowerText()
    {
        powerText.text = power.ToString();
    }
}
