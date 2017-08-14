using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseBlock : MonoBehaviour {

    #region Variables 
    public Vector3 MousePosition;
    public Vector3 myWorldPoint;
    public float distance = 24.29f;
    public GameObject SelectedBlock;
    


    #endregion

    #region Unity methods

    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        if (GameObject.Find("MainInfoBar").GetComponent<MainInfoBar>().selectedSlot.GetComponent<Slots>().numberObjects > 0)
        {
            SelectedBlock = GameObject.Find("MainInfoBar").GetComponent<MainInfoBar>().selectedSlot.GetComponent<Slots>().StockedObject.BlockObjectName;
        }
        else
        {
            SelectedBlock = null;
        }
        

        MousePosition = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        myWorldPoint = ray.origin + (ray.direction * distance);
        Vector3 poseBlock = new Vector3(myWorldPoint.x, 1f, myWorldPoint.z);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (GameObject.Find("EB106").GetComponent<InteractAction>().canInteract == true)
                {
                    float distance = Vector3.Distance(transform.position, myWorldPoint);
                    if (distance < 10)
                    {
                        if (SelectedBlock != null)
                        {
                            Instantiate(SelectedBlock, poseBlock, new Quaternion(0, 0, 0, 0), GameObject.Find("Terrain").transform);
                            GameObject.Find("MainInfoBar").GetComponent<MainInfoBar>().selectedSlot.GetComponent<Slots>().numberObjects -= 1;
                            if (GameObject.Find("MainInfoBar").GetComponent<MainInfoBar>().selectedSlot.GetComponent<Slots>().numberObjects <= 0)
                            {
                                GameObject.Find("MainInfoBar").GetComponent<MainInfoBar>().selectedSlot.GetComponent<Slots>().SendMessage("ClearSlot");
                            }
                        }


                    }
                }


            }
            
        }
        

	}


    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 10f);
    }


    #endregion

    #region Other methods

    #endregion
}
