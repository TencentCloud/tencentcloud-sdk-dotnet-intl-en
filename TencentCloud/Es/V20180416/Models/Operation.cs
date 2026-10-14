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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Operation : AbstractModel
    {
        
        /// <summary>
        /// <p>Unique id of the operation</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>Operation start time.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>Operation type.</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Operation details.</p>
        /// </summary>
        [JsonProperty("Detail")]
        public OperationDetail Detail{ get; set; }

        /// <summary>
        /// <p>Operation result.</p>
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// <p>Process task info</p>
        /// </summary>
        [JsonProperty("Tasks")]
        public TaskDetail[] Tasks{ get; set; }

        /// <summary>
        /// <p>Operation progress.</p>
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// <p>Rollback tag. 0: not rolled back, 1: rolling back, 2: rolled back</p>
        /// </summary>
        [JsonProperty("RollbackTag")]
        public long? RollbackTag{ get; set; }

        /// <summary>
        /// <p>Operator Uin</p>
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// <p>Auto scaling flag. Valid values: 0 (non-auto) and 1 (auto).</p>
        /// </summary>
        [JsonProperty("AutoScaleTag")]
        public ulong? AutoScaleTag{ get; set; }

        /// <summary>
        /// <p>Process exception cause</p>
        /// </summary>
        [JsonProperty("SuspendedReason")]
        public string SuspendedReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Detail.", this.Detail);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "RollbackTag", this.RollbackTag);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "AutoScaleTag", this.AutoScaleTag);
            this.SetParamSimple(map, prefix + "SuspendedReason", this.SuspendedReason);
        }
    }
}

