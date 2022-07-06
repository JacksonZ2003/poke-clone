using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gemians
{
    GemianBase _base;
    int level;

    public Gemians(GemianBase gBase, int gLevel)
    {
        _base = gBase;
        level = gLevel;
    }

    public int PhysicalDmg
    {
        get { return Mathf.FloorToInt((_base.PhysicalDmg * level) / 100f) + 5; }
    }

    public int PhysicalRst
    {
        get { return Mathf.FloorToInt((_base.PhysicalRst * level) / 100f) + 5; }
    }

    public int MagicDmg
    {
        get { return Mathf.FloorToInt((_base.MagicDmg * level) / 100f) + 5; }
    }

    public int MagicRst
    {
        get { return Mathf.FloorToInt((_base.MagicRst * level) / 100f) + 5; }
    }

    public int Speed
    {
        get { return Mathf.FloorToInt((_base.Speed * level) / 100f) + 5; }
    }

    public int MaxHp
    {
        get { return Mathf.FloorToInt((_base.MaxHp * level) / 100f) + 10; }
    }
}
