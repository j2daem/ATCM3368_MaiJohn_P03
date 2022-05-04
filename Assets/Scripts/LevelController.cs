using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] AudioClip openingSong = null;

    private void Start()
    {
        if (openingSong != null)
        {
            global::AudioManager.Instance.PlaySong(openingSong);
        }
    }
}
