using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    public bool InRound;
    public static PlayerMove Instance;
  

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        anim.SetFloat("MoveSpeed", new Vector3(x, 0, y).magnitude);
        if(Input.GetMouseButton(0))
        {
            anim.SetTrigger("Pickup");

        }

    }
}
