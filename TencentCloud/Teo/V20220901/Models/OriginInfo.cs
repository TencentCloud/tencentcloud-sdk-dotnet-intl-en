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
        /// <li>IP_DOMAIN: IPV4, IPV6, or DOMAIN type origin server.</li>.
        /// <Li>COS: tencent cloud cos origin server;</li>.
        /// <Li>AWS_S3: aws s3 cos origin server;</li>.
        /// <Li>ORIGIN_GROUP: origin server group type origin server;</li>.
        /// <Li>VOD: video on demand;</li>.
        /// <Li>SPACE: origin server uninstallation. currently only available to the allowlist;</li>.
        /// <li>LB: load balancing. Currently only available to the allowlist. </li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Origin server address, which varies according to the value of OriginType:.
        /// <li>When OriginType = IP_DOMAIN, this parameter should be an IPv4 address, an IPv6 address, or a DOMAIN name;</li>.
        /// <li>When OriginType = COS, this parameter is the access domain of the COS bucket;</li>.
        /// <li>When OriginType = AWS_S3, this parameter is the access domain of the S3 bucket;</li>.
        /// <li>When OriginType = ORIGIN_GROUP, this parameter should be the ORIGIN server GROUP ID. if referencing an ORIGIN server GROUP from other sites, the format is {ORIGIN server GROUP ID}@{ZoneID}, such as og-testorigin@zone-38moq1z10wwwy;</li>.
        /// <li>When OriginType = VOD, this parameter is the VOD application ID;</li>.
        /// <li>When OriginType = LB, this parameter is the cloud load balancer instance ID. this feature is currently only available to the allowlist. if referencing a load balancer from other sites, the format is {cloud load balancer ID}@{ZoneID}, such as LB-2rxpamcyqfzg@zone-38moq1z10wwwy;</li>.
        /// <li>When OriginType = SPACE, this parameter specifies the origin server uninstallation SPACE ID. this feature is currently only available to the allowlist.</li>.
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// The ID of the secondary origin group. This parameter is valid only when OriginType is ORIGIN_GROUP. This field indicates the old version capability, which cannot be configured or modified on the control panel after being called. Please submit a ticket if required.
        /// </summary>
        [JsonProperty("BackupOrigin")]
        public string BackupOrigin{ get; set; }

        /// <summary>
        /// Whether access to the private object storage origin server is allowed. this parameter is valid only when the origin server type OriginType is COS or AWS_S3. valid values:.
        /// <Li>On: enable private authentication;</li>.
        /// <Li>Off: disable private authentication.</li>if left empty, the default value is off.
        /// </summary>
        [JsonProperty("PrivateAccess")]
        public string PrivateAccess{ get; set; }

        /// <summary>
        /// Private authentication parameter. This parameter is valid only when PrivateAccess is on.
        /// </summary>
        [JsonProperty("PrivateParameters")]
        public PrivateParameter[] PrivateParameters{ get; set; }

        /// <summary>
        /// Custom origin server HOST header. this parameter is valid only when OriginType = IP_DOMAIN. when OriginType is other types, this parameter is not required, otherwise error will occur.
        /// When OriginType is COS or AWS_S3, the origin-pull HOST header will remain consistent with the origin server domain name.
        /// When OriginType is ORIGIN_GROUP, the HOST header follows the ORIGIN site GROUP configuration. if not configured, it defaults to the acceleration domain name.
        /// When OriginType is VOD or SPACE, no configuration required for this header, the corresponding domain name takes effect.
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
        /// VOD on EO distribution range. This parameter is required when OriginType = VODEO. The values are: 
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
        /// VOD origin range. this parameter is valid only when OriginType = VOD. valid values: <li>all: all files in the VOD application corresponding to the current origin server.</li><li>bucket: files in a specified bucket under the VOD application corresponding to the current origin server. use parameter VodBucketId to specify the bucket.</li>default value is all if left empty.
        /// </summary>
        [JsonProperty("VodOriginScope")]
        public string VodOriginScope{ get; set; }

        /// <summary>
        /// VOD bucket ID. this parameter is required when OriginType = VOD and VodOriginScope = bucket. data source: storage ID of the bucket under the VOD professional edition application.
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

