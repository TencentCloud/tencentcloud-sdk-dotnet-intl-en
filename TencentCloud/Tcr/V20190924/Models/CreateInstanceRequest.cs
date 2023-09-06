/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Enterprise Edition instance name
        /// </summary>
        [JsonProperty("RegistryName")]
        public string RegistryName{ get; set; }

        /// <summary>
        /// Enterprise Edition instance type. Valid values: basic: Basic; standard: Standard; premium: Premium.
        /// </summary>
        [JsonProperty("RegistryType")]
        public string RegistryType{ get; set; }

        /// <summary>
        /// Cloud tag description
        /// </summary>
        [JsonProperty("TagSpecification")]
        public TagSpecification TagSpecification{ get; set; }

        /// <summary>
        /// Instance billing mode. Valid values: 0: Pay-as-you-go billing; 1: Prepaid. Default value: 0.
        /// </summary>
        [JsonProperty("RegistryChargeType")]
        public long? RegistryChargeType{ get; set; }

        /// <summary>
        /// Auto-renewal setting and purchase period
        /// </summary>
        [JsonProperty("RegistryChargePrepaid")]
        public RegistryChargePrepaid RegistryChargePrepaid{ get; set; }

        /// <summary>
        /// Whether to sync TCR cloud tags to the COS bucket
        /// </summary>
        [JsonProperty("SyncTag")]
        public bool? SyncTag{ get; set; }

        /// <summary>
        /// Whether to enable the COS Multi-AZ feature
        /// </summary>
        [JsonProperty("EnableCosMAZ")]
        public bool? EnableCosMAZ{ get; set; }

        /// <summary>
        /// Whether to enable deletion protection
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryName", this.RegistryName);
            this.SetParamSimple(map, prefix + "RegistryType", this.RegistryType);
            this.SetParamObj(map, prefix + "TagSpecification.", this.TagSpecification);
            this.SetParamSimple(map, prefix + "RegistryChargeType", this.RegistryChargeType);
            this.SetParamObj(map, prefix + "RegistryChargePrepaid.", this.RegistryChargePrepaid);
            this.SetParamSimple(map, prefix + "SyncTag", this.SyncTag);
            this.SetParamSimple(map, prefix + "EnableCosMAZ", this.EnableCosMAZ);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
        }
    }
}

