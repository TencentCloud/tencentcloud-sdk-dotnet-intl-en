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
        /// Export the type list of configuration items. Leave it blank to export all types of configurations. Currently supported values include: <li>L7AccelerationConfig: means exporting the Layer-7 acceleration configuration, corresponding to the console "Site Acceleration - Global Acceleration Configuration" and "Site Acceleration - Rule Engine".</li><li>WebSecurity: refers to exporting the Web protection configuration.</li> Note: Types supported for future export will increase with iterations. When exporting all types, pay attention to export file size. It is recommended to specify the configuration types to be exported to control the request and response packet payload size.
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

