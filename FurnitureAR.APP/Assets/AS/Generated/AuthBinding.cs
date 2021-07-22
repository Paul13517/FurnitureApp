using UnityEngine;
namespace Generated
{
    public class AuthBinding
    {
        public readonly GameObject GameObject;
        private UnityEngine.Transform _transform;
        public UnityEngine.Transform Transform => _transform ??= GameObject.GetComponent<UnityEngine.Transform>();
        private Auth _auth;
        public Auth Auth => _auth ??= GameObject.GetComponent<Auth>();
        private AuthorizeController _authorizeController;
        public AuthorizeController AuthorizeController => _authorizeController ??= GameObject.GetComponent<AuthorizeController>();
        public AuthBinding(GameObject gameObject) => GameObject = gameObject;
    }
}
