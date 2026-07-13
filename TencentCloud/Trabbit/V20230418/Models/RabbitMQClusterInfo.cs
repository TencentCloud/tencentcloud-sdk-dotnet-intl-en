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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RabbitMQClusterInfo : AbstractModel
    {
        
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
        /// <p>Regional information</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Creation time in milliseconds</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>Cluster description information</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>VPC and network info</p>
        /// </summary>
        [JsonProperty("Vpcs")]
        public VpcEndpointInfo[] Vpcs{ get; set; }

        /// <summary>
        /// <p>AZ information</p>
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// <p>Number of virtual hosts</p>
        /// </summary>
        [JsonProperty("VirtualHostNumber")]
        public long? VirtualHostNumber{ get; set; }

        /// <summary>
        /// <p>Number of queues</p>
        /// </summary>
        [JsonProperty("QueueNumber")]
        public long? QueueNumber{ get; set; }

        /// <summary>
        /// <p>Number of messages produced per second Unit: messages/second</p>
        /// </summary>
        [JsonProperty("MessagePublishRate")]
        public float? MessagePublishRate{ get; set; }

        /// <summary>
        /// <p>Number of accumulated messages Unit: unit</p>
        /// </summary>
        [JsonProperty("MessageStackNumber")]
        public long? MessageStackNumber{ get; set; }

        /// <summary>
        /// <p>Expiration time</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// <p>Number of channels</p>
        /// </summary>
        [JsonProperty("ChannelNumber")]
        public long? ChannelNumber{ get; set; }

        /// <summary>
        /// <p>Number of connections</p>
        /// </summary>
        [JsonProperty("ConnectionNumber")]
        public long? ConnectionNumber{ get; set; }

        /// <summary>
        /// <p>Number of consumers</p>
        /// </summary>
        [JsonProperty("ConsumerNumber")]
        public long? ConsumerNumber{ get; set; }

        /// <summary>
        /// <p>Number of Exchanges</p>
        /// </summary>
        [JsonProperty("ExchangeNumber")]
        public long? ExchangeNumber{ get; set; }

        /// <summary>
        /// <p>Cluster exception information</p>
        /// </summary>
        [JsonProperty("ExceptionInformation")]
        public string ExceptionInformation{ get; set; }

        /// <summary>
        /// <p>Instance status. 0 indicates creating in progress, 1 indicates normal, 2 indicates isolated, 3 indicates terminated, 4 - abnormal, 5 - delivery failed</p>
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public long? ClusterStatus{ get; set; }

        /// <summary>
        /// <p>Automatic renewal flag. 0: default status (initial status (that is manual renewal) if no status is set by the user); 1: automatic renewal; 2: no automatic renewal (set by the user).</p>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>Whether to enable the mirror queue policy. 1 means enabled, 0 means disabled.</p>
        /// </summary>
        [JsonProperty("MirrorQueuePolicyFlag")]
        public long? MirrorQueuePolicyFlag{ get; set; }

        /// <summary>
        /// <p>Number of messages consumed per second Unit: messages/second</p>
        /// </summary>
        [JsonProperty("MessageConsumeRate")]
        public float? MessageConsumeRate{ get; set; }

        /// <summary>
        /// <p>Cluster version information</p>
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// <p>Billing mode. 0 - Postpaid, 1 - Prepaid</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// <p>Cluster type.</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public ulong? InstanceType{ get; set; }

        /// <summary>
        /// <p>Message retention period Unit: hour</p>
        /// </summary>
        [JsonProperty("MessageRetainTime")]
        public ulong? MessageRetainTime{ get; set; }

        /// <summary>
        /// <p>Traffic ratio of sending messages</p>
        /// </summary>
        [JsonProperty("SendReceiveRatio")]
        public float? SendReceiveRatio{ get; set; }

        /// <summary>
        /// <p>Message trace retention time in hours</p>
        /// </summary>
        [JsonProperty("TraceTime")]
        public ulong? TraceTime{ get; set; }

        /// <summary>
        /// <p>Instance tag list</p>
        /// </summary>
        [JsonProperty("Tags")]
        public RabbitMQServerlessTag[] Tags{ get; set; }

        /// <summary>
        /// <p>Elastic scaling enabled tps</p>
        /// </summary>
        [JsonProperty("ElasticTpsFlag")]
        public bool? ElasticTpsFlag{ get; set; }

        /// <summary>
        /// <p>Elastic tps multiple, default is 1x</p>
        /// </summary>
        [JsonProperty("ElasticTpsRatio")]
        public float? ElasticTpsRatio{ get; set; }

        /// <summary>
        /// <p>Maximum retry count</p>
        /// </summary>
        [JsonProperty("MaxRedeliverCount")]
        public ulong? MaxRedeliverCount{ get; set; }

        /// <summary>
        /// <p>Consumption timeout period Unit: min</p>
        /// </summary>
        [JsonProperty("ConsumerTimeout")]
        public ulong? ConsumerTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "Vpcs.", this.Vpcs);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "VirtualHostNumber", this.VirtualHostNumber);
            this.SetParamSimple(map, prefix + "QueueNumber", this.QueueNumber);
            this.SetParamSimple(map, prefix + "MessagePublishRate", this.MessagePublishRate);
            this.SetParamSimple(map, prefix + "MessageStackNumber", this.MessageStackNumber);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ChannelNumber", this.ChannelNumber);
            this.SetParamSimple(map, prefix + "ConnectionNumber", this.ConnectionNumber);
            this.SetParamSimple(map, prefix + "ConsumerNumber", this.ConsumerNumber);
            this.SetParamSimple(map, prefix + "ExchangeNumber", this.ExchangeNumber);
            this.SetParamSimple(map, prefix + "ExceptionInformation", this.ExceptionInformation);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "MirrorQueuePolicyFlag", this.MirrorQueuePolicyFlag);
            this.SetParamSimple(map, prefix + "MessageConsumeRate", this.MessageConsumeRate);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "MessageRetainTime", this.MessageRetainTime);
            this.SetParamSimple(map, prefix + "SendReceiveRatio", this.SendReceiveRatio);
            this.SetParamSimple(map, prefix + "TraceTime", this.TraceTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ElasticTpsFlag", this.ElasticTpsFlag);
            this.SetParamSimple(map, prefix + "ElasticTpsRatio", this.ElasticTpsRatio);
            this.SetParamSimple(map, prefix + "MaxRedeliverCount", this.MaxRedeliverCount);
            this.SetParamSimple(map, prefix + "ConsumerTimeout", this.ConsumerTimeout);
        }
    }
}

