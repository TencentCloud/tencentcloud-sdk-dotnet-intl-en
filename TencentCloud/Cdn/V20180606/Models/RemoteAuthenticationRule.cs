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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RemoteAuthenticationRule : AbstractModel
    {
        
        /// <summary>
        /// Remote authentication server
        /// The server configured in `RemoteAutherntication` is used by default.
        /// </summary>
        [JsonProperty("Server")]
        public string Server{ get; set; }

        /// <summary>
        /// HTTP method used by the remote authentication server. Valid values: `get`, `post`, `head`, and `all`. 
        /// `all`: the remote authentication server follows the client request method.
        /// Default: `all`
        /// </summary>
        [JsonProperty("AuthMethod")]
        public string AuthMethod{ get; set; }

        /// <summary>
        /// Rule types:
        /// `all`: apply to all files
        /// `file`: apply to files with the specified suffixes
        /// `directory`: apply to the specified directories
        /// `path`: apply to the specified absolute paths
        /// Default: `all`.
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Content for each `RuleType`:
        /// For `all`, enter a wildcard `*`.
        /// For `file`, enter a suffix, e.g., `jpg` or `txt`.
        /// For `directory`, enter a path, e.g., `/xxx/test/`.
        /// For `path`, enter an absolute path, e.g., `/xxx/test.html`.
        /// For `index`, enter a forward slash `/`.
        /// Default: `*`
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }

        /// <summary>
        /// Timeout period of the remote authentication server. Unit: ms.
        /// Value range: [1, 30,000]
        /// Default: 20000
        /// </summary>
        [JsonProperty("AuthTimeout")]
        public long? AuthTimeout{ get; set; }

        /// <summary>
        /// Whether to deny or allow the request when the remote authentication server is timed out:
        /// `RETURN_200`: the request is allowed when the remote authentication server is timed out.
        /// `RETURN_403`: the request is denied when the remote authentication server is timed out.
        /// Default: `RETURN_200`
        /// </summary>
        [JsonProperty("AuthTimeoutAction")]
        public string AuthTimeoutAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Server", this.Server);
            this.SetParamSimple(map, prefix + "AuthMethod", this.AuthMethod);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
            this.SetParamSimple(map, prefix + "AuthTimeout", this.AuthTimeout);
            this.SetParamSimple(map, prefix + "AuthTimeoutAction", this.AuthTimeoutAction);
        }
    }
}

