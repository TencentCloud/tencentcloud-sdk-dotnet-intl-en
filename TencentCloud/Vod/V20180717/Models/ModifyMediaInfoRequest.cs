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

    public class ModifyMediaInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique media file ID.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Media filename, which can contain up to 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Media file description, which can contain up to 128 characters.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Media file category ID.
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// Media file expiration time in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I). The value `9999-12-31T23:59:59Z` indicates that the media file never expires. After the expiration, the media file and its related resources (such as transcoding results and image sprites) will be permanently deleted.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// String generated by [Base64-encoding](https://tools.ietf.org/html/rfc4648) the video cover image file (such as .jpeg or .png file). Only .gif, .jpeg, and .png image formats are supported.
        /// </summary>
        [JsonProperty("CoverData")]
        public string CoverData{ get; set; }

        /// <summary>
        /// Set of video timestamps to be added. If a timestamp already exists at an offset time point, it will be overwritten. Up to 100 timestamps can be added to one media file. In the same request, the time offset parameters of `AddKeyFrameDescs` must be different from those of `DeleteKeyFrameDescs`.
        /// </summary>
        [JsonProperty("AddKeyFrameDescs")]
        public MediaKeyFrameDescItem[] AddKeyFrameDescs{ get; set; }

        /// <summary>
        /// Time offset of the set of video timestamps to be deleted in seconds. In the same request, the time offset parameters of `AddKeyFrameDescs` must be different from those of `DeleteKeyFrameDescs`.
        /// </summary>
        [JsonProperty("DeleteKeyFrameDescs")]
        public float?[] DeleteKeyFrameDescs{ get; set; }

        /// <summary>
        /// The value `1` indicates to delete all timestamps in the video. Other values are meaningless.
        /// In the same request, `ClearKeyFrameDescs` and `AddKeyFrameDescs` cannot be present at the same time.
        /// </summary>
        [JsonProperty("ClearKeyFrameDescs")]
        public long? ClearKeyFrameDescs{ get; set; }

        /// <summary>
        /// Set of tags to be added. Up to 16 tags can be added to one media file, and one tag can contain up to 16 characters. In the same request, the parameters of `AddTags` must be different from those of `DeleteTags`.
        /// </summary>
        [JsonProperty("AddTags")]
        public string[] AddTags{ get; set; }

        /// <summary>
        /// Set of tags to be deleted. In the same request, the parameters of `AddTags` must be different from those of `DeleteTags`.
        /// </summary>
        [JsonProperty("DeleteTags")]
        public string[] DeleteTags{ get; set; }

        /// <summary>
        /// The value `1` indicates to delete all tags of the media file. Other values are meaningless.
        /// In the same request, `ClearTags` and `AddTags` cannot be present at the same time.
        /// </summary>
        [JsonProperty("ClearTags")]
        public long? ClearTags{ get; set; }

        /// <summary>
        /// Information of multiple subtitles to be added. A single media file can have up to 16 subtitles. In the same request, the subtitle IDs specified in `AddSubtitles` must be different from those in `DeleteSubtitleIds`.
        /// </summary>
        [JsonProperty("AddSubtitles")]
        public MediaSubtitleInput[] AddSubtitles{ get; set; }

        /// <summary>
        /// Unique IDs of the subtitles to be deleted. In the same request, the subtitle IDs specified in `AddSubtitles` must be different from those in `DeleteSubtitleIds`.
        /// </summary>
        [JsonProperty("DeleteSubtitleIds")]
        public string[] DeleteSubtitleIds{ get; set; }

        /// <summary>
        /// The value `1` indicates to delete all subtitle information of the media file. Other values are meaningless.
        /// `ClearSubtitles` and `AddSubtitles` cannot co-exist in the same request.
        /// </summary>
        [JsonProperty("ClearSubtitles")]
        public long? ClearSubtitles{ get; set; }

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
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
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
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

