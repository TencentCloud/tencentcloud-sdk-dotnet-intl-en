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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppTriggerParamSchema : AbstractModel
    {
        
        /// <summary>
        /// <p>Parameter name</p>
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// <table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>PARAM_TYPE_STRING</td><td>0</td><td>String</td></tr><tr><td>PARAM_TYPE_INT</td><td>1</td><td>Integer</td></tr><tr><td>PARAM_TYPE_FLOAT</td><td>2</td><td>Floating-point number</td></tr><tr><td>PARAM_TYPE_BOOL</td><td>3</td><td>Boolean value</td></tr><tr><td>PARAM_TYPE_OBJECT</td><td>4</td><td>Object</td></tr><tr><td>PARAM_TYPE_ARRAY_STRING</td><td>5</td><td>String array</td></tr><tr><td>PARAM_TYPE_ARRAY_INT</td><td>6</td><td>Integer array</td></tr><tr><td>PARAM_TYPE_ARRAY_FLOAT</td><td>7</td><td>Floating-point number array</td></tr><tr><td>PARAM_TYPE_ARRAY_BOOL</td><td>8</td><td>Boolean value array</td></tr><tr><td>PARAM_TYPE_ARRAY_OBJECT</td><td>9</td><td>Object array</td></tr><tr><td>PARAM_TYPE_ARRAY_ARRAY</td><td>20</td><td>Nested array</td></tr><tr><td>PARAM_TYPE_NULL</td><td>99</td><td>Null</td></tr><tr><td>PARAM_TYPE_UNSPECIFIED</td><td>100</td><td>Unspecified type, used for OneOf and AnyOf scenarios</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("ParamType")]
        public long? ParamType{ get; set; }

        /// <summary>
        /// <p>Required or optional</p>
        /// </summary>
        [JsonProperty("Required")]
        public bool? Required{ get; set; }

        /// <summary>
        /// <p>Sub-parameter list</p>
        /// </summary>
        [JsonProperty("SubParamList")]
        public AppTriggerParamSchema[] SubParamList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamSimple(map, prefix + "ParamType", this.ParamType);
            this.SetParamSimple(map, prefix + "Required", this.Required);
            this.SetParamArrayObj(map, prefix + "SubParamList.", this.SubParamList);
        }
    }
}

