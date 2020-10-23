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

    public class SearchMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// Tag set, which matches any element in the set.
        /// <li>Tag length limit: 8 characters.</li>
        /// <li>Array length limit: 10.</li>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// Category ID set. The categories of the specified IDs and all subcategories in the set are matched.
        /// <li>Array length limit: 10.</li>
        /// </summary>
        [JsonProperty("ClassIds")]
        public long?[] ClassIds{ get; set; }

        /// <summary>
        /// [Stream ID](https://intl.cloud.tencent.com/document/product/267/5959?from_cn_redirect=1) set. Any element in the set can be matched.
        /// <li>Array length limit: 10.</li>
        /// </summary>
        [JsonProperty("StreamIds")]
        public string[] StreamIds{ get; set; }

        /// <summary>
        /// Unique ID of LVB recording file. Any element in the set can be matched.
        /// <li>Array length limit: 10.</li>
        /// </summary>
        [JsonProperty("Vids")]
        public string[] Vids{ get; set; }

        /// <summary>
        /// Media file source set. For valid values, please see [SourceType](https://intl.cloud.tencent.com/document/product/266/31773?from_cn_redirect=1#MediaSourceData).
        /// <li>Array length limit: 10.</li>
        /// </summary>
        [JsonProperty("SourceTypes")]
        public string[] SourceTypes{ get; set; }

        /// <summary>
        /// File type. Any element in the set can be matched.
        /// <li>Video: video file</li>
        /// <li>Audio: audio file</li>
        /// <li>Image: image file</li>
        /// </summary>
        [JsonProperty("Categories")]
        public string[] Categories{ get; set; }

        /// <summary>
        /// Matches files created within the time period.
        /// <li>Includes specified start and end points in time.</li>
        /// </summary>
        [JsonProperty("CreateTime")]
        public TimeRange CreateTime{ get; set; }

        /// <summary>
        /// File ID set. Any element in the set can be matched.
        /// <li>Array length limit: 10.</li>
        /// <li>ID length limit: 40 characters.</li>
        /// </summary>
        [JsonProperty("FileIds")]
        public string[] FileIds{ get; set; }

        /// <summary>
        /// Filename set. Filenames of media files are fuzzily matched. The higher the match rate, the higher-ranked the result.
        /// <li>Filename length limit: 40 characters.</li>
        /// <li>Array length limit: 10.</li>
        /// </summary>
        [JsonProperty("Names")]
        public string[] Names{ get; set; }

        /// <summary>
        /// Filename prefix, which matches the filenames of media files.
        /// <li>Filename prefix length limit: 20 characters.</li>
        /// <li>Array length limit: 10.</li>
        /// </summary>
        [JsonProperty("NamePrefixes")]
        public string[] NamePrefixes{ get; set; }

        /// <summary>
        /// File description set. Any element in the set can be matched.
        /// <li>Description length limit: 100 characters.</li>
        /// <li>Array length limit: 10.</li>
        /// </summary>
        [JsonProperty("Descriptions")]
        public string[] Descriptions{ get; set; }

        /// <summary>
        /// Sorting order.
        /// <li>Valid value of `Sort.Field`: CreateTime.</li>
        /// <li>If `Text`, `Names`, or `Descriptions` is not empty, the `Sort.Field` field will not take effect, and the search results will be sorted by match rate.</li>
        /// </summary>
        [JsonProperty("Sort")]
        public SortBy Sort{ get; set; }

        /// <summary>
        /// <div id="p_offset">Start offset of a paged return. Default value: 0. Entries from No. "Offset" to No. "Offset + Limit - 1" will be returned.
        /// <li>Value range: "Offset + Limit" cannot be more than 5,000. (For more information, please see <a href="#maxResultsDesc">Limit on the Number of Results Returned by API</a>)</li></div>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <div id="p_limit">Number of entries returned by a paged query. Default value: 10. Entries from No. "Offset" to No. "Offset + Limit - 1" will be returned.
        /// <li>Value range: "Offset + Limit" cannot be more than 5,000. (For more information, please see <a href="#maxResultsDesc">Limit on the Number of Results Returned by API</a>)</li></div>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Specifies information entry that needs to be returned for all media files. Multiple entries can be specified simultaneously. N starts from 0. If this field is left empty, all information entries will be returned by default. Valid values:
        /// <li>basicInfo (basic video information).</li>
        /// <li>metaData (video metadata).</li>
        /// <li>transcodeInfo (result information of video transcoding).</li>
        /// <li>animatedGraphicsInfo (result information of animated image generating task).</li>
        /// <li>imageSpriteInfo (image sprite information).</li>
        /// <li>snapshotByTimeOffsetInfo (point-in-time screenshot information).</li>
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
        /// (This is not recommended. `StreamIds` should be used instead)
        /// [Stream ID](https://intl.cloud.tencent.com/document/product/267/5959?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// (This is not recommended. `Vids` should be used instead)
        /// Unique ID of LVB recording file.
        /// </summary>
        [JsonProperty("Vid")]
        public string Vid{ get; set; }

        /// <summary>
        /// (This is not recommended. `Names`, `NamePrefixes`, or `Descriptions` should be used instead)
        /// Search text, which fuzzily matches the media file name or description. The more matching items and the higher the match rate, the higher-ranked the result. It can contain up to 64 characters.
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// (This is not recommended. `CreateTime` should be used instead)
        /// Start time in the creation time range.
        /// <li>After or at the start time.</li>
        /// <li>If `CreateTime.After` also exists, it will be used first.</li>
        /// <li>In ISO 8601 format. For more information, please see [ISO Date Format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I).</li>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// (This is not recommended. `CreateTime` should be used instead)
        /// End time in the creation time range.
        /// <li>Before the end time.</li>
        /// <li>If `CreateTime.Before` also exists, it will be used first.</li>
        /// <li>In ISO 8601 format. For more information, please see [ISO Date Format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I).</li>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// (This is not recommended. `SourceTypes` should be used instead)
        /// Media file source. For valid values, please see [SourceType](https://intl.cloud.tencent.com/document/product/266/31773?from_cn_redirect=1#MediaSourceData).
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "ClassIds.", this.ClassIds);
            this.SetParamArraySimple(map, prefix + "StreamIds.", this.StreamIds);
            this.SetParamArraySimple(map, prefix + "Vids.", this.Vids);
            this.SetParamArraySimple(map, prefix + "SourceTypes.", this.SourceTypes);
            this.SetParamArraySimple(map, prefix + "Categories.", this.Categories);
            this.SetParamObj(map, prefix + "CreateTime.", this.CreateTime);
            this.SetParamArraySimple(map, prefix + "FileIds.", this.FileIds);
            this.SetParamArraySimple(map, prefix + "Names.", this.Names);
            this.SetParamArraySimple(map, prefix + "NamePrefixes.", this.NamePrefixes);
            this.SetParamArraySimple(map, prefix + "Descriptions.", this.Descriptions);
            this.SetParamObj(map, prefix + "Sort.", this.Sort);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
            this.SetParamSimple(map, prefix + "Vid", this.Vid);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
        }
    }
}

