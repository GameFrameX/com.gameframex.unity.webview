using System;
using GameFrameX.Runtime;
using UnityEngine;

namespace GameFrameX.WebView.Runtime
{
    /// <summary>
    /// WebView组件。
    /// </summary>
    [DisallowMultipleComponent]
    [AddComponentMenu("Game Framework/WebView")]
    [UnityEngine.Scripting.Preserve]
    public partial class WebViewComponent : GameFrameworkComponent
    {
        private const int DefaultPriority = 0;

        private IWebViewManager _webViewManager = null;

        /// <summary>
        /// 游戏框架组件初始化。
        /// </summary>
        protected override void Awake()
        {
            ImplementationComponentType = Utility.Assembly.GetType(componentType);
            InterfaceComponentType = typeof(IWebViewManager);
            base.Awake();

            _webViewManager = GameFrameworkEntry.GetModule<IWebViewManager>();
            if (_webViewManager == null)
            {
                Log.Fatal("Web View manager is invalid.");
                return;
            }
        }

        private void Start()
        {
            _webViewManager.Initialize();
        }


        /// <summary>
        /// 显示WebView
        /// </summary>
        /// <param name="url">加载的url</param>
        public void Show(string url)
        {
            _webViewManager.Show(url);
        }

        /// <summary>
        /// 全屏
        /// </summary>
        public void MakeFullScreen()
        {
            _webViewManager.MakeFullScreen();
        }

        /// <summary>
        /// 执行JavaScript
        /// </summary>
        /// <param name="javaScript">javaScript代码</param>
        public void ExecuteJavaScript(string javaScript)
        {
            _webViewManager.ExecuteJavaScript(javaScript);
        }

        /// <summary>
        /// 隐藏
        /// </summary>
        public void Hide()
        {
            _webViewManager.Hide();
        }
    }
}