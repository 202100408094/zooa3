using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garbage : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Scene2.Instance.garbageNum++;
            Destroy(this.gameObject);
        }
    }
}
