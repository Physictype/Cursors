using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private int lvl = 1;
    public GameObject[] levels;
    public GameObject[] comments;
    // Start is called before the first frame update
    void Start()
    {
        LoadLevel(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LoadLevel(int level) {
        for (int i=0; i<levels.Length;i++) {
            if (i==level-1) {
                levels[i].SetActive(true);
            } else {
                levels[i].SetActive(false);
            }
        }
        for (int i=0; i<comments.Length;i++) {
            if (i==level-1) {
                comments[i].SetActive(true);
            } else {
                comments[i].SetActive(false);
            }
        }
    }
    public void NextLevel() {
        lvl+=1;
        LoadLevel(lvl);
    }
}