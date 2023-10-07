using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Start is called before the first frame update
    public Highlight m_Highlight;
    public Witch m_Witch;
    private SpriteRenderer Object_Sprite;
    private Transform ObjektTransform;
    private void Start(){
        ObjektTransform = GetComponent<Transform>();
        Object_Sprite = GetComponent<SpriteRenderer>();
    }
    private void OnMouseEnter(){
        m_Highlight.m_isActive = true;
    }
    private void OnMouseExit(){
        m_Highlight.m_isActive = false; 
    }
    private void OnMouseDown(){
        Debug.Log("Click!!");
        m_Witch.MoveTo(ObjektTransform.position);
    }
    // Update is called once per frame
}