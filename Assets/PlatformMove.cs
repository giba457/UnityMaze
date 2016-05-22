using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class PlatformMove : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		RaycastHit raycasthit;
		if (Physics.Raycast(transform.position, -transform.up, out raycasthit, 2.0f))
		{
			GameObject other = raycasthit.collider.gameObject;
			Rigidbody otherRigidbody = other.GetComponent<Rigidbody>();
			if (otherRigidbody)
			{
				transform.position += otherRigidbody.velocity * Time.deltaTime;
			}
			
			if (other.tag == "LevelFloor")
			{
				Application.LoadLevel("Filename");
			}
		}
	}
}
