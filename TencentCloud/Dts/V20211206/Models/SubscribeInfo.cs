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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubscribeInfo : AbstractModel
    {
        
        /// <summary>
        /// Data subscription instance ID
        /// </summary>
        [JsonProperty("SubscribeId")]
        public string SubscribeId{ get; set; }

        /// <summary>
        /// Data subscription instance name
        /// </summary>
        [JsonProperty("SubscribeName")]
        public string SubscribeName{ get; set; }

        /// <summary>
        /// Kafka topic for data sent by the subscription instance
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// Subscription instance type. Currently, cynosdbmysql, mariadb, mongodb, mysql, percona, tdpg, tdsqlpercona are supported.
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// The subscribed database instance ID (if the subscription is a cloud database). If the instance is not on Tencent Cloud, this value is empty.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Cloud database status: running, isolated, offline. If it is not on the cloud, this value is empty.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// Data subscription lifecycle status. Valid values: normal (normal), isolating (isolating), isolated (isolated), offlining (offlining), post2PrePayIng (changing from pay-as-you-go to monthly subscription).
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Data subscription status. Valid values: notStarted, checking, checkNotPass, checkPass, starting, running, error.
        /// </summary>
        [JsonProperty("SubsStatus")]
        public string SubsStatus{ get; set; }

        /// <summary>
        /// Last modification time, the format is: Y-m-d h:m:s.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Creation time, the format is: Y-m-d h:m:s.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Isolation time, the format is: Y-m-d h:m:s. Default time: 0000-00-00 00:00:00.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsolateTime")]
        public string IsolateTime{ get; set; }

        /// <summary>
        /// Expiration time for monthly subscription tasks, the format is: Y-m-d h:m:s. Default time: 0000-00-00 00:00:00.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Offline time, the format is: Y-m-d h:m:s. Default time: 0000-00-00 00:00:00.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OfflineTime")]
        public string OfflineTime{ get; set; }

        /// <summary>
        /// Billing mode. 1: pay-as-you-go
        /// </summary>
        [JsonProperty("PayType")]
        public long? PayType{ get; set; }

        /// <summary>
        /// Auto-renewal flag. It is meaningful only when PayType=0. Valid values: 0 (auto-renewal disabled); 1 (auto-renewal enabled).
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Data subscription instance region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Access type. Valid values: extranet (public network); vpncloud (VPN access); dcg (Direct Connect); ccn (CCN); cdb (database); cvm (self-build on CVM); intranet (intranet); vpc (VPC).Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// Database node information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Endpoints")]
        public EndpointItem[] Endpoints{ get; set; }

        /// <summary>
        /// Data subscription version, only Kafka version is currently supported.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubscribeVersion")]
        public string SubscribeVersion{ get; set; }

        /// <summary>
        /// TagNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public TagItem[] Tags{ get; set; }

        /// <summary>
        /// Task error messageNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Errors")]
        public SubsErr[] Errors{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubscribeId", this.SubscribeId);
            this.SetParamSimple(map, prefix + "SubscribeName", this.SubscribeName);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SubsStatus", this.SubsStatus);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "IsolateTime", this.IsolateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "OfflineTime", this.OfflineTime);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamArrayObj(map, prefix + "Endpoints.", this.Endpoints);
            this.SetParamSimple(map, prefix + "SubscribeVersion", this.SubscribeVersion);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "Errors.", this.Errors);
        }
    }
}

