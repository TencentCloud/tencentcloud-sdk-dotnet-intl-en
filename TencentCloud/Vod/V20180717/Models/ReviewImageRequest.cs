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

    public class ReviewImageRequest : AbstractModel
    {
        
        /// <summary>
        /// Image content review template ID. Valid values:
        /// <li>10: Pre-set template. Violation labels supported for detection include Porn, Terror, and Polity.</li>
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// Media file ID, which is the globally unique identifier of the file on VOD. This interface requires that the media file must be in an image format.
        /// Either FileId or MediaStoragePath must be provided.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Storage path of the media.
        /// Only sub-apps in [FileID + Path mode](https://www.tencentcloud.com/document/product/266/126825?from_cn_redirect=1) can initiate tasks through MediaStoragePath.
        /// Either FileId or MediaStoragePath must be provided.
        /// </summary>
        [JsonProperty("MediaStoragePath")]
        public string MediaStoragePath{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate VOD services after December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications, whether in the default application or a newly created application.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "MediaStoragePath", this.MediaStoragePath);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

