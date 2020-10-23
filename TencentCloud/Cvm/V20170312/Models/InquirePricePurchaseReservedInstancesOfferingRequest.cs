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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquirePricePurchaseReservedInstancesOfferingRequest : AbstractModel
    {
        
        /// <summary>
        /// The number of the reserved instances you are purchasing.
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// The ID of the reserved instance offering.
        /// </summary>
        [JsonProperty("ReservedInstancesOfferingId")]
        public string ReservedInstancesOfferingId{ get; set; }

        /// <summary>
        /// Dry run.
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// A unique string supplied by the client to ensure that the request is idempotent. Its maximum length is 64 ASCII characters. If this parameter is not specified, the idempotency of the request cannot be guaranteed.<br>For more information, see Ensuring Idempotency.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// Reserved instance name.<br><li>The RI name defaults to “unnamed” if this parameter is left empty.</li><li>You can enter any name within 60 characters (including the pattern string).</li>
        /// </summary>
        [JsonProperty("ReservedInstanceName")]
        public string ReservedInstanceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "ReservedInstancesOfferingId", this.ReservedInstancesOfferingId);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "ReservedInstanceName", this.ReservedInstanceName);
        }
    }
}

