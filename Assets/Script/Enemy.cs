using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    int[] EnemyNums;
    public GameObject controller;

    // Start is called before the first frame update
    void Start()
    {
        EnemyNums = new int[4];
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SetNums()
    {
        for (int i = 0; i < EnemyNums.Length; i++)
        {
            if(i == 0 )
                EnemyNums[i] = Random.Range(1, 9);
            else
                EnemyNums[i] = Random.Range(0, 9);

            Debug.LogFormat("Random Set {0} : {1}", i,  EnemyNums[i]);
        }

        controller.GetComponent<EnemyNumControl>().WaitingPlay();
    }

    public int GetNums(int n)
    {
        return EnemyNums[n];
    }

    public string GetNumsStr() {
        string output = "";
        for (int i = 0; i < EnemyNums.Length; i++) {
            output += GetNums(i).ToString();
            }
        return output;
    }

}
