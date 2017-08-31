using UnityEngine;

[RequireComponent(typeof(player_motor))]
public class player_controller : MonoBehaviour {

    [SerializeField]
    private float speed = 7.5f;

    private player_motor motor;

     void Start()
    {
        motor = GetComponent<player_motor>();  
    }

     void Update()
    {
        float _xMov = Input.GetAxis("Horizontal");
        float _zMov = Input.GetAxis("Vertical");

        Vector3 _movHorizontal = transform.right * _xMov;
        Vector3 _movVertical = transform.forward * _zMov;

        Vector3 _velocity = (_movHorizontal + _movVertical).normalized * speed;

        motor.Move(_velocity);
            }
}
