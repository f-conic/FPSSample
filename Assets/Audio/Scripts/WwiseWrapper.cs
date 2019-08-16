using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WwiseWrapper : MonoBehaviour, IAudioSystem
{
	private bool initiated;

	private void Awake()
	{
		AudioSystem.Instance = this;
	}

	private void OnDestroy()
	{
		initiated = false;
	}

	public void PostEvent(string eventName, GameObject gameObject)
    {
	    AkSoundEngine.RegisterGameObj(gameObject);
	    AkSoundEngine.PostEvent(eventName, gameObject);
    }

	public void PostEvent(string eventName)
	{
		AkSoundEngine.RegisterGameObj(gameObject);
		AkSoundEngine.PostEvent(eventName, gameObject);
		AkSoundEngine.UnregisterGameObj(gameObject);
	}

	public void LoadBank(string bankName)
	{
		uint m_bankId;
		var m_result = AkSoundEngine.LoadBank(bankName, AkSoundEngine.AK_DEFAULT_POOL_ID, out m_bankId);

		if (m_result == AKRESULT.AK_Success)
		{
			Debug.Log("Successfully loaded bank: " + bankName);
		}
	}
}
