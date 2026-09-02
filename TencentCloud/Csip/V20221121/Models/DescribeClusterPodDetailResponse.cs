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

    public class DescribeClusterPodDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>Pod unique ID</p>
        /// </summary>
        [JsonProperty("UniqueID")]
        public string UniqueID{ get; set; }

        /// <summary>
        /// <p>Primary Account AppID</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>Pod name</p>
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// <p>Pod IP address</p>
        /// </summary>
        [JsonProperty("PodIP")]
        public string PodIP{ get; set; }

        /// <summary>
        /// <p>Pod running state</p>
        /// </summary>
        [JsonProperty("RunStatus")]
        public string RunStatus{ get; set; }

        /// <summary>
        /// <p>Pod Labels list</p>
        /// </summary>
        [JsonProperty("Labels")]
        public AssetTag[] Labels{ get; set; }

        /// <summary>
        /// <p>Pod startup time</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>Start time (seconds)</p>
        /// </summary>
        [JsonProperty("StartupTime")]
        public ulong? StartupTime{ get; set; }

        /// <summary>
        /// <p>Pod restart count</p>
        /// </summary>
        [JsonProperty("RestartCount")]
        public ulong? RestartCount{ get; set; }

        /// <summary>
        /// <p>Cluster Name</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>Cluster ID</p>
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// <p>Cluster type</p>
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <p>Cluster operation status</p>
        /// </summary>
        [JsonProperty("ClusterRunStatus")]
        public string ClusterRunStatus{ get; set; }

        /// <summary>
        /// <p>Namespace</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>Node name where it resides.</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>Current node ID</p>
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// <p>Name of the associated Workload</p>
        /// </summary>
        [JsonProperty("WorkloadName")]
        public string WorkloadName{ get; set; }

        /// <summary>
        /// <p>Workload type</p>
        /// </summary>
        [JsonProperty("WorkloadType")]
        public string WorkloadType{ get; set; }

        /// <summary>
        /// <p>Number of critical risk events</p>
        /// </summary>
        [JsonProperty("RiskEventCriticalCount")]
        public ulong? RiskEventCriticalCount{ get; set; }

        /// <summary>
        /// <p>Number of high-risk events</p>
        /// </summary>
        [JsonProperty("RiskEventHighCount")]
        public ulong? RiskEventHighCount{ get; set; }

        /// <summary>
        /// <p>Number of medium-risk events</p>
        /// </summary>
        [JsonProperty("RiskEventMiddleCount")]
        public ulong? RiskEventMiddleCount{ get; set; }

        /// <summary>
        /// <p>Number of low-risk events</p>
        /// </summary>
        [JsonProperty("RiskEventLowCount")]
        public ulong? RiskEventLowCount{ get; set; }

        /// <summary>
        /// <p>Number of critical alarm events</p>
        /// </summary>
        [JsonProperty("AlarmEventCriticalCount")]
        public ulong? AlarmEventCriticalCount{ get; set; }

        /// <summary>
        /// <p>Number of high-risk alarm events</p>
        /// </summary>
        [JsonProperty("AlarmEventHighCount")]
        public ulong? AlarmEventHighCount{ get; set; }

        /// <summary>
        /// <p>Number of medium-risk alarm events</p>
        /// </summary>
        [JsonProperty("AlarmEventMiddleCount")]
        public ulong? AlarmEventMiddleCount{ get; set; }

        /// <summary>
        /// <p>Number of low-risk alarm events</p>
        /// </summary>
        [JsonProperty("AlarmEventLowCount")]
        public ulong? AlarmEventLowCount{ get; set; }

        /// <summary>
        /// <p>Region</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Node private IP</p>
        /// </summary>
        [JsonProperty("NodeInternalIP")]
        public string NodeInternalIP{ get; set; }

        /// <summary>
        /// <p>Node public IP</p>
        /// </summary>
        [JsonProperty("NodeExternalIP")]
        public string NodeExternalIP{ get; set; }

        /// <summary>
        /// <p>Number of associated containers</p>
        /// </summary>
        [JsonProperty("ContainerCount")]
        public ulong? ContainerCount{ get; set; }

        /// <summary>
        /// <p>Number of associated services</p>
        /// </summary>
        [JsonProperty("ServiceCount")]
        public ulong? ServiceCount{ get; set; }

        /// <summary>
        /// <p>Region Chinese Name</p>
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// <p>Region English name</p>
        /// </summary>
        [JsonProperty("RegionNameEn")]
        public string RegionNameEn{ get; set; }

        /// <summary>
        /// <p>Number of alarms.</p>
        /// </summary>
        [JsonProperty("AlarmCount")]
        public ulong? AlarmCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "UniqueID", this.UniqueID);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "PodIP", this.PodIP);
            this.SetParamSimple(map, prefix + "RunStatus", this.RunStatus);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "StartupTime", this.StartupTime);
            this.SetParamSimple(map, prefix + "RestartCount", this.RestartCount);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ClusterRunStatus", this.ClusterRunStatus);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "WorkloadName", this.WorkloadName);
            this.SetParamSimple(map, prefix + "WorkloadType", this.WorkloadType);
            this.SetParamSimple(map, prefix + "RiskEventCriticalCount", this.RiskEventCriticalCount);
            this.SetParamSimple(map, prefix + "RiskEventHighCount", this.RiskEventHighCount);
            this.SetParamSimple(map, prefix + "RiskEventMiddleCount", this.RiskEventMiddleCount);
            this.SetParamSimple(map, prefix + "RiskEventLowCount", this.RiskEventLowCount);
            this.SetParamSimple(map, prefix + "AlarmEventCriticalCount", this.AlarmEventCriticalCount);
            this.SetParamSimple(map, prefix + "AlarmEventHighCount", this.AlarmEventHighCount);
            this.SetParamSimple(map, prefix + "AlarmEventMiddleCount", this.AlarmEventMiddleCount);
            this.SetParamSimple(map, prefix + "AlarmEventLowCount", this.AlarmEventLowCount);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "NodeInternalIP", this.NodeInternalIP);
            this.SetParamSimple(map, prefix + "NodeExternalIP", this.NodeExternalIP);
            this.SetParamSimple(map, prefix + "ContainerCount", this.ContainerCount);
            this.SetParamSimple(map, prefix + "ServiceCount", this.ServiceCount);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "RegionNameEn", this.RegionNameEn);
            this.SetParamSimple(map, prefix + "AlarmCount", this.AlarmCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

