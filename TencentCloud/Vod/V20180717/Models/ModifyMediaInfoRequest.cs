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

    public class ModifyMediaInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CoverData")]
        public string CoverData{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AddKeyFrameDescs")]
        public MediaKeyFrameDescItem[] AddKeyFrameDescs{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DeleteKeyFrameDescs")]
        public float?[] DeleteKeyFrameDescs{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ClearKeyFrameDescs")]
        public long? ClearKeyFrameDescs{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AddTags")]
        public string[] AddTags{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DeleteTags")]
        public string[] DeleteTags{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ClearTags")]
        public long? ClearTags{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AddSubtitles")]
        public MediaSubtitleInput[] AddSubtitles{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DeleteSubtitleIds")]
        public string[] DeleteSubtitleIds{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ClearSubtitles")]
        public long? ClearSubtitles{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DeleteKnowledgeBases")]
        public string[] DeleteKnowledgeBases{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ClearKnowledgeBases")]
        public long? ClearKnowledgeBases{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "CoverData", this.CoverData);
            this.SetParamArrayObj(map, prefix + "AddKeyFrameDescs.", this.AddKeyFrameDescs);
            this.SetParamArraySimple(map, prefix + "DeleteKeyFrameDescs.", this.DeleteKeyFrameDescs);
            this.SetParamSimple(map, prefix + "ClearKeyFrameDescs", this.ClearKeyFrameDescs);
            this.SetParamArraySimple(map, prefix + "AddTags.", this.AddTags);
            this.SetParamArraySimple(map, prefix + "DeleteTags.", this.DeleteTags);
            this.SetParamSimple(map, prefix + "ClearTags", this.ClearTags);
            this.SetParamArrayObj(map, prefix + "AddSubtitles.", this.AddSubtitles);
            this.SetParamArraySimple(map, prefix + "DeleteSubtitleIds.", this.DeleteSubtitleIds);
            this.SetParamSimple(map, prefix + "ClearSubtitles", this.ClearSubtitles);
            this.SetParamArraySimple(map, prefix + "DeleteKnowledgeBases.", this.DeleteKnowledgeBases);
            this.SetParamSimple(map, prefix + "ClearKnowledgeBases", this.ClearKnowledgeBases);
        }
    }
}

