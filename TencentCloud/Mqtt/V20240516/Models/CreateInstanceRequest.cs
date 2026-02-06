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

    public class CreateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance type, which needs to correspond to SkuCode. for details, see the [get MQTT product sales spec](https://www.tencentcloud.com/document/api/1778/116232?from_cn_redirect=1) api.
        /// BASIC: basic edition.
        /// PRO edition.
        /// PLATINUM version.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Specifies the cluster name, cannot be empty, 3-64 characters, only comprised of digits, letters, "-", and "_".
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Product specification, which must correspond to InstanceType. see the [get MQTT product sales spec](https://www.tencentcloud.com/document/api/1778/116232?from_cn_redirect=1) api to obtain details.
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// Specifies the remark information with a maximum length of 128 characters.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Tag list
        /// </summary>
        [JsonProperty("TagList")]
        public Tag[] TagList{ get; set; }

        /// <summary>
        /// Specifies the VPC information associated with the instance. the available VPC and SUBNET under the current user must be provided.
        /// </summary>
        [JsonProperty("VpcList")]
        public VpcInfo[] VpcList{ get; set; }

        /// <summary>
        /// Whether public network access is enabled. default false (disabled).
        /// </summary>
        [JsonProperty("EnablePublic")]
        public bool? EnablePublic{ get; set; }

        /// <summary>
        /// Public network bandwidth (unit: Mbps). this field is mandatory and must be more than 0 when EnablePublic is True.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// Public network access allowlist. if not passed, it means deny all IP network access.
        /// </summary>
        [JsonProperty("IpRules")]
        public IpRule[] IpRules{ get; set; }

        /// <summary>
        /// Whether the instance is automatically renewed (0: no auto-renewal; 1: auto-renewal). this parameter is valid only when you purchase a prepaid cluster. default value: 1 (auto-renewal).
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// Specifies the purchase duration (measurement unit: month). this parameter is valid only when you purchase a prepaid cluster. default: 1m (month). valid values: 1-12, 24, 36, 48, 60.
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// Payment mode (0: postpaid; 1: prepaid). default: 0 (postpaid).
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamArrayObj(map, prefix + "VpcList.", this.VpcList);
            this.SetParamSimple(map, prefix + "EnablePublic", this.EnablePublic);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamArrayObj(map, prefix + "IpRules.", this.IpRules);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
        }
    }
}

