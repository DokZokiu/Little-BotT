using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoCollideBlock : MonoBehaviour {

	#region Variables 
	public bool collided;
    #endregion

    #region Unity methods
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Solid"))
        {
            collided = true;
            GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().AddItem(1, GameObject.FindGameObjectWithTag("List").GetComponent<BlockList>().BlocksID[gameObject.GetComponent<Mining>().DropID]);
            Destroy(gameObject);
        }
    }

    void Awake () {

    }
    void Start()
    {
        StartCoroutine(SolidConfirmation());
    }

    IEnumerator SolidConfirmation()
    {
        gameObject.tag = "null";
        yield return new WaitForSeconds(0.3f);
        gameObject.tag = "Solid";
    }

    // Update is called once per frame
    void Update () {
        

    }

    

    #endregion

    #region Other methods

    #endregion
}
