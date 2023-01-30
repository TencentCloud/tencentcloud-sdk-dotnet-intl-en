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

    public class DescribeAssetContainerDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// Server ID
        /// </summary>
        [JsonProperty("HostID")]
        public string HostID{ get; set; }

        /// <summary>
        /// Server IP
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// Container name
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Operator
        /// </summary>
        [JsonProperty("RunAs")]
        public string RunAs{ get; set; }

        /// <summary>
        /// Command line
        /// </summary>
        [JsonProperty("Cmd")]
        public string Cmd{ get; set; }

        /// <summary>
        /// CPU utilization * 1000
        /// </summary>
        [JsonProperty("CPUUsage")]
        public ulong? CPUUsage{ get; set; }

        /// <summary>
        /// Memory usage in KB
        /// </summary>
        [JsonProperty("RamUsage")]
        public ulong? RamUsage{ get; set; }

        /// <summary>
        /// Image name
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// Image ID
        /// </summary>
        [JsonProperty("ImageID")]
        public string ImageID{ get; set; }

        /// <summary>
        /// Pod
        /// </summary>
        [JsonProperty("POD")]
        public string POD{ get; set; }

        /// <summary>
        /// K8s master node
        /// </summary>
        [JsonProperty("K8sMaster")]
        public string K8sMaster{ get; set; }

        /// <summary>
        /// Number of processes in the container
        /// </summary>
        [JsonProperty("ProcessCnt")]
        public ulong? ProcessCnt{ get; set; }

        /// <summary>
        /// Number of ports in the container
        /// </summary>
        [JsonProperty("PortCnt")]
        public ulong? PortCnt{ get; set; }

        /// <summary>
        /// Number of components
        /// </summary>
        [JsonProperty("ComponentCnt")]
        public ulong? ComponentCnt{ get; set; }

        /// <summary>
        /// Number of applications
        /// </summary>
        [JsonProperty("AppCnt")]
        public ulong? AppCnt{ get; set; }

        /// <summary>
        /// Number of web services
        /// </summary>
        [JsonProperty("WebServiceCnt")]
        public ulong? WebServiceCnt{ get; set; }

        /// <summary>
        /// Mount
        /// </summary>
        [JsonProperty("Mounts")]
        public ContainerMount[] Mounts{ get; set; }

        /// <summary>
        /// Container network information
        /// </summary>
        [JsonProperty("Network")]
        public ContainerNetwork Network{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Image creation time
        /// </summary>
        [JsonProperty("ImageCreateTime")]
        public string ImageCreateTime{ get; set; }

        /// <summary>
        /// Image size
        /// </summary>
        [JsonProperty("ImageSize")]
        public ulong? ImageSize{ get; set; }

        /// <summary>
        /// Server status. Valid values: `offline`, `online`, `pause`.
        /// </summary>
        [JsonProperty("HostStatus")]
        public string HostStatus{ get; set; }

        /// <summary>
        /// Network status
        /// `NORMAL`: 	Not isolated.
        /// `ISOLATED`: 		Isolated.
        /// `ISOLATING`: 		Isolating.
        /// `ISOLATE_FAILED`: 	Isolation failed.
        /// `RESTORING`: Recovering.
        /// `RESTORE_FAILED`: Recovery failed.
        /// </summary>
        [JsonProperty("NetStatus")]
        public string NetStatus{ get; set; }

        /// <summary>
        /// Sub-status of the network
        /// </summary>
        [JsonProperty("NetSubStatus")]
        public string NetSubStatus{ get; set; }

        /// <summary>
        /// Isolation source
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsolateSource")]
        public string IsolateSource{ get; set; }

        /// <summary>
        /// Isolation time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsolateTime")]
        public string IsolateTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "HostID", this.HostID);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RunAs", this.RunAs);
            this.SetParamSimple(map, prefix + "Cmd", this.Cmd);
            this.SetParamSimple(map, prefix + "CPUUsage", this.CPUUsage);
            this.SetParamSimple(map, prefix + "RamUsage", this.RamUsage);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageID", this.ImageID);
            this.SetParamSimple(map, prefix + "POD", this.POD);
            this.SetParamSimple(map, prefix + "K8sMaster", this.K8sMaster);
            this.SetParamSimple(map, prefix + "ProcessCnt", this.ProcessCnt);
            this.SetParamSimple(map, prefix + "PortCnt", this.PortCnt);
            this.SetParamSimple(map, prefix + "ComponentCnt", this.ComponentCnt);
            this.SetParamSimple(map, prefix + "AppCnt", this.AppCnt);
            this.SetParamSimple(map, prefix + "WebServiceCnt", this.WebServiceCnt);
            this.SetParamArrayObj(map, prefix + "Mounts.", this.Mounts);
            this.SetParamObj(map, prefix + "Network.", this.Network);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ImageCreateTime", this.ImageCreateTime);
            this.SetParamSimple(map, prefix + "ImageSize", this.ImageSize);
            this.SetParamSimple(map, prefix + "HostStatus", this.HostStatus);
            this.SetParamSimple(map, prefix + "NetStatus", this.NetStatus);
            this.SetParamSimple(map, prefix + "NetSubStatus", this.NetSubStatus);
            this.SetParamSimple(map, prefix + "IsolateSource", this.IsolateSource);
            this.SetParamSimple(map, prefix + "IsolateTime", this.IsolateTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

