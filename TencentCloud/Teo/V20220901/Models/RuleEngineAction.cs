/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleEngineAction : AbstractModel
    {
        
        /// <summary>
        /// <p>Operation name. The name must correspond to the parameters structure. For example, if Name=Cache, then CacheParameters is required.<li>Cache: Node cache TTL;</li><li>CacheKey: Custom Cache Key;</li><li>CachePrefresh: Cache pre-refresh;</li><li>AccessURLRedirect: Access URL redirection;</li><li>UpstreamURLRewrite: Origin-pull URL rewrite;</li><li>QUIC: QUIC;</li><li>WebSocket: WebSocket;</li><li>Authentication: Token authentication;</li><li>MaxAge: Browser cache TTL;</li><li>StatusCodeCache: Status code cache TTL;</li><li>OfflineCache: Offline cache;</li><li>SmartRouting: Smart acceleration;</li><li>AdvancedOriginRouting: Advanced origin optimization;</li><li>RangeOriginPull: Range-based origin pull;</li><li>UpstreamHTTP2: HTTP2 origin-pull;</li><li>HostHeader: Host header rewrite;</li><li>ForceRedirectHTTPS: Forced HTTPS redirect configuration;</li><li>OriginPullProtocol: Origin-pull HTTPS;</li><li>Compression: Intelligent compression configuration;</li><li>HSTS: HSTS;</li><li>ClientIPHeader: Configuration for storing client IP address in the header;</li><li>OCSPStapling: OCSP stapling;</li><li>HTTP2: HTTP2 integration;</li><li>PostMaxSize: Maximum limit configuration for POST request upload file streaming transmission;</li><li>ClientIPCountry: Carrying regional information of the client IP during origin-pull;</li><li>UpstreamFollowRedirect: Upstream follow redirect parameter configuration;</li><li>UpstreamRequest: Origin-pull request parameters;</li><li>Shield: Origin server uninstallation configuration;</li><li>TLSConfig: SSL/TLS security;</li><li>ModifyOrigin: Modify origin server;</li><li>SiteFailover: Origin server fault migration;</li><li>HTTPUpstreamTimeout: Layer-7 origin-pull timeout configuration;</li><li>HttpResponse: HTTP response;</li><li>ErrorPage: Custom error page;</li><li>ModifyResponseHeader: Modify HTTP node response header;</li><li>ModifyRequestHeader: Modify HTTP node request header;</li><li>ResponseSpeedLimit: Single connection download speed limit;</li><li>SetContentIdentifier: Set content identifier;</li><li>Vary: Vary feature configuration;</li><li>ContentCompression: Content compression configuration;</li><li>OriginAuthentication: Origin-pull authentication configuration;</li><li>CustomAction: Custom configuration.</li></p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Node cache TTL configuration parameter. This parameter is required when the Name value is Cache.</p>
        /// </summary>
        [JsonProperty("CacheParameters")]
        public CacheParameters CacheParameters{ get; set; }

        /// <summary>
        /// <p>Custom Cache Key configuration parameter. When Name value is CacheKey, this parameter is required.
        /// </summary>
        [JsonProperty("CacheKeyParameters")]
        public CacheKeyParameters CacheKeyParameters{ get; set; }

        /// <summary>
        /// <p>Cache pre-refresh configuration parameter. This parameter is required when the Name value is CachePrefresh.</p>
        /// </summary>
        [JsonProperty("CachePrefreshParameters")]
        public CachePrefreshParameters CachePrefreshParameters{ get; set; }

        /// <summary>
        /// <p>Access URL redirection configuration parameter. This parameter is required when the Name value is AccessURLRedirect.</p>
        /// </summary>
        [JsonProperty("AccessURLRedirectParameters")]
        public AccessURLRedirectParameters AccessURLRedirectParameters{ get; set; }

        /// <summary>
        /// <p>Origin-pull URL rewrite configuration parameter. This parameter is required when the value of Name is UpstreamURLRewrite.</p>
        /// </summary>
        [JsonProperty("UpstreamURLRewriteParameters")]
        public UpstreamURLRewriteParameters UpstreamURLRewriteParameters{ get; set; }

        /// <summary>
        /// <p>QUIC configuration parameter. This parameter is required when the Name value is QUIC.</p>
        /// </summary>
        [JsonProperty("QUICParameters")]
        public QUICParameters QUICParameters{ get; set; }

        /// <summary>
        /// <p>WebSocket configuration parameter. This parameter is required when the Name value is WebSocket.</p>
        /// </summary>
        [JsonProperty("WebSocketParameters")]
        public WebSocketParameters WebSocketParameters{ get; set; }

        /// <summary>
        /// <p>Token authentication configuration parameter. This parameter is required when the Name value is Authentication.</p>
        /// </summary>
        [JsonProperty("AuthenticationParameters")]
        public AuthenticationParameters AuthenticationParameters{ get; set; }

        /// <summary>
        /// <p>Browser cache TTL configuration parameter. This parameter is required when the value of Name is MaxAge.</p>
        /// </summary>
        [JsonProperty("MaxAgeParameters")]
        public MaxAgeParameters MaxAgeParameters{ get; set; }

        /// <summary>
        /// <p>Status code cache TTL configuration parameter. This parameter is required when the Name value is StatusCodeCache.</p>
        /// </summary>
        [JsonProperty("StatusCodeCacheParameters")]
        public StatusCodeCacheParameters StatusCodeCacheParameters{ get; set; }

        /// <summary>
        /// <p>Offline cache configuration parameter. This parameter is required when the Name value is OfflineCache.</p>
        /// </summary>
        [JsonProperty("OfflineCacheParameters")]
        public OfflineCacheParameters OfflineCacheParameters{ get; set; }

        /// <summary>
        /// <p>Smart acceleration configuration parameter. This parameter is required when the Name value is SmartRouting.</p>
        /// </summary>
        [JsonProperty("SmartRoutingParameters")]
        public SmartRoutingParameters SmartRoutingParameters{ get; set; }

        /// <summary>
        /// <p>Advanced origin optimization configuration parameter. This parameter is required when the Name value is AdvancedOriginRouting.</p>
        /// </summary>
        [JsonProperty("AdvancedOriginRoutingParameters")]
        public AdvancedOriginRoutingParameters AdvancedOriginRoutingParameters{ get; set; }

        /// <summary>
        /// <p>Configuration parameter for range-based origin pull. This parameter is required when the value of Name is RangeOriginPull.</p>
        /// </summary>
        [JsonProperty("RangeOriginPullParameters")]
        public RangeOriginPullParameters RangeOriginPullParameters{ get; set; }

        /// <summary>
        /// <p>HTTP2 origin configuration parameter. This parameter is required when the Name value is UpstreamHTTP2.</p>
        /// </summary>
        [JsonProperty("UpstreamHTTP2Parameters")]
        public UpstreamHTTP2Parameters UpstreamHTTP2Parameters{ get; set; }

        /// <summary>
        /// <p>Host header rewrite configuration parameter. When the Name value is HostHeader, this parameter is required.</p>
        /// </summary>
        [JsonProperty("HostHeaderParameters")]
        public HostHeaderParameters HostHeaderParameters{ get; set; }

        /// <summary>
        /// <p>Forced HTTPS redirect configuration for the access protocol. This parameter is required when the Name value is ForceRedirectHTTPS.</p>
        /// </summary>
        [JsonProperty("ForceRedirectHTTPSParameters")]
        public ForceRedirectHTTPSParameters ForceRedirectHTTPSParameters{ get; set; }

        /// <summary>
        /// <p>Origin HTTPS configuration parameter. This parameter is required when the Name value is OriginPullProtocol.</p>
        /// </summary>
        [JsonProperty("OriginPullProtocolParameters")]
        public OriginPullProtocolParameters OriginPullProtocolParameters{ get; set; }

        /// <summary>
        /// <p>Intelligent compression configuration. This parameter is required when the Name value is Compression.</p>
        /// </summary>
        [JsonProperty("CompressionParameters")]
        public CompressionParameters CompressionParameters{ get; set; }

        /// <summary>
        /// <p>HSTS configuration parameter. When the Name value is HSTS, this parameter is required.</p>
        /// </summary>
        [JsonProperty("HSTSParameters")]
        public HSTSParameters HSTSParameters{ get; set; }

        /// <summary>
        /// <p>Configuration header information for storing client request IP. When the Name value is ClientIPHeader, this parameter is required.</p>
        /// </summary>
        [JsonProperty("ClientIPHeaderParameters")]
        public ClientIPHeaderParameters ClientIPHeaderParameters{ get; set; }

        /// <summary>
        /// <p>OCSP stapling configuration parameter. This parameter is required when Name value is OCSPStapling.</p>
        /// </summary>
        [JsonProperty("OCSPStaplingParameters")]
        public OCSPStaplingParameters OCSPStaplingParameters{ get; set; }

        /// <summary>
        /// <p>HTTP2 integration configuration parameter. This parameter is required when the Name value is HTTP2.</p>
        /// </summary>
        [JsonProperty("HTTP2Parameters")]
        public HTTP2Parameters HTTP2Parameters{ get; set; }

        /// <summary>
        /// <p>Maximum limit configuration for file streaming transmission in POST request upload. When the Name value is PostMaxSize, this parameter is required.</p>
        /// </summary>
        [JsonProperty("PostMaxSizeParameters")]
        public PostMaxSizeParameters PostMaxSizeParameters{ get; set; }

        /// <summary>
        /// <p>Configuration parameter for carrying client IP regional information during origin pull. When the Name value is ClientIPCountry, this parameter is required.</p>
        /// </summary>
        [JsonProperty("ClientIPCountryParameters")]
        public ClientIPCountryParameters ClientIPCountryParameters{ get; set; }

        /// <summary>
        /// <p>Origin-pull follow redirect parameter configuration. This parameter is required when the Name value is UpstreamFollowRedirect.</p>
        /// </summary>
        [JsonProperty("UpstreamFollowRedirectParameters")]
        public UpstreamFollowRedirectParameters UpstreamFollowRedirectParameters{ get; set; }

        /// <summary>
        /// <p>Origin-pull request parameter configuration parameter. This parameter is required when the Name value is UpstreamRequest.</p>
        /// </summary>
        [JsonProperty("UpstreamRequestParameters")]
        public UpstreamRequestParameters UpstreamRequestParameters{ get; set; }

        /// <summary>
        /// <p>Origin server uninstallation configuration parameter. This parameter is required when the Name value is Shield.</p>
        /// </summary>
        [JsonProperty("ShieldParameters")]
        public ShieldParameters ShieldParameters{ get; set; }

        /// <summary>
        /// <p>SSL/TLS security configuration parameter. This parameter is required when the Name value is TLSConfig.</p>
        /// </summary>
        [JsonProperty("TLSConfigParameters")]
        public TLSConfigParameters TLSConfigParameters{ get; set; }

        /// <summary>
        /// <p>Modify origin server configuration parameter. When the Name value is ModifyOrigin, this parameter is required.</p>
        /// </summary>
        [JsonProperty("ModifyOriginParameters")]
        public ModifyOriginParameters ModifyOriginParameters{ get; set; }

        /// <summary>
        /// <p>Source site fault migration config. When the Name value is SiteFailover, this parameter is required.</p>
        /// </summary>
        [JsonProperty("SiteFailoverParameters")]
        public SiteFailoverParameters SiteFailoverParameters{ get; set; }

        /// <summary>
        /// <p>Layer 7 origin pull timeout configuration. This parameter is required when the Name value is HTTPUpstreamTimeout.</p>
        /// </summary>
        [JsonProperty("HTTPUpstreamTimeoutParameters")]
        public HTTPUpstreamTimeoutParameters HTTPUpstreamTimeoutParameters{ get; set; }

        /// <summary>
        /// <p>HTTP response configuration parameter. This parameter is required when the Name value is HttpResponse.</p>
        /// </summary>
        [JsonProperty("HttpResponseParameters")]
        public HTTPResponseParameters HttpResponseParameters{ get; set; }

        /// <summary>
        /// <p>Custom error page configuration parameter. This parameter is required when the value of Name is ErrorPage.</p>
        /// </summary>
        [JsonProperty("ErrorPageParameters")]
        public ErrorPageParameters ErrorPageParameters{ get; set; }

        /// <summary>
        /// <p>Modify the HTTP node response header configuration parameter. This parameter is required when the Name value is ModifyResponseHeader.</p>
        /// </summary>
        [JsonProperty("ModifyResponseHeaderParameters")]
        public ModifyResponseHeaderParameters ModifyResponseHeaderParameters{ get; set; }

        /// <summary>
        /// <p>Modify the request header configuration parameter of the HTTP node. This parameter is required when the Name value is ModifyRequestHeader.</p>
        /// </summary>
        [JsonProperty("ModifyRequestHeaderParameters")]
        public ModifyRequestHeaderParameters ModifyRequestHeaderParameters{ get; set; }

        /// <summary>
        /// <p>Single connection download speed limit configuration parameter. This parameter is required when the Name value is ResponseSpeedLimit.</p>
        /// </summary>
        [JsonProperty("ResponseSpeedLimitParameters")]
        public ResponseSpeedLimitParameters ResponseSpeedLimitParameters{ get; set; }

        /// <summary>
        /// <p>Content identification configuration parameter. This parameter is required when the Name value is SetContentIdentifier.</p>
        /// </summary>
        [JsonProperty("SetContentIdentifierParameters")]
        public SetContentIdentifierParameters SetContentIdentifierParameters{ get; set; }

        /// <summary>
        /// <p>Vary feature configuration parameter. This parameter is required when the Name value is Vary.</p>
        /// </summary>
        [JsonProperty("VaryParameters")]
        public VaryParameters VaryParameters{ get; set; }

        /// <summary>
        /// <p>Content compression configuration parameter. When the Name value is ContentCompression, this parameter is required. This parameter is an allowlist feature. If needed, contact Tencent Cloud Engineers.</p>
        /// </summary>
        [JsonProperty("ContentCompressionParameters")]
        public ContentCompressionParameters ContentCompressionParameters{ get; set; }

        /// <summary>
        /// <p>Origin authentication configuration parameter. This parameter is required when Name value is OriginAuthentication. This parameter is an allowlist feature. If needed, contact Tencent Cloud Engineers.</p>
        /// </summary>
        [JsonProperty("OriginAuthenticationParameters")]
        public OriginAuthenticationParameters OriginAuthenticationParameters{ get; set; }

        /// <summary>
        /// <p>Custom configuration operation parameter. This parameter is required when the Name value is CustomAction.</p><p>You can obtain the list of currently supported custom configuration items through the CustomActionSet returned value of the DescribeAvailableCustomActionsForRuleEngine API.</p>
        /// </summary>
        [JsonProperty("CustomActionParameters")]
        public CustomActionParameters CustomActionParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "CacheParameters.", this.CacheParameters);
            this.SetParamObj(map, prefix + "CacheKeyParameters.", this.CacheKeyParameters);
            this.SetParamObj(map, prefix + "CachePrefreshParameters.", this.CachePrefreshParameters);
            this.SetParamObj(map, prefix + "AccessURLRedirectParameters.", this.AccessURLRedirectParameters);
            this.SetParamObj(map, prefix + "UpstreamURLRewriteParameters.", this.UpstreamURLRewriteParameters);
            this.SetParamObj(map, prefix + "QUICParameters.", this.QUICParameters);
            this.SetParamObj(map, prefix + "WebSocketParameters.", this.WebSocketParameters);
            this.SetParamObj(map, prefix + "AuthenticationParameters.", this.AuthenticationParameters);
            this.SetParamObj(map, prefix + "MaxAgeParameters.", this.MaxAgeParameters);
            this.SetParamObj(map, prefix + "StatusCodeCacheParameters.", this.StatusCodeCacheParameters);
            this.SetParamObj(map, prefix + "OfflineCacheParameters.", this.OfflineCacheParameters);
            this.SetParamObj(map, prefix + "SmartRoutingParameters.", this.SmartRoutingParameters);
            this.SetParamObj(map, prefix + "AdvancedOriginRoutingParameters.", this.AdvancedOriginRoutingParameters);
            this.SetParamObj(map, prefix + "RangeOriginPullParameters.", this.RangeOriginPullParameters);
            this.SetParamObj(map, prefix + "UpstreamHTTP2Parameters.", this.UpstreamHTTP2Parameters);
            this.SetParamObj(map, prefix + "HostHeaderParameters.", this.HostHeaderParameters);
            this.SetParamObj(map, prefix + "ForceRedirectHTTPSParameters.", this.ForceRedirectHTTPSParameters);
            this.SetParamObj(map, prefix + "OriginPullProtocolParameters.", this.OriginPullProtocolParameters);
            this.SetParamObj(map, prefix + "CompressionParameters.", this.CompressionParameters);
            this.SetParamObj(map, prefix + "HSTSParameters.", this.HSTSParameters);
            this.SetParamObj(map, prefix + "ClientIPHeaderParameters.", this.ClientIPHeaderParameters);
            this.SetParamObj(map, prefix + "OCSPStaplingParameters.", this.OCSPStaplingParameters);
            this.SetParamObj(map, prefix + "HTTP2Parameters.", this.HTTP2Parameters);
            this.SetParamObj(map, prefix + "PostMaxSizeParameters.", this.PostMaxSizeParameters);
            this.SetParamObj(map, prefix + "ClientIPCountryParameters.", this.ClientIPCountryParameters);
            this.SetParamObj(map, prefix + "UpstreamFollowRedirectParameters.", this.UpstreamFollowRedirectParameters);
            this.SetParamObj(map, prefix + "UpstreamRequestParameters.", this.UpstreamRequestParameters);
            this.SetParamObj(map, prefix + "ShieldParameters.", this.ShieldParameters);
            this.SetParamObj(map, prefix + "TLSConfigParameters.", this.TLSConfigParameters);
            this.SetParamObj(map, prefix + "ModifyOriginParameters.", this.ModifyOriginParameters);
            this.SetParamObj(map, prefix + "SiteFailoverParameters.", this.SiteFailoverParameters);
            this.SetParamObj(map, prefix + "HTTPUpstreamTimeoutParameters.", this.HTTPUpstreamTimeoutParameters);
            this.SetParamObj(map, prefix + "HttpResponseParameters.", this.HttpResponseParameters);
            this.SetParamObj(map, prefix + "ErrorPageParameters.", this.ErrorPageParameters);
            this.SetParamObj(map, prefix + "ModifyResponseHeaderParameters.", this.ModifyResponseHeaderParameters);
            this.SetParamObj(map, prefix + "ModifyRequestHeaderParameters.", this.ModifyRequestHeaderParameters);
            this.SetParamObj(map, prefix + "ResponseSpeedLimitParameters.", this.ResponseSpeedLimitParameters);
            this.SetParamObj(map, prefix + "SetContentIdentifierParameters.", this.SetContentIdentifierParameters);
            this.SetParamObj(map, prefix + "VaryParameters.", this.VaryParameters);
            this.SetParamObj(map, prefix + "ContentCompressionParameters.", this.ContentCompressionParameters);
            this.SetParamObj(map, prefix + "OriginAuthenticationParameters.", this.OriginAuthenticationParameters);
            this.SetParamObj(map, prefix + "CustomActionParameters.", this.CustomActionParameters);
        }
    }
}

