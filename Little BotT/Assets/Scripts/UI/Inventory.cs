using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Inventory : MonoBehaviour {



    #region Variables
    public GameObject[] Slots;
	#endregion

	#region Unity Methods

	void Start () {
        
        

	}
	
    
	
	void Update () {
        
    }

    public void SetItem(int slot, int number, BlockInfoClass Object )
    {
        Slots[slot].GetComponent<Slots>().numberObjects = number;
        Slots[slot].GetComponent<Slots>().StockedObject = Object;
    }

    public void AddItem(int number, BlockInfoClass Object)
    {
        int slotID = -1;

        for (int i = 0; i < Slots.Length; i++)
        {
            if (Slots[i].GetComponent<Slots>().StockedObject == Object)
            {
                slotID = i;
                break;
            }
        }
        if (slotID == -1)
        {
            for (int i = 0; i < Slots.Length; i++)
            {
                if (Slots[i].GetComponent<Slots>().numberObjects == 0)
                {
                    slotID = i;
                    break;
                }
            }
        }

        if (slotID != -1)
        {
            SetItem(slotID, Slots[slotID].GetComponent<Slots>().numberObjects += number, Object);
        }
    }

    #endregion

    #region Other Methods

    #endregion
}
