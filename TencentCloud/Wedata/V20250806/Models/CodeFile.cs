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

    public class CodeFile : AbstractModel
    {
        
        /// <summary>
        /// Script ID
        /// 
        /// </summary>
        [JsonProperty("CodeFileId")]
        public string CodeFileId{ get; set; }

        /// <summary>
        /// Script name.
        /// </summary>
        [JsonProperty("CodeFileName")]
        public string CodeFileName{ get; set; }

        /// <summary>
        /// Specifies the script owner uin.
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Specifies the script configuration.
        /// </summary>
        [JsonProperty("CodeFileConfig")]
        public CodeFileConfig CodeFileConfig{ get; set; }

        /// <summary>
        /// Specifies the script content.
        /// </summary>
        [JsonProperty("CodeFileContent")]
        public string CodeFileContent{ get; set; }

        /// <summary>
        /// Latest operator.
        /// </summary>
        [JsonProperty("UpdateUserUin")]
        public string UpdateUserUin{ get; set; }

        /// <summary>
        /// Project ID.
        /// 
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Update time. format: yyyy-MM-dd hh:MM:ss.
        /// Note: This field may return null, indicating that no valid 
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Creation time. format: yyyy-MM-dd hh:MM:ss.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Access permission: SHARED, PRIVATE.
        /// </summary>
        [JsonProperty("AccessScope")]
        public string AccessScope{ get; set; }

        /// <summary>
        /// Full path of the node, /aaa/bbb/ccc.ipynb, consists of the name of each node.
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CodeFileId", this.CodeFileId);
            this.SetParamSimple(map, prefix + "CodeFileName", this.CodeFileName);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamObj(map, prefix + "CodeFileConfig.", this.CodeFileConfig);
            this.SetParamSimple(map, prefix + "CodeFileContent", this.CodeFileContent);
            this.SetParamSimple(map, prefix + "UpdateUserUin", this.UpdateUserUin);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "AccessScope", this.AccessScope);
            this.SetParamSimple(map, prefix + "Path", this.Path);
        }
    }
}

