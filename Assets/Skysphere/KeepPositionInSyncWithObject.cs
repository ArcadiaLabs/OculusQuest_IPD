using UnityEngine;

public class KeepPositionInSyncWithObject : MonoBehaviour 
{
	public GameObject otherGameObject;
	
	void LateUpdate () 
	{
		if(otherGameObject)
			transform.position = otherGameObject.transform.position;
	}
}
