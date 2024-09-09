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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStaffStatusMetricsRequest : AbstractModel
    {
        
        /// <summary>
        /// Application ID (required) can be found at https://console.cloud.tencent.com/ccc.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// Filter agent list. By default, do not pass all returned agent information.
        /// </summary>
        [JsonProperty("StaffList")]
        public string[] StaffList{ get; set; }

        /// <summary>
        /// Filter skill group ID list.
        /// </summary>
        [JsonProperty("GroupIdList")]
        public long?[] GroupIdList{ get; set; }

        /// <summary>
        /// Filter agent status list Agent status free Available | busy Busy | rest On Break | notReady Not Ready | afterCallWork Post-call Adjustment | offline Offline
        /// </summary>
        [JsonProperty("StatusList")]
        public string[] StatusList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamArraySimple(map, prefix + "StaffList.", this.StaffList);
            this.SetParamArraySimple(map, prefix + "GroupIdList.", this.GroupIdList);
            this.SetParamArraySimple(map, prefix + "StatusList.", this.StatusList);
        }
    }
}

