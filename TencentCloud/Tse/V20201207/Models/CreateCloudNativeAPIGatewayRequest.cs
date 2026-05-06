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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCloudNativeAPIGatewayRequest : AbstractModel
    {
        
        /// <summary>
        /// Cloud native API gateway name supports up to 60 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Cloud native API gateway type, currently only support kong.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Cloud Native API gateway version. Reference value:
        /// - 2.4.1
        /// - 2.5.1
        /// </summary>
        [JsonProperty("GatewayVersion")]
        public string GatewayVersion{ get; set; }

        /// <summary>
        /// Cloud Native API gateway node configuration.
        /// </summary>
        [JsonProperty("NodeConfig")]
        public CloudNativeAPIGatewayNodeConfig NodeConfig{ get; set; }

        /// <summary>
        /// Cloud native API gateway vpc configuration.
        /// </summary>
        [JsonProperty("VpcConfig")]
        public CloudNativeAPIGatewayVpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// Cloud native API gateway description supports up to 120 characters.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Tag list
        /// </summary>
        [JsonProperty("Tags")]
        public InstanceTagInfo[] Tags{ get; set; }

        /// <summary>
        /// Whether CLS log is enabled. Default value: false.
        /// </summary>
        [JsonProperty("EnableCls")]
        public bool? EnableCls{ get; set; }

        /// <summary>
        /// Product version. Reference value:
        /// -TRIAL: Development edition
        /// -STANDARD: Standard version (default value)
        /// -PROFESSIONAL: Pro Edition
        /// </summary>
        [JsonProperty("FeatureVersion")]
        public string FeatureVersion{ get; set; }

        /// <summary>
        /// Public network outbound traffic bandwidth, [1,2048]Mbps
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// Actual region information of the instance. Default value: ap-guangzhou.
        /// </summary>
        [JsonProperty("EngineRegion")]
        public string EngineRegion{ get; set; }

        /// <summary>
        /// ingress Class name
        /// </summary>
        [JsonProperty("IngressClassName")]
        public string IngressClassName{ get; set; }

        /// <summary>
        /// Payment type. Reference value:
        /// 0: Postpaid (default value)
        /// 1: Prepayment (The API does not currently support creating prepaid instances)
        /// </summary>
        [JsonProperty("TradeType")]
        public long? TradeType{ get; set; }

        /// <summary>
        /// Public network configuration
        /// </summary>
        [JsonProperty("InternetConfig")]
        public InternetConfig InternetConfig{ get; set; }

        /// <summary>
        /// Associated prometheus ID
        /// </summary>
        [JsonProperty("PromId")]
        public string PromId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "GatewayVersion", this.GatewayVersion);
            this.SetParamObj(map, prefix + "NodeConfig.", this.NodeConfig);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "EnableCls", this.EnableCls);
            this.SetParamSimple(map, prefix + "FeatureVersion", this.FeatureVersion);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "EngineRegion", this.EngineRegion);
            this.SetParamSimple(map, prefix + "IngressClassName", this.IngressClassName);
            this.SetParamSimple(map, prefix + "TradeType", this.TradeType);
            this.SetParamObj(map, prefix + "InternetConfig.", this.InternetConfig);
            this.SetParamSimple(map, prefix + "PromId", this.PromId);
        }
    }
}

