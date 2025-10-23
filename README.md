# Game Frame X Web View

## 介绍

`Game Frame X Web View` 是一个为 [Game Frame X](https://gameframex.doc.alianblank.com) 游戏框架提供的 Web View 组件。它允许您在 Unity 游戏中嵌入和显示 Web 内容。

本组件是对 [gree/unity-webview](https://github.com/gree/unity-webview) 的封装，提供了更简洁的 API 和更方便的集成方式。

## 功能

*   在 Unity 游戏中显示 Web 页面
*   通过 C# 与 JavaScript 进行交互
*   支持全屏显示
*   支持 Android 和 iOS 平台

## 安装

1.  在 Unity 编辑器中打开 `Package Manager`
2.  点击 `+` 号, 选择 `Add package from git URL...`
3.  输入 `https://github.com/gameframex/com.gameframex.unity.webview.git`
4.  点击 `Add`

## 如何使用

1.  在您的场景中创建一个新的空 `GameObject`
2.  将 `WebViewComponent` 附加到该 `GameObject`
3.  在 `Inspector` 视图中，为 `WebViewComponent` 选择一个 `IWebViewManager` 的实现。默认情况下，框架会自动根据平台选择合适的实现。
4.  在您的代码中获取 `WebViewComponent` 的实例
5.  调用 `Show(url)` 方法来显示一个 Web 页面

```csharp
using GameFrameX.WebView.Runtime;
using UnityEngine;

public class Example : MonoBehaviour
{
    void Start()
    {
        var webView = FindObjectOfType<WebViewComponent>();
        webView.Show("https://gameframex.doc.alianblank.com");
    }
}
```

## API

### `void Show(string url)`

显示一个 Web 视图并加载指定的 URL。

### `void Hide()`

隐藏 Web 视图。

### `void MakeFullScreen()`

将 Web 视图设置为全屏。

### `void ExecuteJavaScript(string javaScript)`

在当前加载的 Web 页面上执行 JavaScript 代码。

## 贡献

欢迎通过 Pull Request 或 Issue 为本项目做出贡献。

## 许可证

本仓库遵循 [MIT](LICENSE) 许可证。