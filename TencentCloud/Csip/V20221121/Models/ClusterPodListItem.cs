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

    public class ClusterPodListItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Asset id</p>
        /// </summary>
        [JsonProperty("AssetId")]
        [System.Obsolete]
        public string AssetId{ get; set; }

        /// <summary>
        /// <p>appid</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>Unique pod id</p>
        /// </summary>
        [JsonProperty("PodUid")]
        public string PodUid{ get; set; }

        /// <summary>
        /// <p>Pod name.</p>
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// <p>Pod IP array</p>
        /// </summary>
        [JsonProperty("PodIPs")]
        public string[] PodIPs{ get; set; }

        /// <summary>
        /// <p>pod status</p>
        /// </summary>
        [JsonProperty("RunStatus")]
        public string RunStatus{ get; set; }

        /// <summary>
        /// <p>Number of protected cores</p>
        /// </summary>
        [JsonProperty("DefendCoresCount")]
        [System.Obsolete]
        public long? DefendCoresCount{ get; set; }

        /// <summary>
        /// <p>Node ID.</p>
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// <p>Node type</p>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>Load Name</p>
        /// </summary>
        [JsonProperty("WorkloadName")]
        public string WorkloadName{ get; set; }

        /// <summary>
        /// <p>Workload type</p>
        /// </summary>
        [JsonProperty("WorkloadType")]
        public string WorkloadType{ get; set; }

        /// <summary>
        /// <p>Namespace.</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Unique Pod identifier ID</p>
        /// </summary>
        [JsonProperty("UniqueID")]
        public string UniqueID{ get; set; }

        /// <summary>
        /// <p>Critical risk count</p>
        /// </summary>
        [JsonProperty("RiskEventCriticalCount")]
        [System.Obsolete]
        public ulong? RiskEventCriticalCount{ get; set; }

        /// <summary>
        /// <p>Number of high-risk items</p>
        /// </summary>
        [JsonProperty("RiskEventHighCount")]
        [System.Obsolete]
        public ulong? RiskEventHighCount{ get; set; }

        /// <summary>
        /// <p>Number of medium-risk items</p>
        /// </summary>
        [JsonProperty("RiskEventMiddleCount")]
        [System.Obsolete]
        public ulong? RiskEventMiddleCount{ get; set; }

        /// <summary>
        /// <p>Number of low risks</p>
        /// </summary>
        [JsonProperty("RiskEventLowCount")]
        [System.Obsolete]
        public ulong? RiskEventLowCount{ get; set; }

        /// <summary>
        /// <p>Number of critical alerts</p>
        /// </summary>
        [JsonProperty("AlarmEventCriticalCount")]
        [System.Obsolete]
        public ulong? AlarmEventCriticalCount{ get; set; }

        /// <summary>
        /// <p>High-risk alarm count</p>
        /// </summary>
        [JsonProperty("AlarmEventHighCount")]
        [System.Obsolete]
        public ulong? AlarmEventHighCount{ get; set; }

        /// <summary>
        /// <p>Number of medium-risk alerts</p>
        /// </summary>
        [JsonProperty("AlarmEventMiddleCount")]
        [System.Obsolete]
        public ulong? AlarmEventMiddleCount{ get; set; }

        /// <summary>
        /// <p>Number of low-risk alarms</p>
        /// </summary>
        [JsonProperty("AlarmEventLowCount")]
        [System.Obsolete]
        public ulong? AlarmEventLowCount{ get; set; }

        /// <summary>
        /// <p>Associated container list</p>
        /// </summary>
        [JsonProperty("ContainerList")]
        public ClusterContainerListItem[] ContainerList{ get; set; }

        /// <summary>
        /// <p>Number of associated alarms</p>
        /// </summary>
        [JsonProperty("AlarmCount")]
        public ulong? AlarmCount{ get; set; }

        /// <summary>
        /// <p>Number of cores.</p><p>Unit: millicore.</p>
        /// </summary>
        [JsonProperty("CoresCount")]
        public long? CoresCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "PodUid", this.PodUid);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamArraySimple(map, prefix + "PodIPs.", this.PodIPs);
            this.SetParamSimple(map, prefix + "RunStatus", this.RunStatus);
            this.SetParamSimple(map, prefix + "DefendCoresCount", this.DefendCoresCount);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "WorkloadName", this.WorkloadName);
            this.SetParamSimple(map, prefix + "WorkloadType", this.WorkloadType);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UniqueID", this.UniqueID);
            this.SetParamSimple(map, prefix + "RiskEventCriticalCount", this.RiskEventCriticalCount);
            this.SetParamSimple(map, prefix + "RiskEventHighCount", this.RiskEventHighCount);
            this.SetParamSimple(map, prefix + "RiskEventMiddleCount", this.RiskEventMiddleCount);
            this.SetParamSimple(map, prefix + "RiskEventLowCount", this.RiskEventLowCount);
            this.SetParamSimple(map, prefix + "AlarmEventCriticalCount", this.AlarmEventCriticalCount);
            this.SetParamSimple(map, prefix + "AlarmEventHighCount", this.AlarmEventHighCount);
            this.SetParamSimple(map, prefix + "AlarmEventMiddleCount", this.AlarmEventMiddleCount);
            this.SetParamSimple(map, prefix + "AlarmEventLowCount", this.AlarmEventLowCount);
            this.SetParamArrayObj(map, prefix + "ContainerList.", this.ContainerList);
            this.SetParamSimple(map, prefix + "AlarmCount", this.AlarmCount);
            this.SetParamSimple(map, prefix + "CoresCount", this.CoresCount);
        }
    }
}

