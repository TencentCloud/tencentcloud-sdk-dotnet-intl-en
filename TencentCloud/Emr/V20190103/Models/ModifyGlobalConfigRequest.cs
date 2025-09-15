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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyGlobalConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// English ID of the EMR cluster.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// List of modified configurations. Key values have a one-to-one correspondence with the output parameters of the `DescribeGlobalConfig` API and are case-insensitive (if an error occurs indicating the key cannot be found, refer to the output parameters). The values are:
        /// 1. enableResourceSchedule: Enables or disables resource scheduling. When disabling, a synchronous operation option (sync) is available with values true or false.
        /// 2. scheduler type: scheduler.
        /// 2. enableLabel: Enables or disables tags, with values true or false.
        /// 2. tag directory: labelDir.
        /// 3. whether to overwrite the user-specified queue, with values true or false.
        /// 4. userMaxAppsDefault: program upper limit.
        /// 5. dynamic configuration item: Corresponds to the Name field in the DefaultSettings object returned by the DescribeGlobalConfig API.
        /// The values are strings. For **whether to overwrite the user-specified queue** and **program upper limit**, null in the JSON specifications means clearing the value of this configuration. Individual configuration items can be modified. For **dynamic configurations**, a full transmission is required to perform overwriting.
        /// </summary>
        [JsonProperty("Items")]
        public Item[] Items{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
        }
    }
}

