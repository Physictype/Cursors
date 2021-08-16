using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFinishPos : MonoBehaviour
{
    private Camera camera;
    public Mouse mouse;
    public Game game;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = camera.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,0))+new Vector3(0,0,10);
        if (mouse.playing) {
            GetComponent<SpriteRenderer>().color = new Color(0,1,0);
        } else {
            GetComponent<SpriteRenderer>().color = new Color(1,0,0);
        }
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Mouse") && mouse.playing) {
            game.NextLevel();
            mouse.playing=false;
        }
    } 
}
