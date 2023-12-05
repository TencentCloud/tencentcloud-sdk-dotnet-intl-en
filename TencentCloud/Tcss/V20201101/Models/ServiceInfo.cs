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

    public class ServiceInfo : AbstractModel
    {
        
        /// <summary>
        /// Service ID
        /// </summary>
        [JsonProperty("ServiceID")]
        public string ServiceID{ get; set; }

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
        /// Service name, such as `nginx` and `redis`
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Version
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Account
        /// </summary>
        [JsonProperty("RunAs")]
        public string RunAs{ get; set; }

        /// <summary>
        /// Listened port
        /// </summary>
        [JsonProperty("Listen")]
        public string[] Listen{ get; set; }

        /// <summary>
        /// Configuration
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// Number of associated processes
        /// </summary>
        [JsonProperty("ProcessCnt")]
        public ulong? ProcessCnt{ get; set; }

        /// <summary>
        /// Access log
        /// </summary>
        [JsonProperty("AccessLog")]
        public string AccessLog{ get; set; }

        /// <summary>
        /// Error log
        /// </summary>
        [JsonProperty("ErrorLog")]
        public string ErrorLog{ get; set; }

        /// <summary>
        /// Data directory
        /// </summary>
        [JsonProperty("DataPath")]
        public string DataPath{ get; set; }

        /// <summary>
        /// Web directory
        /// </summary>
        [JsonProperty("WebRoot")]
        public string WebRoot{ get; set; }

        /// <summary>
        /// ID of the associated process
        /// </summary>
        [JsonProperty("Pids")]
        public ulong?[] Pids{ get; set; }

        /// <summary>
        /// Service type. Valid values: `app`, `web`, `db`.
        /// </summary>
        [JsonProperty("MainType")]
        public string MainType{ get; set; }

        /// <summary>
        /// Execution file
        /// </summary>
        [JsonProperty("Exe")]
        public string Exe{ get; set; }

        /// <summary>
        /// Service command line parameter
        /// </summary>
        [JsonProperty("Parameter")]
        public string Parameter{ get; set; }

        /// <summary>
        /// Container ID
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// Server name
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// Public IP
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// Node ID
        /// </summary>
        [JsonProperty("NodeID")]
        public string NodeID{ get; set; }

        /// <summary>
        /// Pod IP
        /// </summary>
        [JsonProperty("PodIP")]
        public string PodIP{ get; set; }

        /// <summary>
        /// Pod name
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// Node type.
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// UID of the super node
        /// </summary>
        [JsonProperty("NodeUniqueID")]
        public string NodeUniqueID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceID", this.ServiceID);
            this.SetParamSimple(map, prefix + "HostID", this.HostID);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "RunAs", this.RunAs);
            this.SetParamArraySimple(map, prefix + "Listen.", this.Listen);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "ProcessCnt", this.ProcessCnt);
            this.SetParamSimple(map, prefix + "AccessLog", this.AccessLog);
            this.SetParamSimple(map, prefix + "ErrorLog", this.ErrorLog);
            this.SetParamSimple(map, prefix + "DataPath", this.DataPath);
            this.SetParamSimple(map, prefix + "WebRoot", this.WebRoot);
            this.SetParamArraySimple(map, prefix + "Pids.", this.Pids);
            this.SetParamSimple(map, prefix + "MainType", this.MainType);
            this.SetParamSimple(map, prefix + "Exe", this.Exe);
            this.SetParamSimple(map, prefix + "Parameter", this.Parameter);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "NodeID", this.NodeID);
            this.SetParamSimple(map, prefix + "PodIP", this.PodIP);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeUniqueID", this.NodeUniqueID);
        }
    }
}

