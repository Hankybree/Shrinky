using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRules : MonoBehaviour
{
    [SerializeField] float scaleFactor;

    public GameObject player;

    private Vector3 scaleChange;

    private bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        scaleChange = new Vector3(scaleFactor, scaleFactor, scaleFactor);
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

            if(player.transform.localScale == new Vector3(0.1f, 0.1f, 0.1f))
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
