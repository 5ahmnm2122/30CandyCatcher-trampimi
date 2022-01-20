using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneController : MonoBehaviour
{
    public PlayerData transfer;
    public Text scoreTxt;
    public Text nameTxt;
    void Start()
    {
        nameTxt.text = transfer.playerName;
        scoreTxt.text = "Score: "  + transfer.score.ToString();
        


    }

 

}
