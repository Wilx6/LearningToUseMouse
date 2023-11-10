using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick6 : MonoBehaviour
{
    public GameObject sticked6;
    bool final6;
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
        if (final6)
        {
            sticked6.transform.position = new Vector2(-4.861145f, 0.7132874f);

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP6"))
        {
            final6 = true;

        }
    }
}
