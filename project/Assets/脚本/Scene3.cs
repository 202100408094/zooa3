using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class Scene3 : MonoBehaviour
{
    // Start is called before the first frame update
    public static Scene3 Instance;
    public GameObject NextLevel;
    public int treeNum;
    public Text TaskText;
    public AudioSource audio;
    public bool PassAudio;
    // Start is called before the first frame update

    private void Awake()
    {
        Instance = this;
        treeNum = 0;
    }
    // Update is called once per frame
    void Update()
    {
        TaskText.text = $"Task: Picking fruits 5/{treeNum}";
        if (treeNum >= 5&&PassAudio==false)
        {
            NextLevel.gameObject.SetActive(true);
            audio.Play();
            PassAudio = true;
        }
    }
}
