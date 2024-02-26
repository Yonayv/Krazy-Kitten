using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


/// <summary>
/// The Audio and UI namespace is imported from UnityEngine
/// The public AudioMixer variable is valled masterMixer
/// Two public methods that take a float as a param, soundlevel
/// ChangesoundVol calls masterMixer masterVol and sounl level in the body. Calls SetMasVol from PreferManager class and pass in soundlevel as the argument.
/// ChaMusVol calls MasMix MusVol soundlevel in the body. SetMusVol calls PreferManager class and pass in soundlevel as the argument. 
/// In start the masMix MasVol is set and prefrenecesmanager.getmastervolume.
/// 
/// </summary>
public class AudioManager : MonoBehaviour
{

    private static AudioManager instance;

    public static AudioManager Instance {get { return instance; } }

    public AudioMixer masterMixer;

    public Slider musicSlider, masterSlider;

    private void Awake()
    {
        if (instance != null && instance != this )
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
                
    }


    // Start is called before the first frame update
    void Start()
    {
        masterMixer.SetFloat("MasterVol", PreferncesManager.GetMasterVolume());
        masterMixer.SetFloat("MusicVol", PreferncesManager.GetMusicVolume());

        if (masterSlider != null)
            PreferncesManager.GetMasterVolume();

        if (musicSlider != null)
            PreferncesManager.GetMusicVolume();
    }

    public void ChangeSoundVolume(float soundlevel)
    {
        masterMixer.SetFloat("MusicVol", soundlevel);
        PreferncesManager.SetMasterVolume(soundlevel);

    }

    public void ChangeMusicVolume(float soundlevel)
    {
        masterMixer.SetFloat("MusicVol", soundlevel);
        PreferncesManager.SetMasterVolume(soundlevel);

    }
}
