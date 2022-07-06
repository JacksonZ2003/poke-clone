using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Gemians", menuName = "Gemians/Create new Gemian")]

public class GemianBase : ScriptableObject
{
    [SerializeField] new string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] gemianType type1;
    [SerializeField] gemianType type2;

    [SerializeField] int maxHp;
    [SerializeField] int physicalDmg;
    [SerializeField] int physicalRst;
    [SerializeField] int magicDmg;
    [SerializeField] int magicRst;
    [SerializeField] int speed;

    public string Name
    {
        get { return name; }
    }

    public string Description
    {
        get { return description; }
    }

    public Sprite FrontSprite
    {
        get { return frontSprite; }
    }

    public Sprite BackSprite
    {
        get { return backSprite; }
    }

    public gemianType Type1
    {
        get { return type1; }
    }

    public gemianType Type2
    {
        get { return type2; }
    }

    public int MaxHp
    {
        get { return maxHp; }
    }

    public int PhysicalDmg
    {
        get { return physicalDmg; }
    }

    public int PhysicalRst
    {
        get { return physicalRst; }
    }

    public int MagicDmg
    {
        get { return magicDmg; }
    }

    public int MagicRst
    {
        get { return magicRst; }
    }

    public int Speed
    {
        get { return speed; }
    }
}

public enum gemianType
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
