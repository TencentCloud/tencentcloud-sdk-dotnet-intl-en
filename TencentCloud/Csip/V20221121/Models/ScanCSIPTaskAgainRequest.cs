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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanCSIPTaskAgainRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Scan task ID.</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Limit the target host list for this rescan. If it is empty, all instance IDs in the sub-table corresponding to the primary table are used. Maximum length: 1000</p>
        /// </summary>
        [JsonProperty("InstanceIDList")]
        public string[] InstanceIDList{ get; set; }

        /// <summary>
        /// <p>Scan timeout duration (seconds). Optional. If it is not zero, update the one-click scan timeout configuration and synchronously update the timeout field in the sub-table. The cap is 7200 seconds (2 hours). If it is exceeded, InvalidParameter is returned.</p>
        /// </summary>
        [JsonProperty("TimeoutPeriod")]
        public ulong? TimeoutPeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "InstanceIDList.", this.InstanceIDList);
            this.SetParamSimple(map, prefix + "TimeoutPeriod", this.TimeoutPeriod);
        }
    }
}

