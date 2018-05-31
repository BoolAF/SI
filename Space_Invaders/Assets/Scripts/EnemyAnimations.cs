using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimations : MonoBehaviour {

    [SerializeField]
    private Animator AlienShips;

    //Enemy Death Animation
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            AlienShips.Play("AlienDeathAnim");
            Destroy(gameObject);
        }
    }
}
