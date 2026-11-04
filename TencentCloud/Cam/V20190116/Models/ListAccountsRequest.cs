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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListAccountsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Number of returned results. If the returned results are truncated after reaching the MaxItems limit, the response parameter IsTruncated will be equal to true.</p><p>Value range: [1, 100]</p>
        /// </summary>
        [JsonProperty("MaxItems")]
        public long? MaxItems{ get; set; }

        /// <summary>
        /// <p>When the return result of the request is truncated, you can use Marker to get the content after the current truncation position.</p>
        /// </summary>
        [JsonProperty("Marker")]
        public string Marker{ get; set; }

        /// <summary>
        /// <p>Type of user</p><p>Enumeration values:</p><ul><li>Owner: root account</li><li>SubUser: ordinary sub-user</li><li>CICUser: CIC sub-user</li><li>WechatCorpUser: WeCom sub-user</li><li>AgentIdentity: AgentIdentity sub-user</li><li>Collaborator: collaborator</li><li>MessageReceiver: message recipient</li></ul>
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxItems", this.MaxItems);
            this.SetParamSimple(map, prefix + "Marker", this.Marker);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
        }
    }
}

