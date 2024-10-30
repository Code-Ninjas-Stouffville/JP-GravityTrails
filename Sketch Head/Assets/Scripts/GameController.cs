using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Platform gameobj
    [Header("Platform Object")]
    public GameObject platform;
    //Default pos for platform
    float pos = 0;
    void Start()
    {
        //Interger i = 1000
        for(int i = 0; i < 1000; i++)
        {
            //Execute SpawnPlat
            SpawnPlatforms();
        }

    }
    void SpawnPlatforms()
    {
        //Spawn platforms at a random pos
        Instantiate(platform, new Vector3(Random.value * 10 - 5f, pos, 0.5f), Quaternion.identity);
        pos += 2.5f;
    }
    // Update is called once per frame
    void Update()
    {

    }
    //Game Over Canvas
    [Header("Game Over UI Canvas Object")]
    public GameObject gameOverCanvas;

    //Game over function
    public void GameOver()
    {
        //Game Over Canvas is active
        gameOverCanvas.SetActive(true);
    }
}

