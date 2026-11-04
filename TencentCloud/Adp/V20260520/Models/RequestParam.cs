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

    public class RequestParam : AbstractModel
    {
        
        /// <summary>
        /// <p>Parameters in types of AnyOf</p>
        /// </summary>
        [JsonProperty("AnyOf")]
        public RequestParam[] AnyOf{ get; set; }

        /// <summary>
        /// <p>Default value.</p>
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// <p>Parameter description</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Globally hidden and invisible (different from agent_hidden in the Agent scenario). true: globally hidden and invisible; false: visible</p>
        /// </summary>
        [JsonProperty("IsGlobalHidden")]
        public bool? IsGlobalHidden{ get; set; }

        /// <summary>
        /// <p>Required or optional</p>
        /// </summary>
        [JsonProperty("IsRequired")]
        public bool? IsRequired{ get; set; }

        /// <summary>
        /// <p>Parameter name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Parameters in types of OneOf</p>
        /// </summary>
        [JsonProperty("OneOf")]
        public RequestParam[] OneOf{ get; set; }

        /// <summary>
        /// <p>Sub-parameter, used only when ParamType is OBJECT or ARRAY&lt;&gt;</p>
        /// </summary>
        [JsonProperty("SubParams")]
        public RequestParam[] SubParams{ get; set; }

        /// <summary>
        /// <table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>PARAM_TYPE_STRING</td><td>0</td><td>String</td></tr><tr><td>PARAM_TYPE_INT</td><td>1</td><td>Integer</td></tr><tr><td>PARAM_TYPE_FLOAT</td><td>2</td><td>Floating-point number</td></tr><tr><td>PARAM_TYPE_BOOL</td><td>3</td><td>Boolean value</td></tr><tr><td>PARAM_TYPE_OBJECT</td><td>4</td><td>Object</td></tr><tr><td>PARAM_TYPE_ARRAY_STRING</td><td>5</td><td>Array of strings</td></tr><tr><td>PARAM_TYPE_ARRAY_INT</td><td>6</td><td>Array of integers</td></tr><tr><td>PARAM_TYPE_ARRAY_FLOAT</td><td>7</td><td>Array of floating-point numbers</td></tr><tr><td>PARAM_TYPE_ARRAY_BOOL</td><td>8</td><td>Array of boolean values</td></tr><tr><td>PARAM_TYPE_ARRAY_OBJECT</td><td>9</td><td>Object array</td></tr><tr><td>PARAM_TYPE_ARRAY_ARRAY</td><td>20</td><td>Nested array</td></tr><tr><td>PARAM_TYPE_NULL</td><td>99</td><td>Null</td></tr><tr><td>PARAM_TYPE_UNSPECIFIED</td><td>100</td><td>Unspecified type, for OneOf and AnyOf scenarios</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "AnyOf.", this.AnyOf);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IsGlobalHidden", this.IsGlobalHidden);
            this.SetParamSimple(map, prefix + "IsRequired", this.IsRequired);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "OneOf.", this.OneOf);
            this.SetParamArrayObj(map, prefix + "SubParams.", this.SubParams);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

