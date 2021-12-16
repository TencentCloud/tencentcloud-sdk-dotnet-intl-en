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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScdnSevenLayerRules : AbstractModel
    {
        
        /// <summary>
        /// Whether values are case sensitive
        /// </summary>
        [JsonProperty("CaseSensitive")]
        public bool? CaseSensitive{ get; set; }

        /// <summary>
        /// Rule types:
        /// `protocol`: protocol. Valid values: `HTTP` and `HTTPS`.
        /// `method`: request method. Valid values: `HEAD`, `GET`, `POST`, `PUT`, `OPTIONS`, `TRACE`, `DELETE`, `PATCH` and `CONNECT`.
        /// `all`: domain name. The matching content is `*` and cannot be edited.
        /// `ip`: IP in CIDR format.
        /// `directory`: path starting with a slash (/). You can specify a directory or specific path using up to 128 characters.
        /// `index`: default homepage, which is specified by `/;/index.html` and cannot be edited.
        /// `path`: full path of the file, such as `/acb/test.png`. Wildcard is supported, such as `/abc/*.jpg`.
        /// `file`: file extension, such as `jpg`, `png` and `css`.
        /// `param`: request parameter. The value can contain up to 512 characters.
        /// `referer`: Referer. The value can contain up to 512 characters.
        /// `cookie`: Cookie. The value can contain up to 512 characters.
        /// `user-agent`: User-Agent. The value can contain up to 512 characters.
        /// `head`: custom header. The value can contain up to 512 characters. If the matching content is blank or does not exist, enter the matching parameter directly.
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Logical operator, which connects the relation between RuleType and RuleValue. Valid values:
        /// `exclude`: the rule value is not contained. 
        /// `include`: the rule value is contained. 
        /// `notequal`: the rule value is not equal to the specified rule type. 
        /// `equal`: the rule value is equal to the specified rule type. 
        /// `matching`: the rule value matches with the prefix of the specified rule type.
        /// `null`: the rule value is empty or does not exist.
        /// </summary>
        [JsonProperty("LogicOperator")]
        public string LogicOperator{ get; set; }

        /// <summary>
        /// Rule value
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleValue")]
        public string[] RuleValue{ get; set; }

        /// <summary>
        /// Matched parameter. Only request parameters, Cookie, and custom request headers have a value.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleParam")]
        public string RuleParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CaseSensitive", this.CaseSensitive);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "LogicOperator", this.LogicOperator);
            this.SetParamArraySimple(map, prefix + "RuleValue.", this.RuleValue);
            this.SetParamSimple(map, prefix + "RuleParam", this.RuleParam);
        }
    }
}

