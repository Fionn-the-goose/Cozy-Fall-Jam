using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Start is called before the first frame update
    public Highlight m_Highlight;

    private void OnMouseEnter()
    {
        Debug.Log("peepeepoopoo");
        m_Highlight.m_isActive = true;
    }
    private void OnMouseExit() {
        m_Highlight.m_isActive = false; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
