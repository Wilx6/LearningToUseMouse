using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick14 : MonoBehaviour
{
    public GameObject sticked14;
    bool final14;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (final14)
        {
            sticked14.transform.position = new Vector2(2.339905f, -0.7220459f);

        }
    }
    void OnMouseUp()
    {
        if (final14)
        {
            sticked14.transform.position = new Vector2(2.339905f, -0.7220459f);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP14"))
        {
            final14 = true;

        }
    }
}
