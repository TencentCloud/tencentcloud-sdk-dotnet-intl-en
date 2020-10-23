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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Target ES version. Valid values: 6.4.3, 6.8.2, 7.5.1
        /// </summary>
        [JsonProperty("EsVersion")]
        public string EsVersion{ get; set; }

        /// <summary>
        /// Whether to check for upgrade only. Default value: false
        /// </summary>
        [JsonProperty("CheckOnly")]
        public bool? CheckOnly{ get; set; }

        /// <summary>
        /// Target X-Pack edition: <li>OSS: Open-source Edition </li><li>basic: Basic Edition </li>Currently only used for v5.6.4 to v6.x upgrade. Default value: basic
        /// </summary>
        [JsonProperty("LicenseType")]
        public string LicenseType{ get; set; }

        /// <summary>
        /// Whether to enable X-Pack security authentication in Basic Edition 6.8 (and above) <li>1: disabled </li><li>2: enabled</li>
        /// </summary>
        [JsonProperty("BasicSecurityType")]
        public ulong? BasicSecurityType{ get; set; }

        /// <summary>
        /// Upgrade mode. <li>scale: blue/green deployment</li><li>restart: rolling restart</li>Default value: scale
        /// </summary>
        [JsonProperty("UpgradeMode")]
        public string UpgradeMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "EsVersion", this.EsVersion);
            this.SetParamSimple(map, prefix + "CheckOnly", this.CheckOnly);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "BasicSecurityType", this.BasicSecurityType);
            this.SetParamSimple(map, prefix + "UpgradeMode", this.UpgradeMode);
        }
    }
}

