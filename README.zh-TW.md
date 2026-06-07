<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Web View

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.webview)](https://github.com/GameFrameX/com.gameframex.unity.webview/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.webview)](https://github.com/GameFrameX/com.gameframex.unity.webview/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

<br />

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#quick-start) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 項目簡介

`Game Frame X Web View` 是為 [Game Frame X](https://gameframex.doc.alianblank.com) 遊戲框架提供的 Web View 組件。允許您在 Unity 遊戲中嵌入和顯示 Web 內容。

本組件是對 [gree/unity-webview](https://github.com/gree/unity-webview) 的封裝，提供了更簡潔的 API 和更方便的集成方式。

## 安裝

### 安裝

編輯 Unity 專案的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：

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

`scopes` 控制哪些套件透過此註冊表解析。只有以 `com.gameframex` 開頭的套件才會從這個註冊表取得。

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.webview": "1.0.0"
  }
}
```


## 開源協議

本倉庫遵循 [MIT](LICENSE) 許可證。
