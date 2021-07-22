using AS.UserInterface;
using UnityEngine;

public class AndroidStatusNavigationBarController : MonoBehaviour
{
    void Start()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            NativeAndroid.SetStatusBarTheme(NativeAndroid.Theme.Light);
            NativeAndroid.SetStatusBarColor(0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
