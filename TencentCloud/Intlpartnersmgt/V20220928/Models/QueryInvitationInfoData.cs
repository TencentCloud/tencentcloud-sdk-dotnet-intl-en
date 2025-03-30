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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryInvitationInfoData : AbstractModel
    {
        
        /// <summary>
        /// Invitation link token.
        /// </summary>
        [JsonProperty("InvitationToken")]
        public string InvitationToken{ get; set; }

        /// <summary>
        /// Creation time of the invitation link.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Invite link status.
        /// 1: Unused.
        /// 2: Used.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Indicates the usage time of the invitation link.
        /// </summary>
        [JsonProperty("UseTime")]
        public string UseTime{ get; set; }

        /// <summary>
        /// Customer uin.
        /// </summary>
        [JsonProperty("ClientUin")]
        public long? ClientUin{ get; set; }

        /// <summary>
        /// Customer mailbox.
        /// </summary>
        [JsonProperty("ClientMail")]
        public string ClientMail{ get; set; }

        /// <summary>
        /// Customer type.
        /// 1: Second-Level reseller.
        /// 2: Sub-Customer.
        /// </summary>
        [JsonProperty("ClientType")]
        public long? ClientType{ get; set; }

        /// <summary>
        /// The binding time of the customer.
        /// </summary>
        [JsonProperty("BindTime")]
        public string BindTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvitationToken", this.InvitationToken);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UseTime", this.UseTime);
            this.SetParamSimple(map, prefix + "ClientUin", this.ClientUin);
            this.SetParamSimple(map, prefix + "ClientMail", this.ClientMail);
            this.SetParamSimple(map, prefix + "ClientType", this.ClientType);
            this.SetParamSimple(map, prefix + "BindTime", this.BindTime);
        }
    }
}

