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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SwitchDBInstancePrimaryRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. obtain through the api [DescribeDBInstances](https://www.tencentcloud.com/document/api/409/16773?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// Whether to force a switch. forced switching initiates a switch as long as the secondary node is accessible, regardless of the primary/secondary delay. only when SwitchTag is 0 can you use switch immediately.
        /// <Li>Default: false</li>.
        /// </summary>
        [JsonProperty("Force")]
        public bool? Force{ get; set; }

        /// <summary>
        /// Specifies the switch time after instance configuration change.
        /// <Li>0: switch immediately</li>.
        /// <Li>1: switch at specified time</li>.
        /// <Li>2: switch during maintenance time window.</li>.
        /// Default value: 0  
        /// </summary>
        [JsonProperty("SwitchTag")]
        public ulong? SwitchTag{ get; set; }

        /// <summary>
        /// The earliest time to start a switch in the format of "HH:MM:SS", such as "01:00:00". This parameter is invalid when `SwitchTag` is `0` or `2`.
        /// </summary>
        [JsonProperty("SwitchStartTime")]
        public string SwitchStartTime{ get; set; }

        /// <summary>
        /// The latest time to start a switch in the format of "HH:MM:SS", such as "01:30:00". This parameter is invalid when `SwitchTag` is `0` or `2`. The difference between `SwitchStartTime` and `SwitchEndTime` cannot be less than 30 minutes.
        /// </summary>
        [JsonProperty("SwitchEndTime")]
        public string SwitchEndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "Force", this.Force);
            this.SetParamSimple(map, prefix + "SwitchTag", this.SwitchTag);
            this.SetParamSimple(map, prefix + "SwitchStartTime", this.SwitchStartTime);
            this.SetParamSimple(map, prefix + "SwitchEndTime", this.SwitchEndTime);
        }
    }
}

