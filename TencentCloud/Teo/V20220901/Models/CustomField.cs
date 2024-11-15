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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomField : AbstractModel
    {
        
        /// <summary>
        /// Type of the custom log filed, which indicates extracting data from a specified position in HTTP requests and responses. Valid values:
        /// <li>ReqHeader: Extract the value of a specified field from an HTTP request header;</li>
        /// <li>RspHeader: Extract the value of a specified field from an HTTP response header;</li>
        /// <li>Cookie: Extract the value of a specified field from a cookie;</li>
        /// <li>ReqBody: Extract specified content from an HTTP request body using a Google RE2 regular expression.</li>
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Enter the definition of the field value based on the field type (Name). This parameter is case-sensitive.
        /// <li>When the field type is ReqHeader, RspHeader, or Cookie, enter the name of the parameter for which you need to extract the value, such as Accept-Language. You can enter 1-100 characters. The name should start with a letter, contain letters, digits, and hyphens (-) in the middle, and end with a letter or digit.</li>
        /// <li>When the field type is ReqBody, enter the Google RE2 regular expression. The maximum length of the regular expression is 4 KB.</li>
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// Indicates whether to deliver this field. If not filled in, this field will not be delivered.
        /// Note: This field may return null, indicating that no valid values can be obtained.
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

