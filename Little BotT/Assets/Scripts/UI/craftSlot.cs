using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class craftSlot : MonoBehaviour {


    #region Variables
    public int CraftID;
    public CraftClass SelectedCraft;
    public Text needText;
    public Text ResultText;
    public Image ResultIcone;
    public int foundObject;
    
	#endregion

	#region Unity Methods

	void Start () {
        needText = this.gameObject.transform.GetChild(2).GetComponent<Text>();
        ResultText = this.gameObject.transform.GetChild(0).GetComponent<Text>();
        ResultIcone = this.gameObject.transform.GetChild(1).GetComponent<Image>();
        SelectedCraft = this.gameObject.GetComponentInParent<Crafting>().CraftList[CraftID];

        foreach (Need need in SelectedCraft.Need)
        {
            needText.text = needText.text + need.Name + "\n";
        }

        ResultText.text = SelectedCraft.NumberResult + " :";

        ResultIcone.sprite = GameObject.FindGameObjectWithTag("List").GetComponent<BlockList>().BlocksID[SelectedCraft.ResultID].SpriteName;

    }
	
	
	void Update () {
		
	}

    public void Click()
    {
        foundObject = 0;

        for (int o = 0; o < SelectedCraft.Need.Length; o++)
        {
            for (int i = 0; i < GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().Slots.Length; i++)
            {
                if (GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().Slots[i].GetComponent<Slots>().numberObjects > 0)
                {
                    if (GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().Slots[i].GetComponent<Slots>().StockedObject.ID == SelectedCraft.Need[o].ObjectID)
                    {
                        if (GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().Slots[i].GetComponent<Slots>().numberObjects >= SelectedCraft.Need[o].number)
                        {
                            foundObject += 1;
                            if (foundObject == SelectedCraft.Need.Length)
                            {
                                GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().Slots[i].GetComponent<Slots>().numberObjects -= SelectedCraft.Need[o].number;
                                GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().AddItem(SelectedCraft.NumberResult, GameObject.FindGameObjectWithTag("List").GetComponent<BlockList>().BlocksID[SelectedCraft.ResultID]);
                                break;
                            }
                        }
                    }
                } 
                
            }
        }

        
    }

	#endregion

	#region Other Methods

	#endregion
}
