using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick4 : MonoBehaviour
{
    public GameObject sticked4;
    bool final4;
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
        if (final4)
        {
            sticked4.transform.position = new Vector2(2.381531f, 2.038513f);

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP4"))
        {
            final4 = true;

        }
    }
}
