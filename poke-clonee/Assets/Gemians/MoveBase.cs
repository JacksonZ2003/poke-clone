using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Gemian/Create new move")]

public class MoveBase : ScriptableObject 
{
    [SerializeField] new string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] gemianType type;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int pp;

    public string Name
    {
        get { return name; }
    }

    public string Desciption
    {
        get { return description; }
    }

    public gemianType Type
    {
        get { return type; }
    }

    public int Power
    {
        get { return power; }
    }

    public int Accuracy
    {
        get { return accuracy; }
    }

    public int Pp
    {
        get { return pp; }
    }
}
