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

namespace TencentCloud.Smh.V20210712.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrafficPackage : AbstractModel
    {
        
        /// <summary>
        /// Specifies the instance ID offset by the traffic package.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Dedicated domain name. if the instance has no dedicated domain name, this attribute is null.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Source type of the traffic package. valid values: 0 (purchase), 1 (complimentary).
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Total traffic in Bytes. since the number type has precision limitations, this field is a String type.
        /// </summary>
        [JsonProperty("Size")]
        public string Size{ get; set; }

        /// <summary>
        /// Total traffic in GB.
        /// </summary>
        [JsonProperty("SizeGB")]
        public ulong? SizeGB{ get; set; }

        /// <summary>
        /// Remaining traffic in Bytes. this field is of String type due to precision limitations of numeric data types.
        /// </summary>
        [JsonProperty("Remain")]
        public string Remain{ get; set; }

        /// <summary>
        /// Used traffic in Bytes. since the number type has precision limitations, this field is a String type.
        /// </summary>
        [JsonProperty("Used")]
        public string Used{ get; set; }

        /// <summary>
        /// Usage percentage. since the String type is used due to precision limitations of the number type, this field is of String type.
        /// </summary>
        [JsonProperty("UsedPercentage")]
        public string UsedPercentage{ get; set; }

        /// <summary>
        /// Effective time, the order time of the traffic package.
        /// </summary>
        [JsonProperty("EffectiveTime")]
        public string EffectiveTime{ get; set; }

        /// <summary>
        /// Expiration time, which is the expiration time of the offset instance. if the traffic package offsets a pay-as-you-go or permanently valid instance, this attribute is null.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "SizeGB", this.SizeGB);
            this.SetParamSimple(map, prefix + "Remain", this.Remain);
            this.SetParamSimple(map, prefix + "Used", this.Used);
            this.SetParamSimple(map, prefix + "UsedPercentage", this.UsedPercentage);
            this.SetParamSimple(map, prefix + "EffectiveTime", this.EffectiveTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
        }
    }
}

