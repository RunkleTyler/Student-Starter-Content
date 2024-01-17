using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Neither GG nor AZ tutorial worked perfectly for Particles on Left Click, had to cobble stuff together from both. 
// Guillermo Gonzalez tutorial: https://www.youtube.com/watch?v=PI04VdO-j_0
// Alexander Zotov tutorial: https://www.youtube.com/watch?v=xO_-qMJOmJc

// RV used for sound when clicking. I changed from button to just Left Click. 
// Rafael Vicuna tutorial: https://www.youtube.com/watch?v=HtiWt0SWxk8

// Custom Cursor (not in this script, but part of this assignment so including here for reference)
// bendux tutorial: https://www.youtube.com/watch?v=ELhg7ge2rIA
// Also if an error is encountered: https://forum.unity.com/threads/invalid-texture-used-for-cursor-check-importer-settings-warning-spam-since-unity-5-4-update.435004/
// From that unity forums I had to do the "check Read/Write Enabled in Advanced"
// The below link is for changing Cursor based on what you're hovering over... TODO: Implement
// https://docs.unity3d.com/ScriptReference/Cursor.SetCursor.html

public class MouseClickEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem testParticleSystem = default;   // GG
    private Vector2 mousePos;   // AZ
    public AudioSource soundPlayer; // RV

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
            soundPlayer.Play(); // RV
        }
    }
}


