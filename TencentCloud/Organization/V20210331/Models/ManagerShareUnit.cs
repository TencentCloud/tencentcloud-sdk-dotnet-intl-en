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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManagerShareUnit : AbstractModel
    {
        
        /// <summary>
        /// <p>Shared unit ID.</p>.
        /// </summary>
        [JsonProperty("UnitId")]
        public string UnitId{ get; set; }

        /// <summary>
        /// <P>Shared unit name.</p>.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Shared unit administrator Uin.</p>.
        /// </summary>
        [JsonProperty("Uin")]
        public long? Uin{ get; set; }

        /// <summary>
        /// <p>Shared unit administrator OwnerUin.</p>.
        /// </summary>
        [JsonProperty("OwnerUin")]
        public long? OwnerUin{ get; set; }

        /// <summary>
        /// <P>Shared unit region.</p>.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <P>Description.</P>.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <P>Creation time.</p>.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <P>The number of resources in a shared unit.</p>.
        /// </summary>
        [JsonProperty("ShareResourceNum")]
        public long? ShareResourceNum{ get; set; }

        /// <summary>
        /// <P>The number of members in a shared unit.</p>.
        /// </summary>
        [JsonProperty("ShareMemberNum")]
        public long? ShareMemberNum{ get; set; }

        /// <summary>
        /// <P>Sharing scope. valid values: 1: only sharing within a group organization is allowed; 2: sharing with any account is allowed.</p>.
        /// </summary>
        [JsonProperty("ShareScope")]
        public ulong? ShareScope{ get; set; }

        /// <summary>
        /// <P>The number of departments in a shared unit.</p>.
        /// </summary>
        [JsonProperty("ShareNodeNum")]
        public long? ShareNodeNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UnitId", this.UnitId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ShareResourceNum", this.ShareResourceNum);
            this.SetParamSimple(map, prefix + "ShareMemberNum", this.ShareMemberNum);
            this.SetParamSimple(map, prefix + "ShareScope", this.ShareScope);
            this.SetParamSimple(map, prefix + "ShareNodeNum", this.ShareNodeNum);
        }
    }
}

