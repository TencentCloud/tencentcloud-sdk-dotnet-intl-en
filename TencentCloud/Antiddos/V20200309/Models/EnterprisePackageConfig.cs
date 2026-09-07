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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnterprisePackageConfig : AbstractModel
    {
        
        /// <summary>
        /// Specifies the region of the anti-ddos pro package.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Number of protected ips.
        /// </summary>
        [JsonProperty("ProtectIpCount")]
        public ulong? ProtectIpCount{ get; set; }

        /// <summary>
        /// Specifies the baseline protection bandwidth.
        /// </summary>
        [JsonProperty("BasicProtectBandwidth")]
        public ulong? BasicProtectBandwidth{ get; set; }

        /// <summary>
        /// Business bandwidth scale.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// Elastic bandwidth in Gbps. valid values: 0, 400, 500, 600, 800, 1000.
        /// The default is 0.
        /// </summary>
        [JsonProperty("ElasticProtectBandwidth")]
        public ulong? ElasticProtectBandwidth{ get; set; }

        /// <summary>
        /// Elastic scaling enabled for business bandwidth.
        /// The default is false.
        /// </summary>
        [JsonProperty("ElasticBandwidthFlag")]
        public bool? ElasticBandwidthFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "ProtectIpCount", this.ProtectIpCount);
            this.SetParamSimple(map, prefix + "BasicProtectBandwidth", this.BasicProtectBandwidth);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "ElasticProtectBandwidth", this.ElasticProtectBandwidth);
            this.SetParamSimple(map, prefix + "ElasticBandwidthFlag", this.ElasticBandwidthFlag);
        }
    }
}

