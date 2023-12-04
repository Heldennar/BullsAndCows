using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputText : MonoBehaviour
{
    public GameObject playerObj;
    TMP_InputField tFieldAns;

    // Start is called before the first frame update
    void Start()
    {
        tFieldAns = gameObject.GetComponent<TMP_InputField>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            InputNum();
        }
    }

    public void InputNum()
    {
        string tmp = tFieldAns.text;
        tFieldAns.text = "";
        playerObj.GetComponent<Player>().SetCheckNums(tmp);
    }


}
