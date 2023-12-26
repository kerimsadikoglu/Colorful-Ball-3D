using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image whiteeffectimage;
    private int effectcontrol = 0;



    public Animator LayoutAnimator;


    public GameObject settings_open;
    public GameObject settings_close;
    public GameObject sound_On;
    public GameObject sound_Off;
    public GameObject vibration_On;
    public GameObject vibration_Off;
    public GameObject iap;
    public GameObject information;

    
    public void Settings_open()
    {
        settings_open.SetActive(false);
        settings_close.SetActive(true);
        LayoutAnimator.SetTrigger("Slide_in");
    }
    public void Settings_close()
    {
        settings_open.SetActive(true);
        settings_close.SetActive(false);
        LayoutAnimator.SetTrigger("Slide_out");
    }

    public void Sound_On()
    {
        sound_On.SetActive(false);
        sound_Off.SetActive(true);
        
    }
    public void Sound_Off()
    {
        sound_On.SetActive(true);
        sound_Off.SetActive(false);
        
    }
    public void Vibration_On()
    {
        vibration_On.SetActive(false);
        vibration_Off.SetActive(true);
        
    }
    public void Vibration_Off()
    {
        vibration_On.SetActive(true);
        vibration_Off.SetActive(false);

    }
    





    public IEnumerator WhiteEffect()
    {
        whiteeffectimage.gameObject.SetActive(true);
        while (effectcontrol == 0)
        {

            yield return new WaitForSeconds(0.01f);
            whiteeffectimage.color += new Color(0, 0, 0, 0.1f);
            if (whiteeffectimage.color == new Color(whiteeffectimage.color.r, whiteeffectimage.color.g, whiteeffectimage.color.b, 1))
            {
                effectcontrol = 1;
            }
        }
        while(effectcontrol == 1)
        {
            yield return new WaitForSeconds(0.01f);
            whiteeffectimage.color -= new Color(0, 0, 0, 0.1f);
            if (whiteeffectimage.color == new Color(whiteeffectimage.color.r, whiteeffectimage.color.g, whiteeffectimage.color.b, 0))
            {
                effectcontrol = 2;
            }
        }
        
    }
}
