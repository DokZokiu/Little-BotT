using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafting : MonoBehaviour {


    #region Variables
    private bool CraftingOn = false;
    public CraftClass[] CraftList;
	#endregion

	#region Unity Methods

	void Start () {
		
	}
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (!CraftingOn)
            {
                gameObject.GetComponent<CanvasGroup>().alpha = 1;
                gameObject.GetComponent<CanvasGroup>().interactable = true;
                gameObject.GetComponent<CanvasGroup>().blocksRaycasts = true;
                CraftingOn = true;
            }
            else
            {
                gameObject.GetComponent<CanvasGroup>().alpha = 0;
                gameObject.GetComponent<CanvasGroup>().interactable = false;
                gameObject.GetComponent<CanvasGroup>().blocksRaycasts = false;
                CraftingOn = false;
            }
        }


	}

	#endregion

	#region Other Methods

	#endregion
}
