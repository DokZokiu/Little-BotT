using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

    #region Variables 

    public Vector3 playerPos;
    public GameObject Camera;

	#endregion
	
	#region Unity methods

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        playerPos = transform.position; //get the camera position

        Camera.transform.position = playerPos + new Vector3(0, 22, 17);
	}

	#endregion

	#region Other methods
	
	#endregion
}
