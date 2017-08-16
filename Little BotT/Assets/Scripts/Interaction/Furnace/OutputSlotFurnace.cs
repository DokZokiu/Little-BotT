using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputSlotFurnace : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click()
    {
        if (GetComponent<Slots>().numberObjects > 0)
        {
            GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().AddItem(GetComponent<Slots>().numberObjects, GetComponent<Slots>().StockedObject);
        }
    }
}
