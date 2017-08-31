using UnityEngine;

public class mouse : MonoBehaviour {
    [SerializeField]
    private float speedH = 5f;
    [SerializeField]
    private float speedV = 5f;

    private float yaw = 0f;
    private float pitch = 0f;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0f);
	}
}
