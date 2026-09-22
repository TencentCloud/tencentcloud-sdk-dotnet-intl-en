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
        /// <p>Media file unique identifier.</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p><b>On-demand <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate on-demand services after December 25, 2023, this field must be filled in as the app ID when accessing resources in on-demand applications (whether the default application or a newly created application).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Media filename, up to 64 characters.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Media file description, up to 128 characters.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Media File Category ID.</p>
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// <p>Media file expiry time in <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format</a>. "9999-12-31T23:59:59Z" means it never expires. After expiry, the media file and its related resources (transcoding result, sprites, etc.) will be permanently deleted.</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>The Base64-encoded string of the video cover image file (for example, jpeg or png). Only gif, jpeg, and png image formats are supported.</p>
        /// </summary>
        [JsonProperty("CoverData")]
        public string CoverData{ get; set; }

        /// <summary>
        /// <p>Newly added set of video timestamp information. If a timestamp already exists at a certain offset, an overlay operation is performed. The maximum for a single media file is 100 timestamp entries. In the same request, the time offset parameters of AddKeyFrameDescs must all be different from those of DeleteKeyFrameDescs.</p>
        /// </summary>
        [JsonProperty("AddKeyFrameDescs")]
        public MediaKeyFrameDescItem[] AddKeyFrameDescs{ get; set; }

        /// <summary>
        /// <p>Time offset of the video timestamp information set to be deleted. Unit: seconds. In the same request, the time offset parameter of AddKeyFrameDescs must be different from that of DeleteKeyFrameDescs.</p>
        /// </summary>
        [JsonProperty("DeleteKeyFrameDescs")]
        public float?[] DeleteKeyFrameDescs{ get; set; }

        /// <summary>
        /// <p>Value 1 indicates clearing video dotting information, and other values are meaningless.<br>In the same request, ClearKeyFrameDescs and AddKeyFrameDescs cannot appear simultaneously.</p>
        /// </summary>
        [JsonProperty("ClearKeyFrameDescs")]
        public long? ClearKeyFrameDescs{ get; set; }

        /// <summary>
        /// <p>A newly-added group of tags. Maximum for a single media file: 16 tags. Maximum for a single tag: 32 characters. In the same request, the AddTags parameter must be all different from DeleteTags.</p>
        /// </summary>
        [JsonProperty("AddTags")]
        public string[] AddTags{ get; set; }

        /// <summary>
        /// <p>Set of tags to delete. In the same request, the AddTags parameter must be all different from DeleteTags.</p>
        /// </summary>
        [JsonProperty("DeleteTags")]
        public string[] DeleteTags{ get; set; }

        /// <summary>
        /// <p>Value 1 means clear all tags of media files, and other values are meaningless.<br>In the same request, ClearTags and AddTags cannot appear simultaneously.</p>
        /// </summary>
        [JsonProperty("ClearTags")]
        public long? ClearTags{ get; set; }

        /// <summary>
        /// <p>Add a set of subtitles. The maximum for a single media file is 16 subtitles. In the same request, the subtitle IDs specified in AddSubtitles must all be different from DeleteSubtitleIds.</p>
        /// </summary>
        [JsonProperty("AddSubtitles")]
        public MediaSubtitleInput[] AddSubtitles{ get; set; }

        /// <summary>
        /// <p>Unique identifier of subtitle to be deleted. In the same request, the specified subtitle id in AddSubtitles must be different from all DeleteSubtitleIds.</p>
        /// </summary>
        [JsonProperty("DeleteSubtitleIds")]
        public string[] DeleteSubtitleIds{ get; set; }

        /// <summary>
        /// <p>The value 1 means to clear all subtitle information of the media file. Other values are meaningless.<br>In the same request, ClearSubtitles and AddSubtitles cannot appear simultaneously.</p>
        /// </summary>
        [JsonProperty("ClearSubtitles")]
        public long? ClearSubtitles{ get; set; }

        /// <summary>
        /// <p>ID of the knowledge base to be outbound.</p>
        /// </summary>
        [JsonProperty("DeleteKnowledgeBases")]
        public string[] DeleteKnowledgeBases{ get; set; }

        /// <summary>
        /// <p>Value 1 means remove this media file from all knowledge bases, and other values are meaningless.</p><p><br>In the same request, ClearKnowledgeBases and DeleteKnowledgeBases cannot appear simultaneously.<p></p></p>
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

