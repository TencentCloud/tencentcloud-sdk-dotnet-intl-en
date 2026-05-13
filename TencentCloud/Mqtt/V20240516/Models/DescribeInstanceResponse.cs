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
        /// <p>Instance type<br>BASIC Basic version<br>PRO Professional Edition<br>PLATINUM Platinum version</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>Instance ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Instance name</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Number of topics</p>
        /// </summary>
        [JsonProperty("TopicNum")]
        public long? TopicNum{ get; set; }

        /// <summary>
        /// <p>Maximum number of topics per instance</p>
        /// </summary>
        [JsonProperty("TopicNumLimit")]
        public long? TopicNumLimit{ get; set; }

        /// <summary>
        /// <p>TPS throttle value</p>
        /// </summary>
        [JsonProperty("TpsLimit")]
        public long? TpsLimit{ get; set; }

        /// <summary>
        /// <p>createTime, in seconds</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public long? CreatedTime{ get; set; }

        /// <summary>
        /// <p>Remarks</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>Instance status, RUNNING, running MAINTAINING, maintaining ABNORMAL, abnormal OVERDUE, arrears DESTROYED, deleted CREATING, creating MODIFYING, modifying CREATE_FAILURE, creation failure MODIFY_FAILURE, configuration change failed DELETING, deleting</p>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// <p>Instance specification</p>
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// <p>Maximum number of subscriptions for a single client</p>
        /// </summary>
        [JsonProperty("MaxSubscriptionPerClient")]
        public long? MaxSubscriptionPerClient{ get; set; }

        /// <summary>
        /// <p>Number of authorization rule entries</p>
        /// </summary>
        [JsonProperty("AuthorizationPolicyLimit")]
        public long? AuthorizationPolicyLimit{ get; set; }

        /// <summary>
        /// <p>Number of clients cap</p>
        /// </summary>
        [JsonProperty("ClientNumLimit")]
        public long? ClientNumLimit{ get; set; }

        /// <summary>
        /// <p>Client certificate registration method:<br>JITP: Automatic sign-up<br>API: Manually register through API</p>
        /// </summary>
        [JsonProperty("DeviceCertificateProvisionType")]
        public string DeviceCertificateProvisionType{ get; set; }

        /// <summary>
        /// <p>Whether to automatically activate when automatically registering a device certificate</p>
        /// </summary>
        [JsonProperty("AutomaticActivation")]
        public bool? AutomaticActivation{ get; set; }

        /// <summary>
        /// <p>Whether it is automatically renewed. Only applicable to monthly subscription clusters. 1: Automatic renewal 0: Non-automatic renewal</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// <p>Billing mode, POSTPAID, pay-as-you-go PREPAID, annual/monthly subscription</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>Expiry time, millisecond-level timestamp</p>
        /// </summary>
        [JsonProperty("ExpiryTime")]
        public long? ExpiryTime{ get; set; }

        /// <summary>
        /// <p>Predestruction time, millisecond-level timestamp</p>
        /// </summary>
        [JsonProperty("DestroyTime")]
        public long? DestroyTime{ get; set; }

        /// <summary>
        /// <p>TLS, one-way authentication    mTLS, mutual authentication    BYOC; one certificate per device</p>
        /// </summary>
        [JsonProperty("X509Mode")]
        public string X509Mode{ get; set; }

        /// <summary>
        /// <p>Maximum Ca quota</p>
        /// </summary>
        [JsonProperty("MaxCaNum")]
        public long? MaxCaNum{ get; set; }

        /// <summary>
        /// <p>FPS Cert Registration Code</p>
        /// </summary>
        [JsonProperty("RegistrationCode")]
        public string RegistrationCode{ get; set; }

        /// <summary>
        /// <p>Maximum number of subscriptions for a cluster</p>
        /// </summary>
        [JsonProperty("MaxSubscription")]
        public long? MaxSubscription{ get; set; }

        /// <summary>
        /// <p>Authorization policy switch</p>
        /// </summary>
        [JsonProperty("AuthorizationPolicy")]
        public bool? AuthorizationPolicy{ get; set; }

        /// <summary>
        /// <p>Maximum limit of shared subscription groups</p>
        /// </summary>
        [JsonProperty("SharedSubscriptionGroupLimit")]
        public long? SharedSubscriptionGroupLimit{ get; set; }

        /// <summary>
        /// <p>Number limit of TopicFilter in one shared subscription group</p>
        /// </summary>
        [JsonProperty("MaxTopicFilterPerSharedSubscriptionGroup")]
        [System.Obsolete]
        public long? MaxTopicFilterPerSharedSubscriptionGroup{ get; set; }

        /// <summary>
        /// <p>Limit on number of auto subscription rules</p>
        /// </summary>
        [JsonProperty("AutoSubscriptionPolicyLimit")]
        public long? AutoSubscriptionPolicyLimit{ get; set; }

        /// <summary>
        /// <p>Number limit of TopicFilter in a single auto subscription rule</p>
        /// </summary>
        [JsonProperty("MaxTopicFilterPerAutoSubscriptionPolicy")]
        public long? MaxTopicFilterPerAutoSubscriptionPolicy{ get; set; }

        /// <summary>
        /// <p>Whether to use the default server certificate</p>
        /// </summary>
        [JsonProperty("UseDefaultServerCert")]
        public bool? UseDefaultServerCert{ get; set; }

        /// <summary>
        /// <p>Maximum number of server CAs</p>
        /// </summary>
        [JsonProperty("TrustedCaLimit")]
        public long? TrustedCaLimit{ get; set; }

        /// <summary>
        /// <p>Maximum number of server certificates</p>
        /// </summary>
        [JsonProperty("ServerCertLimit")]
        public long? ServerCertLimit{ get; set; }

        /// <summary>
        /// <p>Max level of topic prefix</p>
        /// </summary>
        [JsonProperty("TopicPrefixSlashLimit")]
        public long? TopicPrefixSlashLimit{ get; set; }

        /// <summary>
        /// <p>Single client send message rate limiting, unit messages/second</p>
        /// </summary>
        [JsonProperty("MessageRate")]
        public long? MessageRate{ get; set; }

        /// <summary>
        /// <p>Server-side tls supported protocols, separated by ",". Example: TLSv1.3,TLSv1.2,TLSv1.1,TLSv1</p>
        /// </summary>
        [JsonProperty("TransportLayerSecurity")]
        public string TransportLayerSecurity{ get; set; }

        /// <summary>
        /// <p>Message property enhancement rule quota</p>
        /// </summary>
        [JsonProperty("MessageEnrichmentRuleLimit")]
        public long? MessageEnrichmentRuleLimit{ get; set; }

        /// <summary>
        /// <p>Maximum allowed number of blocking rules</p>
        /// </summary>
        [JsonProperty("BlockRuleLimit")]
        public long? BlockRuleLimit{ get; set; }

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
            this.SetParamSimple(map, prefix + "BlockRuleLimit", this.BlockRuleLimit);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

