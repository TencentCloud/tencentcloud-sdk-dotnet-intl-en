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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterContainerDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>Primary Account AppID</p>
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// <p>Container ID</p>
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// <p>Container startup CMD</p>
        /// </summary>
        [JsonProperty("Cmd")]
        public string Cmd{ get; set; }

        /// <summary>
        /// <p>Container creation time</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Running state</p>
        /// </summary>
        [JsonProperty("RunStatus")]
        public string RunStatus{ get; set; }

        /// <summary>
        /// <p>Isolation status</p>
        /// </summary>
        [JsonProperty("IsolateStatus")]
        public string IsolateStatus{ get; set; }

        /// <summary>
        /// <p>Number of critical risk events</p>
        /// </summary>
        [JsonProperty("RiskEventCriticalCount")]
        [System.Obsolete]
        public long? RiskEventCriticalCount{ get; set; }

        /// <summary>
        /// <p>Number of high-risk events</p>
        /// </summary>
        [JsonProperty("RiskEventHighCount")]
        [System.Obsolete]
        public long? RiskEventHighCount{ get; set; }

        /// <summary>
        /// <p>Number of medium-risk events</p>
        /// </summary>
        [JsonProperty("RiskEventMiddleCount")]
        [System.Obsolete]
        public long? RiskEventMiddleCount{ get; set; }

        /// <summary>
        /// <p>Number of low-risk events</p>
        /// </summary>
        [JsonProperty("RiskEventLowCount")]
        [System.Obsolete]
        public long? RiskEventLowCount{ get; set; }

        /// <summary>
        /// <p>Image name.</p>
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// <p>Image ID.</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>Image size.</p>
        /// </summary>
        [JsonProperty("ImageSize")]
        public string ImageSize{ get; set; }

        /// <summary>
        /// <p>Image creation time</p>
        /// </summary>
        [JsonProperty("ImageCreateTime")]
        public string ImageCreateTime{ get; set; }

        /// <summary>
        /// <p>Node name.</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>Node private network IP</p>
        /// </summary>
        [JsonProperty("NodeInternalIP")]
        public string NodeInternalIP{ get; set; }

        /// <summary>
        /// <p>Node running status</p>
        /// </summary>
        [JsonProperty("NodeRunStatus")]
        public string NodeRunStatus{ get; set; }

        /// <summary>
        /// <p>Mount information list</p>
        /// </summary>
        [JsonProperty("Mounts")]
        public ContainerMountItem[] Mounts{ get; set; }

        /// <summary>
        /// <p>Network name</p>
        /// </summary>
        [JsonProperty("NetworkName")]
        public string NetworkName{ get; set; }

        /// <summary>
        /// <p>Network mode</p>
        /// </summary>
        [JsonProperty("NetworkMode")]
        public string NetworkMode{ get; set; }

        /// <summary>
        /// <p>Network ID</p>
        /// </summary>
        [JsonProperty("NetworkId")]
        public string NetworkId{ get; set; }

        /// <summary>
        /// <p>Endpoint ID</p>
        /// </summary>
        [JsonProperty("EndpointId")]
        public string EndpointId{ get; set; }

        /// <summary>
        /// <p>Gateway address</p>
        /// </summary>
        [JsonProperty("Gateway")]
        public string Gateway{ get; set; }

        /// <summary>
        /// <p>IPv4 address</p>
        /// </summary>
        [JsonProperty("IPv4")]
        public string IPv4{ get; set; }

        /// <summary>
        /// <p>IPv6 address</p>
        /// </summary>
        [JsonProperty("IPv6")]
        public string IPv6{ get; set; }

        /// <summary>
        /// <p>MAC address</p>
        /// </summary>
        [JsonProperty("MAC")]
        public string MAC{ get; set; }

        /// <summary>
        /// <p>Container name</p>
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// <p>Node instance ID</p>
        /// </summary>
        [JsonProperty("NodeInstanceId")]
        public string NodeInstanceId{ get; set; }

        /// <summary>
        /// <p>Node type of the container associated node</p>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>Unique ID of the node associated with the container</p>
        /// </summary>
        [JsonProperty("NodeUniqueID")]
        public string NodeUniqueID{ get; set; }

        /// <summary>
        /// <p>md5 value of the cluster ca certificate of the associated cluster and unique identifier of the cluster</p>
        /// </summary>
        [JsonProperty("ClusterCaMD5")]
        public string ClusterCaMD5{ get; set; }

        /// <summary>
        /// <p>Whether the container image can be associated with records in the mirror repository</p>
        /// </summary>
        [JsonProperty("EnableLinkImage")]
        public bool? EnableLinkImage{ get; set; }

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
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "Cmd", this.Cmd);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "RunStatus", this.RunStatus);
            this.SetParamSimple(map, prefix + "IsolateStatus", this.IsolateStatus);
            this.SetParamSimple(map, prefix + "RiskEventCriticalCount", this.RiskEventCriticalCount);
            this.SetParamSimple(map, prefix + "RiskEventHighCount", this.RiskEventHighCount);
            this.SetParamSimple(map, prefix + "RiskEventMiddleCount", this.RiskEventMiddleCount);
            this.SetParamSimple(map, prefix + "RiskEventLowCount", this.RiskEventLowCount);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ImageSize", this.ImageSize);
            this.SetParamSimple(map, prefix + "ImageCreateTime", this.ImageCreateTime);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "NodeInternalIP", this.NodeInternalIP);
            this.SetParamSimple(map, prefix + "NodeRunStatus", this.NodeRunStatus);
            this.SetParamArrayObj(map, prefix + "Mounts.", this.Mounts);
            this.SetParamSimple(map, prefix + "NetworkName", this.NetworkName);
            this.SetParamSimple(map, prefix + "NetworkMode", this.NetworkMode);
            this.SetParamSimple(map, prefix + "NetworkId", this.NetworkId);
            this.SetParamSimple(map, prefix + "EndpointId", this.EndpointId);
            this.SetParamSimple(map, prefix + "Gateway", this.Gateway);
            this.SetParamSimple(map, prefix + "IPv4", this.IPv4);
            this.SetParamSimple(map, prefix + "IPv6", this.IPv6);
            this.SetParamSimple(map, prefix + "MAC", this.MAC);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "NodeInstanceId", this.NodeInstanceId);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeUniqueID", this.NodeUniqueID);
            this.SetParamSimple(map, prefix + "ClusterCaMD5", this.ClusterCaMD5);
            this.SetParamSimple(map, prefix + "EnableLinkImage", this.EnableLinkImage);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

