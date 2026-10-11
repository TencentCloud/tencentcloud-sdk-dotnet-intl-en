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
        /// List of modified configurations. Key values have a one-to-one correspondence with the response parameters of the `DescribeGlobalConfig` API and are case-insensitive (If an error occurs indicating that the key cannot be found, refer to the response parameters). Valid values:
        /// 1. enableResourceSchedule: Whether to enable or disable resource scheduling. When it is disabled, a synchronization option with Key set to sync is available. Valid values: true and false.
        /// 2. scheduler: Scheduler type.
        /// 2. enableLabel: Whether to enable or disable the tag. Valid values: true and false.
        /// 2. labelDir: Tag directory.
        /// 3. queueMappingOverride: Whether to overwrite user-specified queue. Valid values: true and false.
        /// 4. userMaxAppsDefault: Program upper limit.
        /// 5. Dynamic configuration item: Name field in DefaultSettings returned by the `DescribeGlobalConfig` API.
        /// The values are strings. For **whether to overwrite the user-specified queue** and **program upper limit**, null in the JSON specifications means clearing the value of this configuration. Individual configuration items can be modified. For **dynamic configurations**, pass all values to overwrite the existing ones.
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

