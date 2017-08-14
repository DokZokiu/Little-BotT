using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CraftClass
{
    public string Name;
    public string CraftID;
    public Need[] Need;
    public int ResultID;
    public int NumberResult;
    public float craftLevel;
}

[System.Serializable]
public class Need
{
    public string Name;
    public int number;
    public string ObjectID;

}