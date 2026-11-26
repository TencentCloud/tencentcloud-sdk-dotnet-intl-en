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

    public class RuleExtraParameter : AbstractModel
    {
        
        /// <summary>
        /// Parameter name. Valid values:
        /// <li> Action: Parameters required to modify HTTP header. Select RewirteAction for RuleAction;</li>
        /// <li> StatusCode: Parameters required for status code related features. Select CodeAction for RuleAction.</li>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Parameter value type.
        /// <li> CHOICE: The parameter value can only be selected from Values; </li>
        /// <li> CUSTOM_NUM: The parameter value is user-customized, int type;</li>
        /// <li>CUSTOM_STRING: The parameter value is user-customized, string type.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Optional parameter values.
        /// Note: When the value of Id is StatusCode, the values in the array are integers. Fill in the parameter value as an integer in string format.
        /// </summary>
        [JsonProperty("Choices")]
        public string[] Choices{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "Choices.", this.Choices);
        }
    }
}

