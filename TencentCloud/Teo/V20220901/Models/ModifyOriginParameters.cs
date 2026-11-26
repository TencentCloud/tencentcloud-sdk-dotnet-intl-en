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

    public class ModifyOriginParameters : AbstractModel
    {
        
        /// <summary>
        /// Origin server type. Valid values:
        /// <li>IPDomain: IPV4, IPV6, or domain type origin server;</li>
        /// <li>OriginGroup: origin server group type origin server;</li>
        /// <li>LoadBalance: load balancing. This feature is in beta test. If needed, submit a ticket;</li>
        /// <li>COS: Tencent Cloud COS origin server;</li>
        /// <li>AWSS3: supports all COS origin servers using the AWS S3 protocol.</li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Origin server address, which varies according to the value of OriginType:
        /// <li>When OriginType = IPDomain, fill in an IPV4 address, an IPV6 address, or a domain name;</li>
        /// <li>When OriginType = COS, specify the access domain of the COS bucket;</li>
        /// <li>When OriginType = AWSS3, fill in the access domain name of the S3 bucket;</li>
        /// <li>When OriginType = OriginGroup, fill in the origin server group ID. As an output parameter, if an origin server group from another site is referenced, the format is {origin server group ID}@{ZoneID}. For example: og-testorigin@zone-38moq1z10wwwy;</li>
        /// <li>When OriginType = LoadBalance, specify the Cloud Load Balancer instance ID. This feature is currently only available to the allowlist. As an output parameter, if a load balancer from another site is referenced, the format is {load balancer ID}@{ZoneID}. For example: lb-2rxpamcyqfzg@zone-38moq1z10wwwy.</li>
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// Origin-pull protocol configuration. This parameter is required when OriginType is IPDomain, OriginGroup, or LoadBalance. Valid values:
        /// <li>http: use HTTP protocol;</li>
        /// <li>https: Use HTTPS protocol;</li>
        /// <li>follow: follow protocol.</li>
        /// </summary>
        [JsonProperty("OriginProtocol")]
        public string OriginProtocol{ get; set; }

        /// <summary>
        /// HTTP origin-pull port, value ranges from 1 to 65535. This parameter is required when the origin-pull protocol OriginProtocol is http or follow.
        /// </summary>
        [JsonProperty("HTTPOriginPort")]
        public long? HTTPOriginPort{ get; set; }

        /// <summary>
        /// HTTPS origin-pull port, value range: 1–65535. This parameter is required when OriginProtocol is https or follow.
        /// </summary>
        [JsonProperty("HTTPSOriginPort")]
        public long? HTTPSOriginPort{ get; set; }

        /// <summary>
        /// Whether access to the private object storage origin server is allowed. This parameter is required when the origin server type OriginType is COS or AWSS3. Valid values:
        /// <li>on: Enable private authentication;</li>
        /// <li>off: Disable private authentication. </li>
        /// </summary>
        [JsonProperty("PrivateAccess")]
        public string PrivateAccess{ get; set; }

        /// <summary>
        /// Private authentication parameter. This parameter is valid only when OriginType = AWSS3 and PrivateAccess = on.
        /// </summary>
        [JsonProperty("PrivateParameters")]
        public OriginPrivateParameters PrivateParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "OriginProtocol", this.OriginProtocol);
            this.SetParamSimple(map, prefix + "HTTPOriginPort", this.HTTPOriginPort);
            this.SetParamSimple(map, prefix + "HTTPSOriginPort", this.HTTPSOriginPort);
            this.SetParamSimple(map, prefix + "PrivateAccess", this.PrivateAccess);
            this.SetParamObj(map, prefix + "PrivateParameters.", this.PrivateParameters);
        }
    }
}

