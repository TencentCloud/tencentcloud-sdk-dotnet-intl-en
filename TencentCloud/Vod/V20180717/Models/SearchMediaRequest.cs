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
        /// 
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FileIds")]
        public string[] FileIds{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Names")]
        public string[] Names{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("NamePrefixes")]
        public string[] NamePrefixes{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Descriptions")]
        public string[] Descriptions{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ClassIds")]
        public long?[] ClassIds{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Categories")]
        public string[] Categories{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SourceTypes")]
        public string[] SourceTypes{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StreamIds")]
        public string[] StreamIds{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CreateTime")]
        public TimeRange CreateTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ExpireTime")]
        public TimeRange ExpireTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StorageRegions")]
        public string[] StorageRegions{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StorageClasses")]
        public string[] StorageClasses{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MediaTypes")]
        public string[] MediaTypes{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Status")]
        public string[] Status{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ReviewResults")]
        public string[] ReviewResults{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TrtcSdkAppIds")]
        public ulong?[] TrtcSdkAppIds{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TrtcRoomIds")]
        public string[] TrtcRoomIds{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Filters")]
        public string[] Filters{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Sort")]
        public SortBy Sort{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Vids")]
        public string[] Vids{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Vid")]
        public string Vid{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StreamDomains")]
        public string[] StreamDomains{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StreamPaths")]
        public string[] StreamPaths{ get; set; }

        /// <summary>
        /// 
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

