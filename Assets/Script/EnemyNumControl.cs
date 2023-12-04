using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EnemyNumControl : MonoBehaviour
{
    public GameObject enemyObj = new GameObject();
    public GameObject btnObj = new GameObject();
    public GameObject turnObj = new GameObject();
    public GameObject[] numsTextObj;
    Button startBtn;
    Enemy enemy;
    
    public TextMeshProUGUI[] numsText;
    TextMeshProUGUI status;
    TextMeshProUGUI turnText;
    //Image[] numsBack = new Image[4];
    public GameObject player, statusObj;
    string checkingNums;
    //int[] checkedNums = new int[4];// 0 = nothing(default), 1 = ball, 2 = strike
    int ball, strike;
    

    void Start()
    {
        //numsText[0] = numsTextObj[0].GetComponent<TextMeshProUGUI>();
        
        for (int i = 0; i < 4; i++)
        {
            numsText[i] = numsTextObj[i].GetComponent<TextMeshProUGUI>();
            //numsBack[i] = gameObject.transform.GetChild(i).GetComponent<Image>();
        }
        enemy = enemyObj.GetComponent<Enemy>();
        status = statusObj.GetComponent<TextMeshProUGUI>();
        startBtn = btnObj.GetComponent<Button>();
        turnText = turnObj.GetComponent<TextMeshProUGUI>();
    }
    
    public void GameStart()
    {
        
        enemy.SetNums(); //난수 설정
        
        
        
    }

    public void WaitingPlay()
    {
        turnText.text = "Input Numbers";
    }

    public void ShowNums()
    {
        for (int i = 0; i < 4; i++)
        {
            numsText[i].text = enemy.GetNums(i).ToString();
        }
    }

    public void CheckNums()
    {
        ball = 0; strike = 0;
        checkingNums = player.GetComponent<Player>().GetCheckNums();
        string enemyNums = enemy.GetNumsStr();

        for(int i = 0, j = 0; i < 4; j++)
        {
            if(enemyNums[j] == checkingNums[i])
            {
                if (i == j)
                {
                    strike++;
                }
                else
                    ball++;
            }

            if (j == 3)
            {
                j = 0; i++;
            }

        }
        ShowCheck();
    }

    public void ShowCheck()
    {
        if (ball + strike == 0)
        {
            status.text = "out!!!";
            WaitingPlay();
        }
        else if (strike == 4)//win
        {
            status.text = "You Win!";
            ShowNums();
            btnObj.SetActive(true);
            btnObj.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "Restart?";

        }
        else
        {
            status.text = "Ball : " + ball.ToString() + "\n Strike : " + strike.ToString();
            WaitingPlay();
        }
    }

}
