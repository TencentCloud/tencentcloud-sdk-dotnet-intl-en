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

    public class ZoneConfig : AbstractModel
    {
        
        /// <summary>
        /// <Intelligent acceleration configuration.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("SmartRouting")]
        public SmartRoutingParameters SmartRouting{ get; set; }

        /// <summary>
        /// Node cache expiration time configuration.
        /// .
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("Cache")]
        public CacheConfigParameters Cache{ get; set; }

        /// <summary>
        /// Browser cache rule configuration, which is used to set the default value of maxage and is disabled by default.
        /// .
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("MaxAge")]
        public MaxAgeParameters MaxAge{ get; set; }

        /// <summary>
        /// The node cache key configuration.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("CacheKey")]
        public CacheKeyConfigParameters CacheKey{ get; set; }

        /// <summary>
        /// Cache prefresh configuration.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("CachePrefresh")]
        public CachePrefreshParameters CachePrefresh{ get; set; }

        /// <summary>
        /// Offline cache configuration.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("OfflineCache")]
        public OfflineCacheParameters OfflineCache{ get; set; }

        /// <summary>
        /// Smart compression configuration.
        /// .
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("Compression")]
        public CompressionParameters Compression{ get; set; }

        /// <summary>
        /// Forced https redirect configuration for access protocols.
        /// .
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("ForceRedirectHTTPS")]
        public ForceRedirectHTTPSParameters ForceRedirectHTTPS{ get; set; }

        /// <summary>
        /// HSTS configuration.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("HSTS")]
        public HSTSParameters HSTS{ get; set; }

        /// <summary>
        /// TLS configuration.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("TLSConfig")]
        public TLSConfigParameters TLSConfig{ get; set; }

        /// <summary>
        /// OCSP stapling configuration.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("OCSPStapling")]
        public OCSPStaplingParameters OCSPStapling{ get; set; }

        /// <summary>
        /// HTTP/2 configuration.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("HTTP2")]
        public HTTP2Parameters HTTP2{ get; set; }

        /// <summary>
        /// QUIC access configuration.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("QUIC")]
        public QUICParameters QUIC{ get; set; }

        /// <summary>
        /// HTTP2 origin-pull configuration.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("UpstreamHTTP2")]
        public UpstreamHTTP2Parameters UpstreamHTTP2{ get; set; }

        /// <summary>
        /// IPv6 access configuration.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("IPv6")]
        public IPv6Parameters IPv6{ get; set; }

        /// <summary>
        /// WebSocket configuration.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("WebSocket")]
        public WebSocketParameters WebSocket{ get; set; }

        /// <summary>
        /// POST request transport configuration.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("PostMaxSize")]
        public PostMaxSizeParameters PostMaxSize{ get; set; }

        /// <summary>
        /// Client ip origin-pull request header configuration.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("ClientIPHeader")]
        public ClientIPHeaderParameters ClientIPHeader{ get; set; }

        /// <summary>
        /// Whether to carry the region information of the client ip during origin-pull.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("ClientIPCountry")]
        public ClientIPCountryParameters ClientIPCountry{ get; set; }

        /// <summary>
        /// Configuration of grpc support.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("Grpc")]
        public GrpcParameters Grpc{ get; set; }

        /// <summary>
        /// Network Error Logging configuration.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("NetworkErrorLogging")]
        public NetworkErrorLoggingParameters NetworkErrorLogging{ get; set; }

        /// <summary>
        /// Accelerate optimization and configuration in mainland china.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("AccelerateMainland")]
        public AccelerateMainlandParameters AccelerateMainland{ get; set; }

        /// <summary>
        /// Standard debugging configuration.
        /// .
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("StandardDebug")]
        public StandardDebugParameters StandardDebug{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SmartRouting.", this.SmartRouting);
            this.SetParamObj(map, prefix + "Cache.", this.Cache);
            this.SetParamObj(map, prefix + "MaxAge.", this.MaxAge);
            this.SetParamObj(map, prefix + "CacheKey.", this.CacheKey);
            this.SetParamObj(map, prefix + "CachePrefresh.", this.CachePrefresh);
            this.SetParamObj(map, prefix + "OfflineCache.", this.OfflineCache);
            this.SetParamObj(map, prefix + "Compression.", this.Compression);
            this.SetParamObj(map, prefix + "ForceRedirectHTTPS.", this.ForceRedirectHTTPS);
            this.SetParamObj(map, prefix + "HSTS.", this.HSTS);
            this.SetParamObj(map, prefix + "TLSConfig.", this.TLSConfig);
            this.SetParamObj(map, prefix + "OCSPStapling.", this.OCSPStapling);
            this.SetParamObj(map, prefix + "HTTP2.", this.HTTP2);
            this.SetParamObj(map, prefix + "QUIC.", this.QUIC);
            this.SetParamObj(map, prefix + "UpstreamHTTP2.", this.UpstreamHTTP2);
            this.SetParamObj(map, prefix + "IPv6.", this.IPv6);
            this.SetParamObj(map, prefix + "WebSocket.", this.WebSocket);
            this.SetParamObj(map, prefix + "PostMaxSize.", this.PostMaxSize);
            this.SetParamObj(map, prefix + "ClientIPHeader.", this.ClientIPHeader);
            this.SetParamObj(map, prefix + "ClientIPCountry.", this.ClientIPCountry);
            this.SetParamObj(map, prefix + "Grpc.", this.Grpc);
            this.SetParamObj(map, prefix + "NetworkErrorLogging.", this.NetworkErrorLogging);
            this.SetParamObj(map, prefix + "AccelerateMainland.", this.AccelerateMainland);
            this.SetParamObj(map, prefix + "StandardDebug.", this.StandardDebug);
        }
    }
}

