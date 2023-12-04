using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    string checkNums = "0000";
    public GameObject controller;


    public void SetCheckNums(string nums)
    {
        checkNums = nums;
        controller.GetComponent<EnemyNumControl>().CheckNums();
    }

    public string GetCheckNums()
    {
        return checkNums;
    }



    
}
