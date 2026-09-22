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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AigcTextDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>Entries per page</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// <p>scroll_token returned in the previous page response, used for turning to the next page</p>
        /// </summary>
        [JsonProperty("ScrollToken")]
        public string ScrollToken{ get; set; }

        /// <summary>
        /// <p>Detailed data for text generation</p>
        /// </summary>
        [JsonProperty("Data")]
        public AigcTextDetailData[] Data{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "ScrollToken", this.ScrollToken);
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
        }
    }
}

