using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour {

    #region Variables 
    public GameObject GUICanvasGroup;
	#endregion
	
	#region Unity methods

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CloseGUI()
    {
        GUICanvasGroup.GetComponent<CanvasGroup>().alpha = 0;
        GUICanvasGroup.GetComponent<CanvasGroup>().interactable = false;
        GUICanvasGroup.GetComponent<CanvasGroup>().blocksRaycasts = false;
        GameObject.Find("EB106").GetComponent<InteractAction>().canInteract = true;
    }
       

	#endregion

	#region Other methods
	
	#endregion
}
