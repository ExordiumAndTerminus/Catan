using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Color color;
    public string name;
    public float Score
    {
        get
        {
            return FindObjectsOfType<GameObject>().SelectMany(G=> G.GetComponents<IScore>()).Where(jscore=>jscore!=null).Select(jscore=>jscore.VictoryPoints).Sum();
		}
    }



}
