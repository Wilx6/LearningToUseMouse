using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleStick9 : MonoBehaviour
{
    public GameObject sticked9;
    bool final9;
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

        if (final9)
        {
            sticked9.transform.position = new Vector2(2.381531f, 0.8278809f);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PP9"))
        {
            final9 = true;

        }
    }
}
