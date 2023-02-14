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

    public class CptListData : AbstractModel
    {
        
        /// <summary>
        /// The CPT ID.
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// The name of the claim protocol type (CPT).
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// The network ID.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// The group ID.
        /// </summary>
        [JsonProperty("GroupId")]
        public ulong? GroupId{ get; set; }

        /// <summary>
        /// The service ID.
        /// </summary>
        [JsonProperty("ServiceId")]
        public ulong? ServiceId{ get; set; }

        /// <summary>
        /// The application ID of the contract.
        /// </summary>
        [JsonProperty("ContractAppId")]
        public ulong? ContractAppId{ get; set; }

        /// <summary>
        /// The claim protocol type (CPT) ID.
        /// </summary>
        [JsonProperty("CptId")]
        public ulong? CptId{ get; set; }

        /// <summary>
        /// The type. `1`: System CPTs; `2`: Authorization CPTs; `3`: General CPTs
        /// </summary>
        [JsonProperty("CptType")]
        public ulong? CptType{ get; set; }

        /// <summary>
        /// The description of the claim protocol type (CPT).
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// The JSON file of the claim protocol type (CPT).
        /// </summary>
        [JsonProperty("CptJson")]
        public string CptJson{ get; set; }

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
        /// The DID of the creator.
        /// </summary>
        [JsonProperty("CreatorDid")]
        public string CreatorDid{ get; set; }

        /// <summary>
        /// The application name.
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ContractAppId", this.ContractAppId);
            this.SetParamSimple(map, prefix + "CptId", this.CptId);
            this.SetParamSimple(map, prefix + "CptType", this.CptType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CptJson", this.CptJson);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CreatorDid", this.CreatorDid);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
        }
    }
}

