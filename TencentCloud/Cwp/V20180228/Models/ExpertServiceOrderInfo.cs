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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExpertServiceOrderInfo : AbstractModel
    {
        
        /// <summary>
        /// Order ID
        /// </summary>
        [JsonProperty("OrderId")]
        public ulong? OrderId{ get; set; }

        /// <summary>
        /// Order type. 1: emergency; 2: Ultimate Edition important period guarantee; 3: security manager.
        /// </summary>
        [JsonProperty("InquireType")]
        public ulong? InquireType{ get; set; }

        /// <summary>
        /// Number of services
        /// </summary>
        [JsonProperty("InquireNum")]
        public ulong? InquireNum{ get; set; }

        /// <summary>
        /// Service start time
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// Service end time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Service duration, in months
        /// </summary>
        [JsonProperty("ServiceTime")]
        public ulong? ServiceTime{ get; set; }

        /// <summary>
        /// Order status. 0: not started; 1: in service; 2: expired; 3: completed; 4: refunded and terminated.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "InquireType", this.InquireType);
            this.SetParamSimple(map, prefix + "InquireNum", this.InquireNum);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ServiceTime", this.ServiceTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

