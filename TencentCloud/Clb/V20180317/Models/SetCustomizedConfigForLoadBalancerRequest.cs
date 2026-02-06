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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetCustomizedConfigForLoadBalancerRequest : AbstractModel
    {
        
        /// <summary>
        /// Operation type.
        /// -ADD. specifies the creation.
        /// - DELETE: DELETE.
        /// -UPDATE: modify.
        /// -BIND: specifies the binding status.
        /// -UNBIND: unbind.
        /// </summary>
        [JsonProperty("OperationType")]
        public string OperationType{ get; set; }

        /// <summary>
        /// Personalized configuration ID. this field is required except when creating a custom configuration, for example: pz-1234abcd.
        /// </summary>
        [JsonProperty("UconfigId")]
        public string UconfigId{ get; set; }

        /// <summary>
        /// Specifies the personalized configuration content. this field is required when creating or modifying custom configuration.
        /// Specifies specific restrictions. view layer-7 personalized configuration (https://www.tencentcloud.com/document/product/214/15171?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ConfigContent")]
        public string ConfigContent{ get; set; }

        /// <summary>
        /// Custom configuration name. specifies the name when creating or modifying a custom configuration. this field is required.
        /// </summary>
        [JsonProperty("ConfigName")]
        public string ConfigName{ get; set; }

        /// <summary>
        /// CLB instance ID. this field is required for bind/unbind operations.
        /// Can be queried through the [DescribeLoadBalancers](https://www.tencentcloud.com/document/product/1108/48459?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("LoadBalancerIds")]
        public string[] LoadBalancerIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OperationType", this.OperationType);
            this.SetParamSimple(map, prefix + "UconfigId", this.UconfigId);
            this.SetParamSimple(map, prefix + "ConfigContent", this.ConfigContent);
            this.SetParamSimple(map, prefix + "ConfigName", this.ConfigName);
            this.SetParamArraySimple(map, prefix + "LoadBalancerIds.", this.LoadBalancerIds);
        }
    }
}

