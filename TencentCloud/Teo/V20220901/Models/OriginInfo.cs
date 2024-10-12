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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginInfo : AbstractModel
    {
        
        /// <summary>
        /// Origin server type, with values:
        /// <li>IP_DOMAIN: IPv4, IPv6, or domain name type origin server;</li>
        /// <li>COS: Tencent Cloud COS origin server;</li>
        /// <li>AWS_S3: AWS S3 origin server;</li>
        /// <li>ORIGIN_GROUP: origin server group type origin server;</li>
        ///  <li>VOD: Video on Demand;</li>
        /// <li>SPACE: origin server uninstallation. Currently only available to the allowlist;</li>
        /// <li>LB: load balancing. Currently only available to the allowlist. </li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Origin server address, which varies according to the value of OriginType:
        /// <li>When OriginType = IP_DOMAIN, fill in an IPv4 address, an IPv6 address, or a domain name;</li>
        /// <li>When OriginType = COS, fill in the access domain name of the COS bucket;</li>
        /// <li>When OriginType = AWS_S3, fill in the access domain name of the S3 bucket;</li>
        /// <li>When OriginType = ORIGIN_GROUP, fill in the origin server group ID;</li>
        /// <li>When OriginType = VOD, fill in the VOD application ID;</li>
        /// <li>When OriginType = LB, fill in the Cloud Load Balancer instance ID. This feature is currently only available to the allowlist;</li>
        /// <li>When OriginType = SPACE, fill in the origin server uninstallation space ID. This feature is currently only available to the allowlist.</li>
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// The ID of the secondary origin group. This parameter is valid only when OriginType is ORIGIN_GROUP. This field indicates the old version capability, which cannot be configured or modified on the control panel after being called. Please submit a ticket if required.
        /// </summary>
        [JsonProperty("BackupOrigin")]
        public string BackupOrigin{ get; set; }

        /// <summary>
        /// Whether access to the private Cloud Object Storage origin server is allowed. This parameter is valid only when OriginType is COS or AWS_S3. Valid values:
        /// <li>on: Enable private authentication;</li>
        /// <li>off: Disable private authentication.</li>
        /// If it is not specified, the default value is off.
        /// </summary>
        [JsonProperty("PrivateAccess")]
        public string PrivateAccess{ get; set; }

        /// <summary>
        /// Private authentication parameter. This parameter is valid only when PrivateAccess is on.
        /// </summary>
        [JsonProperty("PrivateParameters")]
        public PrivateParameter[] PrivateParameters{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "BackupOrigin", this.BackupOrigin);
            this.SetParamSimple(map, prefix + "PrivateAccess", this.PrivateAccess);
            this.SetParamArrayObj(map, prefix + "PrivateParameters.", this.PrivateParameters);
            this.SetParamSimple(map, prefix + "VodeoSubAppId", this.VodeoSubAppId);
            this.SetParamSimple(map, prefix + "VodeoDistributionRange", this.VodeoDistributionRange);
            this.SetParamSimple(map, prefix + "VodeoBucketId", this.VodeoBucketId);
        }
    }
}

