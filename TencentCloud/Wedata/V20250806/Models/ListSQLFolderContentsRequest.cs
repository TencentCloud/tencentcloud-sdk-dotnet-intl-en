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

    public class ListSQLFolderContentsRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Parent folder path, /aaa/bbb/ccc. path header must include a slash. pass / to query the root directory.
        /// </summary>
        [JsonProperty("ParentFolderPath")]
        public string ParentFolderPath{ get; set; }

        /// <summary>
        /// Folder name or script name search.
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// Queries only the folder.
        /// </summary>
        [JsonProperty("OnlyFolderNode")]
        public bool? OnlyFolderNode{ get; set; }

        /// <summary>
        /// Specifies whether to query only scripts created by the user themselves.
        /// </summary>
        [JsonProperty("OnlyUserSelfScript")]
        public bool? OnlyUserSelfScript{ get; set; }

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
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ParentFolderPath", this.ParentFolderPath);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "OnlyFolderNode", this.OnlyFolderNode);
            this.SetParamSimple(map, prefix + "OnlyUserSelfScript", this.OnlyUserSelfScript);
            this.SetParamSimple(map, prefix + "AccessScope", this.AccessScope);
        }
    }
}

