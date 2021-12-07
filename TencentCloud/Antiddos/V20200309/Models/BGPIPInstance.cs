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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BGPIPInstance : AbstractModel
    {
        
        /// <summary>
        /// Anti-DDoS instance details
        /// </summary>
        [JsonProperty("InstanceDetail")]
        public InstanceRelation InstanceDetail{ get; set; }

        /// <summary>
        /// Anti-DDoS instance specifications
        /// </summary>
        [JsonProperty("SpecificationLimit")]
        public BGPIPInstanceSpecification SpecificationLimit{ get; set; }

        /// <summary>
        /// Anti-DDoS instance usage statistics
        /// </summary>
        [JsonProperty("Usage")]
        public BGPIPInstanceUsages Usage{ get; set; }

        /// <summary>
        /// Region of the Anti-DDoS instance
        /// </summary>
        [JsonProperty("Region")]
        public RegionInfo Region{ get; set; }

        /// <summary>
        /// Status of the Anti-DDoS instance. Valid values:
        /// `idle`: running
        /// `attacking`: under attacks
        /// `blocking`: blocked
        /// `creating`: creating
        /// `deblocking`: unblocking
        /// `isolate`: reprocessed and isolated
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Purchase time
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// Expired At
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Name of the Anti-DDoS instance
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Package details of the Anti-DDoS instance.
        /// Note: This field is `null` for an Anti-DDoS instance without using a package.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PackInfo")]
        public PackInfo PackInfo{ get; set; }

        /// <summary>
        /// Non-BGP package details of the Anti-DDoS instance.
        /// Note: This field is `null` for an Anti-DDoS instance without using a non-BGP package.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("StaticPackRelation")]
        public StaticPackRelation StaticPackRelation{ get; set; }

        /// <summary>
        /// Specifies the ISP. `0`: Chinese mainland ISPs (default); `1`：Radware；`2`: Tencent; `3`: NSFOCUS. Note that `1`, `2` and `3` are used for services outside the Chinese mainland.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// Used to differentiate clusters
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Tgw")]
        public ulong? Tgw{ get; set; }

        /// <summary>
        /// EIP states: `CREATING`, `BINDING`, `BIND`, `UNBINDING`, `UNBIND`, `OFFLINING`, and `BIND_ENI`. The EIP must be bound to an Anti-DDoS Advanced instance.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EipAddressStatus")]
        public string EipAddressStatus{ get; set; }

        /// <summary>
        /// Whether it is an Anti-DDoS EIP instance. `1`: Yes; `0`: No.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EipFlag")]
        public long? EipFlag{ get; set; }

        /// <summary>
        /// EIP package details of the Anti-DDoS Advanced instance.
        /// Note: This field is `null` for an Anti-DDoS Advanced instance without using an EIP package.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EipAddressPackRelation")]
        public EipAddressPackRelation EipAddressPackRelation{ get; set; }

        /// <summary>
        /// Details of the Anti-DDoS Advanced instance bound to the EIP.
        /// Note: This field is `null` if the EIP is not bound to an Anti-DDoS Advanced instance.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EipAddressInfo")]
        public EipAddressRelation EipAddressInfo{ get; set; }

        /// <summary>
        /// Recommended domain name for clients to access.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Whether to enable Sec-MCA. Valid values: `1` (enabled) and `0` (disabled).
        /// </summary>
        [JsonProperty("DamDDoSStatus")]
        public ulong? DamDDoSStatus{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("V6Flag")]
        public ulong? V6Flag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "InstanceDetail.", this.InstanceDetail);
            this.SetParamObj(map, prefix + "SpecificationLimit.", this.SpecificationLimit);
            this.SetParamObj(map, prefix + "Usage.", this.Usage);
            this.SetParamObj(map, prefix + "Region.", this.Region);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "PackInfo.", this.PackInfo);
            this.SetParamObj(map, prefix + "StaticPackRelation.", this.StaticPackRelation);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Tgw", this.Tgw);
            this.SetParamSimple(map, prefix + "EipAddressStatus", this.EipAddressStatus);
            this.SetParamSimple(map, prefix + "EipFlag", this.EipFlag);
            this.SetParamObj(map, prefix + "EipAddressPackRelation.", this.EipAddressPackRelation);
            this.SetParamObj(map, prefix + "EipAddressInfo.", this.EipAddressInfo);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DamDDoSStatus", this.DamDDoSStatus);
            this.SetParamSimple(map, prefix + "V6Flag", this.V6Flag);
        }
    }
}

