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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParamInfo : AbstractModel
    {
        
        /// <summary>
        /// Parameter ID
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// Parameter name
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Value type of the parameter. Valid values: `integer`, `real` (floating-point), `bool`, `enum`, `mutil_enum` (this type of parameter can be set to multiple enumerated values).
        /// For an `integer` or `real` parameter, the `Min` field represents the minimum value and the `Max` field the maximum value. 
        /// For a `bool` parameter, the valid values include `true` and `false`; 
        /// For an `enum` or `mutil_enum` parameter, the `EnumValue` field represents the valid values.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ParamValueType")]
        public string ParamValueType{ get; set; }

        /// <summary>
        /// Unit of the parameter value. If the parameter has no unit, this field will return null.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// Default value of the parameter, which is returned as a string
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// Current value of the parameter, which is returned as a string
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CurrentValue")]
        public string CurrentValue{ get; set; }

        /// <summary>
        /// The maximum value of the `integer` or `real` parameter
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
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
        /// The minimum value of the `integer` or `real` parameter
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Min")]
        public float? Min{ get; set; }

        /// <summary>
        /// Parameter description in Chinese
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ParamDescriptionCH")]
        public string ParamDescriptionCH{ get; set; }

        /// <summary>
        /// Parameter description in English
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ParamDescriptionEN")]
        public string ParamDescriptionEN{ get; set; }

        /// <summary>
        /// Whether to restart the instance for the modified parameter to take effect. Valid values: `true` (yes), `false` (no)
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NeedReboot")]
        public bool? NeedReboot{ get; set; }

        /// <summary>
        /// Parameter category in Chinese
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClassificationCN")]
        public string ClassificationCN{ get; set; }

        /// <summary>
        /// Parameter category in English
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClassificationEN")]
        public string ClassificationEN{ get; set; }

        /// <summary>
        /// Whether the parameter is related to specifications. Valid values: `true` (yes), `false` (no)
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SpecRelated")]
        public bool? SpecRelated{ get; set; }

        /// <summary>
        /// Whether it is a key parameter. Valid values: `true` (yes, and modifying it may affect instance performance), `false` (no)
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Advanced")]
        public bool? Advanced{ get; set; }

        /// <summary>
        /// The last modified time of the parameter
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastModifyTime")]
        public string LastModifyTime{ get; set; }

        /// <summary>
        /// Parameter primary-secondary constraints, `0`: No constraint, `1`: Standby parameter value must be greater than that of the primary machine, `2`: Primary parameter value must be greater than that of the standby machine.
        /// Note: This field may return null, indicating that no valid values can be obtained.
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

