using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Event = AK.Wwise.Event;

public class AudioTrigger : MonoBehaviour
{
	public Event SoundEvent;

    void Start()
    {
	    AkSoundEngine.PostEvent(SoundEvent.Id, gameObject);
    }
}