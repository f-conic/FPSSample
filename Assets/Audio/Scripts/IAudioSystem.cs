﻿using UnityEngine;

public interface IAudioSystem
{
	void PostEvent(string eventName, GameObject gameObject);
	void LoadBank(string bankName);
}

public static class AudioSystem
{
	public static IAudioSystem Instance { get; set; }
}