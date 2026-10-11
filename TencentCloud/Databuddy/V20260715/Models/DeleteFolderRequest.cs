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

    public class DeleteFolderRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Workspace id</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>Folder to be deleted</p>
        /// </summary>
        [JsonProperty("Folder")]
        public FolderLocator Folder{ get; set; }

        /// <summary>
        /// <p>Soft deletion or hard delete from the recycle bin</p><p>Enumeration values:</p><ul><li>false: Soft delete to the recycle bin</li><li>true: Hard delete from the recycle bin</li></ul>
        /// </summary>
        [JsonProperty("ForceDelete")]
        public bool? ForceDelete{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamObj(map, prefix + "Folder.", this.Folder);
            this.SetParamSimple(map, prefix + "ForceDelete", this.ForceDelete);
        }
    }
}

