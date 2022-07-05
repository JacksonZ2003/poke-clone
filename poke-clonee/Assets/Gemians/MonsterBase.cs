using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Gemians", menuName = "Gemians/Create new Gemian")]

public class MonsterBase : ScriptableObject
{
    [SerializeField] string gemianName;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] monsterType type1;
    [SerializeField] monsterType type2;

    [SerializeField] int maxHp;
    [SerializeField] int physicaldmg;
    [SerializeField] int physicalrst;
    [SerializeField] int magicdmg;
    [SerializeField] int magicrst;
    [SerializeField] int speed;
}

public enum monsterType
{
    None,
    Fire,
    Water,
    Grass,
    Normal,
    Electric,
    Ice,
    Fighting,
    Poison,
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost,
    Dragon
}
