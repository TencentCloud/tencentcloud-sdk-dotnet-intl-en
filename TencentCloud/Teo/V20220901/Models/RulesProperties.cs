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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RulesProperties : AbstractModel
    {
        
        /// <summary>
        /// Parameter name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Minimum value. If both `Min` and `Max` are set to `0`, this parameter does not take effect.
        /// </summary>
        [JsonProperty("Min")]
        public long? Min{ get; set; }

        /// <summary>
        /// Valid parameter values.
        /// Note: If `Type` is `CUSTOM_NUM` or `CUSTOM_STRING`, this parameter will be an empty array.
        /// </summary>
        [JsonProperty("ChoicesValue")]
        public string[] ChoicesValue{ get; set; }

        /// <summary>
        /// Parameter value type.
        /// <li>`CHOICE`: The parameter value can be selected only from `ChoicesValue`.</li>
        /// <li>`TOGGLE`: The parameter value is of switch type and can be selected from `ChoicesValue`.</li>
        /// <li>`OBJECT`: The parameter value is of object type, and `ChoiceProperties` indicates the attributes associated with the object type.</li>
        /// <li>`CUSTOM_NUM`: Custom integer</li>
        /// <li>`CUSTOM_STRING`: Custom string.</li>Note: If `OBJECT` is selected, refer to [Example 2. Create a rule with parameters of OBJECT type](https://tcloud4api.woa.com/document/product/1657/79382?!preview&!document=1).
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Maximum value. If both `Min` and `Max` are set to `0`, this parameter does not take effect.
        /// </summary>
        [JsonProperty("Max")]
        public long? Max{ get; set; }

        /// <summary>
        /// Whether multiple values can be selected or entered.
        /// </summary>
        [JsonProperty("IsMultiple")]
        public bool? IsMultiple{ get; set; }

        /// <summary>
        /// Whether the parameter can be left empty.
        /// </summary>
        [JsonProperty("IsAllowEmpty")]
        public bool? IsAllowEmpty{ get; set; }

        /// <summary>
        /// Associated configuration parameters of this parameter, which are required for API call.
        /// Note: This parameter will be an empty array if no special parameters are added as optional parameters.
        /// </summary>
        [JsonProperty("ChoiceProperties")]
        public RuleChoicePropertiesItem[] ChoiceProperties{ get; set; }

        /// <summary>
        /// <li>NULL: No special parameters when `NormalAction` is selected for `RuleAction`.</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
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

