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
        /// <B>VOD [subapplication](https://intl.cloud.tencent.com/document/product/266/14574?from_cn_redirect=1) id.</b>.
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// The unique identifier of the playlist.
        /// </summary>
        [JsonProperty("RoundPlayId")]
        public string RoundPlayId{ get; set; }

        /// <summary>
        /// Operation type. Valid values: <li>Insert: Insert a program into the current playlist. The inserted program remains valid in subsequent loop banner processes.</li> <li>InsertTemporary: Temporarily insert a program into the current playlist. Temporarily inserted programs are only effective during this loop banner process.</li><li>Delete: Delete a program from the playback list. Cannot delete currently playing programs.</li>
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// Playlist program ID. <li>When Operation is Insert, this field is required, indicating the program list to be inserted is located after this program.</li> <li>When Operation is InsertTemporary, this field is optional. If left blank, the program will be inserted at the latest insertion point. If this field is filled and SegmentIndex is also provided, the program will be inserted behind the fragment corresponding to SegmentIndex of the program specified by ItemId; otherwise, it will be inserted after the program.</li> <li>When Operation is Delete, this field is required, indicating the program to be deleted. Cannot delete currently playing programs.</li>
        /// </summary>
        [JsonProperty("ItemId")]
        public string ItemId{ get; set; }

        /// <summary>
        /// Segment index of the M3U8 file shard. The first shard of the M3U8 file has a SegmentIndex of 0. This parameter is valid when Operation is InsertTemporary and ItemId has a value.
        /// </summary>
        [JsonProperty("SegmentIndex")]
        public long? SegmentIndex{ get; set; }

        /// <summary>
        /// Program list. required when operation is insert, inserttemporary, delete, indicating the list of programs to be operated on. the list length can be up to a maximum of 10.
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

