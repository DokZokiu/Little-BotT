using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Smelter : MonoBehaviour {


    #region Variables
    public CoalSlotFurnace CoalSlot;
    public InputSlotFurnace InputSlot;
    public Slider Slider;
    public int CreatedBlockID;
    public string SmeltedBlock;
    public int numberBlockCreated;
    public OutputSlotFurnace OutputSlot;
    public bool isWorking = false;
    
	#endregion

	#region Unity Methods

	void Start () {
        CoalSlot = GetComponentInChildren<CoalSlotFurnace>();
        InputSlot = GetComponentInChildren<InputSlotFurnace>();
        OutputSlot = GetComponentInChildren<OutputSlotFurnace>();
	}
	
	
	void Update () {
        if (!isWorking)
        {
            if (InputSlot.GetComponent<Slots>().numberObjects > 0 && CoalSlot.GetComponent<CoalSlotFurnace>().CoalBar.value > 10)
            {
                isWorking = true;
                CoalSlot.GetComponent<CoalSlotFurnace>().CoalBar.value -= 10;
                SmeltedBlock = InputSlot.GetComponent<Slots>().StockedObject.ID ;
                
                InputSlot.GetComponent<Slots>().numberObjects -= 1;
                StartCoroutine(ProgressBar());

                

            }
        }
	}

    IEnumerator ProgressBar()
    {
        while (Slider.value < Slider.maxValue)
        {
            yield return new WaitForSeconds(0.01f);
            Slider.value += 0.2f;
        }
        gameObject.SendMessage("OutputSet");
        
    }
	#endregion

    void OutputSet()
    {
        switch (SmeltedBlock)
        {
            case "1":
                CreatedBlockID = 2;
                numberBlockCreated = 1;
                break;

        }

        OutputSlot.GetComponent<Slots>().numberObjects += numberBlockCreated;
        OutputSlot.GetComponent<Slots>().StockedObject = GameObject.FindGameObjectWithTag("List").GetComponent<BlockList>().BlocksID[CreatedBlockID];
        Slider.value = 0;
        isWorking = false;
    }

	#region Other Methods

	#endregion
}
