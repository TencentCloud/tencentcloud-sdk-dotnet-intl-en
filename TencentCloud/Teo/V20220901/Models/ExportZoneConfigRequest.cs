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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportZoneConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Type list of configuration items to export. If not specified, all types of configurations will be exported. Currently supported values: <li>L7AccelerationConfig: exports the Layer-7 acceleration configuration, corresponding to Site Acceleration - Global Acceleration Configuration and Site Acceleration - Rule Engine in the console.</li><li>WebSecurity: exports the Web protection configuration.</li><li>AccelerationDomain: exports the acceleration domain name configuration, corresponding to DNS - Domain Name Management and DNS - Shared CNAME Management in the console.</li><li>Origin: exports the origin configuration, corresponding to Origin Configuration - Origin Groups and Origin Configuration - Load Balancing in the console.</li> Note: The types supported for future export will increase with iterations. Pay attention to export file size when exporting all types. It is recommended to specify the configuration types to be exported to control the request and response packet payload size.
        /// </summary>
        [JsonProperty("Types")]
        public string[] Types{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "Types.", this.Types);
        }
    }
}

