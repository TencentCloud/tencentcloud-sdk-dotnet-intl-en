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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InferenceHardwareConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Number of GPU cards assigned to each inference service instance. Currently, supports integers only, and must be an available value in <code>AllowedGPUNums</code> of the specification corresponding to <code>HardwareSpecId</code>.</p><p>If not filled, the default <code>GPUNum</code> value of the selected <code>HardwareSpecId</code> specification is used.</p>
        /// </summary>
        [JsonProperty("GPUNum")]
        public float? GPUNum{ get; set; }

        /// <summary>
        /// <p>Number of CPU cores allocated to each inference service instance. Currently only supports integer values.</p><p>If left blank, use the default <code>CPUNum</code> value of the selected <code>HardwareSpecId</code> specification.</p>
        /// </summary>
        [JsonProperty("CPUNum")]
        public float? CPUNum{ get; set; }

        /// <summary>
        /// <p>Memory size allocated to a single instance of the inference service.</p><p>Unit: MB</p><p>If left blank, use the default <code>MemSize</code> value of the selected <code>HardwareSpecId</code>; if filled, it must be a multiple of <code>1024</code>.</p>
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// <p>Temporary disk capacity allocated to a single instance of the inference service.</p><p>Unit: MB</p><p>If not filled, the default <code>DiskSize</code> value of the specification corresponding to the selected <code>HardwareSpecId</code> is used; if filled, it must be an integral multiple of <code>1024</code>.</p>
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GPUNum", this.GPUNum);
            this.SetParamSimple(map, prefix + "CPUNum", this.CPUNum);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
        }
    }
}

