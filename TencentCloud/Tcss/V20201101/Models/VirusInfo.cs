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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VirusInfo : AbstractModel
    {
        
        /// <summary>
        /// Filename
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// File path
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// Virus name
        /// </summary>
        [JsonProperty("VirusName")]
        public string VirusName{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Update time
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Container name
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// Container ID
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// Container status
        /// `RUNNING`: Running.
        /// `PAUSED`: Paused.
        /// `STOPPED`: Stopped.
        /// `CREATED`: Created.
        /// `DESTROYED`: Terminated.
        /// `RESTARTING`: Restarting.
        /// `REMOVING`: Removing.
        /// </summary>
        [JsonProperty("ContainerStatus")]
        public string ContainerStatus{ get; set; }

        /// <summary>
        /// Image name
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// Image ID
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// `DEAL_NONE`: Pending.
        /// `DEAL_IGNORE`: Ignored.
        /// `DEAL_ADD_WHITELIST`: Allowed.
        /// `DEAL_DEL`: Deleted.
        /// `DEAL_ISOLATE`: Isolated.
        /// `DEAL_ISOLATING`: Isolating.
        /// `DEAL_ISOLATE_FAILED`: Isolation failed.
        /// `DEAL_RECOVERING`: Recovering.
        /// `DEAL_RECOVER_FAILED`: Recovery failed.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Event ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Event description
        /// </summary>
        [JsonProperty("HarmDescribe")]
        public string HarmDescribe{ get; set; }

        /// <summary>
        /// Solution
        /// </summary>
        [JsonProperty("SuggestScheme")]
        public string SuggestScheme{ get; set; }

        /// <summary>
        /// Sub-status of the failure:
        /// `FILE_NOT_FOUND`: The file does not exist.
        /// `FILE_ABNORMAL`: The file is abnormal.
        /// `FILE_ABNORMAL_DEAL_RECOVER`: The file is abnormal when recovered.
        /// `BACKUP_FILE_NOT_FOUND`: The backup file does not exist.
        /// `CONTAINER_NOT_FOUND_DEAL_ISOLATE`: The container does not exist during isolation.
        /// `CONTAINER_NOT_FOUND_DEAL_RECOVER`: The container does not exist during recovery.
        /// `TIMEOUT`: Timed out.
        /// `TOO_MANY`: Too many tasks.
        /// `OFFLINE`: Offline.
        /// `INTERNAL`: Internal service error.
        /// `VALIDATION`: Invalid parameter.
        /// </summary>
        [JsonProperty("SubStatus")]
        public string SubStatus{ get; set; }

        /// <summary>
        /// Network status
        /// `NORMAL`: 	Not isolated.
        /// `ISOLATED`: 		Isolated.
        /// `ISOLATING`: 		Isolating.
        /// `ISOLATE_FAILED`: 	Isolation failed.
        /// `RESTORING`: Recovering.
        /// `RESTORE_FAILED`: Recovery failed.
        /// </summary>
        [JsonProperty("ContainerNetStatus")]
        public string ContainerNetStatus{ get; set; }

        /// <summary>
        /// Sub-status of the container
        /// "AGENT_OFFLINE"       // The agent is offline.
        /// 	"NODE_DESTROYED"      // The node is terminated.
        /// 	"CONTAINER_EXITED"    // The container exited.
        /// 	"CONTAINER_DESTROYED" // The container was terminated.
        /// 	"SHARED_HOST"         // The container shares the network with the server.
        /// 	"RESOURCE_LIMIT"      // The number of resources to be isolated exceeds the limit.
        /// 	"UNKNOW"              // The reason is unknown.
        /// </summary>
        [JsonProperty("ContainerNetSubStatus")]
        public string ContainerNetSubStatus{ get; set; }

        /// <summary>
        /// Container isolation operation source
        /// </summary>
        [JsonProperty("ContainerIsolateOperationSrc")]
        public string ContainerIsolateOperationSrc{ get; set; }

        /// <summary>
        /// MD5 checksum
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MD5")]
        public string MD5{ get; set; }

        /// <summary>
        /// Risk level. Valid values: `RISK_CRITICAL`, `RISK_HIGH`, `RISK_MEDIUM`, `RISK_LOW`, `RISK_NOTICE`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// Check platform
        /// `1`: Tencent Cloud Security Engine.
        /// `2`: tav.
        /// `3`: binaryAi.
        /// `4`: Unusual behavior.
        /// `5`: Threat intelligence.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CheckPlatform")]
        public string[] CheckPlatform{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "VirusName", this.VirusName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "ContainerStatus", this.ContainerStatus);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "HarmDescribe", this.HarmDescribe);
            this.SetParamSimple(map, prefix + "SuggestScheme", this.SuggestScheme);
            this.SetParamSimple(map, prefix + "SubStatus", this.SubStatus);
            this.SetParamSimple(map, prefix + "ContainerNetStatus", this.ContainerNetStatus);
            this.SetParamSimple(map, prefix + "ContainerNetSubStatus", this.ContainerNetSubStatus);
            this.SetParamSimple(map, prefix + "ContainerIsolateOperationSrc", this.ContainerIsolateOperationSrc);
            this.SetParamSimple(map, prefix + "MD5", this.MD5);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamArraySimple(map, prefix + "CheckPlatform.", this.CheckPlatform);
        }
    }
}

