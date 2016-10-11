using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MoveForward : MonoBehaviour {

	public float maxSpeed = 5f;
    public float rotSpeed = 180f;

	// Update is called once per frame
	void Update () {

        // Rotate
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;

        // Move foward 
		Vector3 pos = transform.position;
		
		Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);
		
		pos += transform.rotation * velocity;

		transform.position = pos;


        if (Input.GetKeyUp(KeyCode.R))
        {
            SceneManager.LoadScene("RegEv");
        }
    }


}
