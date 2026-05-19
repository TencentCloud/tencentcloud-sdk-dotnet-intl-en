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
        /// Unique identifier of a media file.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <b>On-demand [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. Customers who activate on-demand services from December 25, 2023 must fill this field with the app ID when accessing resources in on-demand applications (whether default or newly created).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Media filename, with a maximum length of 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Media file description, longest 128 characters.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Media File Category ID.
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// Media file expiry time uses [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I). Enter "9999-12-31T23:59:59Z" to indicate no expiry. After expiry, the media file and its related resources (transcoding result, sprites) will be permanently deleted.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// The video cover image file (such as jpeg, png) is an encoded string in [Base64](https://tools.ietf.org/html/rfc4648). Only three image formats (gif, jpeg, png) are supported.
        /// </summary>
        [JsonProperty("CoverData")]
        public string CoverData{ get; set; }

        /// <summary>
        /// Newly added set of video timestamp information. If timestamp already exists at a certain offset, perform overlay operation. Maximum for a single media file is 100 Dotting Information. In the same request, time offset parameter of AddKeyFrameDescs must be all different from DeleteKeyFrameDescs.
        /// </summary>
        [JsonProperty("AddKeyFrameDescs")]
        public MediaKeyFrameDescItem[] AddKeyFrameDescs{ get; set; }

        /// <summary>
        /// Time offset of the video timestamp information set to be deleted, unit: second. In the same request, the time offset parameter of AddKeyFrameDescs must be consistent with all different DeleteKeyFrameDescs.
        /// </summary>
        [JsonProperty("DeleteKeyFrameDescs")]
        public float?[] DeleteKeyFrameDescs{ get; set; }

        /// <summary>
        /// Value 1 indicates clearing video dotting information. Other values meaningless.
        /// In the same request, ClearKeyFrameDescs and AddKeyFrameDescs cannot appear simultaneously.
        /// </summary>
        [JsonProperty("ClearKeyFrameDescs")]
        public long? ClearKeyFrameDescs{ get; set; }

        /// <summary>
        /// A group of newly-added tags. Maximum for a single media file is 16 tags. Maximum for a single tag is 32 characters. In the same request, the AddTags parameter must be consistent with DeleteTags.
        /// </summary>
        [JsonProperty("AddTags")]
        public string[] AddTags{ get; set; }

        /// <summary>
        /// A group of tags to delete. In the same request, the AddTags parameter must be different from DeleteTags.
        /// </summary>
        [JsonProperty("DeleteTags")]
        public string[] DeleteTags{ get; set; }

        /// <summary>
        /// Value 1 means clear all media files, other values meaningless.
        /// In the same request, ClearTags and AddTags cannot appear simultaneously.
        /// </summary>
        [JsonProperty("ClearTags")]
        public long? ClearTags{ get; set; }

        /// <summary>
        /// Add a set of subtitles. Maximum for a single media file is 16 subtitles. In the same request, the specified subtitle ID in AddSubtitles must be all different from those in DeleteSubtitleIds.
        /// </summary>
        [JsonProperty("AddSubtitles")]
        public MediaSubtitleInput[] AddSubtitles{ get; set; }

        /// <summary>
        /// Unique identifier of subtitle to be deleted. In the same request, the specified subtitle id in AddSubtitles must be consistent with all different in DeleteSubtitleIds.
        /// </summary>
        [JsonProperty("DeleteSubtitleIds")]
        public string[] DeleteSubtitleIds{ get; set; }

        /// <summary>
        /// Value 1 means clear all subtitle information of the media file. Other values meaningless.
        /// In the same request, ClearSubtitles and AddSubtitles cannot appear simultaneously.
        /// </summary>
        [JsonProperty("ClearSubtitles")]
        public long? ClearSubtitles{ get; set; }


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
        }
    }
}

