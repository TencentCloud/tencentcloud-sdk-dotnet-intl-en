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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Environment : AbstractModel
    {
        
        /// <summary>
        /// Environment ID
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// Environment name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Environment description information
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Environment region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Environment type. Valid values:
        /// - KUBERNETES: Kubernetes container cluster
        /// - HPC:HPC HCC 
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Environment status. Valid values:
        /// - INITIALIZING: Creating
        /// - INITIALIZATION_ERROR: Creation failed
        /// - RUNNING: Running
        /// - ERROR: Exceptional
        /// - DELETING: Deleting
        /// - DELETE_ERROR: Deletion failed.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Whether the environment is available. The environment needs to be available before computing runs can be delivered.
        /// </summary>
        [JsonProperty("Available")]
        public bool? Available{ get; set; }

        /// <summary>
        /// Whether the environment is the default environment.
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }

        /// <summary>
        /// Whether the environment is a managed environment.
        /// </summary>
        [JsonProperty("IsManaged")]
        public bool? IsManaged{ get; set; }

        /// <summary>
        /// Environment information
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Cloud resource ID
        /// </summary>
        [JsonProperty("ResourceIds")]
        public ResourceIds ResourceIds{ get; set; }

        /// <summary>
        /// The UUID of the previous workflow
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastWorkflowUuid")]
        public string LastWorkflowUuid{ get; set; }

        /// <summary>
        /// Creation time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Available", this.Available);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "IsManaged", this.IsManaged);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamObj(map, prefix + "ResourceIds.", this.ResourceIds);
            this.SetParamSimple(map, prefix + "LastWorkflowUuid", this.LastWorkflowUuid);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
        }
    }
}

