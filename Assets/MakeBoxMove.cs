using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBoxMove : MonoBehaviour {
    //can do it like this
    public Vector3 motion = new Vector3(0, 1, 5);
    public float someName
    {
        get
        {
            //need f in front of number for floats
            return 5f;
        }
        set
        {
            float bla = value;
        }
    }
    //or....
    // [] use these for attributes for thiiiiings
    [Tooltip("Yes I Am Shitting You")]
    public Vector3 areYouShittingMe;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //deltaTime is simulated time (real time/in game)
        transform.position += transform.rotation*motion * Time.deltaTime;


	}
}
