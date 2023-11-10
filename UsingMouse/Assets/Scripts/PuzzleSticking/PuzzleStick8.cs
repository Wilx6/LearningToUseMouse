using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick8 : MonoBehaviour
{
    public GameObject sticked8;
    bool final8;
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
        if (final8)
        {
            sticked8.transform.position = new Vector2(-0.05444336f, 0.7838135f);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("PP8"))
        {
            final8 = true;

        }
    }
}
