using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    #region Variables 

    public bool inventoryActive = false;

    public Text PowerText;
    public Slider PowerBar;
    public CanvasGroup inventory;
    

    #endregion

    #region Unity methods
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        PowerBar.value = GameObject.Find("EB106").GetComponent<PlayerStat>().Power;
        PowerText.text = "Power : " + GameObject.Find("EB106").GetComponent<PlayerStat>().Power;

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!inventoryActive)
            {
                inventory.alpha = 0f; //this makes everything transparent
                inventory.blocksRaycasts = false; //this prevents the UI element to receive input events
                inventoryActive = true;
                GameObject.Find("EB106").GetComponent<InteractAction>().canInteract = true;
            }
            else
            {
                inventory.alpha = 1f; //this makes everything transparent
                inventory.blocksRaycasts = true;
                inventoryActive = false;
                GameObject.Find("EB106").GetComponent<InteractAction>().canInteract = false;
            }
        }
    }

    

	#endregion

	#region Other methods
	
	#endregion
}
