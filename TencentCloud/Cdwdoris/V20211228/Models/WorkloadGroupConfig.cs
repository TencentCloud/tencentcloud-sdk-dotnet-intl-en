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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkloadGroupConfig : AbstractModel
    {
        
        /// <summary>
        /// Resource group name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WorkloadGroupName")]
        public string WorkloadGroupName{ get; set; }

        /// <summary>
        /// CPU weight
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CpuShare")]
        public long? CpuShare{ get; set; }

        /// <summary>
        /// Memory limit. The sum of memory limit values of all resource groups should be less than or equal to 100.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MemoryLimit")]
        public long? MemoryLimit{ get; set; }

        /// <summary>
        /// Whether to allow over-allocation
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnableMemoryOverCommit")]
        public bool? EnableMemoryOverCommit{ get; set; }

        /// <summary>
        /// CPU hard limit
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CpuHardLimit")]
        public string CpuHardLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkloadGroupName", this.WorkloadGroupName);
            this.SetParamSimple(map, prefix + "CpuShare", this.CpuShare);
            this.SetParamSimple(map, prefix + "MemoryLimit", this.MemoryLimit);
            this.SetParamSimple(map, prefix + "EnableMemoryOverCommit", this.EnableMemoryOverCommit);
            this.SetParamSimple(map, prefix + "CpuHardLimit", this.CpuHardLimit);
        }
    }
}

