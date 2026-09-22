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

    public class CreateRoundPlayRequest : AbstractModel
    {
        
        /// <summary>
        /// Playback start time in ISO 8601 format. See [ISO date format description](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#52).
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Carousel list.
        /// <li>Array length limit: 100.</li>
        /// </summary>
        [JsonProperty("RoundPlaylist")]
        public RoundPlayListItemInfo[] RoundPlaylist{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate VOD services from December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications, whether in the default application or a newly created application.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

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
        /// Playback mode. Optional values:
        /// <li>Loop: loop playback playlist;</li>
        /// <li>Linear: single play, stop playback after playlist finishes.</li>
        /// Default value: Loop.
        /// </summary>
        [JsonProperty("PlayBackMode")]
        public string PlayBackMode{ get; set; }

        /// <summary>
        /// Unique identification ID of the playlist. Length limit: 64 characters. Only allow uppercase and lowercase letters (a-zA-Z), digits (0-9), and hyphens (-). If a playlist with the same RoundPlayId exists, the InvalidParameterValue.RoundPlayAlreadyExists error is returned. The default value is empty, which means it is assigned by the system.
        /// </summary>
        [JsonProperty("RoundPlayId")]
        public string RoundPlayId{ get; set; }

        /// <summary>
        /// Expiration time in ISO 8601 format. For details, see [ISO date format description](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#52). The playlist will stop playback after expiry. "9999-12-31T23:59:59+08:00" means never expire. Default value: 9999-12-31T23:59:59+08:00.
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }


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
            this.SetParamSimple(map, prefix + "PlayBackMode", this.PlayBackMode);
            this.SetParamSimple(map, prefix + "RoundPlayId", this.RoundPlayId);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
        }
    }
}

