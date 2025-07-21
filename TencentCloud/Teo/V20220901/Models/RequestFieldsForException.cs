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

    public class RequestFieldsForException : AbstractModel
    {
        
        /// <summary>
        /// Skip specific field. supported values:.
        /// <li>body.json: parameter content in json requests. at this point, Condition supports key and value, TargetField supports key and value, for example { "Scope": "body.json", "Condition": "", "TargetField": "key" }, which means all parameters in json requests skip WAF scan.</li>.
        /// <li style="margin-top:5px">cookie: cookie; at this point Condition supports key, value, TargetField supports key, value, for example { "Scope": "cookie", "Condition": "${key} in ['account-id'] and ${value} like ['prefix-*']", "TargetField": "value" }, which means the cookie parameter name equals account-id and the parameter value wildcard matches prefix-* to skip WAF scan;</li>.
        /// <li style="margin-top:5px">header: HTTP header parameters. at this point, Condition supports key and value, TargetField supports key and value, for example { "Scope": "header", "Condition": "${key} like ['x-auth-*']", "TargetField": "value" }, which means header parameter name wildcard match x-auth-* skips WAF scan.</li>.
        /// <li style="margin-top:5px">uri.query: URL encoding content/query parameter. at this point, Condition supports key and value, TargetField supports key and value. example: { "Scope": "uri.query", "Condition": "${key} in ['action'] and ${value} in ['upload', 'delete']", "TargetField": "value" }. indicates URL encoding content/query parameter name equal to action and parameter value equal to upload or delete skips WAF scan.</li>.
        /// <li style="margin-top:5px">uri: specifies the request path uri. at this point, Condition must be empty. TargetField supports query, path, fullpath, such as {"Scope": "uri", "Condition": "", "TargetField": "query"}, indicates the request path uri skips WAF scan for query parameters.</li>.
        /// <li style="margin-top:5px">body: request body content. at this point Condition must be empty, TargetField supports fullbody, multipart, such as { "Scope": "body", "Condition": "", "TargetField": "fullbody" }, which means the request body content skips WAF scan as a full request.</li>.
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// Skip specific field expression must comply with expression grammar.
        /// Condition supports expression configuration syntax: <li> write according to the matching conditional expression syntax of rules, with support for referencing key and value.</li> <li> supports in, like operators, and logical combination with and.</li>.
        /// For example: <li>${key} in ['x-trace-id']: the parameter name equals x-trace-id.</li> <li>${key} in ['x-trace-id'] and ${value} like ['Bearer *']: the parameter name equals x-trace-id and the parameter value wildcard matches Bearer *.</li>.
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// The Scope parameter takes different values. the TargetField expression supports the following values:.
        /// <Li> body.json: supports key, value.</li>.
        /// <li>cookie: supports key and value.</li>.
        /// <li>header: supports key, value</li>.
        /// <Li> uri.query: supports key and value</li>.
        /// <li>uri. specifies path, query, or fullpath.</li>.
        /// <Li>Body: supports fullbody and multipart.</li>.
        /// </summary>
        [JsonProperty("TargetField")]
        public string TargetField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamSimple(map, prefix + "TargetField", this.TargetField);
        }
    }
}

