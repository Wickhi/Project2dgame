using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab2 : MonoBehaviour
{
    public Transform kéz;
    public Transform enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay2D(Collider2D collider)
    {
        enemy.position = kéz.position;
    }
}
