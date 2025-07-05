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

    public class ShareUnitResource : AbstractModel
    {
        
        /// <summary>
        /// Shared resource ID.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Shared resource type.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Creation time.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Product resource ID.
        /// </summary>
        [JsonProperty("ProductResourceId")]
        public string ProductResourceId{ get; set; }

        /// <summary>
        /// The number of members in a shared unit.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SharedMemberNum")]
        public ulong? SharedMemberNum{ get; set; }

        /// <summary>
        /// The number of shared unit members in use.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SharedMemberUseNum")]
        public ulong? SharedMemberUseNum{ get; set; }

        /// <summary>
        /// Shared administrator OwnerUin.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ShareManagerUin")]
        public long? ShareManagerUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ProductResourceId", this.ProductResourceId);
            this.SetParamSimple(map, prefix + "SharedMemberNum", this.SharedMemberNum);
            this.SetParamSimple(map, prefix + "SharedMemberUseNum", this.SharedMemberUseNum);
            this.SetParamSimple(map, prefix + "ShareManagerUin", this.ShareManagerUin);
        }
    }
}

