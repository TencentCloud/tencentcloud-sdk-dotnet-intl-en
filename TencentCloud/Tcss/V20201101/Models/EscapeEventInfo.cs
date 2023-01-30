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

    public class EscapeEventInfo : AbstractModel
    {
        
        /// <summary>
        /// Event type
        ///    `ESCAPE_HOST_ACESS_FILE`: Host file access escape.
        ///    `ESCAPE_MOUNT_NAMESPACE`: Mount namespace escape.
        ///    `ESCAPE_PRIVILEDGE`: Program privilege escalation escape.
        ///    `ESCAPE_PRIVILEDGE_CONTAINER_START`: Privileged container startup escape.
        ///    `ESCAPE_MOUNT_SENSITIVE_PTAH`: Sensitive path mount.
        ///    `ESCAPE_SYSCALL`: Syscall escape.
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// Container name
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// Image name
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// Status. Valid values: `EVENT_UNDEAL` (pending); `EVENT_DEALED` (processed); `EVENT_INGNORE` (ignored).
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Unique event ID
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// Node name
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// Pod (instance) name
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// Generation time
        /// </summary>
        [JsonProperty("FoundTime")]
        public string FoundTime{ get; set; }

        /// <summary>
        /// Event name
        /// Host file access escape
        /// Syscall escape
        /// Mount namespace escape
        /// Program privilege escalation escape
        /// Privileged container startup escape
        /// Sensitive path mount
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// Image ID, which is used for redirect.
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// Container ID, which is used for redirect.
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// Event solution
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// Event description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Number of events
        /// </summary>
        [JsonProperty("EventCount")]
        public long? EventCount{ get; set; }

        /// <summary>
        /// Last generation time
        /// </summary>
        [JsonProperty("LatestFoundTime")]
        public string LatestFoundTime{ get; set; }

        /// <summary>
        /// Node IP
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NodeIP")]
        public string NodeIP{ get; set; }

        /// <summary>
        /// Server IP
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostID")]
        public string HostID{ get; set; }

        /// <summary>
        /// Network status
        /// `NORMAL`: 	Not isolated.
        /// `ISOLATED`: 		Isolated.
        /// `ISOLATING`: 		Isolating.
        /// `ISOLATE_FAILED`: 	Isolation failed.
        /// `RESTORING`: Recovering.
        /// `RESTORE_FAILED`: Recovery failed.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContainerNetStatus")]
        public string ContainerNetStatus{ get; set; }

        /// <summary>
        /// Sub-status of the container
        /// "AGENT_OFFLINE"       // The agent is offline.
        /// "NODE_DESTROYED"      // The node is terminated.
        /// "CONTAINER_EXITED"    // The container exited.
        /// "CONTAINER_DESTROYED" // The container was terminated.
        /// "SHARED_HOST"         // The container shares the network with the server.
        /// "RESOURCE_LIMIT"      // The number of resources to be isolated exceeds the limit.
        /// "UNKNOW"              // The reason is unknown.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContainerNetSubStatus")]
        public string ContainerNetSubStatus{ get; set; }

        /// <summary>
        /// Container isolation operation source
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContainerIsolateOperationSrc")]
        public string ContainerIsolateOperationSrc{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "FoundTime", this.FoundTime);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "Solution", this.Solution);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "LatestFoundTime", this.LatestFoundTime);
            this.SetParamSimple(map, prefix + "NodeIP", this.NodeIP);
            this.SetParamSimple(map, prefix + "HostID", this.HostID);
            this.SetParamSimple(map, prefix + "ContainerNetStatus", this.ContainerNetStatus);
            this.SetParamSimple(map, prefix + "ContainerNetSubStatus", this.ContainerNetSubStatus);
            this.SetParamSimple(map, prefix + "ContainerIsolateOperationSrc", this.ContainerIsolateOperationSrc);
            this.SetParamSimple(map, prefix + "ContainerStatus", this.ContainerStatus);
        }
    }
}

