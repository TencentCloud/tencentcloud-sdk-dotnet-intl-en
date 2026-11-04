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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateWorkflowRunRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Application ID. For how to obtain it, see <a href="https://www.tencentcloud.com/document/product/1759/109469?from_cn_redirect=1#4eecb8c1-6ce4-45f5-8fa2-b269449d8efa">AppId</a></p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>Execution environment. 1: Development domain, 2: Production domain</p>
        /// </summary>
        [JsonProperty("Domain")]
        public ulong? Domain{ get; set; }

        /// <summary>
        /// <p>User input.</p>
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// <p>API parameter configuration</p>
        /// </summary>
        [JsonProperty("CustomVariableList")]
        public CustomVariable[] CustomVariableList{ get; set; }

        /// <summary>
        /// <p>uid</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamArrayObj(map, prefix + "CustomVariableList.", this.CustomVariableList);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

