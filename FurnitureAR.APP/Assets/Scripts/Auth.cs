using S123.Network.Models;
using UnityEngine;

public class Auth : MonoBehaviour
{
 [SerializeField]
 private AuthorizeController auth;

private async void Awake(){

    string username = "render1@arkatech.ru";
    string password = "efe63115efa7dfde28d17486382e589f1d0ab4a79cd76860f69f82c04a25761a";
    AuthorizeResult result = await auth.Authorize(username, password);
    if (result.authenticationResult != 1)
    {
        Debug.LogError("Authorize error");
        return;
    }
    Debug.Log("Authorization successfull");
   }
}
