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

    public class ServiceGroup : AbstractModel
    {
        
        /// <summary>
        /// Service group ID.
        /// </summary>
        [JsonProperty("ServiceGroupId")]
        public string ServiceGroupId{ get; set; }

        /// <summary>
        /// Service group name.
        /// </summary>
        [JsonProperty("ServiceGroupName")]
        public string ServiceGroupName{ get; set; }

        /// <summary>
        /// Creator.
        /// </summary>
        [JsonProperty("CreatedBy")]
        public string CreatedBy{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Update time.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Root account.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Total number of services in the service group.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceCount")]
        public ulong? ServiceCount{ get; set; }

        /// <summary>
        /// Number of running services in the service group.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RunningServiceCount")]
        public ulong? RunningServiceCount{ get; set; }

        /// <summary>
        /// Service description.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Services")]
        public Service[] Services{ get; set; }

        /// <summary>
        /// Service group status, which aligns with service status.CREATING: creating.CREATE_FAILED: creation failed.Normal: running.Stopped: stopped.Stopping: stopping.Abnormal: error.Pending: starting.Waiting: getting ready.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Service group tags.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// The latest version in the service group.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LatestVersion")]
        public string LatestVersion{ get; set; }

        /// <summary>
        /// Operational status of the service.CREATING: creating.CREATE_FAILED: creation failed.ARREARS_STOP: service suspended due to overdue payments.BILLING: billing.WHITELIST_USING: allowlist feature is in trial.WHITELIST_STOP: insufficient allowlist quota.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BusinessStatus")]
        public string BusinessStatus{ get; set; }

        /// <summary>
        /// Billing information of the service.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BillingInfo")]
        public string BillingInfo{ get; set; }

        /// <summary>
        /// Creation source of the service.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateSource")]
        public string CreateSource{ get; set; }

        /// <summary>
        /// Weight update status of the service group.UPDATING: updating.UPDATED: updated successfully.UPDATE FAILED: failed to update.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WeightUpdateStatus")]
        public string WeightUpdateStatus{ get; set; }

        /// <summary>
        /// Number of running Pods in the service group.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReplicasCount")]
        public ulong? ReplicasCount{ get; set; }

        /// <summary>
        /// Expected number of Pods under the service group.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AvailableReplicasCount")]
        public ulong? AvailableReplicasCount{ get; set; }

        /// <summary>
        /// Service group's subuin.
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// Service group's app_id.
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// Whether to enable authentication.
        /// </summary>
        [JsonProperty("AuthorizationEnable")]
        public bool? AuthorizationEnable{ get; set; }

        /// <summary>
        /// List of throttling authentication tokens.
        /// </summary>
        [JsonProperty("AuthTokens")]
        public AuthToken[] AuthTokens{ get; set; }

        /// <summary>
        /// Field for monitoring creation source.
        /// </summary>
        [JsonProperty("MonitorSource")]
        public string MonitorSource{ get; set; }

        /// <summary>
        /// Nickname of the sub-user.
        /// </summary>
        [JsonProperty("SubUinName")]
        public string SubUinName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceGroupId", this.ServiceGroupId);
            this.SetParamSimple(map, prefix + "ServiceGroupName", this.ServiceGroupName);
            this.SetParamSimple(map, prefix + "CreatedBy", this.CreatedBy);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "ServiceCount", this.ServiceCount);
            this.SetParamSimple(map, prefix + "RunningServiceCount", this.RunningServiceCount);
            this.SetParamArrayObj(map, prefix + "Services.", this.Services);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "LatestVersion", this.LatestVersion);
            this.SetParamSimple(map, prefix + "BusinessStatus", this.BusinessStatus);
            this.SetParamSimple(map, prefix + "BillingInfo", this.BillingInfo);
            this.SetParamSimple(map, prefix + "CreateSource", this.CreateSource);
            this.SetParamSimple(map, prefix + "WeightUpdateStatus", this.WeightUpdateStatus);
            this.SetParamSimple(map, prefix + "ReplicasCount", this.ReplicasCount);
            this.SetParamSimple(map, prefix + "AvailableReplicasCount", this.AvailableReplicasCount);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AuthorizationEnable", this.AuthorizationEnable);
            this.SetParamArrayObj(map, prefix + "AuthTokens.", this.AuthTokens);
            this.SetParamSimple(map, prefix + "MonitorSource", this.MonitorSource);
            this.SetParamSimple(map, prefix + "SubUinName", this.SubUinName);
        }
    }
}

