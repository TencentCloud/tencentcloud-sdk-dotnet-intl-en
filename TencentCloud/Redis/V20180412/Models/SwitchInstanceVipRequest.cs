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
        /// Source instance ID
        /// </summary>
        [JsonProperty("SrcInstanceId")]
        public string SrcInstanceId{ get; set; }

        /// <summary>
        /// Target instance ID
        /// </summary>
        [JsonProperty("DstInstanceId")]
        public string DstInstanceId{ get; set; }

        /// <summary>
        /// The time that lapses in seconds since DTS is disconnected between the source instance and the target instance. If the DTS disconnection time period is greater than TimeDelay, the VIP will not be switched. We recommend you set an acceptable value based on the actual business conditions.
        /// </summary>
        [JsonProperty("TimeDelay")]
        public long? TimeDelay{ get; set; }

        /// <summary>
        /// Whether to force the switch when DTS is disconnected. 1: yes; 0: no.
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

