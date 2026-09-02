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

    public class ClusterListItem : AbstractModel
    {
        
        /// <summary>
        /// <p>appid</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>Asset id</p>
        /// </summary>
        [JsonProperty("AssetId")]
        [System.Obsolete]
        public string AssetId{ get; set; }

        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Cluster name.</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>Cluster type<br>MANAGED_CLUSTER: managed cluster</p>
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <p>Number of critical alarm events</p>
        /// </summary>
        [JsonProperty("AlarmEventCriticalCount")]
        [System.Obsolete]
        public ulong? AlarmEventCriticalCount{ get; set; }

        /// <summary>
        /// <p>Number of high-risk alarm events</p>
        /// </summary>
        [JsonProperty("AlarmEventHighCount")]
        [System.Obsolete]
        public ulong? AlarmEventHighCount{ get; set; }

        /// <summary>
        /// <p>Number of medium-risk alarm events</p>
        /// </summary>
        [JsonProperty("AlarmEventMiddleCount")]
        [System.Obsolete]
        public ulong? AlarmEventMiddleCount{ get; set; }

        /// <summary>
        /// <p>Number of low-risk alarm events</p>
        /// </summary>
        [JsonProperty("AlarmEventLowCount")]
        [System.Obsolete]
        public ulong? AlarmEventLowCount{ get; set; }

        /// <summary>
        /// <p>Number of critical risk events</p>
        /// </summary>
        [JsonProperty("RiskEventCriticalCount")]
        [System.Obsolete]
        public ulong? RiskEventCriticalCount{ get; set; }

        /// <summary>
        /// <p>Number of high-severity risk events</p>
        /// </summary>
        [JsonProperty("RiskEventHighCount")]
        [System.Obsolete]
        public ulong? RiskEventHighCount{ get; set; }

        /// <summary>
        /// <p>Number of medium-risk events</p>
        /// </summary>
        [JsonProperty("RiskEventMiddleCount")]
        [System.Obsolete]
        public ulong? RiskEventMiddleCount{ get; set; }

        /// <summary>
        /// <p>Number of low-risk events</p>
        /// </summary>
        [JsonProperty("RiskEventLowCount")]
        [System.Obsolete]
        public ulong? RiskEventLowCount{ get; set; }

        /// <summary>
        /// <p>Total nodes</p>
        /// </summary>
        [JsonProperty("NodeCount")]
        public ulong? NodeCount{ get; set; }

        /// <summary>
        /// <p>Total number of offline nodes</p>
        /// </summary>
        [JsonProperty("OfflineNodeCount")]
        public ulong? OfflineNodeCount{ get; set; }

        /// <summary>
        /// <p>Total number of nodes not installed</p>
        /// </summary>
        [JsonProperty("UninstallNodeCount")]
        public ulong? UninstallNodeCount{ get; set; }

        /// <summary>
        /// <p>Total cores.</p>
        /// </summary>
        [JsonProperty("TotalCoresCount")]
        public long? TotalCoresCount{ get; set; }

        /// <summary>
        /// <p>Number of protected cores</p>
        /// </summary>
        [JsonProperty("DefendCoresCount")]
        [System.Obsolete]
        public long? DefendCoresCount{ get; set; }

        /// <summary>
        /// <p>Audit log switch<br>(0: off; 1: on; 2: activation fail; 3: failed to close)</p>
        /// </summary>
        [JsonProperty("AuditLogSwitchStatus")]
        public long? AuditLogSwitchStatus{ get; set; }

        /// <summary>
        /// <p>Protection status<br>Defended: Defended</p>
        /// </summary>
        [JsonProperty("DefendStatus")]
        public string DefendStatus{ get; set; }

        /// <summary>
        /// <p>Cluster status</p>
        /// </summary>
        [JsonProperty("RunStatus")]
        public string RunStatus{ get; set; }

        /// <summary>
        /// <p>Region.</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>K8s version.</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>Most recent asset synchronization time</p>
        /// </summary>
        [JsonProperty("LastAssetSyncTime")]
        public string LastAssetSyncTime{ get; set; }

        /// <summary>
        /// <p>Last risk check time</p>
        /// </summary>
        [JsonProperty("LastRiskCheckTime")]
        public string LastRiskCheckTime{ get; set; }

        /// <summary>
        /// <p>Risk status</p>
        /// </summary>
        [JsonProperty("RiskStatus")]
        public string RiskStatus{ get; set; }

        /// <summary>
        /// <p>Tag list.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public AssetTag[] Tags{ get; set; }

        /// <summary>
        /// <p>Owner name</p>
        /// </summary>
        [JsonProperty("OwnerName")]
        public string OwnerName{ get; set; }

        /// <summary>
        /// <p>Failure reason</p>
        /// </summary>
        [JsonProperty("FailMessage")]
        public string FailMessage{ get; set; }

        /// <summary>
        /// <p>Operating sub-status</p>
        /// </summary>
        [JsonProperty("RunSubStatus")]
        public string RunSubStatus{ get; set; }

        /// <summary>
        /// <p>Cluster access status</p><p>Enumeration values:</p><ul><li>AccessedNone: not connected</li><li>AccessedInstalling: connecting</li><li>AccessedInstalled: connected - unprotected</li><li>AccessedUninstalling: uninstalling</li><li>AccessedUninstallException: uninstallation exception</li><li>AccessedDefended: connected - defended</li><li>AccessedPartialDefence: connected - partially defended</li><li>AccessedException: access exception</li></ul>
        /// </summary>
        [JsonProperty("AccessedStatus")]
        public string AccessedStatus{ get; set; }

        /// <summary>
        /// <p>Integration sub-status</p>
        /// </summary>
        [JsonProperty("AccessedSubStatus")]
        public string AccessedSubStatus{ get; set; }

        /// <summary>
        /// <p>Cluster ca certificate md5 value, unique cluster id</p>
        /// </summary>
        [JsonProperty("ClusterCaMD5")]
        public string ClusterCaMD5{ get; set; }

        /// <summary>
        /// <p>Asset synchronization status</p><p>Enumeration values:</p><ul><li>AssetCheckNone: initial state</li><li>AssetCheckSync: synchronizing</li><li>AssetCheckFinished: synchronization complete</li><li>AssetCheckFailed: synchronization failed</li></ul>
        /// </summary>
        [JsonProperty("AssetSyncStatus")]
        public string AssetSyncStatus{ get; set; }

        /// <summary>
        /// <p>Number of cluster configuration risks</p>
        /// </summary>
        [JsonProperty("RiskConfigCount")]
        [System.Obsolete]
        public ulong? RiskConfigCount{ get; set; }

        /// <summary>
        /// <p>Cluster access failure reason</p>
        /// </summary>
        [JsonProperty("AccessFailedMessage")]
        [System.Obsolete]
        public string AccessFailedMessage{ get; set; }

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
        /// <p>Number of nodes not bound to the Ultimate Edition</p>
        /// </summary>
        [JsonProperty("UnboundUltimateNodeCount")]
        public ulong? UnboundUltimateNodeCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "AlarmEventCriticalCount", this.AlarmEventCriticalCount);
            this.SetParamSimple(map, prefix + "AlarmEventHighCount", this.AlarmEventHighCount);
            this.SetParamSimple(map, prefix + "AlarmEventMiddleCount", this.AlarmEventMiddleCount);
            this.SetParamSimple(map, prefix + "AlarmEventLowCount", this.AlarmEventLowCount);
            this.SetParamSimple(map, prefix + "RiskEventCriticalCount", this.RiskEventCriticalCount);
            this.SetParamSimple(map, prefix + "RiskEventHighCount", this.RiskEventHighCount);
            this.SetParamSimple(map, prefix + "RiskEventMiddleCount", this.RiskEventMiddleCount);
            this.SetParamSimple(map, prefix + "RiskEventLowCount", this.RiskEventLowCount);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "OfflineNodeCount", this.OfflineNodeCount);
            this.SetParamSimple(map, prefix + "UninstallNodeCount", this.UninstallNodeCount);
            this.SetParamSimple(map, prefix + "TotalCoresCount", this.TotalCoresCount);
            this.SetParamSimple(map, prefix + "DefendCoresCount", this.DefendCoresCount);
            this.SetParamSimple(map, prefix + "AuditLogSwitchStatus", this.AuditLogSwitchStatus);
            this.SetParamSimple(map, prefix + "DefendStatus", this.DefendStatus);
            this.SetParamSimple(map, prefix + "RunStatus", this.RunStatus);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "LastAssetSyncTime", this.LastAssetSyncTime);
            this.SetParamSimple(map, prefix + "LastRiskCheckTime", this.LastRiskCheckTime);
            this.SetParamSimple(map, prefix + "RiskStatus", this.RiskStatus);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "OwnerName", this.OwnerName);
            this.SetParamSimple(map, prefix + "FailMessage", this.FailMessage);
            this.SetParamSimple(map, prefix + "RunSubStatus", this.RunSubStatus);
            this.SetParamSimple(map, prefix + "AccessedStatus", this.AccessedStatus);
            this.SetParamSimple(map, prefix + "AccessedSubStatus", this.AccessedSubStatus);
            this.SetParamSimple(map, prefix + "ClusterCaMD5", this.ClusterCaMD5);
            this.SetParamSimple(map, prefix + "AssetSyncStatus", this.AssetSyncStatus);
            this.SetParamSimple(map, prefix + "RiskConfigCount", this.RiskConfigCount);
            this.SetParamSimple(map, prefix + "AccessFailedMessage", this.AccessFailedMessage);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "RegionNameEn", this.RegionNameEn);
            this.SetParamSimple(map, prefix + "UnboundUltimateNodeCount", this.UnboundUltimateNodeCount);
        }
    }
}

