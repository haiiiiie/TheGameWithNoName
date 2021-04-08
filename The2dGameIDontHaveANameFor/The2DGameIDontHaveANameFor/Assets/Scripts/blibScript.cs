using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blibScript : MonoBehaviour
{

    public float HP;
    public Sprite damageSprite;
    public Sprite normalSprite;
    public float spriteSwitchTime;

    public void getDamage(float damage)
    {
        if ((HP - damage) < 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = damageSprite;
            Destroy(this.gameObject, 0f);
            HP -= damage;
            Debug.Log(HP);
        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = damageSprite;
            StartCoroutine(changeSpriteToNormal());
            HP -= damage;
            Debug.Log(HP);
        }
    }

    public IEnumerator changeSpriteToNormal()
    {
        yield return new WaitForSeconds(spriteSwitchTime);
        this.GetComponent<SpriteRenderer>().sprite = normalSprite;
    }
}
