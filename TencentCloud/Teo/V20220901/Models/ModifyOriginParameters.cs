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

    public class ModifyOriginParameters : AbstractModel
    {
        
        /// <summary>
        /// The origin type. values:.
        /// <Li>IPDomain: ipv4, ipv6, or domain name type origin server;</li>.
        /// <Li>OriginGroup: origin server group type origin server;</li>.
        /// <Li>LoadBalance: cloud load balancer (clb), this feature is in beta test. to use it, please submit a ticket or contact smart customer service;</li>.
        /// <Li>COS: tencent cloud COS origin server;</li>.
        /// <Li>AWSS3: all object storage origin servers that support the aws s3 protocol.</li>.
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Origin server address, which varies according to the value of origintype:.
        /// <Li>When origintype = ipdomain, fill in an ipv4 address, an ipv6 address, or a domain name;</li>.
        /// <Li>When origintype = cos, please fill in the access domain name of the cos bucket;</li>.
        /// <Li>When origintype = awss3, fill in the access domain name of the s3 bucket;</li>.
        /// <Li>When origintype = origingroup, fill in the origin server group id;</li>.
        /// <Li>When origintype = loadbalance, fill in the cloud load balancer instance id. this feature is currently only available to the allowlist.</li>.
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// Origin-Pull protocol configuration. this parameter is required when origintype is ipdomain, origingroup, or loadbalance. valid values are:.
        /// <Li>Http: use http protocol;</li>.
        /// <Li>Https: use https protocol;</li>.
        /// <Li>Follow: follow the protocol.</li>.
        /// </summary>
        [JsonProperty("OriginProtocol")]
        public string OriginProtocol{ get; set; }

        /// <summary>
        /// Ports for http origin-pull requests. value range: 1-65535. this parameter takes effect only when the origin-pull protocol originprotocol is http or follow.
        /// </summary>
        [JsonProperty("HTTPOriginPort")]
        public long? HTTPOriginPort{ get; set; }

        /// <summary>
        /// Ports for https origin-pull requests. value range: 1-65535. this parameter takes effect only when the origin-pull protocol originprotocol is https or follow.
        /// </summary>
        [JsonProperty("HTTPSOriginPort")]
        public long? HTTPSOriginPort{ get; set; }

        /// <summary>
        /// Whether access to the private object storage origin server is allowed. this parameter is valid only when the origin server type origintype is COS or awss3. valid values:.
        /// <Li>On: enable private authentication;</li>.
        /// <Li>Off: disable private authentication.</li> if not specified, the default value is off.
        /// </summary>
        [JsonProperty("PrivateAccess")]
        public string PrivateAccess{ get; set; }

        /// <summary>
        /// Private authentication parameter. this parameter is valid only when origintype = awss3 and privateaccess = on.
        /// Note: this field may return null, which indicates a failure to obtain a valid value.
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

