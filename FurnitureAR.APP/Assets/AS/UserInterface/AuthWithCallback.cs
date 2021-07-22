using S123.Network.Models;
using UnityEngine;
using UnityEngine.Events;

public class AuthWithCallback : MonoBehaviour
{
    public UnityEvent OnAuthorizationComplete;
    
    [SerializeField] private AuthorizeController auth;
    
    private async void Start()
    {
        string username = "render1@arkatech.ru";
        string password = "efe63115efa7dfde28d17486382e589f1d0ab4a79cd76860f69f82c04a25761a";
        AuthorizeResult result = await auth.Authorize(username, password);
        if (result.authenticationResult != 1)
        {
            Debug.LogError("Authorize error");
            return;
        }
        OnAuthorizationComplete?.Invoke();
        Debug.Log("Authorization successfull");
    }
}
