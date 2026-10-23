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

    public class ModifyZoneCustomVariablesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Site ID.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>List of site-level custom variables. CustomVariable.Name must use user.zone. as a prefix. Variables are initialized sequentially in array order. InitialValue can only reference variables before the current variable. It does not support referencing the current variable itself or variables after it.</p>
        /// </summary>
        [JsonProperty("CustomVariables")]
        public CustomVariable[] CustomVariables{ get; set; }

        /// <summary>
        /// <p>Site-level custom variable calculation rules. The calculation supports references to defined site-level custom variables. This list currently only supports filling in one rule; additional entries are invalid.</p>
        /// </summary>
        [JsonProperty("CustomVariableOperations")]
        public CustomVariableOperation[] CustomVariableOperations{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArrayObj(map, prefix + "CustomVariables.", this.CustomVariables);
            this.SetParamArrayObj(map, prefix + "CustomVariableOperations.", this.CustomVariableOperations);
        }
    }
}

