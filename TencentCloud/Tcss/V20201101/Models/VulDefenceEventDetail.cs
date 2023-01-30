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

    public class VulDefenceEventDetail : AbstractModel
    {
        
        /// <summary>
        /// Vulnerability CVE ID
        /// </summary>
        [JsonProperty("CVEID")]
        public string CVEID{ get; set; }

        /// <summary>
        /// Vulnerability name
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// POC ID
        /// </summary>
        [JsonProperty("PocID")]
        public string PocID{ get; set; }

        /// <summary>
        /// Intrusion status
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// Attacker IP
        /// </summary>
        [JsonProperty("SourceIP")]
        public string SourceIP{ get; set; }

        /// <summary>
        /// Region of the attacker IP
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// Number of events
        /// </summary>
        [JsonProperty("EventCount")]
        public long? EventCount{ get; set; }

        /// <summary>
        /// Container ID
        /// </summary>
        [JsonProperty("ContainerID")]
        public string ContainerID{ get; set; }

        /// <summary>
        /// Container name
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// Image ID
        /// </summary>
        [JsonProperty("ImageID")]
        public string ImageID{ get; set; }

        /// <summary>
        /// Image name
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// Processing status
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Attacker port
        /// </summary>
        [JsonProperty("SourcePort")]
        public string[] SourcePort{ get; set; }

        /// <summary>
        /// Event ID
        /// </summary>
        [JsonProperty("EventID")]
        public long? EventID{ get; set; }

        /// <summary>
        /// Server name
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// Server private IP
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// Server public IP
        /// </summary>
        [JsonProperty("PublicIP")]
        public string PublicIP{ get; set; }

        /// <summary>
        /// Pod name
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// Harm description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Fix suggestion
        /// </summary>
        [JsonProperty("OfficialSolution")]
        public string OfficialSolution{ get; set; }

        /// <summary>
        /// Attack packet
        /// </summary>
        [JsonProperty("NetworkPayload")]
        public string NetworkPayload{ get; set; }

        /// <summary>
        /// Process PID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PID")]
        public long? PID{ get; set; }

        /// <summary>
        /// Main class name of the process
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MainClass")]
        public string MainClass{ get; set; }

        /// <summary>
        /// Stack information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StackTrace")]
        public string StackTrace{ get; set; }

        /// <summary>
        /// Listened account
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServerAccount")]
        public string ServerAccount{ get; set; }

        /// <summary>
        /// Listened port
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServerPort")]
        public string ServerPort{ get; set; }

        /// <summary>
        /// Process path
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServerExe")]
        public string ServerExe{ get; set; }

        /// <summary>
        /// Process command line parameter
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServerArg")]
        public string ServerArg{ get; set; }

        /// <summary>
        /// Server QUuid
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QUUID")]
        public string QUUID{ get; set; }

        /// <summary>
        /// Isolation status
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
        /// 	"NODE_DESTROYED"      // The node is terminated.
        /// 	"CONTAINER_EXITED"    // The container exited.
        /// 	"CONTAINER_DESTROYED" // The container was terminated.
        /// 	"SHARED_HOST"         // The container shares the network with the server.
        /// 	"RESOURCE_LIMIT"      // The number of resources to be isolated exceeds the limit.
        /// 	"UNKNOW"              // The reason is unknown.
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
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContainerStatus")]
        public string ContainerStatus{ get; set; }

        /// <summary>
        /// API URL
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("JNDIUrl")]
        public string JNDIUrl{ get; set; }

        /// <summary>
        /// RASP details
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("RaspDetail")]
        public RaspInfo[] RaspDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CVEID", this.CVEID);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "PocID", this.PocID);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "SourceIP", this.SourceIP);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "ContainerID", this.ContainerID);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "ImageID", this.ImageID);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "SourcePort.", this.SourcePort);
            this.SetParamSimple(map, prefix + "EventID", this.EventID);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "PublicIP", this.PublicIP);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "OfficialSolution", this.OfficialSolution);
            this.SetParamSimple(map, prefix + "NetworkPayload", this.NetworkPayload);
            this.SetParamSimple(map, prefix + "PID", this.PID);
            this.SetParamSimple(map, prefix + "MainClass", this.MainClass);
            this.SetParamSimple(map, prefix + "StackTrace", this.StackTrace);
            this.SetParamSimple(map, prefix + "ServerAccount", this.ServerAccount);
            this.SetParamSimple(map, prefix + "ServerPort", this.ServerPort);
            this.SetParamSimple(map, prefix + "ServerExe", this.ServerExe);
            this.SetParamSimple(map, prefix + "ServerArg", this.ServerArg);
            this.SetParamSimple(map, prefix + "QUUID", this.QUUID);
            this.SetParamSimple(map, prefix + "ContainerNetStatus", this.ContainerNetStatus);
            this.SetParamSimple(map, prefix + "ContainerNetSubStatus", this.ContainerNetSubStatus);
            this.SetParamSimple(map, prefix + "ContainerIsolateOperationSrc", this.ContainerIsolateOperationSrc);
            this.SetParamSimple(map, prefix + "ContainerStatus", this.ContainerStatus);
            this.SetParamSimple(map, prefix + "JNDIUrl", this.JNDIUrl);
            this.SetParamArrayObj(map, prefix + "RaspDetail.", this.RaspDetail);
        }
    }
}

