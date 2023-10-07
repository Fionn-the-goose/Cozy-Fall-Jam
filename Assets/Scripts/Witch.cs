using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Witch : MonoBehaviour
{
    public static Witch instance;
    public Transform m_Transform;
    void Start(){
        m_Transform = GetComponent<Transform>();
    }
    public void MoveTo(Vector3 obj_pos){
        Vector3 x_achse = new Vector3(obj_pos.x, 0.0f, 0.0f);
        m_Transform.Translate((x_achse));
    }
    void Update()
    {
        
    }
}
