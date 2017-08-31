using UnityEngine;

public class ak47_shooting : MonoBehaviour {

    public float damage = 8f;
    public float range = 10000f;
    public float fireRate = 30f;
    private float nextTimeToFire;

    public Camera Guncam;

	void Update () {
		
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();

        }

	}

    void Shoot ()
    {

        RaycastHit hit;
        if (Physics.Raycast(Guncam.transform.position, Guncam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }

    }

}
