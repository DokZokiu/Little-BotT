using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CoalSlotFurnace : MonoBehaviour {


    #region Variables
    public BlockInfoClass Coal;
    public Slider CoalBar;
	#endregion

	#region Unity Methods

	void Start () {
        Coal = GameObject.FindGameObjectWithTag("List").GetComponent<BlockList>().BlocksID[4];
	}
	
	
	void Update () {
		
	}

    public void Clicked()
    {
        for (int i = 0; i < GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().Slots.Length; i++)
        {
            if (GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().Slots[i].GetComponent<Slots>().numberObjects > 0)
            {
                if (GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().Slots[i].GetComponent<Slots>().StockedObject.ID == Coal.ID)
                {
                    if (CoalBar.value != 100)
                    {
                        GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().Slots[i].GetComponent<Slots>().numberObjects -= 1;
                        CoalBar.value += 10;
                    }
                }
            } 
                
        }
        
    }

	#endregion

	#region Other Methods

	#endregion
}
