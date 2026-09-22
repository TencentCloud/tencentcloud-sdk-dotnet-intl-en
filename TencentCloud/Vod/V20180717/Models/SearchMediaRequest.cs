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

    public class SearchMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate on-demand services from December 25, 2023, to access resources in on-demand applications (whether the default application or a newly created application), this field must be filled with the app ID.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>File ID collection, match any element in the collection.</p><li>Array length limit: 10.</li><li>Single ID length limit: 40 characters.</li>
        /// </summary>
        [JsonProperty("FileIds")]
        public string[] FileIds{ get; set; }

        /// <summary>
        /// <p>File name collection, fuzzy match media file names. The higher the matching degree, the higher priority in sorting.</p><li>Single file name length limit: 100 characters.</li><li>Array length limit: 10.</li>
        /// </summary>
        [JsonProperty("Names")]
        public string[] Names{ get; set; }

        /// <summary>
        /// <p>Filename prefix, which is used to prefix match media file names.</p><li>Single file name prefix length limit: 100 characters.</li><li>Array length limit: 10.</li>
        /// </summary>
        [JsonProperty("NamePrefixes")]
        public string[] NamePrefixes{ get; set; }

        /// <summary>
        /// <p>File description set for fuzzy matching media file descriptions. The higher the matching degree, the higher priority in sorting.</p><li>Single description length limit: 100 characters.</li><li>Array length limit: 10.</li>
        /// </summary>
        [JsonProperty("Descriptions")]
        public string[] Descriptions{ get; set; }

        /// <summary>
        /// <p>Category ID collection, match the category with the specified ID in the collection and all its subclasses.</p><li>Array length limit: 10.</li>
        /// </summary>
        [JsonProperty("ClassIds")]
        public long?[] ClassIds{ get; set; }

        /// <summary>
        /// <p>Tag set, match any element in the collection.</p><li>Single tag length limit: 32 characters.</li><li>Array length limit: 16.</li>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// <p>File type. Match any element in the collection:</p><li>Video: video file</li><li>Audio: audio file</li><li>Image: image file</li>
        /// </summary>
        [JsonProperty("Categories")]
        public string[] Categories{ get; set; }

        /// <summary>
        /// <p>Media file source collection. For source value reference, see <a href="https://www.tencentcloud.com/document/product/266/31773?from_cn_redirect=1#MediaSourceData">SourceType</a>.</p><li>Array length limit: 10.</li>
        /// </summary>
        [JsonProperty("SourceTypes")]
        public string[] SourceTypes{ get; set; }

        /// <summary>
        /// <p>Push stream live code collection. Match any element in the collection.</p><li>Array length limit: 10.</li>
        /// </summary>
        [JsonProperty("StreamIds")]
        public string[] StreamIds{ get; set; }

        /// <summary>
        /// <p>Files whose creation time matches this time period.</p><li>Includes the specified start and end points in time.</li>
        /// </summary>
        [JsonProperty("CreateTime")]
        public TimeRange CreateTime{ get; set; }

        /// <summary>
        /// <p>Files whose expiration time falls within this period cannot be retrieved.</p><li>Includes the specified start and end points in time.</li>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public TimeRange ExpireTime{ get; set; }

        /// <summary>
        /// <p>Media file storage region, for example, ap-chongqing. See <a href="https://www.tencentcloud.com/document/product/266/9760?from_cn_redirect=1#.E5.B7.B2.E6.94.AF.E6.8C.81.E5.9C.B0.E5.9F.9F.E5.88.97.E8.A1.A8">region list</a>.</p><li>Single storage region length limit: 20 characters.</li><li>Array length limit: 20.</li>
        /// </summary>
        [JsonProperty("StorageRegions")]
        public string[] StorageRegions{ get; set; }

        /// <summary>
        /// <p>Storage type array. Optional values:</p><li> STANDARD: standard storage.</li><li> STANDARD_IA: infrequent storage.</li><li> ARCHIVE: archive storage.</li><li> DEEP_ARCHIVE: deep archive storage.</li>
        /// </summary>
        [JsonProperty("StorageClasses")]
        public string[] StorageClasses{ get; set; }

        /// <summary>
        /// <p>Media file packaging format collection, match any element in the collection.</p><li>Array length limit: 10.</li>
        /// </summary>
        [JsonProperty("MediaTypes")]
        public string[] MediaTypes{ get; set; }

        /// <summary>
        /// <p>Media file status. Match any element in the collection.</p><li> Normal: normal;</li><li> SystemForbidden: Platform Ban;</li><li> Forbidden: proactive ban.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string[] Status{ get; set; }

        /// <summary>
        /// <p>Media file review result, match any element in the collection.</p><li> pass: pass review;</li><li> review: suspected violation, suggest re-examination;</li><li> block: confirmed violation, suggest banning;</li><li> notModerated: not moderated.</li>
        /// </summary>
        [JsonProperty("ReviewResults")]
        public string[] ReviewResults{ get; set; }

        /// <summary>
        /// <p>TRTC application ID collection. Match any element in the collection.</p><li>Array length limit: 10.</li>
        /// </summary>
        [JsonProperty("TrtcSdkAppIds")]
        public ulong?[] TrtcSdkAppIds{ get; set; }

        /// <summary>
        /// <p>TRTC room ID collection. Match any element in the collection.</p><li>Single room ID length limit: 64 characters;</li><li>Array length limit: 10.</li>
        /// </summary>
        [JsonProperty("TrtcRoomIds")]
        public string[] TrtcRoomIds{ get; set; }

        /// <summary>
        /// <p>Information to be returned for all specified media files. Multiple information can be specified simultaneously. N starts incrementing from 0. If this field is not filled in, all information is returned by default. Options: </p><li>basicInfo (video basic information). </li><li>metaData (video metadata). </li><li>transcodeInfo (video transcoding result information). </li><li>animatedGraphicsInfo (video motion graphic result information). </li><li>imageSpriteInfo (video thumbnail information). </li><li>snapshotByTimeOffsetInfo (video screenshot by specified time point). </li><li>sampleSnapshotInfo (sampling screenshot information). </li><li>keyFrameDescInfo (Dotting Information). </li><li>adaptiveDynamicStreamingInfo (Adaptive Bitrate Streaming information). </li><li>miniProgramReviewInfo (miniProgramReviewInfo). </li>
        /// </summary>
        [JsonProperty("Filters")]
        public string[] Filters{ get; set; }

        /// <summary>
        /// <p>Sorting method.</p><li>Sort.Field optional CreateTime.</li><li>When Text, Names, or Descriptions is not empty, the Sort.Field field is invalid, and search results will be sorted by relevance.</li>
        /// </summary>
        [JsonProperty("Sort")]
        public SortBy Sort{ get; set; }

        /// <summary>
        /// <div id="p_offset">Starting offset amount for pagination return. Default value: 0. It will return entries from Offset to Offset+Limit-1. <li>Value range: Offset + Limit no more than 5000. (See: <a href="#maxResultsDesc">API return result count limit</a>)</li></div>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <div id="p_limit">Number of records returned in pages. Default value: 10. Records from Offset to Offset+Limit-1 will be returned.<li>Value range: Offset + Limit no more than 5000. (See <a href="#maxResultsDesc">API return result count limit</a>.)</li></div>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>(Not recommended: use Names, NamePrefixes, or Descriptions instead)<br>Search text. Fuzzy match media file name or description information. More matches and higher matching degree result in higher priority in sorting. Length limited to 64 characters.</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>(Not recommended: use SourceTypes instead)<br>Media file source. For source value reference, see <a href="https://www.tencentcloud.com/document/product/266/31773?from_cn_redirect=1#MediaSourceData">SourceType</a>.</p>
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// <p>(Not recommended: use StreamIds instead)<br>Push stream live code.</p>
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// <p>(Not recommended: use CreateTime instead)<br>Start time of the creation time.</p><li>Greater than or equal to start time.</li><li>When CreateTime.After also exists, CreateTime.After will be used first.</li><li>Format according to the ISO 8601 standard. For details, see [ISO date format description](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).</li>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>(Not recommended: use CreateTime instead)<br>End time of the creation time.</p><li>Less than end time.</li><li>When CreateTime.Before also exists, CreateTime.Before will be used first.</li><li>Format according to the ISO 8601 standard. For details, see [ISO date format description](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).</li>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>This field is invalid.</p>
        /// </summary>
        [JsonProperty("Vids")]
        public string[] Vids{ get; set; }

        /// <summary>
        /// <p>This field is invalid.</p>
        /// </summary>
        [JsonProperty("Vid")]
        public string Vid{ get; set; }

        /// <summary>
        /// <p>Live push Domain, valid when the media asset source is live stream recording.</p>
        /// </summary>
        [JsonProperty("StreamDomains")]
        public string[] StreamDomains{ get; set; }

        /// <summary>
        /// <p>Live push Path. Valid when the media asset source is live recording.</p>
        /// </summary>
        [JsonProperty("StreamPaths")]
        public string[] StreamPaths{ get; set; }

        /// <summary>
        /// <p>Knowledge base ID, match any element in the collection.</p>
        /// </summary>
        [JsonProperty("KnowledgeBases")]
        public string[] KnowledgeBases{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamArraySimple(map, prefix + "FileIds.", this.FileIds);
            this.SetParamArraySimple(map, prefix + "Names.", this.Names);
            this.SetParamArraySimple(map, prefix + "NamePrefixes.", this.NamePrefixes);
            this.SetParamArraySimple(map, prefix + "Descriptions.", this.Descriptions);
            this.SetParamArraySimple(map, prefix + "ClassIds.", this.ClassIds);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "Categories.", this.Categories);
            this.SetParamArraySimple(map, prefix + "SourceTypes.", this.SourceTypes);
            this.SetParamArraySimple(map, prefix + "StreamIds.", this.StreamIds);
            this.SetParamObj(map, prefix + "CreateTime.", this.CreateTime);
            this.SetParamObj(map, prefix + "ExpireTime.", this.ExpireTime);
            this.SetParamArraySimple(map, prefix + "StorageRegions.", this.StorageRegions);
            this.SetParamArraySimple(map, prefix + "StorageClasses.", this.StorageClasses);
            this.SetParamArraySimple(map, prefix + "MediaTypes.", this.MediaTypes);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamArraySimple(map, prefix + "ReviewResults.", this.ReviewResults);
            this.SetParamArraySimple(map, prefix + "TrtcSdkAppIds.", this.TrtcSdkAppIds);
            this.SetParamArraySimple(map, prefix + "TrtcRoomIds.", this.TrtcRoomIds);
            this.SetParamArraySimple(map, prefix + "Filters.", this.Filters);
            this.SetParamObj(map, prefix + "Sort.", this.Sort);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "Vids.", this.Vids);
            this.SetParamSimple(map, prefix + "Vid", this.Vid);
            this.SetParamArraySimple(map, prefix + "StreamDomains.", this.StreamDomains);
            this.SetParamArraySimple(map, prefix + "StreamPaths.", this.StreamPaths);
            this.SetParamArraySimple(map, prefix + "KnowledgeBases.", this.KnowledgeBases);
        }
    }
}

