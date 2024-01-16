using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Neither GG nor AZ tutorial worked perfectly, had to cobble stuff together from both. 
// Guillermo Gonzalez tutorial: https://www.youtube.com/watch?v=PI04VdO-j_0
// Alexander Zotov tutorial: https://www.youtube.com/watch?v=xO_-qMJOmJc

public class MouseClickEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem testParticleSystem = default;   // GG
    private Vector2 mousePos;   // AZ

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))    // GG
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // AZ
            testParticleSystem.Play();  // GG
            testParticleSystem.transform.position = new Vector3(mousePos.x, mousePos.y, 0f);    // AZ
        }
    }
}


