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

    public class ModifyInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// TDMQ RocketMQ instance ID. It can be obtained from the API [DescribeFusionInstanceList](https://www.tencentcloud.comom/document/api/1493/106745?from_cn_redirect=1) or the console.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name. It cannot be left blank. It can contain 3 to 64 characters consisting of only digits, letters, hyphens (-), and underscores (_).
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Remarks. Up to 128 characters are allowed.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Message sending and receiving ratio
        /// </summary>
        [JsonProperty("SendReceiveRatio")]
        public float? SendReceiveRatio{ get; set; }

        /// <summary>
        /// Product specification. It can be obtained from the output parameters of [ProductSKU](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#ProductSKU) of the API [DescribeProductSKUs](https://www.tencentcloud.comom/document/api/1493/107676?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// Message retention time (unit: hr). value range refers to the ProductSKU response parameters structure in the DescribeProductSKUs api (https://www.tencentcloud.comom/document/api/1493/107676?from_cn_redirect=1).
        /// 
        /// -Default value: DefaultRetention parameter.
        /// -Minimum value: specifies the RetentionLowerLimit parameter.
        /// -Specifies the maximum value of the RetentionUpperLimit parameter.
        /// </summary>
        [JsonProperty("MessageRetention")]
        public long? MessageRetention{ get; set; }

        /// <summary>
        /// Whether to enable elastic TPS.
        /// </summary>
        [JsonProperty("ScaledTpsEnabled")]
        public bool? ScaledTpsEnabled{ get; set; }

        /// <summary>
        /// Whether ACL is enabled.
        /// </summary>
        [JsonProperty("AclEnabled")]
        public bool? AclEnabled{ get; set; }

        /// <summary>
        /// The maximum number of topics that can be created. value ranges from...to... refer to the ProductSKU output parameter in the DescribeProductSKUs api (https://www.tencentcloud.comom/document/api/1493/107676?from_cn_redirect=1) (https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#ProductSKU).
        /// 
        /// -Minimum value and default value: TopicNumLimit parameter.
        /// -Maximum value of TopicNumUpperLimit parameter.
        /// </summary>
        [JsonProperty("MaxTopicNum")]
        public long? MaxTopicNum{ get; set; }

        /// <summary>
        /// Number of topics not included in the free quota. For the free quota, see the TopicNumLimit parameter in the output parameters of [ProductSKU](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#ProductSKU) of the API [DescribeProductSKUs](https://www.tencentcloud.comom/document/api/1493/107676?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ExtraTopicNum")]
        public string ExtraTopicNum{ get; set; }

        /// <summary>
        /// Whether to enable deletion protection
        /// </summary>
        [JsonProperty("EnableDeletionProtection")]
        public bool? EnableDeletionProtection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SendReceiveRatio", this.SendReceiveRatio);
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "MessageRetention", this.MessageRetention);
            this.SetParamSimple(map, prefix + "ScaledTpsEnabled", this.ScaledTpsEnabled);
            this.SetParamSimple(map, prefix + "AclEnabled", this.AclEnabled);
            this.SetParamSimple(map, prefix + "MaxTopicNum", this.MaxTopicNum);
            this.SetParamSimple(map, prefix + "ExtraTopicNum", this.ExtraTopicNum);
            this.SetParamSimple(map, prefix + "EnableDeletionProtection", this.EnableDeletionProtection);
        }
    }
}

