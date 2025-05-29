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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PluginToolReqParam : AbstractModel
    {
        
        /// <summary>
        /// Parameter name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Parameter description.
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// Parameter type, 0: string; 1: int; 2: float; 3: bool; 4: object; 5: array_string; 6: array_int; 7: array_float; 8: array_bool; 9: array_object, 99: null, 100: upspecified.
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Whether the parameter is required.
        /// </summary>
        [JsonProperty("IsRequired")]
        public bool? IsRequired{ get; set; }

        /// <summary>
        /// Parameter default value.
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// Sub-parameter. "ParamType" is useful when it is "OBJECT " or "ARRAY<>" type.
        /// </summary>
        [JsonProperty("SubParams")]
        public PluginToolReqParam[] SubParams{ get; set; }

        /// <summary>
        /// Whether the plugin parameter configuration is hidden and invisible. true - Hidden and invisible; false - Visible.
        /// </summary>
        [JsonProperty("GlobalHidden")]
        public bool? GlobalHidden{ get; set; }

        /// <summary>
        /// OneOf type parameter.
        /// </summary>
        [JsonProperty("OneOf")]
        public PluginToolReqParam[] OneOf{ get; set; }

        /// <summary>
        /// AnyOf type parameter.
        /// </summary>
        [JsonProperty("AnyOf")]
        public PluginToolReqParam[] AnyOf{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "IsRequired", this.IsRequired);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamArrayObj(map, prefix + "SubParams.", this.SubParams);
            this.SetParamSimple(map, prefix + "GlobalHidden", this.GlobalHidden);
            this.SetParamArrayObj(map, prefix + "OneOf.", this.OneOf);
            this.SetParamArrayObj(map, prefix + "AnyOf.", this.AnyOf);
        }
    }
}

