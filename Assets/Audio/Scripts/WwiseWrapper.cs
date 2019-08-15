using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WwiseWrapper : MonoBehaviour, IAudioSystem
{
	private bool initiated;

	public void Init()
	{
		var cam = Camera.main;

		if (cam == null)
		{
			GameObject akListener = (GameObject)GameObject.Instantiate(Resources.Load("Prefabs/Listener", typeof(GameObject)));
		}

		var akInitalizer = gameObject.AddComponent<AkInitializer>();
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
