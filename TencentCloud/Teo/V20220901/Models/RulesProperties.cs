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

    public class RulesProperties : AbstractModel
    {
        
        /// <summary>
        /// Value of the parameter name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Minimum value of the numeric parameter. This item is meaningless for non-numeric parameters or when both Min and Max are 0.
        /// </summary>
        [JsonProperty("Min")]
        public long? Min{ get; set; }

        /// <summary>
        /// Available values of the parameter.
        /// Note: If the parameter value is user-customized, this array is an empty array.
        /// </summary>
        [JsonProperty("ChoicesValue")]
        public string[] ChoicesValue{ get; set; }

        /// <summary>
        /// Parameter type.
        /// <li> CHOICE: The parameter value can only be selected from ChoicesValue; </li>
        /// <li> TOGGLE: The parameter value is a switch type, select from ChoicesValue;</li>
        /// <li> OBJECT: The parameter value is an object type, and ChoiceProperties are attributes associated with the object type;</li>
        /// <li> CUSTOM_NUM: user-customized parameter value, integer type;</li>
        /// <li>CUSTOM_STRING: The parameter value is user-customized, string type.</li>Note: When the parameter type is OBJECT, see [Example 2: Create with the parameter type OBJECT](https://www.tencentcloud.com/document/product/1552/80622?from_cn_redirect=1#.E7.A4.BA.E4.BE.8B2-.E4.BF.AE.E6.94.B9.E6.BA.90.E7.AB.99.E4.B8.BAIP.E5.9F.9F.E5.90.8D)
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Maximum value of the numeric parameter. This item is meaningless for non-numeric parameters or when both Min and Max are 0.
        /// </summary>
        [JsonProperty("Max")]
        public long? Max{ get; set; }

        /// <summary>
        /// Whether the parameter value supports multiple selections or filling in multiple values.
        /// </summary>
        [JsonProperty("IsMultiple")]
        public bool? IsMultiple{ get; set; }

        /// <summary>
        /// Allow Empty.
        /// </summary>
        [JsonProperty("IsAllowEmpty")]
        public bool? IsAllowEmpty{ get; set; }

        /// <summary>
        /// The associated configuration parameter of this parameter is required for the API call.
        /// Note: If no new configuration parameters are added to the optional parameter, this array is an empty array.
        /// </summary>
        [JsonProperty("ChoiceProperties")]
        public RuleChoicePropertiesItem[] ChoiceProperties{ get; set; }

        /// <summary>
        /// <li> NULL: no special parameter. Select NormalAction for RuleAction;</li>
        /// </summary>
        [JsonProperty("ExtraParameter")]
        public RuleExtraParameter ExtraParameter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamArraySimple(map, prefix + "ChoicesValue.", this.ChoicesValue);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamSimple(map, prefix + "IsMultiple", this.IsMultiple);
            this.SetParamSimple(map, prefix + "IsAllowEmpty", this.IsAllowEmpty);
            this.SetParamArrayObj(map, prefix + "ChoiceProperties.", this.ChoiceProperties);
            this.SetParamObj(map, prefix + "ExtraParameter.", this.ExtraParameter);
        }
    }
}

