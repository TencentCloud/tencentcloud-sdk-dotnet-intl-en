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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunWorkflowRequest : AbstractModel
    {
        
        /// <summary>
        /// Run group name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Delivery environment ID
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// Workflow Git repository information
        /// </summary>
        [JsonProperty("GitSource")]
        public GitInfo GitSource{ get; set; }

        /// <summary>
        /// Workflow type
        /// 
        /// Supported type:
        /// - NEXTFLOW
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Nextflow option
        /// </summary>
        [JsonProperty("NFOption")]
        public NFOption NFOption{ get; set; }

        /// <summary>
        /// Project ID
        /// (If you leave it blank, the default item in the specified region will be used.)
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Run group description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Run input JSON. Base64 encoding is required.
        /// (Either InputBase64 or InputCosUri must be selected.)
        /// </summary>
        [JsonProperty("InputBase64")]
        public string InputBase64{ get; set; }

        /// <summary>
        /// Run input COS path
        /// (Either InputBase64 or InputCosUri must be selected.)
        /// </summary>
        [JsonProperty("InputCosUri")]
        public string InputCosUri{ get; set; }

        /// <summary>
        /// Run cache cleanup time (hours). Leaving it blank or entering 0 indicates no cleanup.
        /// </summary>
        [JsonProperty("CacheClearDelay")]
        public ulong? CacheClearDelay{ get; set; }

        /// <summary>
        /// Working directory. You can fill in the absolute path in the specified volume. If you leave it blank, the default path in the default volume will be used. Currently, only Nextflow is supported.
        /// </summary>
        [JsonProperty("WorkDir")]
        public string WorkDir{ get; set; }

        /// <summary>
        /// Volume ID. If you leave it blank, the default volume will be used. Currently, only Nextflow is supported.
        /// </summary>
        [JsonProperty("VolumeIds")]
        public string[] VolumeIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamObj(map, prefix + "GitSource.", this.GitSource);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "NFOption.", this.NFOption);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "InputBase64", this.InputBase64);
            this.SetParamSimple(map, prefix + "InputCosUri", this.InputCosUri);
            this.SetParamSimple(map, prefix + "CacheClearDelay", this.CacheClearDelay);
            this.SetParamSimple(map, prefix + "WorkDir", this.WorkDir);
            this.SetParamArraySimple(map, prefix + "VolumeIds.", this.VolumeIds);
        }
    }
}

