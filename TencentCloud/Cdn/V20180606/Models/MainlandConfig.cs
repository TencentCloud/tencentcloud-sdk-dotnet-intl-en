/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MainlandConfig : AbstractModel
    {
        
        /// <summary>
        /// Timestamp hotlink protection configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Authentication")]
        public Authentication Authentication{ get; set; }

        /// <summary>
        /// Bandwidth cap configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BandwidthAlert")]
        public BandwidthAlert BandwidthAlert{ get; set; }

        /// <summary>
        /// Cache rules configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Cache")]
        public Cache Cache{ get; set; }

        /// <summary>
        /// Cache configurations.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CacheKey")]
        public CacheKey CacheKey{ get; set; }

        /// <summary>
        /// Smart compression configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Compression")]
        public Compression Compression{ get; set; }

        /// <summary>
        /// Download speed limit configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DownstreamCapping")]
        public DownstreamCapping DownstreamCapping{ get; set; }

        /// <summary>
        /// Error code redirect configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErrorPage")]
        public ErrorPage ErrorPage{ get; set; }

        /// <summary>
        /// 301 and 302 automatic origin-pull follow-redirect configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FollowRedirect")]
        public FollowRedirect FollowRedirect{ get; set; }

        /// <summary>
        /// Access protocol forced redirect configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ForceRedirect")]
        public ForceRedirect ForceRedirect{ get; set; }

        /// <summary>
        /// HTTPS configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Https")]
        public Https Https{ get; set; }

        /// <summary>
        /// IP blocklist/allowlist configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IpFilter")]
        public IpFilter IpFilter{ get; set; }

        /// <summary>
        /// IP access limit configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IpFreqLimit")]
        public IpFreqLimit IpFreqLimit{ get; set; }

        /// <summary>
        /// Browser cache rules configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxAge")]
        public MaxAge MaxAge{ get; set; }

        /// <summary>
        /// Origin server configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Origin")]
        public Origin Origin{ get; set; }

        /// <summary>
        /// Cross-border optimization configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginPullOptimization")]
        public OriginPullOptimization OriginPullOptimization{ get; set; }

        /// <summary>
        /// Range GETs configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RangeOriginPull")]
        public RangeOriginPull RangeOriginPull{ get; set; }

        /// <summary>
        /// Hotlink protection configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Referer")]
        public Referer Referer{ get; set; }

        /// <summary>
        /// Origin-pull request header configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RequestHeader")]
        public RequestHeader RequestHeader{ get; set; }

        /// <summary>
        /// Origin server response header configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResponseHeader")]
        public ResponseHeader ResponseHeader{ get; set; }

        /// <summary>
        /// Follows origin server cache header configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResponseHeaderCache")]
        public ResponseHeaderCache ResponseHeaderCache{ get; set; }

        /// <summary>
        /// SEO configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Seo")]
        public Seo Seo{ get; set; }

        /// <summary>
        /// Domain name service type. `web`: static acceleration; `download`: download acceleration; `media`: streaming media acceleration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// Status code cache configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatusCodeCache")]
        public StatusCodeCache StatusCodeCache{ get; set; }

        /// <summary>
        /// Video dragging configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VideoSeek")]
        public VideoSeek VideoSeek{ get; set; }

        /// <summary>
        /// Private access for S3 origin
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AwsPrivateAccess")]
        public AwsPrivateAccess AwsPrivateAccess{ get; set; }

        /// <summary>
        /// Private access for OSS origin
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OssPrivateAccess")]
        public OssPrivateAccess OssPrivateAccess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Authentication.", this.Authentication);
            this.SetParamObj(map, prefix + "BandwidthAlert.", this.BandwidthAlert);
            this.SetParamObj(map, prefix + "Cache.", this.Cache);
            this.SetParamObj(map, prefix + "CacheKey.", this.CacheKey);
            this.SetParamObj(map, prefix + "Compression.", this.Compression);
            this.SetParamObj(map, prefix + "DownstreamCapping.", this.DownstreamCapping);
            this.SetParamObj(map, prefix + "ErrorPage.", this.ErrorPage);
            this.SetParamObj(map, prefix + "FollowRedirect.", this.FollowRedirect);
            this.SetParamObj(map, prefix + "ForceRedirect.", this.ForceRedirect);
            this.SetParamObj(map, prefix + "Https.", this.Https);
            this.SetParamObj(map, prefix + "IpFilter.", this.IpFilter);
            this.SetParamObj(map, prefix + "IpFreqLimit.", this.IpFreqLimit);
            this.SetParamObj(map, prefix + "MaxAge.", this.MaxAge);
            this.SetParamObj(map, prefix + "Origin.", this.Origin);
            this.SetParamObj(map, prefix + "OriginPullOptimization.", this.OriginPullOptimization);
            this.SetParamObj(map, prefix + "RangeOriginPull.", this.RangeOriginPull);
            this.SetParamObj(map, prefix + "Referer.", this.Referer);
            this.SetParamObj(map, prefix + "RequestHeader.", this.RequestHeader);
            this.SetParamObj(map, prefix + "ResponseHeader.", this.ResponseHeader);
            this.SetParamObj(map, prefix + "ResponseHeaderCache.", this.ResponseHeaderCache);
            this.SetParamObj(map, prefix + "Seo.", this.Seo);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamObj(map, prefix + "StatusCodeCache.", this.StatusCodeCache);
            this.SetParamObj(map, prefix + "VideoSeek.", this.VideoSeek);
            this.SetParamObj(map, prefix + "AwsPrivateAccess.", this.AwsPrivateAccess);
            this.SetParamObj(map, prefix + "OssPrivateAccess.", this.OssPrivateAccess);
        }
    }
}

