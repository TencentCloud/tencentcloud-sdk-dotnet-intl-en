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

    public class DspmDbAsset : AbstractModel
    {
        
        /// <summary>
        /// <p>Asset instance Id</p>
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// <p>Asset type</p>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// <p>Asset name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Account number</p>
        /// </summary>
        [JsonProperty("AccountCount")]
        public long? AccountCount{ get; set; }

        /// <summary>
        /// <p>Public network access address. If there are multiple, separate them with ';'.</p>
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// <p>Intranet access address. If there are multiple, separate them with ';'</p>
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// <p>WAN domain address. If there are multiple, separate them with ';'</p>
        /// </summary>
        [JsonProperty("WanDomain")]
        public string WanDomain{ get; set; }

        /// <summary>
        /// <p>Region.</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>vpc ID of the vpc where the asset is located</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Name of the vpc where the asset is located</p>
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// <p>Subnet ID of the vpc subnet where the asset is located</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Subnet name of the vpc where the asset is located</p>
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// <p>Instance status</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Admin info.</p>
        /// </summary>
        [JsonProperty("Manager")]
        public DspmUinUser[] Manager{ get; set; }

        /// <summary>
        /// <p>Is the identity bound. 0: not bound; 1: bound</p>
        /// </summary>
        [JsonProperty("BindIdentify")]
        public long? BindIdentify{ get; set; }

        /// <summary>
        /// <p>Admin or not</p>
        /// </summary>
        [JsonProperty("IsManager")]
        public long? IsManager{ get; set; }

        /// <summary>
        /// <p>Risk statistics</p>
        /// </summary>
        [JsonProperty("RiskCount")]
        public DspmRiskCount RiskCount{ get; set; }

        /// <summary>
        /// <p>Security recommendation.<br>Resolve immediate problem-solving<br>Reinforcement<br>None no abnormality detected</p>
        /// </summary>
        [JsonProperty("SafetyAdvice")]
        public string SafetyAdvice{ get; set; }

        /// <summary>
        /// <p>Log delivery status.<br>0 - Delivery off. 1 - Delivery on. 2 - Delivery activating. 3 - Delivery closing.</p>
        /// </summary>
        [JsonProperty("LogDeliveryStatus")]
        public long? LogDeliveryStatus{ get; set; }

        /// <summary>
        /// <p>Whether log shipping is supported. 0: no support; 1: support</p>
        /// </summary>
        [JsonProperty("LogDeliverySupported")]
        public long? LogDeliverySupported{ get; set; }

        /// <summary>
        /// <p>Data scanning info</p>
        /// </summary>
        [JsonProperty("DataScanInfo")]
        public DspmAssetDataScanDetail DataScanInfo{ get; set; }

        /// <summary>
        /// <p>app id of the account to which the asset belongs</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>Account nickname</p>
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// <p>Account uin of asset ownership</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>Security analysis status (0-off, 1-on, 2-activating, 3-disabling)</p>
        /// </summary>
        [JsonProperty("SecurityAnalyseStatus")]
        public long? SecurityAnalyseStatus{ get; set; }

        /// <summary>
        /// <p>Total number of logs for the current instance.</p>
        /// </summary>
        [JsonProperty("TotalAuditLogs")]
        public ulong? TotalAuditLogs{ get; set; }

        /// <summary>
        /// <p>Reasons why log audit is forbidden. Available values: VersionNotSupportLogSubscription, InstanceIsUpgrading, CdbRuleAuditEnabled, AssetNotExists</p>
        /// </summary>
        [JsonProperty("LogDeliveryDisableReason")]
        public string LogDeliveryDisableReason{ get; set; }

        /// <summary>
        /// <p>Start timestamp of online log, accurate to second</p>
        /// </summary>
        [JsonProperty("OldestOnlineLogTimestamp")]
        public ulong? OldestOnlineLogTimestamp{ get; set; }

        /// <summary>
        /// <p>Latest timestamp of the online log, accurate to the second</p>
        /// </summary>
        [JsonProperty("NewestOnlineLogTimestamp")]
        public ulong? NewestOnlineLogTimestamp{ get; set; }

        /// <summary>
        /// <p>Operation error information</p>
        /// </summary>
        [JsonProperty("OperationErrorMsg")]
        public string OperationErrorMsg{ get; set; }

        /// <summary>
        /// <p>Whether account operations are supported. 0: not supported; 1: supported</p>
        /// </summary>
        [JsonProperty("AccountOptSupported")]
        public long? AccountOptSupported{ get; set; }

        /// <summary>
        /// <p>Instance type</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// <p>Cluster type (MongoDB), consistent with ClusterType in the cloud API DescribeDBInstances: 0-replica set, 1-sharding; fixed as 0 for non-MongoDB assets</p>
        /// </summary>
        [JsonProperty("ClusterType")]
        public long? ClusterType{ get; set; }

        /// <summary>
        /// <p>Whether sensitive data identification is supported. 0: not supported; 1: supported</p>
        /// </summary>
        [JsonProperty("IdentifyScanSupported")]
        public long? IdentifyScanSupported{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AccountCount", this.AccountCount);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "WanDomain", this.WanDomain);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "Manager.", this.Manager);
            this.SetParamSimple(map, prefix + "BindIdentify", this.BindIdentify);
            this.SetParamSimple(map, prefix + "IsManager", this.IsManager);
            this.SetParamObj(map, prefix + "RiskCount.", this.RiskCount);
            this.SetParamSimple(map, prefix + "SafetyAdvice", this.SafetyAdvice);
            this.SetParamSimple(map, prefix + "LogDeliveryStatus", this.LogDeliveryStatus);
            this.SetParamSimple(map, prefix + "LogDeliverySupported", this.LogDeliverySupported);
            this.SetParamObj(map, prefix + "DataScanInfo.", this.DataScanInfo);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SecurityAnalyseStatus", this.SecurityAnalyseStatus);
            this.SetParamSimple(map, prefix + "TotalAuditLogs", this.TotalAuditLogs);
            this.SetParamSimple(map, prefix + "LogDeliveryDisableReason", this.LogDeliveryDisableReason);
            this.SetParamSimple(map, prefix + "OldestOnlineLogTimestamp", this.OldestOnlineLogTimestamp);
            this.SetParamSimple(map, prefix + "NewestOnlineLogTimestamp", this.NewestOnlineLogTimestamp);
            this.SetParamSimple(map, prefix + "OperationErrorMsg", this.OperationErrorMsg);
            this.SetParamSimple(map, prefix + "AccountOptSupported", this.AccountOptSupported);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "IdentifyScanSupported", this.IdentifyScanSupported);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
        }
    }
}

