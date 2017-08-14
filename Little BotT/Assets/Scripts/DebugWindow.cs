using UnityEngine;
using UnityEditor;

public class DebugWindow : EditorWindow {


    #region Variables
    int addnumber;
    int selectedBlock;
    int slot;
    
    #endregion

    #region Unity Methods

    void Start () {
        
    }
	
	
	void Update () {
		
	}

	#endregion

    [MenuItem("Window/Debug")]
    public static void ShowWindow ()
    {
        GetWindow<DebugWindow>("Debuge");
    }

    private void OnGUI()
    {
        

        GUILayout.Label("Inventory Manager : ", EditorStyles.boldLabel);
        
        addnumber = EditorGUILayout.IntField("Number Of Block  : ", addnumber);

        selectedBlock = EditorGUILayout.IntField("Block", selectedBlock);

        slot = EditorGUILayout.IntField("Slot", slot);

        if (GUILayout.Button("Set Item"))
        {
            GameObject.Find("Inventory").GetComponent<Inventory>().SetItem(slot, addnumber, GameObject.Find("List").GetComponent<BlockList>().BlocksID[selectedBlock]);
        }
    }

    #region Other Methods

    #endregion
}
