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

    public class TaskVersionDetail : AbstractModel
    {
        
        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Version number
        /// 
        /// </summary>
        [JsonProperty("VersionNum")]
        public string VersionNum{ get; set; }

        /// <summary>
        /// Specifies the version creator.
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// Specifies the version Id to save.
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// Version description
        /// </summary>
        [JsonProperty("VersionRemark")]
        public string VersionRemark{ get; set; }

        /// <summary>
        /// Approval status (only for submit version).
        /// </summary>
        [JsonProperty("ApproveStatus")]
        public string ApproveStatus{ get; set; }

        /// <summary>
        /// Production status  (only for submit version).
        /// </summary>
        [JsonProperty("ApproveTime")]
        public string ApproveTime{ get; set; }

        /// <summary>
        /// Describes the task detail of the version.
        /// </summary>
        [JsonProperty("Task")]
        public Task Task{ get; set; }

        /// <summary>
        /// Approver Id.
        /// </summary>
        [JsonProperty("ApproveUserUin")]
        public string ApproveUserUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "VersionNum", this.VersionNum);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "VersionRemark", this.VersionRemark);
            this.SetParamSimple(map, prefix + "ApproveStatus", this.ApproveStatus);
            this.SetParamSimple(map, prefix + "ApproveTime", this.ApproveTime);
            this.SetParamObj(map, prefix + "Task.", this.Task);
            this.SetParamSimple(map, prefix + "ApproveUserUin", this.ApproveUserUin);
        }
    }
}

