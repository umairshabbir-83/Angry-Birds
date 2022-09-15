using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "WhiteBird" || collision.gameObject.name == "WoodenCrate")
        {
            Destroy(gameObject);
        }
    }
}
