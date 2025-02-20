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
        /// The parameter value type.
        /// <Li>`CHOICE`: the parameter value can only be selected from `choicesvalue`.</li>.
        /// <Li>TOGGLE: the parameter value is of switch type and can be selected from `choicesvalue`.</li>.
        /// <Li>OBJECT: the parameter value is of object type, and `choiceproperties` are the properties associated with this object type.</li>.
        /// <Li>`CUSTOM_NUM`: (integer) custom value.</li>.
        /// <Li> custom_string: parameter value is user-customized, string type.</li> note: when the parameter type is object, please refer to [example 2: creating a parameter of object type](https://intl.cloud.tencent.com/document/product/1552/80622?from_cn_redirect=1#.e7.a4.ba.e4.be.8b2-.e4.bf.ae.e6.94.b9.e6.ba.90.e7.ab.99.e4.b8.baip.e5.9f.9f.e5.90.8d).
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

