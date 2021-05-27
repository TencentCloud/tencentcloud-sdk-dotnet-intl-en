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

namespace TencentCloud.Tem.V20201221.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateServiceV2Request : AbstractModel
    {
        
        /// <summary>
        /// Service name
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Whether to use the default image service. 1: yes; 0: no
        /// </summary>
        [JsonProperty("UseDefaultImageService")]
        public long? UseDefaultImageService{ get; set; }

        /// <summary>
        /// Type of the bound repository. 0: Personal Edition; 1: Enterprise Edition
        /// </summary>
        [JsonProperty("RepoType")]
        public long? RepoType{ get; set; }

        /// <summary>
        /// Instance ID of Enterprise Edition image service
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Address of the bound image server
        /// </summary>
        [JsonProperty("RepoServer")]
        public string RepoServer{ get; set; }

        /// <summary>
        /// Name of the bound image repository
        /// </summary>
        [JsonProperty("RepoName")]
        public string RepoName{ get; set; }

        /// <summary>
        /// Source channel
        /// </summary>
        [JsonProperty("SourceChannel")]
        public long? SourceChannel{ get; set; }

        /// <summary>
        /// Service subnet
        /// </summary>
        [JsonProperty("SubnetList")]
        public string[] SubnetList{ get; set; }

        /// <summary>
        /// Programming language 
        /// - JAVA
        /// - OTHER
        /// </summary>
        [JsonProperty("CodingLanguage")]
        public string CodingLanguage{ get; set; }

        /// <summary>
        /// Deployment mode 
        /// - IMAGE
        /// - JAR
        /// - WAR
        /// </summary>
        [JsonProperty("DeployMode")]
        public string DeployMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "UseDefaultImageService", this.UseDefaultImageService);
            this.SetParamSimple(map, prefix + "RepoType", this.RepoType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RepoServer", this.RepoServer);
            this.SetParamSimple(map, prefix + "RepoName", this.RepoName);
            this.SetParamSimple(map, prefix + "SourceChannel", this.SourceChannel);
            this.SetParamArraySimple(map, prefix + "SubnetList.", this.SubnetList);
            this.SetParamSimple(map, prefix + "CodingLanguage", this.CodingLanguage);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
        }
    }
}

