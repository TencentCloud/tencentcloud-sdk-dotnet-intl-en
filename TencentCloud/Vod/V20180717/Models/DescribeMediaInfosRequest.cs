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

    public class DescribeMediaInfosRequest : AbstractModel
    {
        
        /// <summary>
        /// List of media file IDs. N starts from 0 and can be up to 19.
        /// </summary>
        [JsonProperty("FileIds")]
        public string[] FileIds{ get; set; }

        /// <summary>
        /// <b>The VOD [application](https://intl.cloud.tencent.com/document/product/266/14574) ID. For customers who activate VOD service from December 25, 2023, if they want to access resources in a VOD application (whether it's the default application or a newly created one), they must fill in this field with the application ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// The types of information to return. You can specify multiple information types. `N` starts from 0. If you do not specify this parameter, all information will be returned. The supported information types are as follows:
        /// <li>`basicInfo` (basic information)</li>
        /// <li>`metaData` (video metadata)</li>
        /// <li>`transcodeInfo` (transcoding information)</li>
        /// <li>`animatedGraphicsInfo` (animated image information)</li>
        /// <li>`imageSpriteInfo` (image sprite information)</li>
        /// <li>`snapshotByTimeOffsetInfo` (time point screenshot information)</li>
        /// <li>`sampleSnapshotInfo` (sampled screenshot information)</li>
        /// <li>`keyFrameDescInfo` (timestamp information)</li>
        /// <li>`adaptiveDynamicStreamingInfo` (adaptive bitrate information)</li>
        /// <li>`miniProgramReviewInfo` (WeChat Mini Program moderation information)</li>
        /// <li>`subtitleInfo` (subtitle information)</li>
        /// <li>`reviewInfo` (moderation information)</li>
        /// </summary>
        [JsonProperty("Filters")]
        public string[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "FileIds.", this.FileIds);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamArraySimple(map, prefix + "Filters.", this.Filters);
        }
    }
}

