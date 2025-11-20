using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("--------- Audio Clip ------")]
    

    [Header("--------- Audio Clip ------")]
    public AudioClip background;
    
    public static AudioManager instace;
    private void Awake()
    {
        if (instace == null)
        {
            instace = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

   
}

  