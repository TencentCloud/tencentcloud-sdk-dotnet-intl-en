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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePrivateZoneRequest : AbstractModel
    {
        
        /// <summary>
        /// Domain name, which must be in the format of standard TLD
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Tags the private domain when it is created
        /// </summary>
        [JsonProperty("TagSet")]
        public TagInfo[] TagSet{ get; set; }

        /// <summary>
        /// Associates the private domain to a VPC when it is created
        /// </summary>
        [JsonProperty("VpcSet")]
        public VpcInfo[] VpcSet{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Whether to enable subdomain recursive DNS. Valid values: `ENABLED` (default) and `DISABLED`.
        /// </summary>
        [JsonProperty("DnsForwardStatus")]
        public string DnsForwardStatus{ get; set; }

        /// <summary>
        /// Associates the private domain to a VPC when it is created
        /// </summary>
        [JsonProperty("Vpcs")]
        [System.Obsolete]
        public VpcInfo[] Vpcs{ get; set; }

        /// <summary>
        /// List of authorized accounts' VPCs to associate with the private domain
        /// </summary>
        [JsonProperty("AccountVpcSet")]
        public AccountVpcInfo[] AccountVpcSet{ get; set; }

        /// <summary>
        /// Whether to enable CNAME flattening. Valid values: `ENABLED` (default) and `DISABLED`.
        /// </summary>
        [JsonProperty("CnameSpeedupStatus")]
        public string CnameSpeedupStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamArrayObj(map, prefix + "VpcSet.", this.VpcSet);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "DnsForwardStatus", this.DnsForwardStatus);
            this.SetParamArrayObj(map, prefix + "Vpcs.", this.Vpcs);
            this.SetParamArrayObj(map, prefix + "AccountVpcSet.", this.AccountVpcSet);
            this.SetParamSimple(map, prefix + "CnameSpeedupStatus", this.CnameSpeedupStatus);
        }
    }
}

