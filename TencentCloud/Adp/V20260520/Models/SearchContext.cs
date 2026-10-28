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

    public class SearchContext : AbstractModel
    {
        
        /// <summary>
        /// <p>Request source<table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>CALL_SOURCE_UNSPECIFIED</td><td>0</td><td></td></tr><tr><td>CALL_SOURCE_RAG</td><td>1</td><td>Standard mode</td></tr><tr><td>CALL_SOURCE_WORKFLOW</td><td>2</td><td>Workflow</td></tr><tr><td>CALL_SOURCE_PLUGIN</td><td>3</td><td>Plug-in</td></tr><tr><td>CALL_SOURCE_OPENCLAW</td><td>4</td><td>openclaw</td></tr><tr><td>CALL_SOURCE_RECALL_TEST</td><td>5</td><td>Recall test</td></tr><tr><td>CALL_SOURCE_RECALL_TEST_DIFF</td><td>6</td><td>Recall test in comparison scenarios also needs to trigger the retrieval interface. The difference is that in this case, the frontend does not need to update the latest configuration. Because when comparing 1, 2, and 3, the final saved one may be 2.</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("CallSource")]
        public long? CallSource{ get; set; }

        /// <summary>
        /// <p>adp DOMAIN: 1=development DOMAIN, 2=production DOMAIN<table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>adp_DOMAIN_UNSPECIFIED</td><td>0</td><td>not specified</td></tr><tr><td>adp_DOMAIN_DEV</td><td>1</td><td>development DOMAIN</td></tr><tr><td>adp_DOMAIN_PROD</td><td>2</td><td>production DOMAIN</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("Domain")]
        public long? Domain{ get; set; }

        /// <summary>
        /// <p>Visitor ID</p>
        /// </summary>
        [JsonProperty("VisitorId")]
        public string VisitorId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallSource", this.CallSource);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "VisitorId", this.VisitorId);
        }
    }
}

