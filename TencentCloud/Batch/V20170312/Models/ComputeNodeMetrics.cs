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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComputeNodeMetrics : AbstractModel
    {
        
        /// <summary>
        /// Number of compute nodes that have been submitted
        /// </summary>
        [JsonProperty("SubmittedCount")]
        public ulong? SubmittedCount{ get; set; }

        /// <summary>
        /// Number of compute nodes that are being created
        /// </summary>
        [JsonProperty("CreatingCount")]
        public ulong? CreatingCount{ get; set; }

        /// <summary>
        /// Number of compute nodes that failed to be created
        /// </summary>
        [JsonProperty("CreationFailedCount")]
        public ulong? CreationFailedCount{ get; set; }

        /// <summary>
        /// Number of compute nodes that have been created
        /// </summary>
        [JsonProperty("CreatedCount")]
        public ulong? CreatedCount{ get; set; }

        /// <summary>
        /// Number of running compute nodes
        /// </summary>
        [JsonProperty("RunningCount")]
        public ulong? RunningCount{ get; set; }

        /// <summary>
        /// Number of compute nodes that are being terminated
        /// </summary>
        [JsonProperty("DeletingCount")]
        public ulong? DeletingCount{ get; set; }

        /// <summary>
        /// Number of exceptional compute nodes
        /// </summary>
        [JsonProperty("AbnormalCount")]
        public ulong? AbnormalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubmittedCount", this.SubmittedCount);
            this.SetParamSimple(map, prefix + "CreatingCount", this.CreatingCount);
            this.SetParamSimple(map, prefix + "CreationFailedCount", this.CreationFailedCount);
            this.SetParamSimple(map, prefix + "CreatedCount", this.CreatedCount);
            this.SetParamSimple(map, prefix + "RunningCount", this.RunningCount);
            this.SetParamSimple(map, prefix + "DeletingCount", this.DeletingCount);
            this.SetParamSimple(map, prefix + "AbnormalCount", this.AbnormalCount);
        }
    }
}

