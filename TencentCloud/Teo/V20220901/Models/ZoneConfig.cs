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
        /// Intelligent acceleration configuration.
        /// </summary>
        [JsonProperty("SmartRouting")]
        public SmartRoutingParameters SmartRouting{ get; set; }

        /// <summary>
        /// Cache expiration time configuration.
        /// </summary>
        [JsonProperty("Cache")]
        public CacheConfigParameters Cache{ get; set; }

        /// <summary>
        /// Browser cache configuration.
        /// </summary>
        [JsonProperty("MaxAge")]
        public MaxAgeParameters MaxAge{ get; set; }

        /// <summary>
        /// Node cache key configuration.
        /// </summary>
        [JsonProperty("CacheKey")]
        public CacheKeyConfigParameters CacheKey{ get; set; }

        /// <summary>
        /// Cache pre-refresh configuration.
        /// </summary>
        [JsonProperty("CachePrefresh")]
        public CachePrefreshParameters CachePrefresh{ get; set; }

        /// <summary>
        /// Offline cache configuration.
        /// </summary>
        [JsonProperty("OfflineCache")]
        public OfflineCacheParameters OfflineCache{ get; set; }

        /// <summary>
        /// Intelligent compression configuration.
        /// </summary>
        [JsonProperty("Compression")]
        public CompressionParameters Compression{ get; set; }

        /// <summary>
        /// Forced HTTPS redirect configuration for access protocols.
        /// </summary>
        [JsonProperty("ForceRedirectHTTPS")]
        public ForceRedirectHTTPSParameters ForceRedirectHTTPS{ get; set; }

        /// <summary>
        /// HSTS configuration.
        /// </summary>
        [JsonProperty("HSTS")]
        public HSTSParameters HSTS{ get; set; }

        /// <summary>
        /// TLS configuration.
        /// </summary>
        [JsonProperty("TLSConfig")]
        public TLSConfigParameters TLSConfig{ get; set; }

        /// <summary>
        /// OCSP stapling configuration.
        /// </summary>
        [JsonProperty("OCSPStapling")]
        public OCSPStaplingParameters OCSPStapling{ get; set; }

        /// <summary>
        /// HTTP/2 configuration.
        /// </summary>
        [JsonProperty("HTTP2")]
        public HTTP2Parameters HTTP2{ get; set; }

        /// <summary>
        /// QUIC access configuration.
        /// </summary>
        [JsonProperty("QUIC")]
        public QUICParameters QUIC{ get; set; }

        /// <summary>
        /// HTTP/2 origin-pull configuration.
        /// </summary>
        [JsonProperty("UpstreamHTTP2")]
        public UpstreamHTTP2Parameters UpstreamHTTP2{ get; set; }

        /// <summary>
        /// IPv6 access configuration.
        /// </summary>
        [JsonProperty("IPv6")]
        public IPv6Parameters IPv6{ get; set; }

        /// <summary>
        /// WebSocket configuration.
        /// </summary>
        [JsonProperty("WebSocket")]
        public WebSocketParameters WebSocket{ get; set; }

        /// <summary>
        /// Configuration for POST request transmission.
        /// </summary>
        [JsonProperty("PostMaxSize")]
        public PostMaxSizeParameters PostMaxSize{ get; set; }

        /// <summary>
        /// Client IP origin-pull request header configuration.
        /// </summary>
        [JsonProperty("ClientIPHeader")]
        public ClientIPHeaderParameters ClientIPHeader{ get; set; }

        /// <summary>
        /// Configuration of whether to carry the regional information of the client IP during origin-pull.
        /// </summary>
        [JsonProperty("ClientIPCountry")]
        public ClientIPCountryParameters ClientIPCountry{ get; set; }

        /// <summary>
        /// The gRPC protocol supports configuration.
        /// </summary>
        [JsonProperty("Grpc")]
        public GrpcParameters Grpc{ get; set; }

        /// <summary>
        /// Network error log configuration.
        /// </summary>
        [JsonProperty("NetworkErrorLogging")]
        public NetworkErrorLoggingParameters NetworkErrorLogging{ get; set; }

        /// <summary>
        /// Acceleration optimization configuration in the Chinese mainland.
        /// </summary>
        [JsonProperty("AccelerateMainland")]
        public AccelerateMainlandParameters AccelerateMainland{ get; set; }

        /// <summary>
        /// Standard Debug configuration.
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

