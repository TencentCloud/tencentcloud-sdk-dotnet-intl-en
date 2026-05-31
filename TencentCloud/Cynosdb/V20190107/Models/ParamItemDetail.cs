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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParamItemDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>Current value</p>
        /// </summary>
        [JsonProperty("CurrentValue")]
        public string CurrentValue{ get; set; }

        /// <summary>
        /// <p>Default value</p>
        /// </summary>
        [JsonProperty("Default")]
        public string Default{ get; set; }

        /// <summary>
        /// <p>Optional enumerated value of the parameter. If it is a non-enumerated value, it is empty.</p>
        /// </summary>
        [JsonProperty("EnumValue")]
        public string[] EnumValue{ get; set; }

        /// <summary>
        /// <p>1: Global parameter, 0: Non-global parameter</p>
        /// </summary>
        [JsonProperty("IsGlobal")]
        public long? IsGlobal{ get; set; }

        /// <summary>
        /// <p>Maximum value</p>
        /// </summary>
        [JsonProperty("Max")]
        public string Max{ get; set; }

        /// <summary>
        /// <p>Minimum value</p>
        /// </summary>
        [JsonProperty("Min")]
        public string Min{ get; set; }

        /// <summary>
        /// <p>After modifying parameters, whether database restart is required to take effect. 0-no restart required, 1-restart required.</p>
        /// </summary>
        [JsonProperty("NeedReboot")]
        public long? NeedReboot{ get; set; }

        /// <summary>
        /// <p>Parameter name</p>
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// <p>Parameter type: integer, enum, float, string, func</p>
        /// </summary>
        [JsonProperty("ParamType")]
        public string ParamType{ get; set; }

        /// <summary>
        /// <p>Whether the parameter is modifiable</p>
        /// </summary>
        [JsonProperty("ModifiableInfo")]
        public ModifiableInfo ModifiableInfo{ get; set; }

        /// <summary>
        /// <p>Parameter description</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Whether the type is formula</p>
        /// </summary>
        [JsonProperty("IsFunc")]
        public bool? IsFunc{ get; set; }

        /// <summary>
        /// <p>Parameter configuration formula</p>
        /// </summary>
        [JsonProperty("Func")]
        public string Func{ get; set; }

        /// <summary>
        /// <p>Default formula style for parameters that support formulas</p>
        /// </summary>
        [JsonProperty("FuncPattern")]
        public string FuncPattern{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CurrentValue", this.CurrentValue);
            this.SetParamSimple(map, prefix + "Default", this.Default);
            this.SetParamArraySimple(map, prefix + "EnumValue.", this.EnumValue);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamSimple(map, prefix + "NeedReboot", this.NeedReboot);
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamSimple(map, prefix + "ParamType", this.ParamType);
            this.SetParamObj(map, prefix + "ModifiableInfo.", this.ModifiableInfo);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IsFunc", this.IsFunc);
            this.SetParamSimple(map, prefix + "Func", this.Func);
            this.SetParamSimple(map, prefix + "FuncPattern", this.FuncPattern);
        }
    }
}

