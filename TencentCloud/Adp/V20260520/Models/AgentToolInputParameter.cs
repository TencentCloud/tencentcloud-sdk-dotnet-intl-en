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

    public class AgentToolInputParameter : AbstractModel
    {
        
        /// <summary>
        /// <p>Tool name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Tool description</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Tool parameter type</p><p>Enumeration values:</p><ul><li>0: STRING</li><li>1: INT</li><li>2: FLOAT</li><li>3: BOOL</li><li>4: OBJECT</li><li>5: ARRAY_STRING</li><li>6: ARRAY_INT</li><li>7: ARRAY_FLOAT</li><li>8: ARRAY_BOOL</li><li>9: ARRAY_OBJECT</li><li>20: ARRAY_ARRAY</li><li>99: NULL</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>Required or not</p>
        /// </summary>
        [JsonProperty("IsRequired")]
        public bool? IsRequired{ get; set; }

        /// <summary>
        /// <p>Sub-parameter, used only when the data type is OBJECT or ARRAY&lt;&gt;</p>
        /// </summary>
        [JsonProperty("SubParameterList")]
        public AgentToolInputParameter[] SubParameterList{ get; set; }

        /// <summary>
        /// <p>Whether to hide from the model in mode</p>
        /// </summary>
        [JsonProperty("IsHidden")]
        public bool? IsHidden{ get; set; }

        /// <summary>
        /// <p>Parameters in types of OneOf</p>
        /// </summary>
        [JsonProperty("OneOfList")]
        public AgentToolInputParameter[] OneOfList{ get; set; }

        /// <summary>
        /// <p>Parameters in types of AnyOf</p>
        /// </summary>
        [JsonProperty("AnyOfList")]
        public AgentToolInputParameter[] AnyOfList{ get; set; }

        /// <summary>
        /// <p>Source of parameter value</p>
        /// </summary>
        [JsonProperty("Input")]
        public AgentInput Input{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "IsRequired", this.IsRequired);
            this.SetParamArrayObj(map, prefix + "SubParameterList.", this.SubParameterList);
            this.SetParamSimple(map, prefix + "IsHidden", this.IsHidden);
            this.SetParamArrayObj(map, prefix + "OneOfList.", this.OneOfList);
            this.SetParamArrayObj(map, prefix + "AnyOfList.", this.AnyOfList);
            this.SetParamObj(map, prefix + "Input.", this.Input);
        }
    }
}

