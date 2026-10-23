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

    public class RuleEngineCustomActionParameterSchema : AbstractModel
    {
        
        /// <summary>
        /// <p>Parameter field name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Parameter field data type. Valid values: <li>Boolean: boolean;</li><li>Integer: integer;</li><li>Float: floating-point;</li><li>String: string;</li><li>ArrayOfInteger: integer array;</li><li>ArrayOfFloat: floating-point array;</li><li>ArrayOfString: array of strings.</li></p>
        /// </summary>
        [JsonProperty("ValueType")]
        public string ValueType{ get; set; }

        /// <summary>
        /// <p>Parameter field description.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Field default value of the parameter.</p>
        /// </summary>
        [JsonProperty("Default")]
        public string Default{ get; set; }

        /// <summary>
        /// <p>Parameter field unit.</p>
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// <p>Whether the parameter field is required or not.</p><p>Default value: false</p><p>If filled, it is applicable to ALL parameter field type verification; if left blank, no verification.</p>
        /// </summary>
        [JsonProperty("Required")]
        public bool? Required{ get; set; }

        /// <summary>
        /// <p>Minimum value of the parameter field.</p><p>If filled, it is used to validate the value for integer, floating-point number, integer array, and floating-point number array type parameters; if left blank, there is no verification.</p>
        /// </summary>
        [JsonProperty("MinValue")]
        public float? MinValue{ get; set; }

        /// <summary>
        /// <p>Maximum value of the parameter field.</p><p>If filled, it is used for value verification of type parameters for integers, floating-point numbers, integer arrays, and floating-point number arrays. If left blank, there is no verification.</p>
        /// </summary>
        [JsonProperty("MaxValue")]
        public float? MaxValue{ get; set; }

        /// <summary>
        /// <p>Minimum length of the parameter field.</p><p>If filled, it is used for value verification of string and string array type parameters. If not filled, there is no verification.</p>
        /// </summary>
        [JsonProperty("MinLength")]
        public long? MinLength{ get; set; }

        /// <summary>
        /// <p>Maximum length of the parameter field.</p><p>If filled, it is used for value verification for strings and array of strings type parameters; if left blank, no verification.</p>
        /// </summary>
        [JsonProperty("MaxLength")]
        public long? MaxLength{ get; set; }

        /// <summary>
        /// <p>Minimum item count of the parameter field.</p><p>If filled, it is applicable to value verification for various array type parameters; if left blank, there is no verification.</p>
        /// </summary>
        [JsonProperty("MinItems")]
        public long? MinItems{ get; set; }

        /// <summary>
        /// <p>Maximum item count of the parameter field.</p><p>If filled, it is applicable to value verification for various array type parameters. If left blank, there is no verification.</p>
        /// </summary>
        [JsonProperty("MaxItems")]
        public long? MaxItems{ get; set; }

        /// <summary>
        /// <p>Whether the parameter field item is unique.</p><p>Default value: false</p><p>If filled, it is applicable to various array type parameter value verification; if left blank, no verification.</p>
        /// </summary>
        [JsonProperty("UniqueItems")]
        public bool? UniqueItems{ get; set; }

        /// <summary>
        /// <p>Allowed format of the parameter field.</p><p>If filled, verification of string or string array content is required. If not filled, there is no verification.</p>
        /// </summary>
        [JsonProperty("AllowedPattern")]
        public string AllowedPattern{ get; set; }

        /// <summary>
        /// <p>Allowed values of the parameter field. If empty, there is no verification.</p><p>If this parameter is filled, it indicates that the corresponding parameter is an enum and only allows values from this parameter array; if left blank, there is no verification.</p>
        /// </summary>
        [JsonProperty("AllowedValues")]
        public string[] AllowedValues{ get; set; }

        /// <summary>
        /// <p>Minimum step size of the parameter field.</p><p>If filled, it is suitable for value verification of floating-point and floating-point array type parameters. If not filled, there is no verification.</p>
        /// </summary>
        [JsonProperty("MultipleOf")]
        public string MultipleOf{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Default", this.Default);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "Required", this.Required);
            this.SetParamSimple(map, prefix + "MinValue", this.MinValue);
            this.SetParamSimple(map, prefix + "MaxValue", this.MaxValue);
            this.SetParamSimple(map, prefix + "MinLength", this.MinLength);
            this.SetParamSimple(map, prefix + "MaxLength", this.MaxLength);
            this.SetParamSimple(map, prefix + "MinItems", this.MinItems);
            this.SetParamSimple(map, prefix + "MaxItems", this.MaxItems);
            this.SetParamSimple(map, prefix + "UniqueItems", this.UniqueItems);
            this.SetParamSimple(map, prefix + "AllowedPattern", this.AllowedPattern);
            this.SetParamArraySimple(map, prefix + "AllowedValues.", this.AllowedValues);
            this.SetParamSimple(map, prefix + "MultipleOf", this.MultipleOf);
        }
    }
}

