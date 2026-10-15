## [Unreleased]

### ⚠ BREAKING CHANGES

* **module:** `WebViewComponent` 保留为薄入口（纯转发、无序列化字段），模块经 `GetModule<T>()` 直达；组件值参数序列化字段移除，编辑期配置入口收敛到代码 Options，Play 期经活视图 / 模块 API 调整

# [2.0.0](https://github.com/gameframex/com.gameframex.unity.webview/compare/1.0.3...2.0.0) (2026-10-08)


### ⚠ BREAKING CHANGES

* **module:** 模块契约全接口化：删除 `GameFrameworkModule` 抽象基类，改为 `IGameFrameworkModule` 标记接口 + 可选能力接口

**新契约形态与迁移对照：**

| 旧基类成员 | 新契约 | 迁移方式 |
|---|---|---|
| `: GameFrameworkModule` | `IGameFrameworkModule` | 声明处直接替换（标记接口，可注册进 `GameFrameworkEntry`） |
| `override void Update(float, float)` | `IUpdatableModule` | 真实实现改 `public`；空实现删除（未实现者不再被轮询） |
| `override void Shutdown()` | `IShutdownableModule` | 真实实现改 `public`；空实现删除（未实现者不再被关闭） |
| `override int Priority` | `IPrioritizedModule` | 改 `public int Priority { get; }`；未实现视为 0 |

本包变更：`BaseWebViewManager` 声明迁移至 `IGameFrameworkModule`（原继承 abstract 成员未覆写，无行为变化）。

`GameFrameworkEntry.Update` 仅分派 `IUpdatableModule`；`Shutdown` 按优先级反序仅分派 `IShutdownableModule`；tick 与关闭顺序与旧实现完全一致。能力方法仅由宿主入口调用，业务侧继续通过 `GetModule<IXxxManager>()` 访问模块。

## [1.0.3](https://github.com/gameframex/com.gameframex.unity.webview/compare/1.0.2...1.0.3) (2026-07-29)


### Bug Fixes

* **dependencies:** 更新依赖项版本以支持新功能 ([ea0e949](https://github.com/gameframex/com.gameframex.unity.webview/commit/ea0e94990857666913cacace795f33fa0ab88c26))

## [1.0.2](https://github.com/gameframex/com.gameframex.unity.webview/compare/1.0.1...1.0.2) (2026-07-03)


### Bug Fixes

* **webview:** 添加 Preserve 特性防止 IL2CPP 裁剪 ([5484eef](https://github.com/gameframex/com.gameframex.unity.webview/commit/5484eef890d8c2d027b86d19f082ba42c1c235d4))
* **webview:** 组件未就绪时提前返回避免空引用 ([46e3b12](https://github.com/gameframex/com.gameframex.unity.webview/commit/46e3b12fbb0ada548379667272f54caecff4f831))

## [1.0.1](https://github.com/gameframex/com.gameframex.unity.webview/compare/1.0.0...1.0.1) (2026-06-07)


### Bug Fixes

* 补全包规范文件（LICENSE/CHANGELOG/URL 字段/unity 字段） ([999cf1a](https://github.com/gameframex/com.gameframex.unity.webview/commit/999cf1ae3e96093a00837b02d341e3c05fb2f8be))

# 1.0.0 (2025-12-24)


### Features

* 添加WebView模块基础功能实现 ([38f6d15](https://github.com/gameframex/com.gameframex.unity.webview/commit/38f6d155caac5c1282903c5b095460c71ff37e85))
