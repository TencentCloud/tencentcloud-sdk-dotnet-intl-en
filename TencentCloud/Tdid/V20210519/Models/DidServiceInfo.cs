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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DidServiceInfo : AbstractModel
    {
        
        /// <summary>
        /// The DID service ID.
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// The application ID.
        /// </summary>
        [JsonProperty("Appid")]
        public ulong? Appid{ get; set; }

        /// <summary>
        /// The account ID.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// The consortium ID.
        /// </summary>
        [JsonProperty("ConsortiumId")]
        public long? ConsortiumId{ get; set; }

        /// <summary>
        /// The consortium name.
        /// </summary>
        [JsonProperty("ConsortiumName")]
        public string ConsortiumName{ get; set; }

        /// <summary>
        /// The network ID.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// The group ID.
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// The chain ID.
        /// </summary>
        [JsonProperty("ChainId")]
        public string ChainId{ get; set; }

        /// <summary>
        /// Whether you are the owner of the consortium. `1`: Yes; `0`: No.
        /// </summary>
        [JsonProperty("RoleType")]
        public ulong? RoleType{ get; set; }

        /// <summary>
        /// The organization DID.
        /// </summary>
        [JsonProperty("AgencyDid")]
        public string AgencyDid{ get; set; }

        /// <summary>
        /// The organization name.
        /// </summary>
        [JsonProperty("CreateOrg")]
        public string CreateOrg{ get; set; }

        /// <summary>
        /// The endpoint.
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// The creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// The last updated time.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// The group name.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "ConsortiumId", this.ConsortiumId);
            this.SetParamSimple(map, prefix + "ConsortiumName", this.ConsortiumName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "ChainId", this.ChainId);
            this.SetParamSimple(map, prefix + "RoleType", this.RoleType);
            this.SetParamSimple(map, prefix + "AgencyDid", this.AgencyDid);
            this.SetParamSimple(map, prefix + "CreateOrg", this.CreateOrg);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
        }
    }
}

