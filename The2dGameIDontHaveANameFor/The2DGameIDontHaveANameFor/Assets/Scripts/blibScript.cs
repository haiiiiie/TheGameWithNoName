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
            Debug.Log("Damage");
            this.GetComponent<SpriteRenderer>().sprite = damageSprite;
            changeSpriteToNormal();
            Destroy(this.gameObject, .5f);
            HP -= damage;
            Debug.Log(HP);
        }
        else
        {
            Debug.Log("Damage");
            this.GetComponent<SpriteRenderer>().sprite = damageSprite;
            changeSpriteToNormal();
            HP -= damage;
            Debug.Log(HP);
        }
    }

    public IEnumerator changeSpriteToNormal()
    {
        yield return new WaitForSeconds(spriteSwitchTime);
        Debug.Log("Change back");
        this.GetComponent<SpriteRenderer>().sprite = normalSprite;
    }
}
