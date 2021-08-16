using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartPos : MonoBehaviour
{
    private Camera camera;
    public Mouse mouse;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        Wait();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = camera.ScreenToWorldPoint(new Vector3(0,0,0))+new Vector3(0,0,10);
        if (mouse.playing) {
            GetComponent<SpriteRenderer>().color = new Color(0,1,0);
        } else {
            GetComponent<SpriteRenderer>().color = new Color(1,0,0);
        }
    }
    public void Wait() {
        mouse.playing = false;
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Mouse")) {
            mouse.playing = true;
        }
    }
}
