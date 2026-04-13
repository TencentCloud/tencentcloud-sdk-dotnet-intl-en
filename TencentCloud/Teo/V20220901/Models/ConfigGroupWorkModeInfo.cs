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

    public class ConfigGroupWorkModeInfo : AbstractModel
    {
        
        /// <summary>
        /// Configuration group type. Options are as follows:<li>l7_acceleration: layer-7 acceleration configuration group;</li><li>edge_functions: edge function configuration group.</li><li>web_security: web protection configuration group.</li>
        /// </summary>
        [JsonProperty("ConfigGroupType")]
        public string ConfigGroupType{ get; set; }

        /// <summary>
        /// Working mode. options are as follows: <li>immediate_effect: immediate effect mode;</li><li>version_control: version management mode.</li>.
        /// </summary>
        [JsonProperty("WorkMode")]
        public string WorkMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigGroupType", this.ConfigGroupType);
            this.SetParamSimple(map, prefix + "WorkMode", this.WorkMode);
        }
    }
}

