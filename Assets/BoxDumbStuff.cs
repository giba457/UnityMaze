using UnityEngine;
using UnityEngine;
using System.Collections;

public class BoxDumbStuff : MonoBehaviour {
	
	public float speed = 2;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Rigidbody rigidbody = GetComponent<Rigidbody>();

		if (rigidbody)
		{
			rigidbody.velocity = speed * transform.forward;
		}
		//transform.position += transform.forward * speed * Time.deltaTime;
		
		RaycastHit raycasthit;
		if (Physics.Raycast(transform.position, transform.forward, out raycasthit, 2.0f))
		{
			if (raycasthit.collider.gameObject.tag == "Boundary")
			{
				transform.Rotate(0, 180, 0);
			}
		}
	}
}