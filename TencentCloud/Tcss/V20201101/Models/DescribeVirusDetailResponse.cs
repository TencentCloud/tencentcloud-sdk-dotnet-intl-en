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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVirusDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// Image ID
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// Image name
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Trojan File Size
        /// </summary>
        [JsonProperty("Size")]
        public ulong? Size{ get; set; }

        /// <summary>
        /// Trojan file path
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// Latest creation time
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Virus name
        /// </summary>
        [JsonProperty("VirusName")]
        public string VirusName{ get; set; }

        /// <summary>
        /// Risk Level: RISK_CRITICAL, RISK_HIGH, RISK_MEDIUM, RISK_LOW, and RISK_NOTICE
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// Container name
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// Container id
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// Host name
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// Host ID
        /// </summary>
        [JsonProperty("HostId")]
        public string HostId{ get; set; }

        /// <summary>
        /// Process name
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// Process path
        /// </summary>
        [JsonProperty("ProcessPath")]
        public string ProcessPath{ get; set; }

        /// <summary>
        /// Process md5
        /// </summary>
        [JsonProperty("ProcessMd5")]
        public string ProcessMd5{ get; set; }

        /// <summary>
        /// Process id
        /// </summary>
        [JsonProperty("ProcessId")]
        public ulong? ProcessId{ get; set; }

        /// <summary>
        /// Process parameter
        /// </summary>
        [JsonProperty("ProcessArgv")]
        public string ProcessArgv{ get; set; }

        /// <summary>
        /// Process chain
        /// </summary>
        [JsonProperty("ProcessChan")]
        public string ProcessChan{ get; set; }

        /// <summary>
        /// Process Group
        /// </summary>
        [JsonProperty("ProcessAccountGroup")]
        public string ProcessAccountGroup{ get; set; }

        /// <summary>
        /// process initiator
        /// </summary>
        [JsonProperty("ProcessStartAccount")]
        public string ProcessStartAccount{ get; set; }

        /// <summary>
        /// Process file permission
        /// </summary>
        [JsonProperty("ProcessFileAuthority")]
        public string ProcessFileAuthority{ get; set; }

        /// <summary>
        /// Source. 0: One-Click Scan; 1: Scheduled Scan; 2: Real-Time Monitoring
        /// </summary>
        [JsonProperty("SourceType")]
        public long? SourceType{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// Event description
        /// </summary>
        [JsonProperty("HarmDescribe")]
        public string HarmDescribe{ get; set; }

        /// <summary>
        /// Recommended solution
        /// </summary>
        [JsonProperty("SuggestScheme")]
        public string SuggestScheme{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Mark")]
        public string Mark{ get; set; }

        /// <summary>
        /// Risk File Name
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// File MD5
        /// </summary>
        [JsonProperty("FileMd5")]
        public string FileMd5{ get; set; }

        /// <summary>
        /// Event type
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// Cluster name.
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// DEAL_NONE: File pending
        /// DEAL_IGNORE: Already ignored
        /// DEAL_ADD_WHITELIST: Add to whitelist
        /// DEAL_DEL: File deleted
        /// DEAL_ISOLATE: Has been isolated
        /// DEAL_ISOLATING: Isolated
        /// DEAL_ISOLATE_FAILED: Isolation failed
        /// DEAL_RECOVERING: Recovering
        /// DEAL_RECOVER_FAILED: Recovery failed
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Failed sub-status
        /// FILE_NOT_FOUND: File not found
        /// FILE_ABNORMAL: File abnormality
        /// FILE_ABNORMAL_DEAL_RECOVER: File abnormality when recovering file
        /// BACKUP FILE NOT FOUND
        /// CONTAINER_NOT_FOUND_DEAL_ISOLATE: Container not found in isolation
        /// CONTAINER_NOT_FOUND_DEAL_RECOVER: Container not found when recovering
        /// </summary>
        [JsonProperty("SubStatus")]
        public string SubStatus{ get; set; }

        /// <summary>
        /// Private IP address
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// Public IP address
        /// </summary>
        [JsonProperty("ClientIP")]
        public string ClientIP{ get; set; }

        /// <summary>
        /// Parent Process Startup User
        /// </summary>
        [JsonProperty("PProcessStartUser")]
        public string PProcessStartUser{ get; set; }

        /// <summary>
        /// Parent process user group
        /// </summary>
        [JsonProperty("PProcessUserGroup")]
        public string PProcessUserGroup{ get; set; }

        /// <summary>
        /// Parent process path
        /// </summary>
        [JsonProperty("PProcessPath")]
        public string PProcessPath{ get; set; }

        /// <summary>
        /// Parent Process Command Line Parameters
        /// </summary>
        [JsonProperty("PProcessParam")]
        public string PProcessParam{ get; set; }

        /// <summary>
        /// Ancestor Process Startup User
        /// </summary>
        [JsonProperty("AncestorProcessStartUser")]
        public string AncestorProcessStartUser{ get; set; }

        /// <summary>
        /// Ancestor Process User Group
        /// </summary>
        [JsonProperty("AncestorProcessUserGroup")]
        public string AncestorProcessUserGroup{ get; set; }

        /// <summary>
        /// Ancestor process path
        /// </summary>
        [JsonProperty("AncestorProcessPath")]
        public string AncestorProcessPath{ get; set; }

        /// <summary>
        /// Ancestor Process Command Line Parameters
        /// </summary>
        [JsonProperty("AncestorProcessParam")]
        public string AncestorProcessParam{ get; set; }

        /// <summary>
        /// Last Time for Event Handling
        /// </summary>
        [JsonProperty("OperationTime")]
        public string OperationTime{ get; set; }

        /// <summary>
        /// Container isolation status
        /// </summary>
        [JsonProperty("ContainerNetStatus")]
        public string ContainerNetStatus{ get; set; }

        /// <summary>
        /// Container Isolation Sub-status
        /// </summary>
        [JsonProperty("ContainerNetSubStatus")]
        public string ContainerNetSubStatus{ get; set; }

        /// <summary>
        /// Container Isolation Operation Source
        /// </summary>
        [JsonProperty("ContainerIsolateOperationSrc")]
        public string ContainerIsolateOperationSrc{ get; set; }

        /// <summary>
        /// detection platform
        /// 1: Cloud Killing Engine
        /// 2: tav
        /// 3: binaryAi
        /// 4: Abnormal behavior
        /// 5: TI
        /// </summary>
        [JsonProperty("CheckPlatform")]
        public string[] CheckPlatform{ get; set; }

        /// <summary>
        /// File Access Time
        /// </summary>
        [JsonProperty("FileAccessTime")]
        public string FileAccessTime{ get; set; }

        /// <summary>
        /// File Modification Time
        /// </summary>
        [JsonProperty("FileModifyTime")]
        public string FileModifyTime{ get; set; }

        /// <summary>
        /// Node subnet ID
        /// </summary>
        [JsonProperty("NodeSubNetID")]
        public string NodeSubNetID{ get; set; }

        /// <summary>
        /// Node subnet name
        /// </summary>
        [JsonProperty("NodeSubNetName")]
        public string NodeSubNetName{ get; set; }

        /// <summary>
        /// Subnet IP range
        /// </summary>
        [JsonProperty("NodeSubNetCIDR")]
        public string NodeSubNetCIDR{ get; set; }

        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// Pod IP
        /// </summary>
        [JsonProperty("PodIP")]
        public string PodIP{ get; set; }

        /// <summary>
        /// Pod status
        /// </summary>
        [JsonProperty("PodStatus")]
        public string PodStatus{ get; set; }

        /// <summary>
        /// UID of the node
        /// </summary>
        [JsonProperty("NodeUniqueID")]
        public string NodeUniqueID{ get; set; }

        /// <summary>
        /// Node type. Values: `NORMAL` (general node), `SUPER` (super node).
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// Node ID
        /// </summary>
        [JsonProperty("NodeID")]
        public string NodeID{ get; set; }

        /// <summary>
        /// Cluster name
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Namespace
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Workload type
        /// </summary>
        [JsonProperty("WorkloadType")]
        public string WorkloadType{ get; set; }

        /// <summary>
        /// Container status.
        /// </summary>
        [JsonProperty("ContainerStatus")]
        public string ContainerStatus{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "VirusName", this.VirusName);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostId", this.HostId);
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "ProcessPath", this.ProcessPath);
            this.SetParamSimple(map, prefix + "ProcessMd5", this.ProcessMd5);
            this.SetParamSimple(map, prefix + "ProcessId", this.ProcessId);
            this.SetParamSimple(map, prefix + "ProcessArgv", this.ProcessArgv);
            this.SetParamSimple(map, prefix + "ProcessChan", this.ProcessChan);
            this.SetParamSimple(map, prefix + "ProcessAccountGroup", this.ProcessAccountGroup);
            this.SetParamSimple(map, prefix + "ProcessStartAccount", this.ProcessStartAccount);
            this.SetParamSimple(map, prefix + "ProcessFileAuthority", this.ProcessFileAuthority);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "HarmDescribe", this.HarmDescribe);
            this.SetParamSimple(map, prefix + "SuggestScheme", this.SuggestScheme);
            this.SetParamSimple(map, prefix + "Mark", this.Mark);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileMd5", this.FileMd5);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SubStatus", this.SubStatus);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "ClientIP", this.ClientIP);
            this.SetParamSimple(map, prefix + "PProcessStartUser", this.PProcessStartUser);
            this.SetParamSimple(map, prefix + "PProcessUserGroup", this.PProcessUserGroup);
            this.SetParamSimple(map, prefix + "PProcessPath", this.PProcessPath);
            this.SetParamSimple(map, prefix + "PProcessParam", this.PProcessParam);
            this.SetParamSimple(map, prefix + "AncestorProcessStartUser", this.AncestorProcessStartUser);
            this.SetParamSimple(map, prefix + "AncestorProcessUserGroup", this.AncestorProcessUserGroup);
            this.SetParamSimple(map, prefix + "AncestorProcessPath", this.AncestorProcessPath);
            this.SetParamSimple(map, prefix + "AncestorProcessParam", this.AncestorProcessParam);
            this.SetParamSimple(map, prefix + "OperationTime", this.OperationTime);
            this.SetParamSimple(map, prefix + "ContainerNetStatus", this.ContainerNetStatus);
            this.SetParamSimple(map, prefix + "ContainerNetSubStatus", this.ContainerNetSubStatus);
            this.SetParamSimple(map, prefix + "ContainerIsolateOperationSrc", this.ContainerIsolateOperationSrc);
            this.SetParamArraySimple(map, prefix + "CheckPlatform.", this.CheckPlatform);
            this.SetParamSimple(map, prefix + "FileAccessTime", this.FileAccessTime);
            this.SetParamSimple(map, prefix + "FileModifyTime", this.FileModifyTime);
            this.SetParamSimple(map, prefix + "NodeSubNetID", this.NodeSubNetID);
            this.SetParamSimple(map, prefix + "NodeSubNetName", this.NodeSubNetName);
            this.SetParamSimple(map, prefix + "NodeSubNetCIDR", this.NodeSubNetCIDR);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "PodIP", this.PodIP);
            this.SetParamSimple(map, prefix + "PodStatus", this.PodStatus);
            this.SetParamSimple(map, prefix + "NodeUniqueID", this.NodeUniqueID);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeID", this.NodeID);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "WorkloadType", this.WorkloadType);
            this.SetParamSimple(map, prefix + "ContainerStatus", this.ContainerStatus);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

