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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ActionFieldConfigDetail : AbstractModel
    {
        
        /// <summary>
        /// Component type
        /// The options are as follows:
        /// input: text box
        /// textarea: multi-line text box
        /// number: number input box
        /// select: selector
        /// cascader: cascade selector
        /// radio: single choice
        /// time: time selection
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Component label
        /// </summary>
        [JsonProperty("Lable")]
        public string Lable{ get; set; }

        /// <summary>
        /// Unique identifier of the component, key when it is sent back to the backend
        /// </summary>
        [JsonProperty("Field")]
        public string Field{ get; set; }

        /// <summary>
        /// Default value
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// The supported configuration items are as follows. You can select the configuration items as needed. If no configuration is required, set the value to {}.
        /// 
        /// {  placeholder: string (placeholder)
        /// 
        ///   tooltip: string (prompt message)
        /// 
        ///   reg: RegExp (regular expression for the input content format)
        /// 
        ///   max: number (maximum number of input characters for text boxes and upper limit of the input number for number input boxes)
        /// 
        ///   min: number (lower limit of the input number for number input boxes)
        /// 
        ///   step: number (step size for number input boxes; default value: 1)
        /// 
        ///   format: string (format for time selection, for example YYYY-MM-DD and YYYY-MM-DD HH:mm:ss)
        /// 
        ///   separator: string[] (separator for multi-line input boxes. If it is left blank, no separator is used, and the text string entered by the user is returned directly.)
        /// 
        ///   multiple: boolean (multiple-choice or not, valid for selectors and cascade selectors)
        /// 
        ///   options: selector options (support the following two forms)
        /// 
        /// Directly provide the option array: { value: string; label: string }[]
        /// Obtain options by calling the API: { api: string (API URL), params: string[] (interface parameters, corresponding to field of the parameter configuration. The frontend uses the input values of all components corresponding to field as parameters to query data. If no value is input, the frontend directly requests data when components are loaded.) 
        /// }
        /// }
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// Whether it is required (0: no; 1: yes)
        /// </summary>
        [JsonProperty("Required")]
        public ulong? Required{ get; set; }

        /// <summary>
        /// The compute configuration passes the verification when other fields that it depends on meet the conditions. (For example, at least one of the three form items must be filled in.)
        /// 
        /// [fieldName,
        /// 
        /// { config: This item is retained and will be refined based on subsequent scenes. }
        /// 
        /// ]
        /// </summary>
        [JsonProperty("Validate")]
        public string Validate{ get; set; }

        /// <summary>
        /// Whether it is visible
        /// </summary>
        [JsonProperty("Visible")]
        public string Visible{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Lable", this.Lable);
            this.SetParamSimple(map, prefix + "Field", this.Field);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "Required", this.Required);
            this.SetParamSimple(map, prefix + "Validate", this.Validate);
            this.SetParamSimple(map, prefix + "Visible", this.Visible);
        }
    }
}

