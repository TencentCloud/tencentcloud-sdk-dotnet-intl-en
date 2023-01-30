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

    public class DescribeAssetHostDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// CWPP UUID
        /// </summary>
        [JsonProperty("UUID")]
        public string UUID{ get; set; }

        /// <summary>
        /// Update time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Server name
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// Server group
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// Server IP
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// OS
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// Agent version
        /// </summary>
        [JsonProperty("AgentVersion")]
        public string AgentVersion{ get; set; }

        /// <summary>
        /// Kernel version
        /// </summary>
        [JsonProperty("KernelVersion")]
        public string KernelVersion{ get; set; }

        /// <summary>
        /// Docker version
        /// </summary>
        [JsonProperty("DockerVersion")]
        public string DockerVersion{ get; set; }

        /// <summary>
        /// Docker API version
        /// </summary>
        [JsonProperty("DockerAPIVersion")]
        public string DockerAPIVersion{ get; set; }

        /// <summary>
        /// Docker version for Go
        /// </summary>
        [JsonProperty("DockerGoVersion")]
        public string DockerGoVersion{ get; set; }

        /// <summary>
        /// Docker file system type
        /// </summary>
        [JsonProperty("DockerFileSystemDriver")]
        public string DockerFileSystemDriver{ get; set; }

        /// <summary>
        /// Docker root directory
        /// </summary>
        [JsonProperty("DockerRootDir")]
        public string DockerRootDir{ get; set; }

        /// <summary>
        /// Number of images
        /// </summary>
        [JsonProperty("ImageCnt")]
        public ulong? ImageCnt{ get; set; }

        /// <summary>
        /// Number of containers
        /// </summary>
        [JsonProperty("ContainerCnt")]
        public ulong? ContainerCnt{ get; set; }

        /// <summary>
        /// K8s IP
        /// </summary>
        [JsonProperty("K8sMasterIP")]
        public string K8sMasterIP{ get; set; }

        /// <summary>
        /// K8s version
        /// </summary>
        [JsonProperty("K8sVersion")]
        public string K8sVersion{ get; set; }

        /// <summary>
        /// kube proxy
        /// </summary>
        [JsonProperty("KubeProxyVersion")]
        public string KubeProxyVersion{ get; set; }

        /// <summary>
        /// Valid values: `UNINSTALL` (not installed); `OFFLINE` (offline); `ONLINE` (defended).
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Whether it is Containerd
        /// </summary>
        [JsonProperty("IsContainerd")]
        public bool? IsContainerd{ get; set; }

        /// <summary>
        /// Server source. Valid values: `TENCENTCLOUD` (Tencent Cloud instance); `OTHERCLOUD` (non-Tencent Cloud instance).
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// Public IP
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// Server instance ID
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// Region ID
        /// </summary>
        [JsonProperty("RegionID")]
        public long? RegionID{ get; set; }

        /// <summary>
        /// Project
        /// </summary>
        [JsonProperty("Project")]
        public ProjectInfo Project{ get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UUID", this.UUID);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "AgentVersion", this.AgentVersion);
            this.SetParamSimple(map, prefix + "KernelVersion", this.KernelVersion);
            this.SetParamSimple(map, prefix + "DockerVersion", this.DockerVersion);
            this.SetParamSimple(map, prefix + "DockerAPIVersion", this.DockerAPIVersion);
            this.SetParamSimple(map, prefix + "DockerGoVersion", this.DockerGoVersion);
            this.SetParamSimple(map, prefix + "DockerFileSystemDriver", this.DockerFileSystemDriver);
            this.SetParamSimple(map, prefix + "DockerRootDir", this.DockerRootDir);
            this.SetParamSimple(map, prefix + "ImageCnt", this.ImageCnt);
            this.SetParamSimple(map, prefix + "ContainerCnt", this.ContainerCnt);
            this.SetParamSimple(map, prefix + "K8sMasterIP", this.K8sMasterIP);
            this.SetParamSimple(map, prefix + "K8sVersion", this.K8sVersion);
            this.SetParamSimple(map, prefix + "KubeProxyVersion", this.KubeProxyVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsContainerd", this.IsContainerd);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "RegionID", this.RegionID);
            this.SetParamObj(map, prefix + "Project.", this.Project);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

