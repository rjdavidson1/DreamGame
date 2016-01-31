using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

    public GameObject cameraObj;
    public Vector3 specificVector ;
    public float smoothSpeed ;
  
     
     void Start()
    {
        //just turn camera in Inspector, for example
    }

    
    void Update()
    {
        if (cameraObj.transform.position.y < transform.position.y - 2)
        {
            specificVector = new Vector3(transform.position.x, transform.position.y - 2, cameraObj.transform.position.z);
            cameraObj.transform.position = Vector3.Lerp(cameraObj.transform.position, specificVector, smoothSpeed * Time.deltaTime);
        }
        else if (cameraObj.transform.position.y > transform.position.y + 2)
        {
            specificVector = new Vector3(transform.position.x, transform.position.y + 2, cameraObj.transform.position.z);
            cameraObj.transform.position = Vector3.Lerp(cameraObj.transform.position, specificVector, smoothSpeed * Time.deltaTime);
        }
        else
        {
            specificVector = new Vector3(transform.position.x, cameraObj.transform.position.y, cameraObj.transform.position.z);
            cameraObj.transform.position = Vector3.Lerp(cameraObj.transform.position, specificVector, smoothSpeed * Time.deltaTime);
        }
    }
  
}
