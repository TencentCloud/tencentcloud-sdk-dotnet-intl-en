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

    public class OriginDetail : AbstractModel
    {
        
        /// <summary>
        /// Origin server type. Valid values:
        /// <li>IP_DOMAIN: IPv4, IPv6, or domain name type origin server;</li>
        /// <li>COS: Tencent Cloud COS origin server;</li>
        /// <li>AWS_S3: AWS S3 COS origin server;</li>
        /// <li>ORIGIN_GROUP: origin server group;</li>
        /// <li>VOD: Video on Demand;</li>
        /// <li>SPACE: origin server uninstallation, currently only available to the allowlist;</li>
        /// <li>LB: load balancing. Currently only available to the allowlist. </li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Origin server address, which varies with the value of OriginType:
        /// <li>When OriginType = IP_DOMAIN, this parameter is an IPv4 address, an IPv6 address, or a domain name.</li>
        /// <li>When OriginType = COS, this parameter is the access domain name of the COS bucket.</li>
        /// <li>When OriginType = AWS_S3, this parameter is the access domain name of the S3 bucket.</li>
        /// <li>When OriginType = ORIGIN_GROUP, this parameter is the origin server group ID.</li>
        /// <li>When OriginType = VOD, this parameter is the VOD application ID.</li>
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// Secondary origin group ID. This parameter is valid only when OriginType is ORIGIN_GROUP and a secondary origin group is configured.
        /// </summary>
        [JsonProperty("BackupOrigin")]
        public string BackupOrigin{ get; set; }

        /// <summary>
        /// Primary origin group name. This parameter returns a value when OriginType is ORIGIN_GROUP.
        /// </summary>
        [JsonProperty("OriginGroupName")]
        public string OriginGroupName{ get; set; }

        /// <summary>
        /// Secondary origin group name. This parameter is valid only when OriginType is ORIGIN_GROUP and a secondary origin group is configured.
        /// </summary>
        [JsonProperty("BackOriginGroupName")]
        public string BackOriginGroupName{ get; set; }

        /// <summary>
        /// Whether access to the private object storage origin server is allowed. This parameter is valid only when the origin server type OriginType is COS or AWS_S3. Valid values:
        /// <li>on: Enable private authentication;</li>
        /// <li>off: Disable private authentication. </li>
        /// If this field is not specified, the default value 'off' will be used.
        /// </summary>
        [JsonProperty("PrivateAccess")]
        public string PrivateAccess{ get; set; }

        /// <summary>
        /// Private authentication parameter. This parameter is valid only when PrivateAccess is on.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PrivateParameters")]
        public PrivateParameter[] PrivateParameters{ get; set; }

        /// <summary>
        /// Specifies the current configuration of the origin-pull HOST header.
        /// </summary>
        [JsonProperty("HostHeader")]
        public string HostHeader{ get; set; }

        /// <summary>
        /// MO sub-application ID
        /// </summary>
        [JsonProperty("VodeoSubAppId")]
        [System.Obsolete]
        public long? VodeoSubAppId{ get; set; }

        /// <summary>
        /// MO distribution range. Valid values: <li>All: all</li> <li>Bucket: bucket</li>
        /// </summary>
        [JsonProperty("VodeoDistributionRange")]
        [System.Obsolete]
        public string VodeoDistributionRange{ get; set; }

        /// <summary>
        /// MO bucket ID, required when the distribution range (DistributionRange) is bucket (Bucket)
        /// </summary>
        [JsonProperty("VodeoBucketId")]
        [System.Obsolete]
        public string VodeoBucketId{ get; set; }

        /// <summary>
        /// VOD origin-pull range. this parameter returns a value when OriginType = VOD. valid values: <li>all: all files in the VOD application corresponding to the current origin server. the default value is all;</li> <li>bucket: files in a specified bucket under the VOD application corresponding to the current origin server. specify the bucket by the VodBucketId parameter.</li>.
        /// </li>
        /// </summary>
        [JsonProperty("VodOriginScope")]
        public string VodOriginScope{ get; set; }

        /// <summary>
        /// VOD bucket ID. this parameter is required when OriginType = VOD and VodOriginScope = bucket. data source: storage ID of the bucket under the VOD professional application.
        /// </summary>
        [JsonProperty("VodBucketId")]
        public string VodBucketId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "BackupOrigin", this.BackupOrigin);
            this.SetParamSimple(map, prefix + "OriginGroupName", this.OriginGroupName);
            this.SetParamSimple(map, prefix + "BackOriginGroupName", this.BackOriginGroupName);
            this.SetParamSimple(map, prefix + "PrivateAccess", this.PrivateAccess);
            this.SetParamArrayObj(map, prefix + "PrivateParameters.", this.PrivateParameters);
            this.SetParamSimple(map, prefix + "HostHeader", this.HostHeader);
            this.SetParamSimple(map, prefix + "VodeoSubAppId", this.VodeoSubAppId);
            this.SetParamSimple(map, prefix + "VodeoDistributionRange", this.VodeoDistributionRange);
            this.SetParamSimple(map, prefix + "VodeoBucketId", this.VodeoBucketId);
            this.SetParamSimple(map, prefix + "VodOriginScope", this.VodOriginScope);
            this.SetParamSimple(map, prefix + "VodBucketId", this.VodBucketId);
        }
    }
}

