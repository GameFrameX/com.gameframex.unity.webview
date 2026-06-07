<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Web View

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.webview)](https://github.com/GameFrameX/com.gameframex.unity.webview/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.webview)](https://github.com/GameFrameX/com.gameframex.unity.webview/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현

<br />

[문서](https://gameframex.doc.alianblank.com) · [빠른 시작](#quick-start) · QQ 그룹: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**

</div>

## 프로젝트 개요

`Game Frame X Web View`는 [Game Frame X](https://gameframex.doc.alianblank.com) 게임 프레임워크를 위한 Web View 컴포넌트입니다. Unity 게임 내에 웹 콘텐츠를 임베드하여 표시할 수 있습니다.

## 빠른 시작

### 설치

### 설치

Unity 프로젝트의 `Packages/manifest.json`을 편집하여 `scopedRegistries` 섹션을 추가하세요:

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

`scopes`는 이 레지스트리를 통해 어떤 패키지를 해석할지 제어합니다. `com.gameframex`로 시작하는 패키지만 이 레지스트리에서 가져옵니다.

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.webview": "1.0.0"
  }
}
```


## 의존성

| 패키지 | 설명 |
|--------|------|
| `com.gameframex.unity` | 1.0.0 |

## 문서 및 자료

- [문서](https://gameframex.doc.alianblank.com)

## 커뮤니티 및 지원

- QQ 그룹: 467608841 / 233840761

## 변경 로그

[Releases](https://github.com/GameFrameX/gameframex/com.gameframex.unity.webview/releases)에서 변경 로그를 확인하세요.
## 라이선스

이 저장소는 [MIT](LICENSE) 라이선스에 따라 배포됩니다.
