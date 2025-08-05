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

    public class CustomField : AbstractModel
    {
        
        /// <summary>
        /// Type of the custom log field, which indicates extracting data from specified positions in HTTP requests and responses. valid values:.
        /// <li>ReqHeader: extract the value of a specified field from an HTTP request header;</li>.
        /// <li>RspHeader: extracts the value of a specified field from an HTTP response header.</li>.
        /// <Li>Cookie: extract the specified field value from a cookie;</li>.
        /// <li>ReqBody: extract specified content from an HTTP request body using a Google RE2 regular expression.</li>.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Enter the field value definition based on the field type (Name). this parameter is case-sensitive.
        /// <li>When the field type is ReqHeader, RspHeader, or Cookie, enter the parameter name for value extraction, such as Accept-Language. you can enter 1-100 characters. the name must start with a letter, contain letters, digits, or hyphens (-) in the middle, and end with a letter or digit.</li>.
        /// <li>When the field type is ReqBody, enter the Google RE2 regular expression. the maximum length of the regular expression is 4 KB.</li>.
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// Whether to deliver this field. leave blank to skip delivery.
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

