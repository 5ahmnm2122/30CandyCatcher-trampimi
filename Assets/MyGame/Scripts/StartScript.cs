using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    public PlayerData transfer;
    public Text playerName;
    public void NextScene(string scene)
    {
        transfer.playerName = playerName.text;
        SceneManager.LoadScene(scene);
    }
}
