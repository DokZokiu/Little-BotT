using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    #region Variables 
    public float moveSpeed;
    public Quaternion actualRotation;
    public float Axis;
    public Rigidbody rigibody;
    #endregion

    #region Unity methods

    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        actualRotation = transform.rotation;

        Axis = Input.GetAxis("Vertical");

        if (GameObject.Find("EB106").GetComponent<InteractAction>().canInteract == true)
        {
            if (Input.GetAxis("Horizontal") > 0)                                        //Movement + rotaion haut, bas, gauche, droite
            {
                transform.rotation = new Quaternion(0, 0.7071068f, 0, 0.7071068f);
                transform.Translate(moveSpeed * transform.right * Time.deltaTime);
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                transform.rotation = new Quaternion(0, 0.7071068f, 0, -0.7071068f);
                transform.Translate(moveSpeed * transform.right * -1 * Time.deltaTime);
            }

            if (Input.GetAxis("Vertical") < 0)
            {
                transform.rotation = new Quaternion(0, 1, 0, 0);
                transform.Translate(moveSpeed * transform.forward * Time.deltaTime);
            }
            else if (Input.GetAxis("Vertical") > 0)
            {
                transform.rotation = new Quaternion(0, 0, 0, 1);
                transform.Translate(moveSpeed * transform.forward * -1 * Time.deltaTime);

            }
            if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") > 0)       //Rotation en diagonale
            {
                transform.rotation = new Quaternion(0, 0.3826834f, 0, 0.9238796f);
            }

            if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") < 0)
            {
                  transform.rotation = new Quaternion(0, -0.3826834f, 0, 0.9238796f);
             }

            if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") < 0)
            {
                transform.rotation = new Quaternion(0, -0.9238796f, 0, 0.3826833f);
            }

            if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") > 0)
            {
                transform.rotation = new Quaternion(0, 0.9238796f, 0, 0.3826833f);
            }
            
        }
        

                                                                                

        


    }
    
    #endregion

    #region Other methods

    #endregion
}
