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

namespace TencentCloud.Kms.V20190118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetServiceStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether the KMS service is enabled. true means enabled</p>
        /// </summary>
        [JsonProperty("ServiceEnabled")]
        public bool? ServiceEnabled{ get; set; }

        /// <summary>
        /// <p>Service unavailability type: 0-not purchased, 1-normal, 2-service suspended due to overdue payments, 3-resource release</p>
        /// </summary>
        [JsonProperty("InvalidType")]
        public long? InvalidType{ get; set; }

        /// <summary>
        /// <p>0-Standard Edition, 1-Flagship Edition</p>
        /// </summary>
        [JsonProperty("UserLevel")]
        public ulong? UserLevel{ get; set; }

        /// <summary>
        /// <p>Expiry time of the flagship edition (Epoch Unix Timestamp).</p>
        /// </summary>
        [JsonProperty("ProExpireTime")]
        public ulong? ProExpireTime{ get; set; }

        /// <summary>
        /// <p>Whether the flagship edition is automatically renewed: 0-no auto-renewal, 1-auto-renewal</p>
        /// </summary>
        [JsonProperty("ProRenewFlag")]
        public ulong? ProRenewFlag{ get; set; }

        /// <summary>
        /// <p>Unique identifier of the flagship edition purchase record. If the flagship edition is not activated, the return value is empty.</p>
        /// </summary>
        [JsonProperty("ProResourceId")]
        public string ProResourceId{ get; set; }

        /// <summary>
        /// <p>Whether to enable managed by KMS</p>
        /// </summary>
        [JsonProperty("ExclusiveVSMEnabled")]
        public bool? ExclusiveVSMEnabled{ get; set; }

        /// <summary>
        /// <p>Whether to enable KMS exclusive edition</p>
        /// </summary>
        [JsonProperty("ExclusiveHSMEnabled")]
        public bool? ExclusiveHSMEnabled{ get; set; }

        /// <summary>
        /// <p>KMS subscription information.</p>
        /// </summary>
        [JsonProperty("SubscriptionInfo")]
        public string SubscriptionInfo{ get; set; }

        /// <summary>
        /// <p>Return the usage quantity of KMS user secret key</p>
        /// </summary>
        [JsonProperty("CmkUserCount")]
        public ulong? CmkUserCount{ get; set; }

        /// <summary>
        /// <p>Return the specification quantity of KMS user secret keys</p>
        /// </summary>
        [JsonProperty("CmkLimit")]
        public ulong? CmkLimit{ get; set; }

        /// <summary>
        /// <p>Return the dedicated cluster group</p>
        /// </summary>
        [JsonProperty("ExclusiveHSMList")]
        public ExclusiveHSM[] ExclusiveHSMList{ get; set; }

        /// <summary>
        /// <p>Indicates whether data key management is supported. 1: supported. 0: not supported.</p>
        /// </summary>
        [JsonProperty("IsAllowedDataKeyHosted")]
        public bool? IsAllowedDataKeyHosted{ get; set; }

        /// <summary>
        /// <p>Valid when IsAllowedDataKeyHosted is 1. Purchase quota of the data key</p>
        /// </summary>
        [JsonProperty("DataKeyLimit")]
        public ulong? DataKeyLimit{ get; set; }

        /// <summary>
        /// <p>Valid at that time when IsAllowedDataKeyHosted is 1. Data key free quota.</p>
        /// </summary>
        [JsonProperty("FreeDataKeyLimit")]
        public ulong? FreeDataKeyLimit{ get; set; }

        /// <summary>
        /// <p>Valid when IsAllowedDataKeyHosted is 1. Number of used data keys.</p>
        /// </summary>
        [JsonProperty("DataKeyUsedCount")]
        public ulong? DataKeyUsedCount{ get; set; }

        /// <summary>
        /// <p>Target region info of the sync task</p>
        /// </summary>
        [JsonProperty("SyncTaskList")]
        public DestinationSyncConfig[] SyncTaskList{ get; set; }

        /// <summary>
        /// <p>Whether sync task is supported. true: supported, false: unsupported.</p>
        /// </summary>
        [JsonProperty("IsAllowedSync")]
        public bool? IsAllowedSync{ get; set; }

        /// <summary>
        /// <p>QPS in the region</p>
        /// </summary>
        [JsonProperty("QpsLimit")]
        public ulong? QpsLimit{ get; set; }

        /// <summary>
        /// <p>Total QPS value</p>
        /// </summary>
        [JsonProperty("QpsTotalLimit")]
        public ulong? QpsTotalLimit{ get; set; }

        /// <summary>
        /// <p>QPS in the region</p>
        /// </summary>
        [JsonProperty("RegionsQps")]
        public RegionQps[] RegionsQps{ get; set; }

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
            this.SetParamSimple(map, prefix + "ServiceEnabled", this.ServiceEnabled);
            this.SetParamSimple(map, prefix + "InvalidType", this.InvalidType);
            this.SetParamSimple(map, prefix + "UserLevel", this.UserLevel);
            this.SetParamSimple(map, prefix + "ProExpireTime", this.ProExpireTime);
            this.SetParamSimple(map, prefix + "ProRenewFlag", this.ProRenewFlag);
            this.SetParamSimple(map, prefix + "ProResourceId", this.ProResourceId);
            this.SetParamSimple(map, prefix + "ExclusiveVSMEnabled", this.ExclusiveVSMEnabled);
            this.SetParamSimple(map, prefix + "ExclusiveHSMEnabled", this.ExclusiveHSMEnabled);
            this.SetParamSimple(map, prefix + "SubscriptionInfo", this.SubscriptionInfo);
            this.SetParamSimple(map, prefix + "CmkUserCount", this.CmkUserCount);
            this.SetParamSimple(map, prefix + "CmkLimit", this.CmkLimit);
            this.SetParamArrayObj(map, prefix + "ExclusiveHSMList.", this.ExclusiveHSMList);
            this.SetParamSimple(map, prefix + "IsAllowedDataKeyHosted", this.IsAllowedDataKeyHosted);
            this.SetParamSimple(map, prefix + "DataKeyLimit", this.DataKeyLimit);
            this.SetParamSimple(map, prefix + "FreeDataKeyLimit", this.FreeDataKeyLimit);
            this.SetParamSimple(map, prefix + "DataKeyUsedCount", this.DataKeyUsedCount);
            this.SetParamArrayObj(map, prefix + "SyncTaskList.", this.SyncTaskList);
            this.SetParamSimple(map, prefix + "IsAllowedSync", this.IsAllowedSync);
            this.SetParamSimple(map, prefix + "QpsLimit", this.QpsLimit);
            this.SetParamSimple(map, prefix + "QpsTotalLimit", this.QpsTotalLimit);
            this.SetParamArrayObj(map, prefix + "RegionsQps.", this.RegionsQps);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

