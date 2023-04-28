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

    public class AddCdnDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// Domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Acceleration domain name service type
        /// `web`: Webpage file downloads
        /// `download`: Large file downloads
        /// `media`: Audio and video on demand acceleration
        /// `hybrid`: Dynamic and static content acceleration
        /// `dynamic`: Dynamic content acceleration
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// Origin server configuration
        /// </summary>
        [JsonProperty("Origin")]
        public Origin Origin{ get; set; }

        /// <summary>
        /// Project ID. Default value: 0, indicating `Default Project`
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// IP blocklist/allowlist
        /// </summary>
        [JsonProperty("IpFilter")]
        public IpFilter IpFilter{ get; set; }

        /// <summary>
        /// IP rate limiting
        /// </summary>
        [JsonProperty("IpFreqLimit")]
        public IpFreqLimit IpFreqLimit{ get; set; }

        /// <summary>
        /// Status code cache
        /// </summary>
        [JsonProperty("StatusCodeCache")]
        public StatusCodeCache StatusCodeCache{ get; set; }

        /// <summary>
        /// Smart compression
        /// </summary>
        [JsonProperty("Compression")]
        public Compression Compression{ get; set; }

        /// <summary>
        /// Bandwidth cap configuration
        /// </summary>
        [JsonProperty("BandwidthAlert")]
        public BandwidthAlert BandwidthAlert{ get; set; }

        /// <summary>
        /// Range GETs configuration
        /// </summary>
        [JsonProperty("RangeOriginPull")]
        public RangeOriginPull RangeOriginPull{ get; set; }

        /// <summary>
        /// 301/302 origin-pull follow-redirect configuration
        /// </summary>
        [JsonProperty("FollowRedirect")]
        public FollowRedirect FollowRedirect{ get; set; }

        /// <summary>
        /// Error code redirection (in beta)
        /// </summary>
        [JsonProperty("ErrorPage")]
        public ErrorPage ErrorPage{ get; set; }

        /// <summary>
        /// Request header configuration
        /// </summary>
        [JsonProperty("RequestHeader")]
        public RequestHeader RequestHeader{ get; set; }

        /// <summary>
        /// Response header configuration
        /// </summary>
        [JsonProperty("ResponseHeader")]
        public ResponseHeader ResponseHeader{ get; set; }

        /// <summary>
        /// Download speed configuration
        /// </summary>
        [JsonProperty("DownstreamCapping")]
        public DownstreamCapping DownstreamCapping{ get; set; }

        /// <summary>
        /// Node cache key configuration
        /// </summary>
        [JsonProperty("CacheKey")]
        public CacheKey CacheKey{ get; set; }

        /// <summary>
        /// Header cache configuration
        /// </summary>
        [JsonProperty("ResponseHeaderCache")]
        public ResponseHeaderCache ResponseHeaderCache{ get; set; }

        /// <summary>
        /// Video dragging configuration
        /// </summary>
        [JsonProperty("VideoSeek")]
        public VideoSeek VideoSeek{ get; set; }

        /// <summary>
        /// Cache validity configuration
        /// </summary>
        [JsonProperty("Cache")]
        public Cache Cache{ get; set; }

        /// <summary>
        /// Cross-MLC-border origin-pull optimization
        /// </summary>
        [JsonProperty("OriginPullOptimization")]
        public OriginPullOptimization OriginPullOptimization{ get; set; }

        /// <summary>
        /// HTTPS acceleration
        /// </summary>
        [JsonProperty("Https")]
        public Https Https{ get; set; }

        /// <summary>
        /// Timestamp hotlink protection
        /// </summary>
        [JsonProperty("Authentication")]
        public Authentication Authentication{ get; set; }

        /// <summary>
        /// SEO optimization
        /// </summary>
        [JsonProperty("Seo")]
        public Seo Seo{ get; set; }

        /// <summary>
        /// Force redirect by access protocol
        /// </summary>
        [JsonProperty("ForceRedirect")]
        public ForceRedirect ForceRedirect{ get; set; }

        /// <summary>
        /// Referer hotlink protection
        /// </summary>
        [JsonProperty("Referer")]
        public Referer Referer{ get; set; }

        /// <summary>
        /// Browser caching (in beta)
        /// </summary>
        [JsonProperty("MaxAge")]
        public MaxAge MaxAge{ get; set; }

        /// <summary>
        /// IPv6 configuration (This feature is in beta and not generally available yet.)
        /// </summary>
        [JsonProperty("Ipv6")]
        public Ipv6 Ipv6{ get; set; }

        /// <summary>
        /// Specific region configuration
        /// Applicable to cases where the acceleration domain name configuration differs for regions in and outside mainland China.
        /// </summary>
        [JsonProperty("SpecificConfig")]
        public SpecificConfig SpecificConfig{ get; set; }

        /// <summary>
        /// Domain name acceleration region
        /// mainland: acceleration inside mainland China
        /// overseas: acceleration outside mainland China
        /// global: global acceleration
        /// Overseas acceleration service must be enabled to use overseas acceleration and global acceleration.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Origin-pull timeout configuration
        /// </summary>
        [JsonProperty("OriginPullTimeout")]
        public OriginPullTimeout OriginPullTimeout{ get; set; }

        /// <summary>
        /// Tag configuration
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// Ipv6 access configuration
        /// </summary>
        [JsonProperty("Ipv6Access")]
        public Ipv6Access Ipv6Access{ get; set; }

        /// <summary>
        /// Offline cache
        /// </summary>
        [JsonProperty("OfflineCache")]
        public OfflineCache OfflineCache{ get; set; }

        /// <summary>
        /// QUIC access, which is a paid service. You can check the product document and Billing Overview for more information.
        /// </summary>
        [JsonProperty("Quic")]
        public Quic Quic{ get; set; }

        /// <summary>
        /// Access authentication for S3 origin
        /// </summary>
        [JsonProperty("AwsPrivateAccess")]
        public AwsPrivateAccess AwsPrivateAccess{ get; set; }

        /// <summary>
        /// Access authentication for OSS origin
        /// </summary>
        [JsonProperty("OssPrivateAccess")]
        public OssPrivateAccess OssPrivateAccess{ get; set; }

        /// <summary>
        /// Origin-pull authentication for Huawei Cloud OBS origin
        /// </summary>
        [JsonProperty("HwPrivateAccess")]
        public HwPrivateAccess HwPrivateAccess{ get; set; }

        /// <summary>
        /// Origin-pull authentication for Qiniu Cloud Kodo origin
        /// </summary>
        [JsonProperty("QnPrivateAccess")]
        public QnPrivateAccess QnPrivateAccess{ get; set; }

        /// <summary>
        /// Origin-pull authentication for other origins
        /// </summary>
        [JsonProperty("OthersPrivateAccess")]
        public OthersPrivateAccess OthersPrivateAccess{ get; set; }

        /// <summary>
        /// HTTPS (enabled by default), which is a paid service. You can check the product document and Billing Overview for more information.
        /// </summary>
        [JsonProperty("HttpsBilling")]
        public HttpsBilling HttpsBilling{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamObj(map, prefix + "Origin.", this.Origin);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamObj(map, prefix + "IpFilter.", this.IpFilter);
            this.SetParamObj(map, prefix + "IpFreqLimit.", this.IpFreqLimit);
            this.SetParamObj(map, prefix + "StatusCodeCache.", this.StatusCodeCache);
            this.SetParamObj(map, prefix + "Compression.", this.Compression);
            this.SetParamObj(map, prefix + "BandwidthAlert.", this.BandwidthAlert);
            this.SetParamObj(map, prefix + "RangeOriginPull.", this.RangeOriginPull);
            this.SetParamObj(map, prefix + "FollowRedirect.", this.FollowRedirect);
            this.SetParamObj(map, prefix + "ErrorPage.", this.ErrorPage);
            this.SetParamObj(map, prefix + "RequestHeader.", this.RequestHeader);
            this.SetParamObj(map, prefix + "ResponseHeader.", this.ResponseHeader);
            this.SetParamObj(map, prefix + "DownstreamCapping.", this.DownstreamCapping);
            this.SetParamObj(map, prefix + "CacheKey.", this.CacheKey);
            this.SetParamObj(map, prefix + "ResponseHeaderCache.", this.ResponseHeaderCache);
            this.SetParamObj(map, prefix + "VideoSeek.", this.VideoSeek);
            this.SetParamObj(map, prefix + "Cache.", this.Cache);
            this.SetParamObj(map, prefix + "OriginPullOptimization.", this.OriginPullOptimization);
            this.SetParamObj(map, prefix + "Https.", this.Https);
            this.SetParamObj(map, prefix + "Authentication.", this.Authentication);
            this.SetParamObj(map, prefix + "Seo.", this.Seo);
            this.SetParamObj(map, prefix + "ForceRedirect.", this.ForceRedirect);
            this.SetParamObj(map, prefix + "Referer.", this.Referer);
            this.SetParamObj(map, prefix + "MaxAge.", this.MaxAge);
            this.SetParamObj(map, prefix + "Ipv6.", this.Ipv6);
            this.SetParamObj(map, prefix + "SpecificConfig.", this.SpecificConfig);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamObj(map, prefix + "OriginPullTimeout.", this.OriginPullTimeout);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamObj(map, prefix + "Ipv6Access.", this.Ipv6Access);
            this.SetParamObj(map, prefix + "OfflineCache.", this.OfflineCache);
            this.SetParamObj(map, prefix + "Quic.", this.Quic);
            this.SetParamObj(map, prefix + "AwsPrivateAccess.", this.AwsPrivateAccess);
            this.SetParamObj(map, prefix + "OssPrivateAccess.", this.OssPrivateAccess);
            this.SetParamObj(map, prefix + "HwPrivateAccess.", this.HwPrivateAccess);
            this.SetParamObj(map, prefix + "QnPrivateAccess.", this.QnPrivateAccess);
            this.SetParamObj(map, prefix + "OthersPrivateAccess.", this.OthersPrivateAccess);
            this.SetParamObj(map, prefix + "HttpsBilling.", this.HttpsBilling);
        }
    }
}

