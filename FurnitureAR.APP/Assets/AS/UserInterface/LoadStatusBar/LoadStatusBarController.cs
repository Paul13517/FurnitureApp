using TMPro;
using Tools;
using UnityEngine;

namespace UserInterface
{
    public class LoadStatusBarController : MonoBehaviour
    {
        public TextMeshProUGUI Text;

        public GameObject Spinner;
        
        public void SetStatus(LoadStatus status)
        {
            switch (status)
            {
                case LoadStatus.Success:
                    Spinner.SetActive(false);
                    Destroy(gameObject);
                    break;
                case LoadStatus.Error:
                    Spinner.SetActive(false);
                    gameObject.SetActive(true);
                    StartCoroutine(InternetUtility.CheckInternetConnection(connection => Text.text += connection? "(Ошибка сервера)" : "(Нет интернет соединения)"));
                    break;
            }
        }
    }
}
