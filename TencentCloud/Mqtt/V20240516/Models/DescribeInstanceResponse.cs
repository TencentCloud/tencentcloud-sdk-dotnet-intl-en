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

    public class DescribeInstanceResponse : AbstractModel
    {
        
        /// <summary>
        /// Instance type
        /// BASIC: basic edition.
        /// PRO edition.
        /// PLATINUM edition.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Number of topics
        /// </summary>
        [JsonProperty("TopicNum")]
        public long? TopicNum{ get; set; }

        /// <summary>
        /// Maximum number of topics per instance
        /// </summary>
        [JsonProperty("TopicNumLimit")]
        public long? TopicNumLimit{ get; set; }

        /// <summary>
        /// TPS throttle value
        /// </summary>
        [JsonProperty("TpsLimit")]
        public long? TpsLimit{ get; set; }

        /// <summary>
        /// Creation time, in seconds
        /// </summary>
        [JsonProperty("CreatedTime")]
        public long? CreatedTime{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Instance status. RUNNING: running; MAINTAINING: maintaining; ABNORMAL: abnormal; OVERDUE: in arrears; DESTROYED: deleted; CREATING: creating; MODIFYING: adjusting the configuration; CREATE_FAILURE: creation failed; MODIFY_FAILURE: configuration adjustment failed; DELETING: deleting.
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// Specifies the instance specification.
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// Maximum number of subscriptions for a single client.
        /// </summary>
        [JsonProperty("MaxSubscriptionPerClient")]
        public long? MaxSubscriptionPerClient{ get; set; }

        /// <summary>
        /// Number of authorization rules.
        /// </summary>
        [JsonProperty("AuthorizationPolicyLimit")]
        public long? AuthorizationPolicyLimit{ get; set; }

        /// <summary>
        /// Maximum number of clients.
        /// </summary>
        [JsonProperty("ClientNumLimit")]
        public long? ClientNumLimit{ get; set; }

        /// <summary>
        /// Specifies the registration method for the client certificate.
        /// JITP: automatically register.
        /// API: register manually through api.
        /// </summary>
        [JsonProperty("DeviceCertificateProvisionType")]
        public string DeviceCertificateProvisionType{ get; set; }

        /// <summary>
        /// Specifies whether to automatically activate the device certificate during automatic registration.
        /// </summary>
        [JsonProperty("AutomaticActivation")]
        public bool? AutomaticActivation{ get; set; }

        /// <summary>
        /// Whether the instance is automatically renewed. this parameter is valid only for monthly subscription clusters. valid values: 1 (auto-renewal), 0 (non-automatic renewal).
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// Billing mode. POSTPAID: pay-as-you-go billing. PREPAID: monthly subscription.
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Expiry time. millisecond-level timestamp.
        /// </summary>
        [JsonProperty("ExpiryTime")]
        public long? ExpiryTime{ get; set; }

        /// <summary>
        /// Scheduled destruction time. millisecond-level timestamp.
        /// </summary>
        [JsonProperty("DestroyTime")]
        public long? DestroyTime{ get; set; }

        /// <summary>
        /// TLS, one-way authentication. mTLS, mutual authentication. BYOC, one certificate per device.
        /// </summary>
        [JsonProperty("X509Mode")]
        public string X509Mode{ get; set; }

        /// <summary>
        /// Specifies the maximum Ca quota.
        /// </summary>
        [JsonProperty("MaxCaNum")]
        public long? MaxCaNum{ get; set; }

        /// <summary>
        /// FPS cert registration code.
        /// </summary>
        [JsonProperty("RegistrationCode")]
        public string RegistrationCode{ get; set; }

        /// <summary>
        /// Maximum number of subscriptions for a cluster.
        /// </summary>
        [JsonProperty("MaxSubscription")]
        public long? MaxSubscription{ get; set; }

        /// <summary>
        /// Authorization policy switch.
        /// </summary>
        [JsonProperty("AuthorizationPolicy")]
        public bool? AuthorizationPolicy{ get; set; }

        /// <summary>
        /// Maximum limit of shared subscription groups.
        /// </summary>
        [JsonProperty("SharedSubscriptionGroupLimit")]
        public long? SharedSubscriptionGroupLimit{ get; set; }

        /// <summary>
        /// Specifies the topic filter number limit for each shared subscription group.
        /// </summary>
        [JsonProperty("MaxTopicFilterPerSharedSubscriptionGroup")]
        public long? MaxTopicFilterPerSharedSubscriptionGroup{ get; set; }

        /// <summary>
        /// Specifies the limit on number of auto-subscription rules.
        /// </summary>
        [JsonProperty("AutoSubscriptionPolicyLimit")]
        public long? AutoSubscriptionPolicyLimit{ get; set; }

        /// <summary>
        /// Specifies the number limit of TopicFilter in a single auto-subscription rule.
        /// </summary>
        [JsonProperty("MaxTopicFilterPerAutoSubscriptionPolicy")]
        public long? MaxTopicFilterPerAutoSubscriptionPolicy{ get; set; }

        /// <summary>
        /// Specifies whether to use the default server certificate.
        /// </summary>
        [JsonProperty("UseDefaultServerCert")]
        public bool? UseDefaultServerCert{ get; set; }

        /// <summary>
        /// Maximum allowed number of server cas.
        /// </summary>
        [JsonProperty("TrustedCaLimit")]
        public long? TrustedCaLimit{ get; set; }

        /// <summary>
        /// Specifies the maximum allowed number of server certificates.
        /// </summary>
        [JsonProperty("ServerCertLimit")]
        public long? ServerCertLimit{ get; set; }

        /// <summary>
        /// Specifies the max level of the topic prefix.
        /// </summary>
        [JsonProperty("TopicPrefixSlashLimit")]
        public long? TopicPrefixSlashLimit{ get; set; }

        /// <summary>
        /// Specifies the speed limit for sending messages by a single client in messages per second.
        /// </summary>
        [JsonProperty("MessageRate")]
        public long? MessageRate{ get; set; }

        /// <summary>
        /// Specifies the protocols supported by the server tls, separated by ",". example: TLSv1.3,TLSv1.2,TLSv1.1,TLSv1.
        /// </summary>
        [JsonProperty("TransportLayerSecurity")]
        public string TransportLayerSecurity{ get; set; }

        /// <summary>
        /// Specifies the message property enrichment rule quota.
        /// </summary>
        [JsonProperty("MessageEnrichmentRuleLimit")]
        public long? MessageEnrichmentRuleLimit{ get; set; }

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
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "TopicNum", this.TopicNum);
            this.SetParamSimple(map, prefix + "TopicNumLimit", this.TopicNumLimit);
            this.SetParamSimple(map, prefix + "TpsLimit", this.TpsLimit);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "MaxSubscriptionPerClient", this.MaxSubscriptionPerClient);
            this.SetParamSimple(map, prefix + "AuthorizationPolicyLimit", this.AuthorizationPolicyLimit);
            this.SetParamSimple(map, prefix + "ClientNumLimit", this.ClientNumLimit);
            this.SetParamSimple(map, prefix + "DeviceCertificateProvisionType", this.DeviceCertificateProvisionType);
            this.SetParamSimple(map, prefix + "AutomaticActivation", this.AutomaticActivation);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ExpiryTime", this.ExpiryTime);
            this.SetParamSimple(map, prefix + "DestroyTime", this.DestroyTime);
            this.SetParamSimple(map, prefix + "X509Mode", this.X509Mode);
            this.SetParamSimple(map, prefix + "MaxCaNum", this.MaxCaNum);
            this.SetParamSimple(map, prefix + "RegistrationCode", this.RegistrationCode);
            this.SetParamSimple(map, prefix + "MaxSubscription", this.MaxSubscription);
            this.SetParamSimple(map, prefix + "AuthorizationPolicy", this.AuthorizationPolicy);
            this.SetParamSimple(map, prefix + "SharedSubscriptionGroupLimit", this.SharedSubscriptionGroupLimit);
            this.SetParamSimple(map, prefix + "MaxTopicFilterPerSharedSubscriptionGroup", this.MaxTopicFilterPerSharedSubscriptionGroup);
            this.SetParamSimple(map, prefix + "AutoSubscriptionPolicyLimit", this.AutoSubscriptionPolicyLimit);
            this.SetParamSimple(map, prefix + "MaxTopicFilterPerAutoSubscriptionPolicy", this.MaxTopicFilterPerAutoSubscriptionPolicy);
            this.SetParamSimple(map, prefix + "UseDefaultServerCert", this.UseDefaultServerCert);
            this.SetParamSimple(map, prefix + "TrustedCaLimit", this.TrustedCaLimit);
            this.SetParamSimple(map, prefix + "ServerCertLimit", this.ServerCertLimit);
            this.SetParamSimple(map, prefix + "TopicPrefixSlashLimit", this.TopicPrefixSlashLimit);
            this.SetParamSimple(map, prefix + "MessageRate", this.MessageRate);
            this.SetParamSimple(map, prefix + "TransportLayerSecurity", this.TransportLayerSecurity);
            this.SetParamSimple(map, prefix + "MessageEnrichmentRuleLimit", this.MessageEnrichmentRuleLimit);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

