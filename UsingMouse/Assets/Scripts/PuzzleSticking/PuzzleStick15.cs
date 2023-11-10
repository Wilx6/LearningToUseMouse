using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick15 : MonoBehaviour
{
    public GameObject sticked15;
    bool final15;

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
        if (final15)
        {
            sticked15.transform.position = new Vector2(4.29f, -0.75f);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP15"))
        {
            final15 = true;

        }
    }
}
