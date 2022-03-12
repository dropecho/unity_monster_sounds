using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct Timing {
  public float min;
  public float max;
}

[CreateAssetMenu(menuName = "Dropecho/SoundSettings")]
public class SoundSettings : ScriptableObject {
  public List<AudioClip> clips = new List<AudioClip>();
  public List<Timing> timings = new List<Timing>();
}