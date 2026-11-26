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

    public class OriginInfo : AbstractModel
    {
        
        /// <summary>
        /// Origin server type. Valid values:
        /// <li>IP_DOMAIN: IPV4, IPV6, or DOMAIN name type origin server;</li>
        /// <li>COS: Tencent Cloud COS origin server;</li>
        /// <li>AWS_S3: AWS S3 COS origin server;</li>
        /// <li>ORIGIN_GROUP: origin server group type origin server;</li>
        /// <li>VOD: Video on Demand;</li>
        /// <li>SPACE: origin server uninstallation. Currently only available to the allowlist;</li>
        /// <li>LB: load balancing. Currently only available to the allowlist. </li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Origin server address, which varies according to the value of OriginType:
        /// <li>When OriginType = IP_DOMAIN, this parameter should be an IPv4 address, an IPv6 address, or a domain name;</li>
        /// <li>When OriginType = COS, this parameter is the access domain name of the COS bucket;</li>
        /// <li>When OriginType = AWS_S3, this parameter should be the access domain name of the S3 bucket;</li>
        /// <li>When OriginType = ORIGIN_GROUP, this parameter should be the origin server group ID. If you reference an origin server group from another site, use the format {origin server group ID}@{ZoneID}. For example: og-testorigin@zone-38moq1z10wwwy;</li>
        /// <li>When OriginType = VOD, this parameter is the VOD application ID;</li>
        /// <li>When OriginType = LB, this parameter is the Cloud Load Balancer instance ID. This feature is currently only available to the allowlist. If a load balancer from another site is referenced, the format is {load balancer ID}@{ZoneID}. For example: lb-2rxpamcyqfzg@zone-38moq1z10wwwy;</li>
        /// <li>When OriginType = SPACE, this parameter is the origin server uninstallation space ID. This feature is currently only available to the allowlist.</li>
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// Secondary origin group ID. This parameter is valid only when OriginType = ORIGIN_GROUP. This field indicates the old version capability. After calling, you cannot modify the configuration in the console. If needed, submit a ticket for consultation.
        /// </summary>
        [JsonProperty("BackupOrigin")]
        public string BackupOrigin{ get; set; }

        /// <summary>
        /// Whether access to the private object storage origin server is allowed. This parameter is valid only when the origin server type OriginType is COS or AWS_S3. Valid values:
        /// <li>on: Enable private authentication;</li>
        /// <li>off: Disable private authentication. </li>If left empty, the default value is off.
        /// </summary>
        [JsonProperty("PrivateAccess")]
        public string PrivateAccess{ get; set; }

        /// <summary>
        /// Private authentication parameter. This parameter is valid only when the origin server type is PrivateAccess = on.
        /// </summary>
        [JsonProperty("PrivateParameters")]
        public PrivateParameter[] PrivateParameters{ get; set; }

        /// <summary>
        /// Custom origin server HOST header. This parameter is valid only when OriginType is IP_DOMAIN. For other origin server types, this parameter is not required, otherwise an error will be reported.
        /// When OriginType is COS or AWS_S3, the origin-pull HOST header remains the same as the origin server domain name.
        /// When OriginType = ORIGIN_GROUP, the origin-pull HOST header follows the configuration in the origin group. If there is no configuration, it defaults to the acceleration domain name.
        /// When OriginType is VOD or SPACE, no configuration is required for this header. It takes effect based on the corresponding origin server domain name.
        /// </summary>
        [JsonProperty("HostHeader")]
        public string HostHeader{ get; set; }

        /// <summary>
        /// VODEO sub-application ID. This parameter is required when OriginType is VODEO.
        /// </summary>
        [JsonProperty("VodeoSubAppId")]
        [System.Obsolete]
        public long? VodeoSubAppId{ get; set; }

        /// <summary>
        /// VOD on EO distribution range. This parameter is required when OriginType = VODEO. Valid values: 
        /// <li>All: all buckets under the current application;</li> 
        /// <li>Bucket: a specified bucket.</li>
        /// </summary>
        [JsonProperty("VodeoDistributionRange")]
        [System.Obsolete]
        public string VodeoDistributionRange{ get; set; }

        /// <summary>
        /// VODEO storage bucket ID. This parameter is required when OriginType is VODEO and VodeoDistributionRange is Bucket.
        /// </summary>
        [JsonProperty("VodeoBucketId")]
        [System.Obsolete]
        public string VodeoBucketId{ get; set; }

        /// <summary>
        /// VOD origin-pull scope. This parameter is valid only when OriginType = VOD. Valid values: <li>all: all files in the VOD application corresponding to the current origin server;</li><li>bucket: files in a specified bucket under the VOD application corresponding to the current origin server. Specify the bucket with the VodBucketId parameter.</li>If left empty, the default value is all.
        /// </summary>
        [JsonProperty("VodOriginScope")]
        public string VodOriginScope{ get; set; }

        /// <summary>
        /// VOD bucket ID. This parameter is required when OriginType = VOD and VodOriginScope = bucket. Data source: storage ID of a bucket under a VOD professional application.
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

