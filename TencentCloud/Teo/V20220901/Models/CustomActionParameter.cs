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

    public class CustomActionParameter : AbstractModel
    {
        
        /// <summary>
        /// <p>Field Name of each parameter under custom configuration.</p><p>You can get it through the API return value CustomActionSet[].Parameters[].Name of DescribeAvailableCustomActionsForRuleEngine, such as "Seconds", "Ports", "StatusCode".</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Data type of each parameter field value under custom configuration.</p><p>Enumeration value:</p><ul><li>String: string type.</li><li>Integer: integer type.</li><li>Float: floating-point type.</li><li>Boolean: boolean type.</li><li>ArrayOfString: string array type.</li><li>ArrayOfInteger: integer array type.</li><li>ArrayOfFloat: floating-point number array type.</li></ul><p>It can be obtained through the API return value CustomActionSet[].Parameters[].Type of DescribeAvailableCustomActionsForRuleEngine.</p>
        /// </summary>
        [JsonProperty("ValueType")]
        public string ValueType{ get; set; }

        /// <summary>
        /// <p>Parameter value of string type. This parameter is required when ValueType is String.</p><p>You can get the default value, measurement unit, limit and other details of the parameter value through the CustomActionSet[].Parameters in the API return value of DescribeAvailableCustomActionsForRuleEngine.</p>
        /// </summary>
        [JsonProperty("StringValue")]
        public string StringValue{ get; set; }

        /// <summary>
        /// <p>Integer type parameter value. This parameter is required when ValueType is Integer.</p><p>You can get the default value, measurement unit, limit, and other details of the parameter value through the CustomActionSet[].Parameters field in the API return value of DescribeAvailableCustomActionsForRuleEngine.</p>
        /// </summary>
        [JsonProperty("IntegerValue")]
        public long? IntegerValue{ get; set; }

        /// <summary>
        /// <p>Floating-point type parameter value. This parameter is required when ValueType is Float.</p><p>You can get the default value, measurement unit, limitation, and other details of the parameter value through the CustomActionSet[].Parameters field in the API return value of DescribeAvailableCustomActionsForRuleEngine.</p>
        /// </summary>
        [JsonProperty("FloatValue")]
        public float? FloatValue{ get; set; }

        /// <summary>
        /// <p>Boolean type parameter value. This parameter is required when ValueType is Boolean.</p><p>You can get the default value, measurement unit, limitation, and other details of the parameter value through the CustomActionSet[].Parameters in the API return value of DescribeAvailableCustomActionsForRuleEngine.</p>
        /// </summary>
        [JsonProperty("BooleanValue")]
        public bool? BooleanValue{ get; set; }

        /// <summary>
        /// <p>String array type parameter value. This parameter is required when ValueType is ArrayOfString.</p><p>You can get the default value, measurement unit, and limitation of the parameter value through the API return value CustomActionSet[].Parameters of the DescribeAvailableCustomActionsForRuleEngine API.</p>
        /// </summary>
        [JsonProperty("StringArrayValue")]
        public string[] StringArrayValue{ get; set; }

        /// <summary>
        /// <p>Array type parameter value of integer. This parameter is required when ValueType is ArrayOfInteger.</p><p>You can get the default value, measurement unit, limit, and other details of the parameter value through the API return value CustomActionSet[].Parameters of the DescribeAvailableCustomActionsForRuleEngine API.</p>
        /// </summary>
        [JsonProperty("IntegerArrayValue")]
        public long?[] IntegerArrayValue{ get; set; }

        /// <summary>
        /// <p>Floating-point number array type parameter value. This parameter is required when ValueType is ArrayOfFloat.</p><p>You can get the default value, measurement unit, limitation, and other descriptions of the parameter value through the CustomActionSet[].Parameters field in the API return value of DescribeAvailableCustomActionsForRuleEngine.</p>
        /// </summary>
        [JsonProperty("FloatArrayValue")]
        public float?[] FloatArrayValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
            this.SetParamSimple(map, prefix + "StringValue", this.StringValue);
            this.SetParamSimple(map, prefix + "IntegerValue", this.IntegerValue);
            this.SetParamSimple(map, prefix + "FloatValue", this.FloatValue);
            this.SetParamSimple(map, prefix + "BooleanValue", this.BooleanValue);
            this.SetParamArraySimple(map, prefix + "StringArrayValue.", this.StringArrayValue);
            this.SetParamArraySimple(map, prefix + "IntegerArrayValue.", this.IntegerArrayValue);
            this.SetParamArraySimple(map, prefix + "FloatArrayValue.", this.FloatArrayValue);
        }
    }
}

