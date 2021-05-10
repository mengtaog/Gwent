using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Prefabs 
{
    private static Prefabs Instance;

    public GameObject MonsterCardPrefab;
    public GameObject SpellCardPrefab;

    public static Prefabs GetInstance()
    {
        if (Instance == null) Instance = new Prefabs();
        return Instance;
    }


    private Prefabs()
    {
        MonsterCardPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/MonsterCard.prefab");
        
        SpellCardPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/SpellCard.prefab");
        
    }
}
