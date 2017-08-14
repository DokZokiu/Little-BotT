using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSlotFurnace : MonoBehaviour {


    #region Variables
    private BlockInfoClass SelectedObject;
    private Slots SelectedSlot;
    private Slots InputSlot;
	#endregion

	#region Unity Methods

	void Start () {
        InputSlot = GetComponent<Slots>();
    }
	
	
	void Update () {
        SelectedSlot = GameObject.FindGameObjectWithTag("MainInfoBar").GetComponent<MainInfoBar>().selectedSlot.GetComponent<Slots>();
        SelectedObject = GameObject.FindGameObjectWithTag("MainInfoBar").GetComponent<MainInfoBar>().selectedSlot.GetComponent<Slots>().StockedObject;

    }

    public void Click()
    {
        
        if (SelectedSlot.numberObjects > 0)
        {
            if (SelectedObject.CanMelt == true)
            {
                InputSlot.StockedObject = SelectedSlot.StockedObject;
                InputSlot.numberObjects += 1;
                SelectedSlot.numberObjects -= 1;
            }
        }
        else
        {
            
            if (InputSlot.numberObjects > 0)
            {
                SelectedSlot.numberObjects = InputSlot.numberObjects;
                SelectedSlot.StockedObject = InputSlot.StockedObject;
                InputSlot.ClearSlot();
            }
        }
        
    }

	#endregion

	#region Other Methods

	#endregion
}
