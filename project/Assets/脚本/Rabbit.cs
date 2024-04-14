using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Rabbit : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    public GameObject UI1,UI2;
    public AudioSource source;
    private void Awake()
    {
        anim = this.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerMove>().InRound = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerMove>().InRound = false;
        }
    }
    private void Update()
    {
        
        if(PlayerMove.Instance.InRound&&Input.GetMouseButtonDown(0))
        {
            anim.SetBool("run", true);
            UI1.SetActive(false);
            UI2.SetActive(true);
            source.Play();
        }
    }
}
