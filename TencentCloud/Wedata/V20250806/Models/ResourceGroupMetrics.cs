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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceGroupMetrics : AbstractModel
    {
        
        /// <summary>
        /// Resource group specification, indicates the number of cpus.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CpuNum")]
        public ulong? CpuNum{ get; set; }

        /// <summary>
        /// Resource group specification related to disk specification.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiskVolume")]
        public ulong? DiskVolume{ get; set; }

        /// <summary>
        /// Resource group specification related to memory size. unit: gb.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// Resource group lifecycle. unit: day.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LifeCycle")]
        public ulong? LifeCycle{ get; set; }

        /// <summary>
        /// Resource group specification related to highest concurrency.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaximumConcurrency")]
        public ulong? MaximumConcurrency{ get; set; }

        /// <summary>
        /// Resource group status
        /// 
        /// -0 - initializing.
        /// -1. running.
        /// -2 --- operation exception.
        /// -Releasing.
        /// -4 --- released.
        /// -Creating.
        /// -6 --- creation failed.
        /// -7 --- updating.
        /// -8 --- update failed.
        /// -9 --- expired.
        /// - 10 --- release failed.
        /// -11 --- in use.
        /// -12 --- inactive.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Metric detail.
        /// </summary>
        [JsonProperty("MetricSnapshots")]
        public MetricData[] MetricSnapshots{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CpuNum", this.CpuNum);
            this.SetParamSimple(map, prefix + "DiskVolume", this.DiskVolume);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "LifeCycle", this.LifeCycle);
            this.SetParamSimple(map, prefix + "MaximumConcurrency", this.MaximumConcurrency);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "MetricSnapshots.", this.MetricSnapshots);
        }
    }
}

