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

namespace TencentCloud.Organization.V20181225.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrgInvitation : AbstractModel
    {
        
        /// <summary>
        /// Invitation ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// UIN of the invitee
        /// </summary>
        [JsonProperty("Uin")]
        public ulong? Uin{ get; set; }

        /// <summary>
        /// Creator UIN
        /// </summary>
        [JsonProperty("HostUin")]
        public ulong? HostUin{ get; set; }

        /// <summary>
        /// Creator's name
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// Creator's email address
        /// </summary>
        [JsonProperty("HostMail")]
        public string HostMail{ get; set; }

        /// <summary>
        /// Invitation status. `-1`: expired; `0`: normal; `1`: accepted; `2`: invalid; `3`: cancelled
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Organization type
        /// </summary>
        [JsonProperty("OrgType")]
        public ulong? OrgType{ get; set; }

        /// <summary>
        /// Time of invitation
        /// </summary>
        [JsonProperty("InviteTime")]
        public string InviteTime{ get; set; }

        /// <summary>
        /// Expiration time
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "HostUin", this.HostUin);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostMail", this.HostMail);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "OrgType", this.OrgType);
            this.SetParamSimple(map, prefix + "InviteTime", this.InviteTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
        }
    }
}

