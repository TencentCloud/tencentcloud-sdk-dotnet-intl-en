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
        /// Specifies information entry that needs to be returned by all media files. Multiple entries can be specified simultaneously. N starts from 0. If this field is left empty, all information entries will be returned by default. Valid values:
        /// <li>basicInfo (basic video information).</li>
        /// <li>metaData (video metadata).</li>
        /// <li>transcodeInfo (result information of video transcoding).</li>
        /// <li>animatedGraphicsInfo (result information of animated image generating task).</li>
        /// <li>imageSpriteInfo (image sprite information).</li>
        /// <li>snapshotByTimeOffsetInfo (time point screenshot information).</li>
        /// <li>sampleSnapshotInfo (sampled screenshot information).</li>
        /// <li>keyFrameDescInfo (timestamp information).</li>
        /// <li>adaptiveDynamicStreamingInfo (information of adaptive bitrate streaming).</li>
        /// <li>miniProgramReviewInfo (WeChat Mini Program audit information).</li>
        /// </summary>
        [JsonProperty("Filters")]
        public string[] Filters{ get; set; }

        /// <summary>
        /// [Subapplication](https://intl.cloud.tencent.com/document/product/266/14574?from_cn_redirect=1) ID in VOD. If you need to access a resource in a subapplication, enter the subapplication ID in this field; otherwise, leave it empty.
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "FileIds.", this.FileIds);
            this.SetParamArraySimple(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

