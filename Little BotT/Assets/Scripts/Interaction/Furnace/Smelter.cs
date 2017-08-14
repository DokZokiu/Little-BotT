using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Smelter : MonoBehaviour {


    #region Variables
    public CoalSlotFurnace CoalSlot;
    public InputSlotFurnace InputSlot;
    public Slider Slider;
    public bool isWorking = false;
    
	#endregion

	#region Unity Methods

	void Start () {
        CoalSlot = GetComponentInChildren<CoalSlotFurnace>();
        InputSlot = GetComponentInChildren<InputSlotFurnace>();
        
	}
	
	
	void Update () {
        if (!isWorking)
        {
            if (InputSlot.GetComponent<Slots>().numberObjects > 0 && CoalSlot.GetComponent<CoalSlotFurnace>().CoalBar.value > 10)
            {
                isWorking = true;
                CoalSlot.GetComponent<CoalSlotFurnace>().CoalBar.value -= 10;
                BlockInfoClass SmeltedBlock = InputSlot.GetComponent<Slots>().StockedObject;
                InputSlot.GetComponent<Slots>().numberObjects -= 1;

                

            }
        }
	}

	#endregion

	#region Other Methods

	#endregion
}
