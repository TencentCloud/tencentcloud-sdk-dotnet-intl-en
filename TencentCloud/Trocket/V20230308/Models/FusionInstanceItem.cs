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

    public class FusionInstanceItem : AbstractModel
    {
        
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
        /// Instance version.
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Instance type.
        /// Trial version.
        /// BASIC version.
        /// PRO, professional edition.
        /// PLATINUM edition.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Instance status.
        /// RUNNING. specifies the running status.
        /// MAINTAINING.
        /// ABNORMAL.
        /// OVERDUE. specifies the state of arrears.
        /// `DESTROYED`: `deleted`.
        /// CREATING.
        /// MODIFYING.
        /// CREATE_FAILURE. specifies that the creation failed.
        /// MODIFY_FAILURE. indicates a configuration adjustment failure.
        /// Valid values: DELETING. indicates that the resource is being deleted.
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// Maximum number of instance topics
        /// </summary>
        [JsonProperty("TopicNumLimit")]
        public long? TopicNumLimit{ get; set; }

        /// <summary>
        /// Maximum number of instance consumer groups
        /// </summary>
        [JsonProperty("GroupNumLimit")]
        public long? GroupNumLimit{ get; set; }

        /// <summary>
        /// Billing mode. valid enumeration values are as follows:.
        /// 
        /// -POSTPAID: pay-as-you-go.
        /// 
        /// - PREPAID: monthly subscription.
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Expiration time. **It is a Unix timestamp (ms).**
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpiryTime")]
        public long? ExpiryTime{ get; set; }

        /// <summary>
        /// Remarks
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Number of topics
        /// </summary>
        [JsonProperty("TopicNum")]
        public long? TopicNum{ get; set; }

        /// <summary>
        /// Number of consumer groups
        /// </summary>
        [JsonProperty("GroupNum")]
        public long? GroupNum{ get; set; }

        /// <summary>
        /// Tag list
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagList")]
        public Tag[] TagList{ get; set; }

        /// <summary>
        /// Specifies the product specification.
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// TPS throttle value
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TpsLimit")]
        public long? TpsLimit{ get; set; }

        /// <summary>
        /// Elastic TPS throttle value
        /// </summary>
        [JsonProperty("ScaledTpsLimit")]
        public long? ScaledTpsLimit{ get; set; }

        /// <summary>
        /// Message retention time, in hours
        /// </summary>
        [JsonProperty("MessageRetention")]
        public long? MessageRetention{ get; set; }

        /// <summary>
        /// Maximum delayed message duration, in hours
        /// </summary>
        [JsonProperty("MaxMessageDelay")]
        public long? MaxMessageDelay{ get; set; }

        /// <summary>
        /// Specifies whether the prepaid cluster is automatically renewed. valid values are as follows:.
        /// 
        /// - 0: no automatic renewal.
        /// - 1: specifies automatic renewal.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// Data unique to version 4.x.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceItemExtraInfo")]
        public InstanceItemExtraInfo InstanceItemExtraInfo{ get; set; }

        /// <summary>
        /// Expected termination time. **It is a Unix timestamp (ms).**
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DestroyTime")]
        public long? DestroyTime{ get; set; }

        /// <summary>
        /// AZ list. See [ZoneInfo](https://www.tencentcloud.comom/document/api/1596/77932?from_cn_redirect=1#ZoneInfo) returned by the API [DescribeZones](https://www.tencentcloud.comom/document/product/1596/77929?from_cn_redirect=1) in Data Type.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// Whether to enable deletion protection
        /// </summary>
        [JsonProperty("EnableDeletionProtection")]
        public bool? EnableDeletionProtection{ get; set; }

        /// <summary>
        /// Instance creation time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// Elastic TPS switch.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScaledTpsEnabled")]
        public bool? ScaledTpsEnabled{ get; set; }


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
            this.SetParamSimple(map, prefix + "GroupNumLimit", this.GroupNumLimit);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ExpiryTime", this.ExpiryTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "TopicNum", this.TopicNum);
            this.SetParamSimple(map, prefix + "GroupNum", this.GroupNum);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "TpsLimit", this.TpsLimit);
            this.SetParamSimple(map, prefix + "ScaledTpsLimit", this.ScaledTpsLimit);
            this.SetParamSimple(map, prefix + "MessageRetention", this.MessageRetention);
            this.SetParamSimple(map, prefix + "MaxMessageDelay", this.MaxMessageDelay);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamObj(map, prefix + "InstanceItemExtraInfo.", this.InstanceItemExtraInfo);
            this.SetParamSimple(map, prefix + "DestroyTime", this.DestroyTime);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "EnableDeletionProtection", this.EnableDeletionProtection);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ScaledTpsEnabled", this.ScaledTpsEnabled);
        }
    }
}

