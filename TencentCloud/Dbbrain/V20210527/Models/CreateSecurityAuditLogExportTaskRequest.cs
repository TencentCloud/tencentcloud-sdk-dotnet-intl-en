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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSecurityAuditLogExportTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Security audit group ID.
        /// </summary>
        [JsonProperty("SecAuditGroupId")]
        public string SecAuditGroupId{ get; set; }

        /// <summary>
        /// Exported log start time, such as 2020-12-28 00:00:00.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Exported log end time, such as 2020-12-28 01:00:00.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Service type. Valid value: `mysql` (TencentDB for MySQL).
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// List of log risk levels. Valid values: `0` (no risk), `1` (low risk), `2` (medium risk), `3` (high risk).
        /// </summary>
        [JsonProperty("DangerLevels")]
        public long?[] DangerLevels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecAuditGroupId", this.SecAuditGroupId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamArraySimple(map, prefix + "DangerLevels.", this.DangerLevels);
        }
    }
}

