using BNG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
	public bool forSpecificObject = false;
	public Collider targetCollider;
    public bool isRightHand = false;
    public bool isLeftHand = false;

    public UnityEvent triggerEnter;
	public UnityEvent triggerStay;
	public UnityEvent triggerExit;


    private float lerpDuration = 1f;

    // Haptic feedback properties
    public float hapticIntensity = 0.5f;
    public float hapticDuration = 0.1f;

    private void OnTriggerEnter(Collider other)
	{
		if (forSpecificObject)
		{
			if (other == targetCollider)
			{
				triggerEnter.Invoke();
				if (isRightHand)
				{
                    TriggerHapticFeedback(true);
                }
				if(isLeftHand) 
				{
                    TriggerHapticFeedback(false);
                }
                
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
                if (isRightHand)
                {
                    TriggerHapticFeedback(true);
                }
                if (isLeftHand)
                {
                    TriggerHapticFeedback(false);
                }

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
                if (isRightHand)
                {
                    TriggerHapticFeedback(true);
                }
                if (isLeftHand)
                {
                    TriggerHapticFeedback(false);
                }
            }
		}
		else
		{
			triggerExit.Invoke();
		}
	}
    private void TriggerHapticFeedback(bool isRightHand)
    {
        if (isRightHand)
        {
            InputBridge.Instance.VibrateController(0, hapticIntensity, hapticDuration, ControllerHand.Right);
        }
        else
        {
            InputBridge.Instance.VibrateController(0, hapticIntensity, hapticDuration, ControllerHand.Left);
        }
    }

} 