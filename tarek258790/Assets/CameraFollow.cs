using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Taregt;
public float cameraspeed;
public float minX,maxX;
public float minY,maxY;
    // Start is called before the first frame update
    void Start()
    {
        
    }
void FixedUpdate(){
if(Taregt!=null)
{
    Vector2 newcamposition= Vector2.Lerp(transform.position, Taregt.position,Time.deltaTime * cameraspeed); 
    float ClampX= Mathf.Clamp(newcamposition.x,minX,maxX);
float ClampY= Mathf.Clamp(newcamposition.y,minX,maxY);
transform.position = new Vector3(ClampX,ClampY,-10f);
}

}
    // Update is called once per frame
    void Update()
    {
        
    }
}

