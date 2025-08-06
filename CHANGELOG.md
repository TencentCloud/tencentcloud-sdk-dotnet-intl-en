# Changelog

### [3.0.1097] - 2025-03-26

- fix: Removed premature `dispose()` call for SSE responses

### [3.0.1084] - 2025-03-07

- fix: Supports timeouts

### [3.0.887] - 2024-04-29

- feat: Added `IsStream` property to support non-stream calls in a stream context

### [3.0.882] - 2024-04-22

- fix: Supports optional JSON protocol for SSE APIs

### [3.0.844] - 2024-02-21

- fix: Switched to using `ConfigureAwait(false)` everywhere (
  Reference: [https://devblogs.microsoft.com/dotnet/configureawait-faq/#why-would-i-want-to-use-configureawaitfalse](https://devblogs.microsoft.com/dotnet/configureawait-faq/#why-would-i-want-to-use-configureawaitfalse))

### [3.0.838] - 2023-12-08

- feat: Supports `text/event-stream`
- fix: Fixed an error that caused synchronous calls to hang in .NET Framework
- feat: Added `ErrorCode` to `TencentCloudSDKException`

### [3.0.808] - 2023-11-02

- feat: Supports `octet-stream`

### [3.0.641] - 2023-03-08

- feat: Supports `CommonClient`
- security fix: Bumped `System.Text.Encodings.Web` to 4.5.1
- feat: Added `Language` parameter
- Removed `Pathoschild.Http.FluentClient` and rewrote `HttpConnection`
- fix: Fixed daylight saving time offset issues
- fix: Set the `Host` header value through the `HttpWebRequest.Host` property instead of the `HttpWebRequest.Headers`
  collection

### [3.0.2] - 2020-03-20

- feat: Supports TC3-HMAC-SHA256