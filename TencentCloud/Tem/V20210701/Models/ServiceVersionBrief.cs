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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceVersionBrief : AbstractModel
    {
        
        /// <summary>
        /// Version name
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// Status of version
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// (Disused) Whether to enable elastic scaling
        /// </summary>
        [JsonProperty("EnableEs")]
        public long? EnableEs{ get; set; }

        /// <summary>
        /// Number of current instances
        /// </summary>
        [JsonProperty("CurrentInstances")]
        public long? CurrentInstances{ get; set; }

        /// <summary>
        /// Version ID
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// (Disused) Log output configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LogOutputConf")]
        public LogOutputConf LogOutputConf{ get; set; }

        /// <summary>
        /// Expected number of instances
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpectedInstances")]
        public long? ExpectedInstances{ get; set; }

        /// <summary>
        /// Deployment mode
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeployMode")]
        public string DeployMode{ get; set; }

        /// <summary>
        /// Task ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BuildTaskId")]
        public string BuildTaskId{ get; set; }

        /// <summary>
        /// Environment ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// Environment name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnvironmentName")]
        public string EnvironmentName{ get; set; }

        /// <summary>
        /// Application ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// Application name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// Whether the application is being deployed
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnderDeploying")]
        public bool? UnderDeploying{ get; set; }

        /// <summary>
        /// Status of batch deployment
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("BatchDeployStatus")]
        public string BatchDeployStatus{ get; set; }

        /// <summary>
        /// Availability zones
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// Node information
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("NodeInfos")]
        public NodeInfo[] NodeInfos{ get; set; }

        /// <summary>
        /// Pod information
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PodList")]
        public DescribeRunPodPage PodList{ get; set; }

        /// <summary>
        /// Workload information
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("WorkloadInfo")]
        public WorkloadInfo WorkloadInfo{ get; set; }

        /// <summary>
        /// Creation time
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("CreateDate")]
        public string CreateDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EnableEs", this.EnableEs);
            this.SetParamSimple(map, prefix + "CurrentInstances", this.CurrentInstances);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamObj(map, prefix + "LogOutputConf.", this.LogOutputConf);
            this.SetParamSimple(map, prefix + "ExpectedInstances", this.ExpectedInstances);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "BuildTaskId", this.BuildTaskId);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "EnvironmentName", this.EnvironmentName);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "UnderDeploying", this.UnderDeploying);
            this.SetParamSimple(map, prefix + "BatchDeployStatus", this.BatchDeployStatus);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamArrayObj(map, prefix + "NodeInfos.", this.NodeInfos);
            this.SetParamObj(map, prefix + "PodList.", this.PodList);
            this.SetParamObj(map, prefix + "WorkloadInfo.", this.WorkloadInfo);
            this.SetParamSimple(map, prefix + "CreateDate", this.CreateDate);
        }
    }
}

