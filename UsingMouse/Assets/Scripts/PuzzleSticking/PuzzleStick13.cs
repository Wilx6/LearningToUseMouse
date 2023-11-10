using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick13 : MonoBehaviour
{
    public GameObject sticked13;
    bool final13;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseUp()
    {
        if (final13)
        {
            sticked13.transform.position = new Vector2(-0.07415771f, -0.7424011f);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP13"))
        {
            final13 = true;

        }
    }
}
