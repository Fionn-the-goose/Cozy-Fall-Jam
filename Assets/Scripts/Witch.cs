using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Witch : MonoBehaviour
{
    public static Witch instance;
    public float m_Speed = 0.01f;
    public float m_HoldingTreshold = 0.1f;
    private Transform destination;
    private float dist = 0.0f;
    void Start(){
    }
    public void MoveTo(Vector3 obj_pos){
        Vector3 x_achse = new Vector3(obj_pos.x, 0.0f, 0.0f);
        transform.Translate((x_achse));
    }
    public void SetDestination(Transform other){
        destination = other;
        dist = other.position.x - transform.position.x;
    }
    void Update(){
        if(dist>=m_HoldingTreshold){
            Debug.Log(dist);
            Vector2 movement = new Vector2(m_Speed, 0.0f);
            transform.Translate(movement);
            dist = destination.position.x - transform.position.x;
        }
    }
}
