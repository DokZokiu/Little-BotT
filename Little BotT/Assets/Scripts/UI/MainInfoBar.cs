using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainInfoBar : MonoBehaviour {


    #region Variables
    public GameObject selectedSlot;
    public GameObject Shortcut1;
    public GameObject Shortcut2;
    public GameObject SelectedIndic0;
    public GameObject SelectedIndic1;
    
	#endregion

	#region Unity Methods

	void Start () {
		
	}
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            selectedSlot = Shortcut1;
            SelectedIndic0.SetActive(true);
            SelectedIndic1.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            selectedSlot = Shortcut2;
            SelectedIndic0.SetActive(false);
            SelectedIndic1.SetActive(true);
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
        {
            selectedSlot = Shortcut2;
            SelectedIndic0.SetActive(false);
            SelectedIndic1.SetActive(true);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
        {
            selectedSlot = Shortcut1;
            SelectedIndic0.SetActive(true);
            SelectedIndic1.SetActive(false);
        }

    }



    #endregion

    #region Other Methods

    #endregion
}
