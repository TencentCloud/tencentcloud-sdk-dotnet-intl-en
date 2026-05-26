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

    public class UpgradeDBInstanceKernelVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. obtain through the api [DescribeDBInstances](https://www.tencentcloud.com/document/api/409/16773?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// Target kernel version, which can be obtained in the `AvailableUpgradeTarget` field in the returned value of the [DescribeDBVersions](https://intl.cloud.tencent.com/document/api/409/89018?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("TargetDBKernelVersion")]
        public string TargetDBKernelVersion{ get; set; }

        /// <summary>
        /// Specifies the switch time after upgrading the kernel for the specified instance. valid values:.
        /// <Li>0: switch immediately.</li>.
        /// <Li>1: switch at specified time</li>.
        /// <Li>2: switch during maintenance time window.</li>.
        /// Default value: 0  
        /// </summary>
        [JsonProperty("SwitchTag")]
        public ulong? SwitchTag{ get; set; }

        /// <summary>
        /// Switch start time in the format of `HH:MM:SS`, such as 01:00:00. When `SwitchTag` is `0` or `2`, this parameter is invalid.
        /// </summary>
        [JsonProperty("SwitchStartTime")]
        public string SwitchStartTime{ get; set; }

        /// <summary>
        /// Switch end time in the format of `HH:MM:SS`, such as 01:30:00. When `SwitchTag` is `0` or `2`, this parameter is invalid. The difference between `SwitchStartTime` and `SwitchEndTime` cannot be less than 30 minutes.
        /// </summary>
        [JsonProperty("SwitchEndTime")]
        public string SwitchEndTime{ get; set; }

        /// <summary>
        /// Specifies whether to perform a pre-check for the instance kernel version upgrade operation this time.
        /// <li>true: performs a pre-check without upgrading the kernel. check items include request parameters, kernel version compatibility, and instance parameters.</li>.
        /// <li>false: send a normal request (default value). after passing the check, directly upgrade the kernel.</li>.
        /// Default value: `false`.
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "TargetDBKernelVersion", this.TargetDBKernelVersion);
            this.SetParamSimple(map, prefix + "SwitchTag", this.SwitchTag);
            this.SetParamSimple(map, prefix + "SwitchStartTime", this.SwitchStartTime);
            this.SetParamSimple(map, prefix + "SwitchEndTime", this.SwitchEndTime);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
        }
    }
}

