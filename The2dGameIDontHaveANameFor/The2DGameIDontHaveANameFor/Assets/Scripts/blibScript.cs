using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blibScript : MonoBehaviour
{

    public float HP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(HP);
    }

    public void getDamage(float damage)
    {
        Debug.Log("Got Damage");
        HP -= damage;
    }
}
