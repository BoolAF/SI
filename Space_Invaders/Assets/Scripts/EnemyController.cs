using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {

    private Transform enemyHolder;
    public float speed;

    public GameObject shot;
    public Text winText;
    public float fireRate = 0.997f;


    void Start() {
        winText.enabled = false;
        InvokeRepeating("MoveEnemy", 0.1f, 0.3f);
        enemyHolder = GetComponent<Transform>();
    }

    void MoveEnemy()
    {
        enemyHolder.position += Vector3.right * speed;

        //enemy movement distances
        foreach (Transform enemy in enemyHolder)
        {
            if (enemyHolder.position.x < -3 || enemyHolder.position.x > 3)
            {
                speed = -speed;
                enemyHolder.position += Vector3.down * 0.3f;
                return;
            }


            //Random bullet shots
            if (Random.value > fireRate)
            {
                Instantiate(shot, enemy.position, enemy.rotation);
            }

            if (enemy.position.y <= -4)
            {
                GameOver.isPlayerDead = true;
                Time.timeScale = 0;
            }
        }

        //checking if all enemies are destroyed
        if (enemyHolder.childCount == 1)
        {
            CancelInvoke();
            InvokeRepeating("MoveEnemy", 0.1f, 0.25f);
        }

        if (enemyHolder.childCount == 0)
        {
            winText.enabled = true;
        }
    }
}
