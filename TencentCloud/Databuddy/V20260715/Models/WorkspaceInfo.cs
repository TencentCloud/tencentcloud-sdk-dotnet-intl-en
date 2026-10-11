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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkspaceInfo : AbstractModel
    {
        
        /// <summary>
        /// Workspace ID
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// Workspace name
        /// </summary>
        [JsonProperty("WorkspaceName")]
        public string WorkspaceName{ get; set; }

        /// <summary>
        /// Workspace description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Workspace region (for example, ap-guangzhou)
        /// </summary>
        [JsonProperty("WorkspaceRegion")]
        public string WorkspaceRegion{ get; set; }

        /// <summary>
        /// Workspace status: 0=unspecified, 1=creating, 2=creation failed, 3=operating normally, 4=deleted.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Failure reason (valid when Status=2, indicating creation failure)
        /// </summary>
        [JsonProperty("ErrorReason")]
        public string ErrorReason{ get; set; }

        /// <summary>
        /// Creator information
        /// </summary>
        [JsonProperty("Creator")]
        public StandardUserInfo Creator{ get; set; }

        /// <summary>
        /// Creation time. Millisecond timestamp
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last update time. Timestamp in milliseconds
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Whether the current user has access permission for the workspace
        /// </summary>
        [JsonProperty("HasAccess")]
        public bool? HasAccess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "WorkspaceName", this.WorkspaceName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "WorkspaceRegion", this.WorkspaceRegion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrorReason", this.ErrorReason);
            this.SetParamObj(map, prefix + "Creator.", this.Creator);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "HasAccess", this.HasAccess);
        }
    }
}

