using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FoodScript : MonoBehaviour
{
    [SerializeField] GameObject[] foodPrefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    public Text timeTxt;
    public int score;
    public float time = 60;
    public PlayerData transfer;

    
    void Start()
    {
        StartCoroutine(FoodSpawn());
 
    }

    void Update()
    {
        time -= Time.deltaTime;
        var timeInt = (int)time;
        timeTxt.text = timeInt.ToString();

        if(time < 0)
        {
            transfer.score = score;
            SceneManager.LoadScene("EndScene");
        }
    }

  IEnumerator FoodSpawn()
    {
        while(true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(foodPrefab[Random.Range(0, foodPrefab.Length)],
            position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }
}
