using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    private Camera camera;
    public bool playing;
    public SetStartPos corner;
    // Start is called before the first frame update
    void Start()
    {
        playing=true;
        camera = Camera.main;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = camera.ScreenToWorldPoint(Input.mousePosition);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Walls")) {
            corner.Wait();
        }
    }
}
