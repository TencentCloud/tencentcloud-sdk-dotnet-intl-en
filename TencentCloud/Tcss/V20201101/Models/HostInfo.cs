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

    public class HostInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Host ID.</p>
        /// </summary>
        [JsonProperty("HostID")]
        public string HostID{ get; set; }

        /// <summary>
        /// <p>Host IP address, which is the private IP address.</p>
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// <p>Host name.</p>
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// <p>Business group.</p>
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// <p>Docker version.</p>
        /// </summary>
        [JsonProperty("DockerVersion")]
        public string DockerVersion{ get; set; }

        /// <summary>
        /// <p>Docker file system type.</p>
        /// </summary>
        [JsonProperty("DockerFileSystemDriver")]
        public string DockerFileSystemDriver{ get; set; }

        /// <summary>
        /// <p>Number of images.</p>
        /// </summary>
        [JsonProperty("ImageCnt")]
        public ulong? ImageCnt{ get; set; }

        /// <summary>
        /// <p>Number of containers.</p>
        /// </summary>
        [JsonProperty("ContainerCnt")]
        public ulong? ContainerCnt{ get; set; }

        /// <summary>
        /// <p>Agent running status.</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Whether it is containerd.</p>
        /// </summary>
        [JsonProperty("IsContainerd")]
        public bool? IsContainerd{ get; set; }

        /// <summary>
        /// <p>Server source: one of ["CVM", "ECM", "LH", "BM"] is a Tencent Cloud server; one of ["Other"] is a non-Tencent Cloud server;</p>
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// <p>Public IP address.</p>
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// <p>Host UUID.</p>
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// <p>Host instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>Region ID.</p>
        /// </summary>
        [JsonProperty("RegionID")]
        public long? RegionID{ get; set; }

        /// <summary>
        /// <p>Project.</p>
        /// </summary>
        [JsonProperty("Project")]
        public ProjectInfo Project{ get; set; }

        /// <summary>
        /// <p>Tag.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// <p>Cluster name.</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>Cluster access status.</p>
        /// </summary>
        [JsonProperty("ClusterAccessedStatus")]
        public string ClusterAccessedStatus{ get; set; }

        /// <summary>
        /// <p>Cluster access sub-status.</p><p>Enumeration values:</p><ul><li>AccessedSubNone: none</li><li>AccessedSubUninstallException: uninstallation exception</li><li>AccessedSubTimeout: access timeout</li><li>AccessedSubUninstallTimeout: uninstallation timeout</li><li>AccessedSubResourceException: cluster component check exception, including Deployment and DaemonSet</li><li>AccessedSubCAMPermissionDenied: insufficient CAM permissions</li></ul>
        /// </summary>
        [JsonProperty("ClusterAccessedSubStatus")]
        public string ClusterAccessedSubStatus{ get; set; }

        /// <summary>
        /// <p>Detailed description of the failure reason.</p>
        /// </summary>
        [JsonProperty("ClusterAccessedErrorReason")]
        public string ClusterAccessedErrorReason{ get; set; }

        /// <summary>
        /// <p>Billable cores.</p>
        /// </summary>
        [JsonProperty("ChargeCoresCnt")]
        public ulong? ChargeCoresCnt{ get; set; }

        /// <summary>
        /// <p>Protection status:<br>Defended<br>Undefended</p>
        /// </summary>
        [JsonProperty("DefendStatus")]
        public string DefendStatus{ get; set; }

        /// <summary>
        /// <p>Number of cores.</p>
        /// </summary>
        [JsonProperty("CoresCnt")]
        public ulong? CoresCnt{ get; set; }

        /// <summary>
        /// <p>Last online time.</p>
        /// </summary>
        [JsonProperty("LastOnlineTime")]
        public string LastOnlineTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostID", this.HostID);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "DockerVersion", this.DockerVersion);
            this.SetParamSimple(map, prefix + "DockerFileSystemDriver", this.DockerFileSystemDriver);
            this.SetParamSimple(map, prefix + "ImageCnt", this.ImageCnt);
            this.SetParamSimple(map, prefix + "ContainerCnt", this.ContainerCnt);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsContainerd", this.IsContainerd);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "RegionID", this.RegionID);
            this.SetParamObj(map, prefix + "Project.", this.Project);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterAccessedStatus", this.ClusterAccessedStatus);
            this.SetParamSimple(map, prefix + "ClusterAccessedSubStatus", this.ClusterAccessedSubStatus);
            this.SetParamSimple(map, prefix + "ClusterAccessedErrorReason", this.ClusterAccessedErrorReason);
            this.SetParamSimple(map, prefix + "ChargeCoresCnt", this.ChargeCoresCnt);
            this.SetParamSimple(map, prefix + "DefendStatus", this.DefendStatus);
            this.SetParamSimple(map, prefix + "CoresCnt", this.CoresCnt);
            this.SetParamSimple(map, prefix + "LastOnlineTime", this.LastOnlineTime);
        }
    }
}

