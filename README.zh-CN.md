<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Web View

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.webview)](https://github.com/GameFrameX/com.gameframex.unity.webview/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.webview)](https://github.com/GameFrameX/com.gameframex.unity.webview/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使

<br />

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#quick-start) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 项目简介

`Game Frame X Web View` 是一个为 [Game Frame X](https://gameframex.doc.alianblank.com) 游戏框架提供的 Web View 组件。它允许您在 Unity 游戏中嵌入和显示 Web 内容。

本组件是对 [gree/unity-webview](https://github.com/gree/unity-webview) 的封装，提供了更简洁的 API 和更方便的集成方式。

## 功能

- 在 Unity 游戏中显示 Web 页面
- 通过 C# 与 JavaScript 进行交互
- 支持全屏显示
- 支持 Android 和 iOS 平台

## 快速开始

### 安装

### 安装

编辑 Unity 项目的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：

```json
{
  "scopedRegistries": [
    {
      "name": "GameFrameX",
      "url": "https://gameframex.upm.alianblank.uk",
      "scopes": [
        "com.gameframex"
      ]
    }
  ]
}
```

`scopes` 控制哪些包通过此注册表解析。只有以 `com.gameframex` 开头的包才会从这个注册表获取。

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.webview": "1.0.0"
  }
}
```


## 使用示例

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

- `Show(string url)` - 显示 Web 视图并加载指定 URL
- `Hide()` - 隐藏 Web 视图
- `MakeFullScreen()` - 将 Web 视图设置为全屏
- `ExecuteJavaScript(string javaScript)` - 执行 JavaScript 代码


## 依赖

| 包 | 说明 |
|----|------|
| `com.gameframex.unity` | 1.0.0 |

## 文档与资源

- [官方文档](https://gameframex.doc.alianblank.com)

## 社区与支持

- QQ群: 467608841 / 233840761

## 更新日志

查看 [Releases](https://github.com/GameFrameX/gameframex/com.gameframex.unity.webview/releases) 了解更新日志。
## 开源协议

本仓库遵循 [MIT](LICENSE) 许可证。
