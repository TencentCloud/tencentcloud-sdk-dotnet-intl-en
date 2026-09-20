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

    public class RoundPlayInfo : AbstractModel
    {
        
        /// <summary>
        /// Carousel playlist identifier.
        /// </summary>
        [JsonProperty("RoundPlayId")]
        public string RoundPlayId{ get; set; }

        /// <summary>
        /// Playback start time in ISO 8601 format. For details, see [ISO date format description](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#52).
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Carousel list.
        /// </summary>
        [JsonProperty("RoundPlaylist")]
        public RoundPlayListItemInfo[] RoundPlaylist{ get; set; }

        /// <summary>
        /// Carousel playbill name. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Carousel playlist description, with a length limit of 256 characters.
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// Playback status. Available values:
        /// <li>Enabled: running state;</li>
        /// <li>Disabled: stopped.</li>
        /// Default value: Enabled.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Playback mode. Optional values:
        /// <li>Loop: loop playback playlist;</li>
        /// <li>Linear: single play, stop playback after playlist finishes.</li>
        /// Default value: Loop.
        /// </summary>
        [JsonProperty("PlayBackMode")]
        public string PlayBackMode{ get; set; }

        /// <summary>
        /// Carousel playback address.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Creation time in ISO 8601 format. For details, see [ISO date format description](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#52).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Update time, format according to the ISO 8601 standard. For details, see [ISO date format description](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#52).
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Expiration time in ISO 8601 format. For details, see [ISO date format description](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#52). Playback of the playlist will stop after expiry. "9999-12-31T23:59:59+08:00" means it never expires.
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoundPlayId", this.RoundPlayId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamArrayObj(map, prefix + "RoundPlaylist.", this.RoundPlaylist);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PlayBackMode", this.PlayBackMode);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
        }
    }
}

