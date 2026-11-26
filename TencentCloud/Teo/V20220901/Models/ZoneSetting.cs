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

    public class ZoneSetting : AbstractModel
    {
        
        /// <summary>
        /// Site name.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Site acceleration region info. Valid values:
        /// <li>mainland: domestic acceleration in China;</li>
        /// <li> overseas: acceleration outside the Chinese mainland.</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Node cache key configuration.
        /// </summary>
        [JsonProperty("CacheKey")]
        public CacheKey CacheKey{ get; set; }

        /// <summary>
        /// Quic access configuration.
        /// </summary>
        [JsonProperty("Quic")]
        public Quic Quic{ get; set; }

        /// <summary>
        /// HTTP POST request transmission configuration.
        /// </summary>
        [JsonProperty("PostMaxSize")]
        public PostMaxSize PostMaxSize{ get; set; }

        /// <summary>
        /// Intelligent compression configuration.
        /// </summary>
        [JsonProperty("Compression")]
        public Compression Compression{ get; set; }

        /// <summary>
        /// Http/2 origin-pull configuration.
        /// </summary>
        [JsonProperty("UpstreamHttp2")]
        public UpstreamHttp2 UpstreamHttp2{ get; set; }

        /// <summary>
        /// Access protocol mandatory Https redirection configuration.
        /// </summary>
        [JsonProperty("ForceRedirect")]
        public ForceRedirect ForceRedirect{ get; set; }

        /// <summary>
        /// Cache expiration time configuration.
        /// </summary>
        [JsonProperty("CacheConfig")]
        public CacheConfig CacheConfig{ get; set; }

        /// <summary>
        /// Origin server configuration.
        /// </summary>
        [JsonProperty("Origin")]
        public Origin Origin{ get; set; }

        /// <summary>
        /// Smart acceleration configuration.
        /// </summary>
        [JsonProperty("SmartRouting")]
        public SmartRouting SmartRouting{ get; set; }

        /// <summary>
        /// Browser cache configuration.
        /// </summary>
        [JsonProperty("MaxAge")]
        public MaxAge MaxAge{ get; set; }

        /// <summary>
        /// Offline cache configuration.
        /// </summary>
        [JsonProperty("OfflineCache")]
        public OfflineCache OfflineCache{ get; set; }

        /// <summary>
        /// WebSocket configuration.
        /// </summary>
        [JsonProperty("WebSocket")]
        public WebSocket WebSocket{ get; set; }

        /// <summary>
        /// Client IP HTTP Request Headers configuration.
        /// </summary>
        [JsonProperty("ClientIpHeader")]
        public ClientIpHeader ClientIpHeader{ get; set; }

        /// <summary>
        /// Cache pre-refresh configuration.
        /// </summary>
        [JsonProperty("CachePrefresh")]
        public CachePrefresh CachePrefresh{ get; set; }

        /// <summary>
        /// Ipv6 access configuration.
        /// </summary>
        [JsonProperty("Ipv6")]
        public Ipv6 Ipv6{ get; set; }

        /// <summary>
        /// Https acceleration configuration.
        /// </summary>
        [JsonProperty("Https")]
        public Https Https{ get; set; }

        /// <summary>
        /// Configuration of whether to carry the regional information of the client IP during origin-pull.
        /// </summary>
        [JsonProperty("ClientIpCountry")]
        public ClientIpCountry ClientIpCountry{ get; set; }

        /// <summary>
        /// Grpc protocol supports configuration.
        /// </summary>
        [JsonProperty("Grpc")]
        public Grpc Grpc{ get; set; }

        /// <summary>
        /// Network error log configuration.
        /// </summary>
        [JsonProperty("NetworkErrorLogging")]
        public NetworkErrorLogging NetworkErrorLogging{ get; set; }

        /// <summary>
        /// Image optimization configuration.
        /// </summary>
        [JsonProperty("ImageOptimize")]
        public ImageOptimize ImageOptimize{ get; set; }

        /// <summary>
        /// Acceleration optimization configuration for the Chinese mainland.
        /// </summary>
        [JsonProperty("AccelerateMainland")]
        public AccelerateMainland AccelerateMainland{ get; set; }

        /// <summary>
        /// Standard Debug configuration.
        /// </summary>
        [JsonProperty("StandardDebug")]
        public StandardDebug StandardDebug{ get; set; }

        /// <summary>
        /// Just-in-time media processing configuration.
        /// </summary>
        [JsonProperty("JITVideoProcess")]
        public JITVideoProcess JITVideoProcess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamObj(map, prefix + "CacheKey.", this.CacheKey);
            this.SetParamObj(map, prefix + "Quic.", this.Quic);
            this.SetParamObj(map, prefix + "PostMaxSize.", this.PostMaxSize);
            this.SetParamObj(map, prefix + "Compression.", this.Compression);
            this.SetParamObj(map, prefix + "UpstreamHttp2.", this.UpstreamHttp2);
            this.SetParamObj(map, prefix + "ForceRedirect.", this.ForceRedirect);
            this.SetParamObj(map, prefix + "CacheConfig.", this.CacheConfig);
            this.SetParamObj(map, prefix + "Origin.", this.Origin);
            this.SetParamObj(map, prefix + "SmartRouting.", this.SmartRouting);
            this.SetParamObj(map, prefix + "MaxAge.", this.MaxAge);
            this.SetParamObj(map, prefix + "OfflineCache.", this.OfflineCache);
            this.SetParamObj(map, prefix + "WebSocket.", this.WebSocket);
            this.SetParamObj(map, prefix + "ClientIpHeader.", this.ClientIpHeader);
            this.SetParamObj(map, prefix + "CachePrefresh.", this.CachePrefresh);
            this.SetParamObj(map, prefix + "Ipv6.", this.Ipv6);
            this.SetParamObj(map, prefix + "Https.", this.Https);
            this.SetParamObj(map, prefix + "ClientIpCountry.", this.ClientIpCountry);
            this.SetParamObj(map, prefix + "Grpc.", this.Grpc);
            this.SetParamObj(map, prefix + "NetworkErrorLogging.", this.NetworkErrorLogging);
            this.SetParamObj(map, prefix + "ImageOptimize.", this.ImageOptimize);
            this.SetParamObj(map, prefix + "AccelerateMainland.", this.AccelerateMainland);
            this.SetParamObj(map, prefix + "StandardDebug.", this.StandardDebug);
            this.SetParamObj(map, prefix + "JITVideoProcess.", this.JITVideoProcess);
        }
    }
}

