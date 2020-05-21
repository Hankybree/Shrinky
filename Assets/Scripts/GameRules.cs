using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRules : MonoBehaviour
{
    [SerializeField] float scaleFactor;

    public GameObject player;
    public GameObject powerUp;
    public static bool powerUpInGame = false;

    private Vector3 scaleChange;

    private bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(scaleFactor, scaleFactor, scaleFactor);
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        shrinkPlayer();

        if(!powerUpInGame) 
        {
            powerUpInGame = true;
            spawnPowerUp();
        }
    }

    private void shrinkPlayer()
    {
        if(!gameOver)
        {
            player.transform.localScale += scaleChange;

            if(player.transform.localScale.x <= 0.1f)
            {
                GameOver();
            } 
        }
    }

    private void spawnPowerUp() 
    {
        int x = Random.Range(-20, 20);
        int z = Random.Range(-20, 20);

        Instantiate(powerUp, new Vector3(x, 0.7f, z), powerUp.transform.rotation);
    }

    private void GameOver()
    {
        Debug.Log("You lose!");

        gameOver = true;
    }
}
