using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public Sprite fullHeart, halfHeart, emptyHeart;
    Image heartImage;
    // Start is called before the first frame update
    private void Awake()
    {
        heartImage = GetComponent<Image>();
    }

    public void SetHeartImage(HeartStatus status)
    {
        switch (status)

        {
            case HeartStatus.Empty:
                heartImage.sprite = emptyHeart; break;
            case HeartStatus.Half:
                heartImage.sprite = halfHeart; break;
            case HeartStatus.Full:
                heartImage.sprite = fullHeart; break;
        }


    }

    public enum HeartStatus 

    {
        Empty = 0,
        Half = 1,
        Full = 2,
        FullheartImage = 3
    }
}
