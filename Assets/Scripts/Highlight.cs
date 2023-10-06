using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    private SpriteRenderer m_Sprite;
    public SpriteRenderer m_ParentSprite;
    public bool m_isActive = false;
    // Start is called before the first frame update
    
    void Start(){
        m_Sprite.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(m_isActive){
            m_Sprite.enabled = true;
        }
        else{
            m_Sprite.enabled = false;
        }
    }
}
