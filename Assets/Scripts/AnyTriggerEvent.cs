using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnyTriggerEvent : MonoBehaviour
{
	public bool forSpecificObject = false;
	public Collider targetCollider;

    public UnityEvent triggerEnter;
    public UnityEvent triggerStay;
    public UnityEvent triggerExit;

	private void OnTriggerEnter(Collider other)
	{
        if (forSpecificObject)
        {
            if(other == targetCollider)
			{
				triggerEnter.Invoke();
			}
		}
		else
		{
			triggerEnter.Invoke();
		}
        
	}

	private void OnTriggerStay(Collider other)
	{
		if (forSpecificObject)
		{
			if (other == targetCollider)
			{
				triggerStay.Invoke();
			}
		}
		else
		{
			triggerStay.Invoke();
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (forSpecificObject)
		{
			if (other == targetCollider)
			{
				triggerExit.Invoke();
			}
		}
		else
		{
			triggerExit.Invoke();
		}
	}
}
