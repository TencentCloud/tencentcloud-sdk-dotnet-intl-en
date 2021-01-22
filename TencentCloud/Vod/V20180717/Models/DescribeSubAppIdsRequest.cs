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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSubAppIdsRequest : AbstractModel
    {
        
        /// <summary>
        /// Subapplication name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Tag information. You can query the list of subapplications with specified tags.
        /// </summary>
        [JsonProperty("Tags")]
        public ResourceTag[] Tags{ get; set; }

        /// <summary>
        /// Page number offset from the beginning of paginated queries. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Maximum return results of pulling paginated queries. Default: 200; maximum: 200.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

