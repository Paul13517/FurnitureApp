using System;
using System.Collections;
using UnityEngine.Networking;

namespace Tools
{
    public class InternetUtility
    {
        public static IEnumerator CheckInternetConnection(Action<Boolean> action){
            var www = new UnityWebRequest("http://google.com");
            yield return www;
            action(www.error == null);
        } 
    }
}