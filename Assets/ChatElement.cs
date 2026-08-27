using System;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class ChatElement
{
    [TextArea(10, 10)]
    public string value;
    public string character;
    public int next;
    public int chatEvent = -1;
    public List<NameAndVal<int>> option;
    public bool disableNext;
}
