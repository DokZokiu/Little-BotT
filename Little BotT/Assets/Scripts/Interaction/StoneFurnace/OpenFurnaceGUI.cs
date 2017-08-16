using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFurnaceGUI : MonoBehaviour {


	#region Variables

	#endregion

	#region Unity Methods

	void Start () {
		
	}
	
	
	void Update () {
		
	}

    public void Interaction()
    {
        GameObject.Find("EB106").GetComponent<InteractAction>().canInteract = false;
        this.gameObject.transform.GetChild(3).gameObject.GetComponent<CanvasGroup>().alpha = 1;
        this.gameObject.transform.GetChild(3).gameObject.GetComponent<CanvasGroup>().blocksRaycasts = true;
        this.gameObject.transform.GetChild(3).gameObject.GetComponent<CanvasGroup>().interactable = true;
    }

    #endregion

    #region Other Methods

    #endregion
}
