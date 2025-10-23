using GameFrameX.Event.Runtime;
using GameFrameX.Runtime;

namespace GameFrameX.WebView.Runtime
{
    /// <summary>
    /// WebView消息接收事件
    /// </summary>
    public sealed class WebViewReceivedMessageEventArgs : GameEventArgs
    {
        /// <summary>
        /// WebView消息接收事件ID
        /// </summary>
        public static readonly string EventId = typeof(WebViewReceivedMessageEventArgs).FullName;

        public override void Clear()
        {
        }

        public override string Id
        {
            get { return EventId; }
        }

        /// <summary>
        /// 创建WebView消息接收事件
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <returns></returns>
        public static WebViewReceivedMessageEventArgs Create(string message)
        {
            var eventArgs = ReferencePool.Acquire<WebViewReceivedMessageEventArgs>();
            eventArgs.Message = message;
            return eventArgs;
        }

        /// <summary>
        /// 事件消息
        /// </summary>
        public string Message { get; private set; }
    }
}