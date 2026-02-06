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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceResponse : AbstractModel
    {
        
        /// <summary>
        /// Instance type.
        /// Specifies the EXPERIMENT trial version.
        /// BASIC version.
        /// PRO edition.
        /// PLATINUM. platinum version.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Instance ID
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
        /// Number of consumer groups
        /// </summary>
        [JsonProperty("GroupNum")]
        public long? GroupNum{ get; set; }

        /// <summary>
        /// Maximum number of consumer groups per instance
        /// </summary>
        [JsonProperty("GroupNumLimit")]
        public long? GroupNumLimit{ get; set; }

        /// <summary>
        /// Message retention time, in hours
        /// </summary>
        [JsonProperty("MessageRetention")]
        public long? MessageRetention{ get; set; }

        /// <summary>
        /// Maximum adjustable message retention time, in hours
        /// </summary>
        [JsonProperty("RetentionUpperLimit")]
        public long? RetentionUpperLimit{ get; set; }

        /// <summary>
        /// Minimum adjustable message retention time, in hours
        /// </summary>
        [JsonProperty("RetentionLowerLimit")]
        public long? RetentionLowerLimit{ get; set; }

        /// <summary>
        /// TPS throttle value
        /// </summary>
        [JsonProperty("TpsLimit")]
        public long? TpsLimit{ get; set; }

        /// <summary>
        /// Elastic TPS throttle value
        /// </summary>
        [JsonProperty("ScaledTpsLimit")]
        public long? ScaledTpsLimit{ get; set; }

        /// <summary>
        /// Maximum delayed message time, in hours
        /// </summary>
        [JsonProperty("MaxMessageDelay")]
        public long? MaxMessageDelay{ get; set; }

        /// <summary>
        /// Creation time. **It is a Unix timestamp (ms).**
        /// </summary>
        [JsonProperty("CreatedTime")]
        public long? CreatedTime{ get; set; }

        /// <summary>
        /// Message sending and receiving ratio
        /// </summary>
        [JsonProperty("SendReceiveRatio")]
        public float? SendReceiveRatio{ get; set; }

        /// <summary>
        /// Tag.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagList")]
        public Tag[] TagList{ get; set; }

        /// <summary>
        /// Access point list
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndpointList")]
        public Endpoint[] EndpointList{ get; set; }

        /// <summary>
        /// Maximum number of topic queues
        /// </summary>
        [JsonProperty("TopicQueueNumUpperLimit")]
        public long? TopicQueueNumUpperLimit{ get; set; }

        /// <summary>
        /// Minimum queue count for topic
        /// </summary>
        [JsonProperty("TopicQueueNumLowerLimit")]
        public long? TopicQueueNumLowerLimit{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Instance status. valid values are as follows:.
        /// 
        /// - RUNNING: RUNNING.
        /// -ABNORMAL: indicates an abnormal status.
        /// -OVERDUE: isolated.
        /// -DESTROYED: specifies the terminated status.
        /// -CREATING: creating.
        /// -MODIFYING.
        /// -CREATE_FAILURE: creation failed.
        /// -MODIFY_FAILURE: configuration adjustment failure.
        /// -DELETING: deleting.
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// Instance specification.
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// Billing mode. valid enumeration values are as follows:.
        /// 
        /// - POSTPAID: POSTPAID pay-as-you-go billing.
        /// - PREPAID: PREPAID annual and monthly.
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Whether to enable elastic TPS.
        /// </summary>
        [JsonProperty("ScaledTpsEnabled")]
        public bool? ScaledTpsEnabled{ get; set; }

        /// <summary>
        /// Specifies whether the prepaid cluster is automatically renewed. valid values are as follows:.
        /// 
        /// - 0: no automatic renewal.
        /// - 1: specifies automatic renewal.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// Expiration time. **It is a Unix timestamp (ms).**
        /// </summary>
        [JsonProperty("ExpiryTime")]
        public long? ExpiryTime{ get; set; }

        /// <summary>
        /// Specifies the limit on the number of roles.
        /// </summary>
        [JsonProperty("RoleNumLimit")]
        public long? RoleNumLimit{ get; set; }

        /// <summary>
        /// Whether ACL is enabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AclEnabled")]
        public bool? AclEnabled{ get; set; }

        /// <summary>
        /// Number of topics within the free quota.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TopicNumLowerLimit")]
        public long? TopicNumLowerLimit{ get; set; }

        /// <summary>
        /// Maximum settable number of topics.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TopicNumUpperLimit")]
        public long? TopicNumUpperLimit{ get; set; }

        /// <summary>
        /// AZ list. See [ZoneInfo](https://www.tencentcloud.com/document/api/1596/77932?from_cn_redirect=1#ZoneInfo) returned by the API [DescribeZones](https://www.tencentcloud.com/document/product/1596/77929?from_cn_redirect=1) in Data Type.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// Number of proxy nodes.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NodeCount")]
        public long? NodeCount{ get; set; }

        /// <summary>
        /// Proxy scheduling details.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ZoneScheduledList")]
        public ZoneScheduledItem[] ZoneScheduledList{ get; set; }

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
            this.SetParamSimple(map, prefix + "GroupNum", this.GroupNum);
            this.SetParamSimple(map, prefix + "GroupNumLimit", this.GroupNumLimit);
            this.SetParamSimple(map, prefix + "MessageRetention", this.MessageRetention);
            this.SetParamSimple(map, prefix + "RetentionUpperLimit", this.RetentionUpperLimit);
            this.SetParamSimple(map, prefix + "RetentionLowerLimit", this.RetentionLowerLimit);
            this.SetParamSimple(map, prefix + "TpsLimit", this.TpsLimit);
            this.SetParamSimple(map, prefix + "ScaledTpsLimit", this.ScaledTpsLimit);
            this.SetParamSimple(map, prefix + "MaxMessageDelay", this.MaxMessageDelay);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "SendReceiveRatio", this.SendReceiveRatio);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamArrayObj(map, prefix + "EndpointList.", this.EndpointList);
            this.SetParamSimple(map, prefix + "TopicQueueNumUpperLimit", this.TopicQueueNumUpperLimit);
            this.SetParamSimple(map, prefix + "TopicQueueNumLowerLimit", this.TopicQueueNumLowerLimit);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ScaledTpsEnabled", this.ScaledTpsEnabled);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "ExpiryTime", this.ExpiryTime);
            this.SetParamSimple(map, prefix + "RoleNumLimit", this.RoleNumLimit);
            this.SetParamSimple(map, prefix + "AclEnabled", this.AclEnabled);
            this.SetParamSimple(map, prefix + "TopicNumLowerLimit", this.TopicNumLowerLimit);
            this.SetParamSimple(map, prefix + "TopicNumUpperLimit", this.TopicNumUpperLimit);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamArrayObj(map, prefix + "ZoneScheduledList.", this.ZoneScheduledList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

