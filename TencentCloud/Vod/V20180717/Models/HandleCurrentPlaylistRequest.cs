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

    public class HandleCurrentPlaylistRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Carousel playlist unique identifier.
        /// </summary>
        [JsonProperty("RoundPlayId")]
        public string RoundPlayId{ get; set; }

        /// <summary>
        /// Operation type. Valid values: <li>Insert: insert a program into the current playback list. The inserted program remains valid in subsequent carousel processes.</li> <li>InsertTemporary: temporarily insert a program into the current playback list. Temporarily inserted programs are only effective during this carousel process.</li><li>Delete: delete a program from the playback list. Cannot delete currently playing programs.</li>
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// Playlist program ID. <li>When Operation is Insert, this field is required, indicating that the inserted program list is located after this program.</li> <li>When Operation is InsertTemporary, this field is optional. If not filled in, the program is inserted at the latest insertion point. If this field is filled in and SegmentIndex is also filled in, the program is inserted behind the SegmentIndex fragment of the program corresponding to ItemId. Otherwise, it is inserted after this program.</li> <li>When Operation is Delete, this field is required, indicating deletion of this program. Currently playing programs cannot be deleted.</li>
        /// </summary>
        [JsonProperty("ItemId")]
        public string ItemId{ get; set; }

        /// <summary>
        /// Index number of the M3U8 file segment. The SegmentIndex of the first segment in an M3U8 file is 0. This parameter is valid when Operation is InsertTemporary and ItemId has a value.
        /// </summary>
        [JsonProperty("SegmentIndex")]
        public long? SegmentIndex{ get; set; }

        /// <summary>
        /// Program list. Required when Operation is Insert, InsertTemporary, or Delete. Indicates the program list to operate. The maximum list length is 10.
        /// </summary>
        [JsonProperty("RoundPlaylist")]
        public RoundPlayListItemInfo[] RoundPlaylist{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "RoundPlayId", this.RoundPlayId);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "ItemId", this.ItemId);
            this.SetParamSimple(map, prefix + "SegmentIndex", this.SegmentIndex);
            this.SetParamArrayObj(map, prefix + "RoundPlaylist.", this.RoundPlaylist);
        }
    }
}

