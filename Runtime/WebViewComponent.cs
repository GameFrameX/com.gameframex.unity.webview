using System;
using GameFrameX.Runtime;
using UnityEngine;

namespace GameFrameX.WebView.Runtime
{
    /// <summary>
    /// WebView组件。
    /// </summary>
    [DisallowMultipleComponent]
    [AddComponentMenu("GameFrameX/WebView")]
    [UnityEngine.Scripting.Preserve]
    [GameFrameXAutoComponent(1700)]
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
            if (!IsRuntimeComponentReady)
            {
                return;
            }

            _webViewManager = GameFrameworkEntry.GetModule<IWebViewManager>();
            if (_webViewManager == null)
            {
                Log.Fatal("Web View manager is invalid.");
                return;
            }
        }

        private void Start()
        {
            if (_webViewManager == null)
            {
                return;
            }

            _webViewManager.Initialize();
        }


        /// <summary>
        /// 显示WebView
        /// </summary>
        /// <param name="url">加载的url</param>
        [UnityEngine.Scripting.Preserve]
        public void Show(string url)
        {
            _webViewManager.Show(url);
        }

        /// <summary>
        /// 全屏
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public void MakeFullScreen()
        {
            _webViewManager.MakeFullScreen();
        }

        /// <summary>
        /// 执行JavaScript
        /// </summary>
        /// <param name="javaScript">javaScript代码</param>
        [UnityEngine.Scripting.Preserve]
        public void ExecuteJavaScript(string javaScript)
        {
            _webViewManager.ExecuteJavaScript(javaScript);
        }

        /// <summary>
        /// 隐藏
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public void Hide()
        {
            _webViewManager.Hide();
        }
    }
}
