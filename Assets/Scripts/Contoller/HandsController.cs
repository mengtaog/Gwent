using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsController : MonoBehaviour
{
    

    public void PushCard(GameObject cardObj)
    {
        cardObj.transform.SetParent(transform);
    }
}
