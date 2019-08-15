using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefreshAudioListener : MonoBehaviour
{
	private GameObject sceneListener;

	private void Awake()
	{
		sceneListener = GameObject.Find("Listener");
		sceneListener.transform.parent = gameObject.transform;
		UpdateListenerPosition();
	}

	private void Update()
	{
		UpdateListenerPosition();
	}

	private void UpdateListenerPosition()
	{
		sceneListener.transform.position = gameObject.transform.position;
		sceneListener.transform.rotation = gameObject.transform.rotation;
	}
}
