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
        /// Name of the site
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Site acceleration region. Values:
        /// <li>`mainland`: Acceleration in the Chinese mainland.</li>
        /// <li>`overseas`: Acceleration outside the Chinese mainland.</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Node cache key configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CacheKey")]
        public CacheKey CacheKey{ get; set; }

        /// <summary>
        /// The QUIC access configuration.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Quic")]
        public Quic Quic{ get; set; }

        /// <summary>
        /// The POST transport configuration.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PostMaxSize")]
        public PostMaxSize PostMaxSize{ get; set; }

        /// <summary>
        /// Smart compression configuration.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Compression")]
        public Compression Compression{ get; set; }

        /// <summary>
        /// HTTP2 origin-pull configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpstreamHttp2")]
        public UpstreamHttp2 UpstreamHttp2{ get; set; }

        /// <summary>
        /// Force HTTPS redirect configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ForceRedirect")]
        public ForceRedirect ForceRedirect{ get; set; }

        /// <summary>
        /// Cache expiration time configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CacheConfig")]
        public CacheConfig CacheConfig{ get; set; }

        /// <summary>
        /// Origin server configuration.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Origin")]
        public Origin Origin{ get; set; }

        /// <summary>
        /// Smart acceleration configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SmartRouting")]
        public SmartRouting SmartRouting{ get; set; }

        /// <summary>
        /// Browser cache configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxAge")]
        public MaxAge MaxAge{ get; set; }

        /// <summary>
        /// The offline cache configuration.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OfflineCache")]
        public OfflineCache OfflineCache{ get; set; }

        /// <summary>
        /// WebSocket configuration.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WebSocket")]
        public WebSocket WebSocket{ get; set; }

        /// <summary>
        /// Origin-pull client IP header configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClientIpHeader")]
        public ClientIpHeader ClientIpHeader{ get; set; }

        /// <summary>
        /// Cache prefresh configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CachePrefresh")]
        public CachePrefresh CachePrefresh{ get; set; }

        /// <summary>
        /// IPv6 access configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ipv6")]
        public Ipv6 Ipv6{ get; set; }

        /// <summary>
        /// HTTPS acceleration configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Https")]
        public Https Https{ get; set; }

        /// <summary>
        /// Whether to carry the location information of the client IP during origin-pull.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ClientIpCountry")]
        public ClientIpCountry ClientIpCountry{ get; set; }

        /// <summary>
        /// Configuration of gRPC support
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Grpc")]
        public Grpc Grpc{ get; set; }

        /// <summary>
        /// Network Error Logging configuration.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("NetworkErrorLogging")]
        public NetworkErrorLogging NetworkErrorLogging{ get; set; }

        /// <summary>
        /// Image optimization configuration. 
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ImageOptimize")]
        public ImageOptimize ImageOptimize{ get; set; }

        /// <summary>
        /// Cross-MLC-border acceleration. 
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AccelerateMainland")]
        public AccelerateMainland AccelerateMainland{ get; set; }

        /// <summary>
        /// Standard debugging configuration.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StandardDebug")]
        public StandardDebug StandardDebug{ get; set; }

        /// <summary>
        /// Just-in-time media processing configuration.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
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

