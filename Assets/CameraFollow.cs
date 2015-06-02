using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
	public GameObject target;
	private Vector3 _myPosition;
	private Vector3 _targetPosition;
	private bool _lerpPosition;
	// Use this for initialization
	void Start ()
	{
		_myPosition = transform.position;
		_targetPosition = target.transform.position;
		_lerpPosition = false;
	}
	
	// Update is called once per frame
	void Update ()
	{


		transform.position = Vector3.Lerp (new Vector3 (transform.position.x, transform.position.y, transform.position.z),
		                                   new Vector3 (target.transform.position.x, transform.position.y, target.transform.position.z), Time.deltaTime * 10f);

	
	}
}
