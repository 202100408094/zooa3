using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class Scene2 : MonoBehaviour
{
    public static Scene2 Instance;
    public GameObject NextLevel;
    public int garbageNum;
    public Text TaskText;
    public AudioSource audio;
    bool PassAudio;
    // Start is called before the first frame update

    private void Awake()
    {
        Instance = this;
        garbageNum = 0;
    }
    // Update is called once per frame
    void Update()
    {
        TaskText.text = $"Task: Pick up garbage 5/{garbageNum}";
        if(garbageNum>=5&&PassAudio==false)
        {
            NextLevel.gameObject.SetActive(true);
            audio.Play();
            PassAudio = true;
        }
    }
}
