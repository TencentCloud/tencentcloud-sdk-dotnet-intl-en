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

    public class CustomVariableOperationRuleAction : AbstractModel
    {
        
        /// <summary>
        /// <p>Operation name. The name should correspond to the parameter structure. For example, if Name=Set, SetParameters is required. Currently only support filling in Set.</p><li>Set: custom variable settings;</li>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Custom Variable parameter settings. If there are multiple operations in this parameter, they are executed in sequence according to the array order. When the value of Name is Set, this parameter is required.</p>
        /// </summary>
        [JsonProperty("SetParameters")]
        public SetParameters SetParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "SetParameters.", this.SetParameters);
        }
    }
}

