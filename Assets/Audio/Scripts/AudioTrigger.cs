using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Event = AK.Wwise.Event;

public class AudioTrigger : MonoBehaviour
{
	public Event SoundEvent;

    void Awake()
    {
	    AkSoundEngine.RegisterGameObj(gameObject);
		AudioSystem.Instance.PostEvent(SoundEvent.Name, gameObject);
    }
}