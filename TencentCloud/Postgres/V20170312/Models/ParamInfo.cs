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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParamInfo : AbstractModel
    {
        
        /// <summary>
        /// Parameter ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// Parameter name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Parameter value type: integer, real, bool, enum, mutil_enum.
        /// When the parameter type is integer or real (floating-point), the value range is determined based on the Max and Min of the return value. 
        /// When the parameter type is boolean, the valid values are true or false. 
        /// When the parameter type is enum (enumeration type) or mutil_enum (multi-enum type), the valid values are determined by EnumValue in the return value.
        /// </summary>
        [JsonProperty("ParamValueType")]
        public string ParamValueType{ get; set; }

        /// <summary>
        /// Parameter value unit. returns null if the parameter has no units.
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// Default parameter value. returns in string form.
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// Specifies the current value in string form.
        /// </summary>
        [JsonProperty("CurrentValue")]
        public string CurrentValue{ get; set; }

        /// <summary>
        /// Specifies the numerical type (integer, real) parameter and its lower bound.
        /// </summary>
        [JsonProperty("Max")]
        public float? Max{ get; set; }

        /// <summary>
        /// Value range of the enum parameter
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnumValue")]
        public string[] EnumValue{ get; set; }

        /// <summary>
        /// Numerical type (integer, real) parameter specifies the upper bound.
        /// </summary>
        [JsonProperty("Min")]
        public float? Min{ get; set; }

        /// <summary>
        /// Chinese description.
        /// </summary>
        [JsonProperty("ParamDescriptionCH")]
        public string ParamDescriptionCH{ get; set; }

        /// <summary>
        /// Specifies the english description of the parameter.
        /// </summary>
        [JsonProperty("ParamDescriptionEN")]
        public string ParamDescriptionEN{ get; set; }

        /// <summary>
        /// Specifies whether a restart is required for parameter modification (true indicates required, false indicates not required).
        /// </summary>
        [JsonProperty("NeedReboot")]
        public bool? NeedReboot{ get; set; }

        /// <summary>
        /// Parameter chinese category.
        /// </summary>
        [JsonProperty("ClassificationCN")]
        public string ClassificationCN{ get; set; }

        /// <summary>
        /// Parameter english category.
        /// </summary>
        [JsonProperty("ClassificationEN")]
        public string ClassificationEN{ get; set; }

        /// <summary>
        /// Specifies whether it is related to the specification (true for related, false for unrelated).
        /// </summary>
        [JsonProperty("SpecRelated")]
        public bool? SpecRelated{ get; set; }

        /// <summary>
        /// Indicates whether it is a key parameter (true means it is a key parameter, modification requires special attention and may affect instance performance).
        /// </summary>
        [JsonProperty("Advanced")]
        public bool? Advanced{ get; set; }

        /// <summary>
        /// Specifies the last modified time.
        /// </summary>
        [JsonProperty("LastModifyTime")]
        public string LastModifyTime{ get; set; }

        /// <summary>
        /// Parameter primary-secondary constraints. `0`: no constraint between primary and standby. `1`: standby parameter value > primary machine parameter value. `2`: primary parameter value must be greater than that of the standby machine.
        /// </summary>
        [JsonProperty("StandbyRelated")]
        public long? StandbyRelated{ get; set; }

        /// <summary>
        /// Parameter version association information, containing detailed parameter information for the respective kernel version
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VersionRelationSet")]
        public ParamVersionRelation[] VersionRelationSet{ get; set; }

        /// <summary>
        /// Parameter specification association information, containing detailed parameter information for the respective specification
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SpecRelationSet")]
        public ParamSpecRelation[] SpecRelationSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ParamValueType", this.ParamValueType);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamSimple(map, prefix + "CurrentValue", this.CurrentValue);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamArraySimple(map, prefix + "EnumValue.", this.EnumValue);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamSimple(map, prefix + "ParamDescriptionCH", this.ParamDescriptionCH);
            this.SetParamSimple(map, prefix + "ParamDescriptionEN", this.ParamDescriptionEN);
            this.SetParamSimple(map, prefix + "NeedReboot", this.NeedReboot);
            this.SetParamSimple(map, prefix + "ClassificationCN", this.ClassificationCN);
            this.SetParamSimple(map, prefix + "ClassificationEN", this.ClassificationEN);
            this.SetParamSimple(map, prefix + "SpecRelated", this.SpecRelated);
            this.SetParamSimple(map, prefix + "Advanced", this.Advanced);
            this.SetParamSimple(map, prefix + "LastModifyTime", this.LastModifyTime);
            this.SetParamSimple(map, prefix + "StandbyRelated", this.StandbyRelated);
            this.SetParamArrayObj(map, prefix + "VersionRelationSet.", this.VersionRelationSet);
            this.SetParamArrayObj(map, prefix + "SpecRelationSet.", this.SpecRelationSet);
        }
    }
}

