<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Web View

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.webview)](https://github.com/GameFrameX/com.gameframex.unity.webview/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.webview)](https://github.com/GameFrameX/com.gameframex.unity.webview/releases)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

<br />

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · QQ Group: 467608841 / 233840761

<br />

**English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>
## Project Overview

`Game Frame X Web View` is a Web View component for the [Game Frame X](https://gameframex.doc.alianblank.com) game framework. It allows you to embed and display web content within Unity games.

This component wraps [gree/unity-webview](https://github.com/gree/unity-webview), providing a simpler API and easier integration.

## Features

- Display web pages within Unity games
- Interact between C# and JavaScript
- Fullscreen support
- Android and iOS platform support

## Installation

1. Open `Package Manager` in Unity Editor
2. Click `+` and select `Add package from git URL...`
3. Enter `https://github.com/gameframex/com.gameframex.unity.webview.git`
4. Click `Add`

## Usage

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

- `Show(string url)` - Display a web view and load the specified URL
- `Hide()` - Hide the web view
- `MakeFullScreen()` - Set the web view to fullscreen
- `ExecuteJavaScript(string javaScript)` - Execute JavaScript code

## License

This repository is licensed under the [MIT](LICENSE) License.
