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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InvitationEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>The ID of the invitee</p>
        /// </summary>
        [JsonProperty("InviteeUserId")]
        public string InviteeUserId{ get; set; }

        /// <summary>
        /// <p>The ID of the promotion</p>
        /// </summary>
        [JsonProperty("PromotionId")]
        public string PromotionId{ get; set; }

        /// <summary>
        /// <p>The name of the promotion</p>
        /// </summary>
        [JsonProperty("PromotionName")]
        public string PromotionName{ get; set; }

        /// <summary>
        /// <p>The description of the promotion</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>The phone number of the invitee</p><p>Parameter format: Complies with the E.164 standard format, which includes "+", region code, and number.</p>
        /// </summary>
        [JsonProperty("InviteePhone")]
        public string InviteePhone{ get; set; }

        /// <summary>
        /// <p>The code that the inviter sent to the user</p>
        /// </summary>
        [JsonProperty("InvitationCode")]
        public string InvitationCode{ get; set; }

        /// <summary>
        /// <p>The url that the inviter sent to the user</p>
        /// </summary>
        [JsonProperty("InvitationUrl")]
        public string InvitationUrl{ get; set; }

        /// <summary>
        /// <p>The channel that inviter used to invite the user </p>
        /// </summary>
        [JsonProperty("InvitationChannel")]
        public string InvitationChannel{ get; set; }

        /// <summary>
        /// <p>The custom parameters agreed with RCE. An array of objects in K:V format. e.g.[{"Key": "ApproverName", "Value": "bob"},{"Key":"ApproverPhone","Value": "+86131****5678"}]</p>
        /// </summary>
        [JsonProperty("Cust")]
        public Cust[] Cust{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InviteeUserId", this.InviteeUserId);
            this.SetParamSimple(map, prefix + "PromotionId", this.PromotionId);
            this.SetParamSimple(map, prefix + "PromotionName", this.PromotionName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "InviteePhone", this.InviteePhone);
            this.SetParamSimple(map, prefix + "InvitationCode", this.InvitationCode);
            this.SetParamSimple(map, prefix + "InvitationUrl", this.InvitationUrl);
            this.SetParamSimple(map, prefix + "InvitationChannel", this.InvitationChannel);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

