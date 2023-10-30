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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CDNDomainConfig : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Origin Server Configuration
        /// </summary>
        [JsonProperty("Origin")]
        public Origin Origin{ get; set; }

        /// <summary>
        /// IP blocklist/allowlist configuration. This is disabled by default.
        /// </summary>
        [JsonProperty("IpFilter")]
        public IpFilter IpFilter{ get; set; }

        /// <summary>
        /// UserAgent:blacklist/whitelist configuration.
        /// </summary>
        [JsonProperty("UserAgentFilter")]
        public UserAgentFilter UserAgentFilter{ get; set; }

        /// <summary>
        /// Back to the source 301/302 status code automatically follows the configuration, the default is off
        /// </summary>
        [JsonProperty("FollowRedirect")]
        public FollowRedirect FollowRedirect{ get; set; }

        /// <summary>
        /// Custom request header configuration. This is disabled by default.
        /// </summary>
        [JsonProperty("RequestHeader")]
        public RequestHeader RequestHeader{ get; set; }

        /// <summary>
        /// Custom response header configuration. This is disabled by default.
        /// </summary>
        [JsonProperty("ResponseHeader")]
        public ResponseHeader ResponseHeader{ get; set; }

        /// <summary>
        /// Node cache expiration time configuration.
        /// </summary>
        [JsonProperty("Cache")]
        public Cache Cache{ get; set; }

        /// <summary>
        /// Domain name HTTPS acceleration configuration. This is disabled by default.
        /// </summary>
        [JsonProperty("Https")]
        public Https Https{ get; set; }

        /// <summary>
        /// Timestamp hotlink protection configuration.
        /// </summary>
        [JsonProperty("Authentication")]
        public Authentication Authentication{ get; set; }

        /// <summary>
        /// Access protocol forced redirect configuration. This is disabled by default.
        /// </summary>
        [JsonProperty("ForceRedirect")]
        public ForceRedirect ForceRedirect{ get; set; }

        /// <summary>
        /// Referer blacklist/whitelist configuration. This is disabled by default.
        /// </summary>
        [JsonProperty("Referer")]
        public Referer Referer{ get; set; }

        /// <summary>
        /// Browser cache rule configuration, which is used to set the default value of MaxAge and is disabled by default.
        /// </summary>
        [JsonProperty("MaxAge")]
        public MaxAge MaxAge{ get; set; }

        /// <summary>
        /// IPv6 access configuration.
        /// </summary>
        [JsonProperty("Ipv6Access")]
        public Ipv6Access Ipv6Access{ get; set; }

        /// <summary>
        /// QUIC configuration item.
        /// </summary>
        [JsonProperty("Quic")]
        public Quic Quic{ get; set; }

        /// <summary>
        /// Origin access authentication for S3 bucket.
        /// </summary>
        [JsonProperty("AwsPrivateAccess")]
        public AwsPrivateAccess AwsPrivateAccess{ get; set; }

        /// <summary>
        /// Access authentication configuration for OSS origin.
        /// </summary>
        [JsonProperty("OssPrivateAccess")]
        public OssPrivateAccess OssPrivateAccess{ get; set; }

        /// <summary>
        /// Access authentication for Huawei Cloud OBS origin
        /// </summary>
        [JsonProperty("HwPrivateAccess")]
        public HwPrivateAccess HwPrivateAccess{ get; set; }

        /// <summary>
        /// Origin-pull authentication for other origins.
        /// </summary>
        [JsonProperty("OthersPrivateAccess")]
        public OthersPrivateAccess OthersPrivateAccess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamObj(map, prefix + "Origin.", this.Origin);
            this.SetParamObj(map, prefix + "IpFilter.", this.IpFilter);
            this.SetParamObj(map, prefix + "UserAgentFilter.", this.UserAgentFilter);
            this.SetParamObj(map, prefix + "FollowRedirect.", this.FollowRedirect);
            this.SetParamObj(map, prefix + "RequestHeader.", this.RequestHeader);
            this.SetParamObj(map, prefix + "ResponseHeader.", this.ResponseHeader);
            this.SetParamObj(map, prefix + "Cache.", this.Cache);
            this.SetParamObj(map, prefix + "Https.", this.Https);
            this.SetParamObj(map, prefix + "Authentication.", this.Authentication);
            this.SetParamObj(map, prefix + "ForceRedirect.", this.ForceRedirect);
            this.SetParamObj(map, prefix + "Referer.", this.Referer);
            this.SetParamObj(map, prefix + "MaxAge.", this.MaxAge);
            this.SetParamObj(map, prefix + "Ipv6Access.", this.Ipv6Access);
            this.SetParamObj(map, prefix + "Quic.", this.Quic);
            this.SetParamObj(map, prefix + "AwsPrivateAccess.", this.AwsPrivateAccess);
            this.SetParamObj(map, prefix + "OssPrivateAccess.", this.OssPrivateAccess);
            this.SetParamObj(map, prefix + "HwPrivateAccess.", this.HwPrivateAccess);
            this.SetParamObj(map, prefix + "OthersPrivateAccess.", this.OthersPrivateAccess);
        }
    }
}

