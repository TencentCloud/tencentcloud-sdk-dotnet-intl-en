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

    public class EipAddressRelation : AbstractModel
    {
        
        /// <summary>
        /// Region of the Anti-DDoS instance bound to the EIP. For example, hk indicates Hong Kong.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EipAddressRegion")]
        public string EipAddressRegion{ get; set; }

        /// <summary>
        /// ID of the bound resource. For example, an ID may be bound to an CVM instance.
        /// Note: This is field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EipBoundRscIns")]
        public string EipBoundRscIns{ get; set; }

        /// <summary>
        /// ID of the bound ENI
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EipBoundRscEni")]
        public string EipBoundRscEni{ get; set; }

        /// <summary>
        /// Private IP of the bound resource
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EipBoundRscVip")]
        public string EipBoundRscVip{ get; set; }

        /// <summary>
        /// Modification time
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EipAddressRegion", this.EipAddressRegion);
            this.SetParamSimple(map, prefix + "EipBoundRscIns", this.EipBoundRscIns);
            this.SetParamSimple(map, prefix + "EipBoundRscEni", this.EipBoundRscEni);
            this.SetParamSimple(map, prefix + "EipBoundRscVip", this.EipBoundRscVip);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
        }
    }
}

