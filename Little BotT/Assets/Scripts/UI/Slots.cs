using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class Slots : MonoBehaviour {


    #region Variables

    public BlockInfoClass StockedObject;
    public int numberObjects;
    public Text BlockCounter;
    public Image Icone;
    public bool EmptyIcon = true;
    public GameObject MainInfoBar;
    public CanvasGroup inventory;




    #endregion

    #region Unity Methods

    void Start () {
        Icone = this.gameObject.transform.GetChild(0).GetComponent<Image>();
        BlockCounter = this.gameObject.transform.GetChild(1).GetComponent<Text>();
        MainInfoBar = GameObject.Find("MainInfoBar");

    }
	
	
	void Update () {
        if (Icone.sprite != null)
        {
            Color c = Icone.gameObject.GetComponent<Image>().color;
            c.a = 1;
            Icone.gameObject.GetComponent<Image>().color = c;
        } else
        {
            Color c = Icone.gameObject.GetComponent<Image>().color;
            c.a = 0;
            Icone.gameObject.GetComponent<Image>().color = c;
        }

        if (numberObjects > 0)
        {
            BlockCounter.enabled = true;
            BlockCounter.text = "" + numberObjects;
        }
        else
        {
            BlockCounter.enabled = false;
            ClearSlot();
        }

        if (StockedObject != null)
        {
            Icone.sprite = StockedObject.SpriteName;
        }
        else
        {
            Icone.sprite = null;
        }
    }


    public void Clicked()
    {
        if (MainInfoBar.GetComponent<MainInfoBar>().selectedSlot.GetComponent<Slots>().numberObjects == 0 && numberObjects > 0)
        {
            if (MainInfoBar.GetComponent<MainInfoBar>().selectedSlot == MainInfoBar.GetComponent<MainInfoBar>().Shortcut1)
            {
                GameObject.Find("Inventory").GetComponent<Inventory>().SetItem(30, numberObjects, StockedObject);
            }
            else
            {
                GameObject.Find("Inventory").GetComponent<Inventory>().SetItem(31, numberObjects, StockedObject);
            }
            ClearSlot();
        }
        else
        {
            if (MainInfoBar.GetComponent<MainInfoBar>().selectedSlot.GetComponent<Slots>().numberObjects > 0 && numberObjects <= 0)
            {
                StockedObject = MainInfoBar.GetComponent<MainInfoBar>().selectedSlot.GetComponent<Slots>().StockedObject;
                numberObjects = MainInfoBar.GetComponent<MainInfoBar>().selectedSlot.GetComponent<Slots>().numberObjects;
                MainInfoBar.GetComponent<MainInfoBar>().selectedSlot.GetComponent<Slots>().SendMessage("ClearSlot");
            }
        }
    }

    public void ClearSlot()
    {
        StockedObject = null;
        numberObjects = 0;
    }

    #endregion

    #region Other Methods

    #endregion
}
