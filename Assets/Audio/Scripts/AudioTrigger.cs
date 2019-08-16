using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Event = AK.Wwise.Event;

public class AudioTrigger : MonoBehaviour
{
	public Event SoundEvent;

    void Start()
    {
	    //AkSoundEngine.RegisterGameObj(gameObject);
	    //AkSoundEngine.PostEvent(SoundEvent.Id, gameObject);
		AudioSystem.Instance.PostEvent("Debug");
    }
}