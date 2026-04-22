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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeApplicationMNPInfoResp : AbstractModel
    {
        
        /// <summary>
        /// Mini program or mini game appid
        /// </summary>
        [JsonProperty("MNPId")]
        public string MNPId{ get; set; }

        /// <summary>
        /// Mini program or mini game icon
        /// </summary>
        [JsonProperty("MNPIcon")]
        public string MNPIcon{ get; set; }

        /// <summary>
        /// Mini program or mini game name
        /// </summary>
        [JsonProperty("MNPName")]
        public string MNPName{ get; set; }

        /// <summary>
        /// Mini program or mini game information
        /// </summary>
        [JsonProperty("MNPIntro")]
        public string MNPIntro{ get; set; }

        /// <summary>
        /// Creator
        /// </summary>
        [JsonProperty("CreateUser")]
        public string CreateUser{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Modifier
        /// </summary>
        [JsonProperty("UpdateUser")]
        public string UpdateUser{ get; set; }

        /// <summary>
        /// Update time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Online status. 0 Not available; 1 Available
        /// </summary>
        [JsonProperty("OnlineStatus")]
        public long? OnlineStatus{ get; set; }

        /// <summary>
        /// Engine type. 0 Mini program; 1 Mini game
        /// </summary>
        [JsonProperty("EngineType")]
        public long? EngineType{ get; set; }

        /// <summary>
        /// Category information
        /// </summary>
        [JsonProperty("CategoryList")]
        public CategoryInfo[] CategoryList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MNPId", this.MNPId);
            this.SetParamSimple(map, prefix + "MNPIcon", this.MNPIcon);
            this.SetParamSimple(map, prefix + "MNPName", this.MNPName);
            this.SetParamSimple(map, prefix + "MNPIntro", this.MNPIntro);
            this.SetParamSimple(map, prefix + "CreateUser", this.CreateUser);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateUser", this.UpdateUser);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "OnlineStatus", this.OnlineStatus);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamArrayObj(map, prefix + "CategoryList.", this.CategoryList);
        }
    }
}

