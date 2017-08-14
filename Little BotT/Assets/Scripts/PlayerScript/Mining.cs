using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Mining : MonoBehaviour {


    #region Variables
    public int miningCountMax;
    public float miningPercent;
    public float miningNeedTime;
    public int DropID;
    public int NumberDrop;
    public Slider Slider;
	#endregion

	#region Unity Methods

	void Start () {
        Slider = GameObject.Find("MiningSlider").GetComponent<Slider>(); 
	}
	
	
	void Update () {
        if (miningPercent >= miningNeedTime)

        {
            GameObject.Find("Inventory").GetComponent<Inventory>().AddItem(NumberDrop, GameObject.FindGameObjectWithTag("List").GetComponent<BlockList>().BlocksID[DropID]);
            miningCountMax -= 1;
            miningPercent = 0;
            if (miningCountMax == 0)
            {
                Destroy(gameObject);
                Slider.gameObject.GetComponentInChildren<CanvasGroup>().alpha = 0;
            }
        }

	}

    void OnMouseOver()
    {
        if (GameObject.Find("EB106").GetComponent<InteractAction>().canInteract == true)
        {
            
            float distance = Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position);
            if ( distance < 13)
            {
                Slider.value = miningPercent;
                Slider.gameObject.GetComponentInChildren<CanvasGroup>().alpha = 1;
                Slider.maxValue = miningNeedTime;
                if (Input.GetMouseButton(0))
                {
                    miningPercent += 0.1f;
                }
            }
        }
    }

    private void OnMouseExit()
    {
        Slider.maxValue = 100;
        Slider.gameObject.GetComponentInChildren<CanvasGroup>().alpha = 0;
        miningPercent = 0f;
    }

    #endregion

    #region Other Methods

    #endregion
}
