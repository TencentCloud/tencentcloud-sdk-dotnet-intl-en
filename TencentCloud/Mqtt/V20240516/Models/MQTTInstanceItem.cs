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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MQTTInstanceItem : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance version
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Instance type
        /// BASIC, basic version
        /// PRO, Professional Edition
        /// PLATINUM, platinum version
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Instance status
        /// RUNNING: running.
        /// MAINTAINING
        /// ABNORMAL
        /// OVERDUE, arrears
        /// CREATING
        /// MODIFYING, Modifying configuration in progress
        /// Creation failed
        /// MODIFY_FAILURE, configuration change failed
        /// DELETING: Deleting
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// Maximum number of instance topics
        /// </summary>
        [JsonProperty("TopicNumLimit")]
        public long? TopicNumLimit{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Number of topics
        /// </summary>
        [JsonProperty("TopicNum")]
        public long? TopicNum{ get; set; }

        /// <summary>
        /// Product specification
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// Elastic TPS throttle value
        /// </summary>
        [JsonProperty("TpsLimit")]
        public long? TpsLimit{ get; set; }

        /// <summary>
        /// Creation time, with a millisecond-level timestamp.
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// Maximum number of subscriptions for a single client
        /// </summary>
        [JsonProperty("MaxSubscriptionPerClient")]
        public long? MaxSubscriptionPerClient{ get; set; }

        /// <summary>
        /// Maximum number of client connections.
        /// </summary>
        [JsonProperty("ClientNumLimit")]
        public long? ClientNumLimit{ get; set; }

        /// <summary>
        /// Whether it is automatically renewed. Only applicable to monthly subscription clusters.
        /// 1: Automatic renewal
        /// Non-automatic renewal
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// Billing mode, POSTPAID, pay-as-you-go PREPAID, annual/monthly subscription
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Expiry time, millisecond-level timestamp
        /// </summary>
        [JsonProperty("ExpiryTime")]
        public long? ExpiryTime{ get; set; }

        /// <summary>
        /// Predestruction time, millisecond-level timestamp
        /// </summary>
        [JsonProperty("DestroyTime")]
        public long? DestroyTime{ get; set; }

        /// <summary>
        /// Number of authorization rule entries limit
        /// </summary>
        [JsonProperty("AuthorizationPolicyLimit")]
        public long? AuthorizationPolicyLimit{ get; set; }

        /// <summary>
        /// Maximum ca quota
        /// </summary>
        [JsonProperty("MaxCaNum")]
        public long? MaxCaNum{ get; set; }

        /// <summary>
        /// Maximum number of subscriptions
        /// </summary>
        [JsonProperty("MaxSubscription")]
        public long? MaxSubscription{ get; set; }

        /// <summary>
        /// Maximum limit of shared subscription groups
        /// </summary>
        [JsonProperty("SharedSubscriptionGroupLimit")]
        public long? SharedSubscriptionGroupLimit{ get; set; }

        /// <summary>
        /// Number limit of TopicFilter in one shared subscription group
        /// </summary>
        [JsonProperty("MaxTopicFilterPerSharedSubscriptionGroup")]
        public long? MaxTopicFilterPerSharedSubscriptionGroup{ get; set; }

        /// <summary>
        /// Limit on number of auto subscription rules
        /// </summary>
        [JsonProperty("AutoSubscriptionPolicyLimit")]
        public long? AutoSubscriptionPolicyLimit{ get; set; }

        /// <summary>
        /// Number limit of TopicFilter in a single auto subscription rule
        /// </summary>
        [JsonProperty("MaxTopicFilterPerAutoSubscriptionPolicy")]
        public long? MaxTopicFilterPerAutoSubscriptionPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "TopicNumLimit", this.TopicNumLimit);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "TopicNum", this.TopicNum);
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "TpsLimit", this.TpsLimit);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MaxSubscriptionPerClient", this.MaxSubscriptionPerClient);
            this.SetParamSimple(map, prefix + "ClientNumLimit", this.ClientNumLimit);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ExpiryTime", this.ExpiryTime);
            this.SetParamSimple(map, prefix + "DestroyTime", this.DestroyTime);
            this.SetParamSimple(map, prefix + "AuthorizationPolicyLimit", this.AuthorizationPolicyLimit);
            this.SetParamSimple(map, prefix + "MaxCaNum", this.MaxCaNum);
            this.SetParamSimple(map, prefix + "MaxSubscription", this.MaxSubscription);
            this.SetParamSimple(map, prefix + "SharedSubscriptionGroupLimit", this.SharedSubscriptionGroupLimit);
            this.SetParamSimple(map, prefix + "MaxTopicFilterPerSharedSubscriptionGroup", this.MaxTopicFilterPerSharedSubscriptionGroup);
            this.SetParamSimple(map, prefix + "AutoSubscriptionPolicyLimit", this.AutoSubscriptionPolicyLimit);
            this.SetParamSimple(map, prefix + "MaxTopicFilterPerAutoSubscriptionPolicy", this.MaxTopicFilterPerAutoSubscriptionPolicy);
        }
    }
}

