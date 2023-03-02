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

    public class CreateRoundPlayRequest : AbstractModel
    {
        
        /// <summary>
        /// The playback start time, in [ISO 8601 date format](https://intl.cloud.tencent.com/document/product/266/11732?lang=en&pg=).
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// The files on the list.
        /// <li>Array length limit: 100.</li>
        /// </summary>
        [JsonProperty("RoundPlaylist")]
        public RoundPlayListItemInfo[] RoundPlaylist{ get; set; }

        /// <summary>
        /// <b>The VOD [subapplication](https://intl.cloud.tencent.com/document/product/266/14574?from_cn_redirect=1) ID. If you need to access a resource in a subapplication, set this parameter to the subapplication ID; otherwise, leave it empty.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// The playlist name (not longer than 64 characters).
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// The playlist description (not longer than 256 characters).
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamArrayObj(map, prefix + "RoundPlaylist.", this.RoundPlaylist);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
        }
    }
}

