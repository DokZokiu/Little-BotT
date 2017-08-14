using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractAction : MonoBehaviour {

    #region Variables 
    public LayerMask ActionMask;
    public Interactable Selected;
    public bool canInteract;
    
    #endregion

    #region Unity methods

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100, ActionMask))
            {
                if (canInteract)
                {
                    Interactable interactable = hit.collider.GetComponent<Interactable>();
                    GameObject Objectinteractable = interactable.gameObject;
                    float distance = Vector3.Distance(transform.position, interactable.transform.position);
                    if (interactable && distance < interactable.radius)
                    {
                        Selected = interactable;

                        Objectinteractable.SendMessage("Interaction");

                    }
                }

            } 
            
        }
    }

    
    #endregion

    #region Other methods

    #endregion
}
