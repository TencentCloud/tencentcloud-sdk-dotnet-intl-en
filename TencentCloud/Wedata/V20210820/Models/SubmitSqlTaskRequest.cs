/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitSqlTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Database Type
        /// </summary>
        [JsonProperty("DatabaseType")]
        public string DatabaseType{ get; set; }

        /// <summary>
        /// Data Source ID
        /// </summary>
        [JsonProperty("DatasourceId")]
        public long? DatasourceId{ get; set; }

        /// <summary>
        /// Resource Group ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Script File ID
        /// </summary>
        [JsonProperty("ScriptId")]
        public string ScriptId{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Database name
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// Execution Engine Instance ID
        /// </summary>
        [JsonProperty("EngineId")]
        public string EngineId{ get; set; }

        /// <summary>
        /// Script Content
        /// </summary>
        [JsonProperty("ScriptContent")]
        public string ScriptContent{ get; set; }

        /// <summary>
        /// Resource Queue
        /// </summary>
        [JsonProperty("ResourceQueue")]
        public string ResourceQueue{ get; set; }

        /// <summary>
        /// Database Type
        /// </summary>
        [JsonProperty("DatasourceType")]
        public string DatasourceType{ get; set; }

        /// <summary>
        /// Compute Resource Name
        /// </summary>
        [JsonProperty("ComputeResource")]
        public string ComputeResource{ get; set; }

        /// <summary>
        /// Advanced Running Parameters
        /// </summary>
        [JsonProperty("RunParams")]
        public string RunParams{ get; set; }

        /// <summary>
        /// Advanced Settings
        /// </summary>
        [JsonProperty("ConfParams")]
        public string ConfParams{ get; set; }

        /// <summary>
        /// Whether the script content is Base64 encrypted
        /// </summary>
        [JsonProperty("ScriptEncryption")]
        public bool? ScriptEncryption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatabaseType", this.DatabaseType);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "ScriptId", this.ScriptId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "EngineId", this.EngineId);
            this.SetParamSimple(map, prefix + "ScriptContent", this.ScriptContent);
            this.SetParamSimple(map, prefix + "ResourceQueue", this.ResourceQueue);
            this.SetParamSimple(map, prefix + "DatasourceType", this.DatasourceType);
            this.SetParamSimple(map, prefix + "ComputeResource", this.ComputeResource);
            this.SetParamSimple(map, prefix + "RunParams", this.RunParams);
            this.SetParamSimple(map, prefix + "ConfParams", this.ConfParams);
            this.SetParamSimple(map, prefix + "ScriptEncryption", this.ScriptEncryption);
        }
    }
}

