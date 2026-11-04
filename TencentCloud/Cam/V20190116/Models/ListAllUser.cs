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

    public class ListAllUser : AbstractModel
    {
        
        /// <summary>
        /// <p>Sub-account account ID.</p>
        /// </summary>
        [JsonProperty("Uin")]
        public long? Uin{ get; set; }

        /// <summary>
        /// <p>Username of sub-account.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Sub-account UID.</p>
        /// </summary>
        [JsonProperty("Uid")]
        public long? Uid{ get; set; }

        /// <summary>
        /// <p>Sub-account remark.</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>Whether or not the sub-account can log in to the console.</p>
        /// </summary>
        [JsonProperty("ConsoleLogin")]
        public long? ConsoleLogin{ get; set; }

        /// <summary>
        /// <p>Phone number.</p>
        /// </summary>
        [JsonProperty("PhoneNum")]
        public string PhoneNum{ get; set; }

        /// <summary>
        /// <p>Area code.</p>
        /// </summary>
        [JsonProperty("CountryCode")]
        public string CountryCode{ get; set; }

        /// <summary>
        /// <p>Mailbox.</p>
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// <p>Creation time.</p><p>Parameter format: YYYY-MM-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Account type</p><p>Enumeration values:</p><ul><li>Owner: root account</li><li>SubUser: sub-user</li><li>CICUser: CIC user</li><li>WechatCorpUser: WeCom sub-user</li><li>AgentIdentity: AgentIdentity user</li><li>Collaborator: collaborator</li><li>MessageReceiver: message recipient</li><li>Unknown: unknown</li></ul>
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ConsoleLogin", this.ConsoleLogin);
            this.SetParamSimple(map, prefix + "PhoneNum", this.PhoneNum);
            this.SetParamSimple(map, prefix + "CountryCode", this.CountryCode);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
        }
    }
}

