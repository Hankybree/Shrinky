using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRules : MonoBehaviour
{
    [SerializeField] float scaleFactor;

    public GameObject player;
    public GameObject powerUp;

    private Vector3 scaleChange;

    private bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(scaleFactor, scaleFactor, scaleFactor);
        gameOver = false;
        Instantiate(powerUp, new Vector3(0f, 0.7f, 5f), powerUp.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        shrinkPlayer();
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

    private void GameOver()
    {
        Debug.Log("You lose!");

        gameOver = true;
    }
}
