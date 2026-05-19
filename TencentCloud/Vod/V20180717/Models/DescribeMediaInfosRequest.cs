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

    public class DescribeMediaInfosRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Media file ID list. N starts from 0 with a maximum of 19.</p>
        /// </summary>
        [JsonProperty("FileIds")]
        public string[] FileIds{ get; set; }

        /// <summary>
        /// <p><b>VOD <a href="https://www.tencentcloud.com/document/product/266/33987">application</a> ID. Customers who activate on-demand services from December 25, 2023 must fill this field with the application ID when accessing resources in on-demand applications (whether the default application or a newly created application).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Information to be returned for all specified media files. Multiple information can be specified simultaneously, with N starting from 0. If this field is not filled in, default return all information. Options:</p><li>basicInfo (video basic information).</li><li>metaData (video metadata).</li><li>transcodeInfo (video transcoding result information).</li><li>animatedGraphicsInfo (video motion graphic result information).</li><li>imageSpriteInfo (video thumbnail information).</li><li>snapshotByTimeOffsetInfo (video screenshot by specified time point).</li><li>sampleSnapshotInfo (sampling screenshot information).</li><li>keyFrameDescInfo (Dotting Information).</li><li>adaptiveDynamicStreamingInfo (Adaptive Bitrate Streaming information).</li><li>miniProgramReviewInfo (miniProgramReviewInfo).</li><li>subtitleInfo (subtitle information).</li><li>reviewInfo (review information).</li><li>mpsAiMediaInfo (Intelligent Media Assets information).</li>
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

