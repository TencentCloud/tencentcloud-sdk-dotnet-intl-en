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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAndSendClientInvitationMailRequest : AbstractModel
    {
        
        /// <summary>
        /// Email address that receives the customer invitation link.
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// Invite a role.
        /// Note: if no value is passed, it defaults to the sub - customer.
        /// Client: customer.
        /// SubAgent: second-level reseller.
        /// </summary>
        [JsonProperty("InvitationRole")]
        public string InvitationRole{ get; set; }

        /// <summary>
        /// Specifies the application material.
        /// Note: this field takes effect only in the scenario of inviting a second-level reseller.
        /// </summary>
        [JsonProperty("MaterialUrl")]
        public string MaterialUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "InvitationRole", this.InvitationRole);
            this.SetParamSimple(map, prefix + "MaterialUrl", this.MaterialUrl);
        }
    }
}

