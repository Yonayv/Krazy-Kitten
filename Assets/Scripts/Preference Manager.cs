using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class  PreferncesManager
{
    /// <summary>
    /// The public stats method returns the floats MusicVol/MasterVol
    //// MusicVol is returned for GetMusicVol
    /// MasterVol is returned for GetMusicVol
    ///  Two public stats are made and inide the float params soundLevel, setmusicvol, and setmastervol
    ///  
    /// </summary>
    /// <returns></returns>
    public static float GetMusicVolume()
    {
        return PlayerPrefs.GetFloat("MusicVolume", 1);
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat("MasterVolume");

    }


    public static void SetMusicVolume( float soundlevel)
    {
        PlayerPrefs.SetFloat("MusicVolume", soundlevel);
    }    

    public static void SetMasterVolume( float soundlevel)
    {
        PlayerPrefs.SetFloat("MasterVolume", soundlevel);
    }
}   

