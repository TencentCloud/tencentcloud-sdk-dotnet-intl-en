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

    public class ParamDetail : AbstractModel
    {
        
        /// <summary>
        /// Parameter name.
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// Parameter type: integer, enum, float, string, func
        /// </summary>
        [JsonProperty("ParamType")]
        public string ParamType{ get; set; }

        /// <summary>
        /// true: supports "func"; false: no formula support
        /// </summary>
        [JsonProperty("SupportFunc")]
        public bool? SupportFunc{ get; set; }

        /// <summary>
        /// Default value
        /// </summary>
        [JsonProperty("Default")]
        public string Default{ get; set; }

        /// <summary>
        /// Parameter description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Current parameter value
        /// </summary>
        [JsonProperty("CurrentValue")]
        public string CurrentValue{ get; set; }

        /// <summary>
        /// Whether database restart is required after modifying parameters to take effect. 0: no restart required; 1: restart required.
        /// </summary>
        [JsonProperty("NeedReboot")]
        public long? NeedReboot{ get; set; }

        /// <summary>
        /// Maximum value allowed for the parameter
        /// </summary>
        [JsonProperty("Max")]
        public string Max{ get; set; }

        /// <summary>
        /// Minimum allowed parameter value
        /// </summary>
        [JsonProperty("Min")]
        public string Min{ get; set; }

        /// <summary>
        /// Optional enumerated values of the parameter. If it is a non-enumerated value, this parameter is empty
        /// </summary>
        [JsonProperty("EnumValue")]
        public string[] EnumValue{ get; set; }

        /// <summary>
        /// 1: global parameter, 0: non-global parameter
        /// </summary>
        [JsonProperty("IsGlobal")]
        public long? IsGlobal{ get; set; }

        /// <summary>
        /// Match type. multiVal
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }

        /// <summary>
        /// Match target value. If multiVal is set, separate each key with a comma.
        /// </summary>
        [JsonProperty("MatchValue")]
        public string MatchValue{ get; set; }

        /// <summary>
        /// true: formula; false: non-formula
        /// </summary>
        [JsonProperty("IsFunc")]
        public bool? IsFunc{ get; set; }

        /// <summary>
        /// When the parameter is set to a formula, Func returns the set formula content.
        /// </summary>
        [JsonProperty("Func")]
        public string Func{ get; set; }

        /// <summary>
        /// Whether the parameter is modifiable
        /// </summary>
        [JsonProperty("ModifiableInfo")]
        public ModifiableInfo ModifiableInfo{ get; set; }

        /// <summary>
        /// Default formula style for parameters that support formulas
        /// </summary>
        [JsonProperty("FuncPattern")]
        public string FuncPattern{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamSimple(map, prefix + "ParamType", this.ParamType);
            this.SetParamSimple(map, prefix + "SupportFunc", this.SupportFunc);
            this.SetParamSimple(map, prefix + "Default", this.Default);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CurrentValue", this.CurrentValue);
            this.SetParamSimple(map, prefix + "NeedReboot", this.NeedReboot);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamArraySimple(map, prefix + "EnumValue.", this.EnumValue);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
            this.SetParamSimple(map, prefix + "MatchValue", this.MatchValue);
            this.SetParamSimple(map, prefix + "IsFunc", this.IsFunc);
            this.SetParamSimple(map, prefix + "Func", this.Func);
            this.SetParamObj(map, prefix + "ModifiableInfo.", this.ModifiableInfo);
            this.SetParamSimple(map, prefix + "FuncPattern", this.FuncPattern);
        }
    }
}

