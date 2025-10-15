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

    public class OpsAsyncJobDetail : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Operation ID
        /// </summary>
        [JsonProperty("AsyncId")]
        public string AsyncId{ get; set; }

        /// <summary>
        /// Asynchronous operation type.
        /// </summary>
        [JsonProperty("AsyncType")]
        public string AsyncType{ get; set; }

        /// <summary>
        /// Asynchronous operation status: initial status: INIT; Running: RUNNING; Success: SUCCESS; failure: FAIL; partially successful: PART_SUCCESS.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Error message.
        /// 
        /// </summary>
        [JsonProperty("ErrorDesc")]
        public string ErrorDesc{ get; set; }

        /// <summary>
        /// Total sub-processes.
        /// </summary>
        [JsonProperty("TotalSubProcessCount")]
        public ulong? TotalSubProcessCount{ get; set; }

        /// <summary>
        /// Number of completed sub-processes.
        /// </summary>
        [JsonProperty("FinishedSubProcessCount")]
        public ulong? FinishedSubProcessCount{ get; set; }

        /// <summary>
        /// Count of successful sub-processes.
        /// </summary>
        [JsonProperty("SuccessSubProcessCount")]
        public ulong? SuccessSubProcessCount{ get; set; }

        /// <summary>
        /// Operator id.
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Update time.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AsyncId", this.AsyncId);
            this.SetParamSimple(map, prefix + "AsyncType", this.AsyncType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrorDesc", this.ErrorDesc);
            this.SetParamSimple(map, prefix + "TotalSubProcessCount", this.TotalSubProcessCount);
            this.SetParamSimple(map, prefix + "FinishedSubProcessCount", this.FinishedSubProcessCount);
            this.SetParamSimple(map, prefix + "SuccessSubProcessCount", this.SuccessSubProcessCount);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

