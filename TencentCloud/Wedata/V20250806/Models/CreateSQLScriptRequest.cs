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

    public class CreateSQLScriptRequest : AbstractModel
    {
        
        /// <summary>
        /// Script name.
        /// </summary>
        [JsonProperty("ScriptName")]
        public string ScriptName{ get; set; }

        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Parent folder path, /aaa/bbb/ccc. root directory is empty string or /.
        /// </summary>
        [JsonProperty("ParentFolderPath")]
        public string ParentFolderPath{ get; set; }

        /// <summary>
        /// Specifies the script configuration for data exploration.
        /// </summary>
        [JsonProperty("ScriptConfig")]
        public SQLScriptConfig ScriptConfig{ get; set; }

        /// <summary>
        /// Specifies the script content, if any, needs to be base64 encoded.
        /// </summary>
        [JsonProperty("ScriptContent")]
        public string ScriptContent{ get; set; }

        /// <summary>
        /// Access permission: SHARED, PRIVATE.
        /// </summary>
        [JsonProperty("AccessScope")]
        public string AccessScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScriptName", this.ScriptName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ParentFolderPath", this.ParentFolderPath);
            this.SetParamObj(map, prefix + "ScriptConfig.", this.ScriptConfig);
            this.SetParamSimple(map, prefix + "ScriptContent", this.ScriptContent);
            this.SetParamSimple(map, prefix + "AccessScope", this.AccessScope);
        }
    }
}

