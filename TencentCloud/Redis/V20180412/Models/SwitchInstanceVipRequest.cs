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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SwitchInstanceVipRequest : AbstractModel
    {
        
        /// <summary>
        /// Source instance ID. Log in to the [Redis console](https://console.tencentcloud.com/redis/instance) and copy it in the instance list.
        /// </summary>
        [JsonProperty("SrcInstanceId")]
        public string SrcInstanceId{ get; set; }

        /// <summary>
        /// Target instance ID. Log in to the [Redis console](https://console.tencentcloud.com/redis/instance) and copy it in the instance list.
        /// </summary>
        [JsonProperty("DstInstanceId")]
        public string DstInstanceId{ get; set; }

        /// <summary>
        /// DTS disconnection time between the source instance and target instance. Unit: second. If the DTS disconnection time exceeds TimeDelay, the VIP will not be switched. It is recommended to set an acceptable value based on business needs.
        /// </summary>
        [JsonProperty("TimeDelay")]
        public long? TimeDelay{ get; set; }

        /// <summary>
        /// Whether to force a switch in the case of a DTS disconnection.
        /// - 1: Force the switch.
        /// - 0: Do not force the switch.
        /// </summary>
        [JsonProperty("ForceSwitch")]
        public long? ForceSwitch{ get; set; }

        /// <summary>
        /// now: switch now; syncComplete: switch after sync is completed
        /// </summary>
        [JsonProperty("SwitchTime")]
        public string SwitchTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcInstanceId", this.SrcInstanceId);
            this.SetParamSimple(map, prefix + "DstInstanceId", this.DstInstanceId);
            this.SetParamSimple(map, prefix + "TimeDelay", this.TimeDelay);
            this.SetParamSimple(map, prefix + "ForceSwitch", this.ForceSwitch);
            this.SetParamSimple(map, prefix + "SwitchTime", this.SwitchTime);
        }
    }
}

