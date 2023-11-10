using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick : MonoBehaviour
{
    public GameObject sticked1;
    bool final1;
 
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
        if (final1)
        {
            sticked1.transform.position = new Vector2(-4.436f, 2.292f);

        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP1"))
        {
            final1 = true;

        }
    }
}
