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

    public class CreateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance type. valid values are as follows:.
        /// 
        /// -EXPERIMENT: specifies the trial version.
        /// 
        /// - BASIC: BASIC edition.
        /// 
        /// -PRO edition.
        /// 
        /// -PLATINUM: platinum version.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Cluster name. values cannot be empty. 3-64 characters, only comprised of digits, letters, "-", and "_".
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Product specification. It can be obtained from the output parameters of [ProductSKU](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#ProductSKU) of the API [DescribeProductSKUs](https://www.tencentcloud.comom/document/api/1493/107676?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// Specifies the VPC information bound to the cluster.
        /// </summary>
        [JsonProperty("VpcList")]
        public VpcInfo[] VpcList{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Tag list
        /// </summary>
        [JsonProperty("TagList")]
        public Tag[] TagList{ get; set; }

        /// <summary>
        /// Whether public network access is enabled. the default value of false means not enabled.
        /// </summary>
        [JsonProperty("EnablePublic")]
        public bool? EnablePublic{ get; set; }

        /// <summary>
        /// Whether the public network is billed by traffic. the default value is false, which indicates that the public network is not billed by traffic.
        /// </summary>
        [JsonProperty("BillingFlow")]
        public bool? BillingFlow{ get; set; }

        /// <summary>
        /// Public network bandwidth (unit: mbps). the default value is 0. if public network access is enabled, this field must be a positive integer above 0.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// Public network access allowlist. if left blank, it means deny all IP access.
        /// </summary>
        [JsonProperty("IpRules")]
        public IpRule[] IpRules{ get; set; }

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
        /// Payment mode (0: postpaid; 1: prepaid). the default value is 0.
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// Whether the prepaid cluster is automatically renewed (0: no auto-renewal; 1: auto-renewal). default value: 0.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// Specifies the purchase duration (unit: month) for a prepaid cluster. value range: 1–60. default value: 1.
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// Specifies the maximum number of topics that can be created. obtained from the ProductSKU response parameters structure in the DescribeProductSKUs api (https://www.tencentcloud.comom/document/api/1493/107676?from_cn_redirect=1) (https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#ProductSKU).
        /// 
        /// -Default value and minimum value: specifies the TopicNumLimit parameter.
        /// -Maximum value of TopicNumUpperLimit parameter.
        /// </summary>
        [JsonProperty("MaxTopicNum")]
        public long? MaxTopicNum{ get; set; }

        /// <summary>
        /// Deployment AZ list. obtain from the [ZoneInfo](https://www.tencentcloud.comom/document/api/1596/77932?from_cn_redirect=1#ZoneInfo) data structure returned by the api [DescribeZones](https://www.tencentcloud.comom/document/product/1596/77929?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamArrayObj(map, prefix + "VpcList.", this.VpcList);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "EnablePublic", this.EnablePublic);
            this.SetParamSimple(map, prefix + "BillingFlow", this.BillingFlow);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamArrayObj(map, prefix + "IpRules.", this.IpRules);
            this.SetParamSimple(map, prefix + "MessageRetention", this.MessageRetention);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "MaxTopicNum", this.MaxTopicNum);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
        }
    }
}

