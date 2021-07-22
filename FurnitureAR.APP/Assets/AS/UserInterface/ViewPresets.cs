using System;
using TMPro;
using Tools;
using Tools.AnimationUtility;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UserInterface.TitleBar;

namespace Assets.AS.UserInterface
{
    public class ViewPresets
    {
        public static void SetTitleBarText(Transform titleBar, ScrollRect scrollRect, String text)
        {
            var headerText = titleBar.transform.Find("Header").GetComponent<TextMeshProUGUI>();
            
            var bigHeaderText = titleBar.transform.Find("BigHeaderContainer/BigHeader").GetComponent<TextMeshProUGUI>();

            headerText.text = text;
            bigHeaderText.text = text;
            
            MoveScrollViewByTitleBarExtraHeight(titleBar, text, bigHeaderText, scrollRect);
        }
        
        public static void SetTitleBarCloseAction(Transform titleBar, UnityAction close)
        {
            var button = titleBar.transform.Find("BackIcon").GetComponent<Button>();

            button.onClick.AddListener(close);
        }
        
        public static void SetTitleBarRefreshAction(Transform titleBar, UnityAction refresh)
        {
            var button = titleBar.transform.Find("RefreshIcon").GetComponent<Button>();

            button.onClick.AddListener(refresh);
        }
        
        public static void SetTitleBarOpenSiteAction(Transform titleBar, UnityAction openSite)
        {
            var button = titleBar.transform.Find("InternetIcon").GetComponent<Button>();

            button.onClick.AddListener(openSite);
        }

        public static void LoadingEndProcessing(Transform layout, Boolean successState)
        {
            layout.transform.Find("LoadingBar").gameObject.SetActive(false);

            if (successState)
            {
                return;
            }
            
            var loadErrorBar = layout.transform.Find("LoadErrorBar");
            loadErrorBar.gameObject.SetActive(true);
            layout.gameObject.AddComponent<MonoBehaviourAnimations.MonoBehaviourStub>().
                StartCoroutine(InternetUtility.CheckInternetConnection(internetState =>
                {
                    loadErrorBar.GetComponentInChildren<TextMeshProUGUI>().text +=
                        internetState? "(Ошибка сервера)" : "(Отсутсвует интернет соединение)";
                }));
        }
        
        private static void MoveScrollViewByTitleBarExtraHeight(Transform titleBar, String text, TextMeshProUGUI bigHeaderText, ScrollRect scrollRect)
        {
            var crunchHeight = Screen.width / PlatformDisplayMetrics.DpDensity - (bigHeaderText.margin.x + bigHeaderText.margin.z);
            
            var addOffset = bigHeaderText.GetPreferredValues(text,crunchHeight, Mathf.Infinity);

            var scrollViewRectTransform = scrollRect.GetComponent<RectTransform>();

            scrollViewRectTransform.offsetMax -= addOffset.y * Vector2.up;
            
            var titleBarController = titleBar.GetComponent<MainTitleBarController>();
            //     titleBarController.TextOffset = addOffset.y;
        }
    }
}