using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public float bridgeDestroyTime;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine("DestroyBridge");
    }

    IEnumerator DestroyBridge()
    {
        yield return new WaitForSeconds(bridgeDestroyTime);
        Destroy(gameObject);
    }
}
