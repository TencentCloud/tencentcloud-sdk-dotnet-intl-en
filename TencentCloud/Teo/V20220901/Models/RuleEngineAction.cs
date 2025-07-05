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
        /// 
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Node cache ttl configuration parameter. when name is cache, this parameter is required.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("CacheParameters")]
        public CacheParameters CacheParameters{ get; set; }

        /// <summary>
        /// Custom cache key configuration parameter. when name is cachekey, this parameter is required.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("CacheKeyParameters")]
        public CacheKeyParameters CacheKeyParameters{ get; set; }

        /// <summary>
        /// The cache prefresh configuration parameter. this parameter is required when `name` is `cacheprefresh`.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("CachePrefreshParameters")]
        public CachePrefreshParameters CachePrefreshParameters{ get; set; }

        /// <summary>
        /// The access url redirection configuration parameter. this parameter is required when `name` is `accessurlredirect`.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("AccessURLRedirectParameters")]
        public AccessURLRedirectParameters AccessURLRedirectParameters{ get; set; }

        /// <summary>
        /// The origin-pull url rewrite configuration parameter. this parameter is required when `name` is `upstreamurlrewrite`.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("UpstreamURLRewriteParameters")]
        public UpstreamURLRewriteParameters UpstreamURLRewriteParameters{ get; set; }

        /// <summary>
        /// The quic configuration parameter. this parameter is required when `name` is `quic`.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("QUICParameters")]
        public QUICParameters QUICParameters{ get; set; }

        /// <summary>
        /// The websocket configuration parameter. this parameter is required when `name` is `websocket`.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("WebSocketParameters")]
        public WebSocketParameters WebSocketParameters{ get; set; }

        /// <summary>
        /// Token authentication configuration parameter. this parameter is required when `name` is `authentication`.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("AuthenticationParameters")]
        public AuthenticationParameters AuthenticationParameters{ get; set; }

        /// <summary>
        /// Browser cache ttl configuration parameter. this parameter is required when `name` is `maxage`.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("MaxAgeParameters")]
        public MaxAgeParameters MaxAgeParameters{ get; set; }

        /// <summary>
        /// Status code cache ttl configuration parameter. this parameter is required when `name` is `statuscodecache`.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("StatusCodeCacheParameters")]
        public StatusCodeCacheParameters StatusCodeCacheParameters{ get; set; }

        /// <summary>
        /// Offline cache configuration parameter. this parameter is required when `name` is `offlinecache`.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("OfflineCacheParameters")]
        public OfflineCacheParameters OfflineCacheParameters{ get; set; }

        /// <summary>
        /// Smart acceleration configuration parameter. this parameter is required when `name` is `smartrouting`.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("SmartRoutingParameters")]
        public SmartRoutingParameters SmartRoutingParameters{ get; set; }

        /// <summary>
        /// Shard source retrieval configuration parameter. this parameter is required when name is set to rangeoriginpull.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("RangeOriginPullParameters")]
        public RangeOriginPullParameters RangeOriginPullParameters{ get; set; }

        /// <summary>
        /// HTTP2 origin-pull configuration parameter. this parameter is required when name is set to upstreamhttp2.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("UpstreamHTTP2Parameters")]
        public UpstreamHTTP2Parameters UpstreamHTTP2Parameters{ get; set; }

        /// <summary>
        /// Host header rewrite configuration parameter. this parameter is required when name is set to hostheader.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("HostHeaderParameters")]
        public HostHeaderParameters HostHeaderParameters{ get; set; }

        /// <summary>
        /// Force https redirect configuration parameter. this parameter is required when the name is set to forceredirecthttps.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("ForceRedirectHTTPSParameters")]
        public ForceRedirectHTTPSParameters ForceRedirectHTTPSParameters{ get; set; }

        /// <summary>
        /// Intelligent compression configuration. this parameter is required when name is set to compression.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("CompressionParameters")]
        public CompressionParameters CompressionParameters{ get; set; }

        /// <summary>
        /// HSTS configuration parameter. this parameter is required when name is hsts.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("HSTSParameters")]
        public HSTSParameters HSTSParameters{ get; set; }

        /// <summary>
        /// Client ip header configuration for storing client request ip information. this parameter is required when name is clientipheader.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("ClientIPHeaderParameters")]
        public ClientIPHeaderParameters ClientIPHeaderParameters{ get; set; }

        /// <summary>
        /// OCSP stapling configuration parameter. this parameter is required when the name is set to ocspstapling.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("OCSPStaplingParameters")]
        public OCSPStaplingParameters OCSPStaplingParameters{ get; set; }

        /// <summary>
        /// HTTP2 access configuration parameter. this parameter is required when name is http2.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("HTTP2Parameters")]
        public HTTP2Parameters HTTP2Parameters{ get; set; }

        /// <summary>
        /// Maximum size configuration for file streaming upload via a post request. this parameter is required when name is postmaxsize.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("PostMaxSizeParameters")]
        public PostMaxSizeParameters PostMaxSizeParameters{ get; set; }

        /// <summary>
        /// Configuration parameter for carrying the region information of the client ip during origin-pull. this parameter is required when the name is set to clientipcountry.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("ClientIPCountryParameters")]
        public ClientIPCountryParameters ClientIPCountryParameters{ get; set; }

        /// <summary>
        /// Configuration parameter for following redirects during origin-pull. this parameter is required when the name is set to upstreamfollowredirect.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("UpstreamFollowRedirectParameters")]
        public UpstreamFollowRedirectParameters UpstreamFollowRedirectParameters{ get; set; }

        /// <summary>
        /// Configuration parameter for origin-pull request. this parameter is required when the name is set to upstreamrequest.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("UpstreamRequestParameters")]
        public UpstreamRequestParameters UpstreamRequestParameters{ get; set; }

        /// <summary>
        /// SSL/TLS security configuration parameter. this parameter is required when the name is set to tlsconfig.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("TLSConfigParameters")]
        public TLSConfigParameters TLSConfigParameters{ get; set; }

        /// <summary>
        /// Configuration parameter for modifying the origin server. this parameter is required when the name is set to modifyorigin.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("ModifyOriginParameters")]
        public ModifyOriginParameters ModifyOriginParameters{ get; set; }

        /// <summary>
        /// Configuration of layer 7 origin timeout. this parameter is required when name is httpupstreamtimeout.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("HTTPUpstreamTimeoutParameters")]
        public HTTPUpstreamTimeoutParameters HTTPUpstreamTimeoutParameters{ get; set; }

        /// <summary>
        /// HTTP response configuration parameters. this parameter is required when name is httpresponse.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("HttpResponseParameters")]
        public HTTPResponseParameters HttpResponseParameters{ get; set; }

        /// <summary>
        /// Custom error page configuration parameters. this parameter is required when name is errorpage.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("ErrorPageParameters")]
        public ErrorPageParameters ErrorPageParameters{ get; set; }

        /// <summary>
        /// Modify http node response header configuration parameters. this parameter is required when name is modifyresponseheader.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("ModifyResponseHeaderParameters")]
        public ModifyResponseHeaderParameters ModifyResponseHeaderParameters{ get; set; }

        /// <summary>
        /// Modify http node request header configuration parameters. this parameter is required when name is modifyrequestheader.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("ModifyRequestHeaderParameters")]
        public ModifyRequestHeaderParameters ModifyRequestHeaderParameters{ get; set; }

        /// <summary>
        /// Single connection download speed limit configuration parameter. this parameter is required when name is responsespeedlimit.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("ResponseSpeedLimitParameters")]
        public ResponseSpeedLimitParameters ResponseSpeedLimitParameters{ get; set; }

        /// <summary>
        /// Content identification configuration parameter. this parameter is required when name is httpresponse.
        /// 
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("SetContentIdentifierParameters")]
        public SetContentIdentifierParameters SetContentIdentifierParameters{ get; set; }


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
            this.SetParamObj(map, prefix + "RangeOriginPullParameters.", this.RangeOriginPullParameters);
            this.SetParamObj(map, prefix + "UpstreamHTTP2Parameters.", this.UpstreamHTTP2Parameters);
            this.SetParamObj(map, prefix + "HostHeaderParameters.", this.HostHeaderParameters);
            this.SetParamObj(map, prefix + "ForceRedirectHTTPSParameters.", this.ForceRedirectHTTPSParameters);
            this.SetParamObj(map, prefix + "CompressionParameters.", this.CompressionParameters);
            this.SetParamObj(map, prefix + "HSTSParameters.", this.HSTSParameters);
            this.SetParamObj(map, prefix + "ClientIPHeaderParameters.", this.ClientIPHeaderParameters);
            this.SetParamObj(map, prefix + "OCSPStaplingParameters.", this.OCSPStaplingParameters);
            this.SetParamObj(map, prefix + "HTTP2Parameters.", this.HTTP2Parameters);
            this.SetParamObj(map, prefix + "PostMaxSizeParameters.", this.PostMaxSizeParameters);
            this.SetParamObj(map, prefix + "ClientIPCountryParameters.", this.ClientIPCountryParameters);
            this.SetParamObj(map, prefix + "UpstreamFollowRedirectParameters.", this.UpstreamFollowRedirectParameters);
            this.SetParamObj(map, prefix + "UpstreamRequestParameters.", this.UpstreamRequestParameters);
            this.SetParamObj(map, prefix + "TLSConfigParameters.", this.TLSConfigParameters);
            this.SetParamObj(map, prefix + "ModifyOriginParameters.", this.ModifyOriginParameters);
            this.SetParamObj(map, prefix + "HTTPUpstreamTimeoutParameters.", this.HTTPUpstreamTimeoutParameters);
            this.SetParamObj(map, prefix + "HttpResponseParameters.", this.HttpResponseParameters);
            this.SetParamObj(map, prefix + "ErrorPageParameters.", this.ErrorPageParameters);
            this.SetParamObj(map, prefix + "ModifyResponseHeaderParameters.", this.ModifyResponseHeaderParameters);
            this.SetParamObj(map, prefix + "ModifyRequestHeaderParameters.", this.ModifyRequestHeaderParameters);
            this.SetParamObj(map, prefix + "ResponseSpeedLimitParameters.", this.ResponseSpeedLimitParameters);
            this.SetParamObj(map, prefix + "SetContentIdentifierParameters.", this.SetContentIdentifierParameters);
        }
    }
}

