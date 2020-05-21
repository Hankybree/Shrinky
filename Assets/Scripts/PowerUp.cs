using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject player;
    public GameObject audioSource;

    private void OnCollisionEnter(Collision collision)
    {
        RestorePlayer();
    }
    private void Update()
    {
        transform.Rotate(0f, 0f, 5f);
    }

    private void RestorePlayer()
    {
        audioSource.GetComponent<PowerUpAudio>().PlayAudio();
        player.transform.localScale = new Vector3(1, 1, 1);
        Destroy(gameObject);
    }
}
