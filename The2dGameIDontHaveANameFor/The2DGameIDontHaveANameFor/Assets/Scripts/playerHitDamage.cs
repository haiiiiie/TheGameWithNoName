
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHitDamage : MonoBehaviour
{

    private float damage;
    public GameObject player;

    private void Start()
    {
        damage = player.GetComponent<playerHit>().damage;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<blibScript>().getDamage(damage);
        }
    }
}
