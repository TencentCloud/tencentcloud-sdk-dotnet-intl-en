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

    public class ModifyZoneSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// Site ID to be changed.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Cache expiration time configuration.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("CacheConfig")]
        public CacheConfig CacheConfig{ get; set; }

        /// <summary>
        /// Node cache key configuration.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("CacheKey")]
        public CacheKey CacheKey{ get; set; }

        /// <summary>
        /// Browser cache configuration.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("MaxAge")]
        public MaxAge MaxAge{ get; set; }

        /// <summary>
        /// Offline cache configuration.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("OfflineCache")]
        public OfflineCache OfflineCache{ get; set; }

        /// <summary>
        /// Quic access configuration.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("Quic")]
        public Quic Quic{ get; set; }

        /// <summary>
        /// Configuration for Post request transmission.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("PostMaxSize")]
        public PostMaxSize PostMaxSize{ get; set; }

        /// <summary>
        /// Intelligent compression configuration.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("Compression")]
        public Compression Compression{ get; set; }

        /// <summary>
        /// Http2 origin-pull configuration.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("UpstreamHttp2")]
        public UpstreamHttp2 UpstreamHttp2{ get; set; }

        /// <summary>
        /// Access protocol forcing Https redirection configuration.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("ForceRedirect")]
        public ForceRedirect ForceRedirect{ get; set; }

        /// <summary>
        /// Https acceleration configuration.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("Https")]
        public Https Https{ get; set; }

        /// <summary>
        /// Origin server configuration.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("Origin")]
        public Origin Origin{ get; set; }

        /// <summary>
        /// Intelligent acceleration configuration.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("SmartRouting")]
        public SmartRouting SmartRouting{ get; set; }

        /// <summary>
        /// WebSocket configuration.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("WebSocket")]
        public WebSocket WebSocket{ get; set; }

        /// <summary>
        /// Client IP origin-pull request header configuration.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("ClientIpHeader")]
        public ClientIpHeader ClientIpHeader{ get; set; }

        /// <summary>
        /// Cache pre-refresh configuration.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("CachePrefresh")]
        public CachePrefresh CachePrefresh{ get; set; }

        /// <summary>
        /// Ipv6 access configuration.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("Ipv6")]
        public Ipv6 Ipv6{ get; set; }

        /// <summary>
        /// Configuration of whether to carry the regional information of the client IP during origin-pull.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("ClientIpCountry")]
        public ClientIpCountry ClientIpCountry{ get; set; }

        /// <summary>
        /// Grpc protocol support configuration.
        /// Leave blank to retain the original configuration.
        /// </summary>
        [JsonProperty("Grpc")]
        public Grpc Grpc{ get; set; }

        /// <summary>
        /// Network error log configuration. If this field is not specified, the original configuration will be retained.
        /// </summary>
        [JsonProperty("NetworkErrorLogging")]
        public NetworkErrorLogging NetworkErrorLogging{ get; set; }

        /// <summary>
        /// Image optimization configuration.
        /// Not specified: disabled.
        /// </summary>
        [JsonProperty("ImageOptimize")]
        public ImageOptimize ImageOptimize{ get; set; }

        /// <summary>
        /// Standard Debug configuration.
        /// </summary>
        [JsonProperty("StandardDebug")]
        public StandardDebug StandardDebug{ get; set; }

        /// <summary>
        /// Just-in-time media processing configuration. The original configuration applies if this field is not specified.
        /// </summary>
        [JsonProperty("JITVideoProcess")]
        public JITVideoProcess JITVideoProcess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamObj(map, prefix + "CacheConfig.", this.CacheConfig);
            this.SetParamObj(map, prefix + "CacheKey.", this.CacheKey);
            this.SetParamObj(map, prefix + "MaxAge.", this.MaxAge);
            this.SetParamObj(map, prefix + "OfflineCache.", this.OfflineCache);
            this.SetParamObj(map, prefix + "Quic.", this.Quic);
            this.SetParamObj(map, prefix + "PostMaxSize.", this.PostMaxSize);
            this.SetParamObj(map, prefix + "Compression.", this.Compression);
            this.SetParamObj(map, prefix + "UpstreamHttp2.", this.UpstreamHttp2);
            this.SetParamObj(map, prefix + "ForceRedirect.", this.ForceRedirect);
            this.SetParamObj(map, prefix + "Https.", this.Https);
            this.SetParamObj(map, prefix + "Origin.", this.Origin);
            this.SetParamObj(map, prefix + "SmartRouting.", this.SmartRouting);
            this.SetParamObj(map, prefix + "WebSocket.", this.WebSocket);
            this.SetParamObj(map, prefix + "ClientIpHeader.", this.ClientIpHeader);
            this.SetParamObj(map, prefix + "CachePrefresh.", this.CachePrefresh);
            this.SetParamObj(map, prefix + "Ipv6.", this.Ipv6);
            this.SetParamObj(map, prefix + "ClientIpCountry.", this.ClientIpCountry);
            this.SetParamObj(map, prefix + "Grpc.", this.Grpc);
            this.SetParamObj(map, prefix + "NetworkErrorLogging.", this.NetworkErrorLogging);
            this.SetParamObj(map, prefix + "ImageOptimize.", this.ImageOptimize);
            this.SetParamObj(map, prefix + "StandardDebug.", this.StandardDebug);
            this.SetParamObj(map, prefix + "JITVideoProcess.", this.JITVideoProcess);
        }
    }
}

