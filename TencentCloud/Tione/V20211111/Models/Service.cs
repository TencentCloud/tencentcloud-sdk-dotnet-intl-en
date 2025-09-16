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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Service : AbstractModel
    {
        
        /// <summary>
        /// Service group ID.
        /// </summary>
        [JsonProperty("ServiceGroupId")]
        public string ServiceGroupId{ get; set; }

        /// <summary>
        /// Service ID.
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// Service group name.
        /// </summary>
        [JsonProperty("ServiceGroupName")]
        public string ServiceGroupName{ get; set; }

        /// <summary>
        /// Service description.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceDescription")]
        public string ServiceDescription{ get; set; }

        /// <summary>
        /// Service details.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceInfo")]
        public ServiceInfo ServiceInfo{ get; set; }

        /// <summary>
        /// Cluster ID.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Region.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Namespace.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Billing type.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// Resource group ID for yearly/monthly subscription services. The value is null for pay-as-you-go services.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// Resource group name corresponding to the yearly/monthly subscription service.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }

        /// <summary>
        /// Tag of the service.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Name of the ingress where the service is located.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IngressName")]
        public string IngressName{ get; set; }

        /// <summary>
        /// Creator.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreatedBy")]
        public string CreatedBy{ get; set; }

        /// <summary>
        /// Creation time.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Update time.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Root account.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Sub-account.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// app_id
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// Operational status of the service.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BusinessStatus")]
        public string BusinessStatus{ get; set; }

        /// <summary>
        /// Deprecated. See the corresponding field in ServiceInfo.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceLimit")]
        [System.Obsolete]
        public ServiceLimit ServiceLimit{ get; set; }

        /// <summary>
        /// Deprecated. See the corresponding field in ServiceInfo.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScheduledAction")]
        [System.Obsolete]
        public ScheduledAction ScheduledAction{ get; set; }

        /// <summary>
        /// Cause for service creation failure. The default value of this field is CREATE_SUCCEED upon successful creation.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateFailedReason")]
        public string CreateFailedReason{ get; set; }

        /// <summary>
        /// Service status.CREATING: creating.CREATE_FAILED: creation failed.Normal: running.Stopped: stopped.Stopping: stopping.Abnormal: error.Pending: starting.Waiting: getting ready.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Billing information.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BillingInfo")]
        public string BillingInfo{ get; set; }

        /// <summary>
        /// Model weight.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// Creation source of the service.AUTO_ML: comes from one-click release of automatic learning.DEFAULT: other sources.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateSource")]
        public string CreateSource{ get; set; }

        /// <summary>
        /// Version number.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// The latest version number of services under a service group.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LatestVersion")]
        public string LatestVersion{ get; set; }

        /// <summary>
        /// Resource group category. Valid values: NORMAL (hosting) and SW (half-hosting).Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceGroupSWType")]
        public string ResourceGroupSWType{ get; set; }

        /// <summary>
        /// Archiving status of the service. Valid values: Waiting (pending archiving) and Archived (archived).Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ArchiveStatus")]
        public string ArchiveStatus{ get; set; }

        /// <summary>
        /// Deployment type of the service. Valid values: STANDARD (standard deployment) and DIST (multi-machine distributed deployment). The default value is STANDARD.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeployType")]
        public string DeployType{ get; set; }

        /// <summary>
        /// Number of instances per replica. This parameter is valid only when the deployment type is DIST. Default value: 1.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstancePerReplicas")]
        public string InstancePerReplicas{ get; set; }

        /// <summary>
        /// Source for monitoring queries.Enumeration value. May differ from CreateSource in certain scenarios. This field is designed to be compatible.
        /// </summary>
        [JsonProperty("MonitorSource")]
        public string MonitorSource{ get; set; }

        /// <summary>
        /// Sub-account name of the service creator.
        /// </summary>
        [JsonProperty("SubUinName")]
        public string SubUinName{ get; set; }

        /// <summary>
        /// Scheduling policy of the service.
        /// </summary>
        [JsonProperty("SchedulingPolicy")]
        public SchedulingPolicy SchedulingPolicy{ get; set; }

        /// <summary>
        /// External resource group information, indicating which resources are borrowed from resource groups.
        /// </summary>
        [JsonProperty("ExternalResourceGroups")]
        public ResourceGroupInfo[] ExternalResourceGroups{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceGroupId", this.ServiceGroupId);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ServiceGroupName", this.ServiceGroupName);
            this.SetParamSimple(map, prefix + "ServiceDescription", this.ServiceDescription);
            this.SetParamObj(map, prefix + "ServiceInfo.", this.ServiceInfo);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "IngressName", this.IngressName);
            this.SetParamSimple(map, prefix + "CreatedBy", this.CreatedBy);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "BusinessStatus", this.BusinessStatus);
            this.SetParamObj(map, prefix + "ServiceLimit.", this.ServiceLimit);
            this.SetParamObj(map, prefix + "ScheduledAction.", this.ScheduledAction);
            this.SetParamSimple(map, prefix + "CreateFailedReason", this.CreateFailedReason);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BillingInfo", this.BillingInfo);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "CreateSource", this.CreateSource);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "LatestVersion", this.LatestVersion);
            this.SetParamSimple(map, prefix + "ResourceGroupSWType", this.ResourceGroupSWType);
            this.SetParamSimple(map, prefix + "ArchiveStatus", this.ArchiveStatus);
            this.SetParamSimple(map, prefix + "DeployType", this.DeployType);
            this.SetParamSimple(map, prefix + "InstancePerReplicas", this.InstancePerReplicas);
            this.SetParamSimple(map, prefix + "MonitorSource", this.MonitorSource);
            this.SetParamSimple(map, prefix + "SubUinName", this.SubUinName);
            this.SetParamObj(map, prefix + "SchedulingPolicy.", this.SchedulingPolicy);
            this.SetParamArrayObj(map, prefix + "ExternalResourceGroups.", this.ExternalResourceGroups);
        }
    }
}

