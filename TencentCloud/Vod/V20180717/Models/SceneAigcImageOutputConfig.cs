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

    public class SceneAigcImageOutputConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Storage mode</p><p>Enumeration values:</p><ul><li>Temporary: temporary storage. The generated video file will not be stored in VOD. You can obtain a temporary access URL in the event notification, valid for 7 days.</li><li>Permanent: retained permanently. The generated video file will be stored in VOD. You can obtain the FileId in the event notification.</li></ul><p>Default value: Temporary</p>
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// <p>Output filename, up to 64 characters. By default, the system assigns the generated filename.</p>
        /// </summary>
        [JsonProperty("MediaName")]
        public string MediaName{ get; set; }

        /// <summary>
        /// <p>Category ID, used to categorize and manage media. You can create a category through the <a href="/document/product/266/7812">Create Category</a> API to obtain the category ID.</p><li>Default value: 0, indicating other categories.</li>
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// <p>Expiry date of the output file. The file will be deleted after this time. It never expires by default. Format according to the ISO 8601 standard representation. For details, see <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format description</a>.</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>Specify the aspect ratio of the generated image. Input format: W:H.<br>This field is valid in the following scenarios:</p><ul><li>Product image generation. Available values are: 1:1, 3:2, 2:3, 3:4, 4:3, 4:5, 5:4, 16:9, 9:16, 21:9</li><li>AI image expansion. Available values are: 1:1, 3:2, 2:3, 3:4, 4:3, 4:5, 5:4, 9:16, 16:9, 21:9. It can be used in conjunction with ImageWidth and ImageHeight. The rules are as follows: <ol><li>If only AspectRatio is specified, it is adaptively adjusted based on the original image.</li><li>If AspectRatio and ImageWidth are specified, ImageHeight is calculated from both, and vice versa.</li><li>If AspectRatio, ImageWidth, and ImageHeight are specified simultaneously, ImageWidth and ImageHeight are prioritized.</li></ol></li></ul>
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// <p>Output image encoding format parameters.</p>
        /// </summary>
        [JsonProperty("EncodeConfig")]
        public ImageSceneAigcEncodeConfig EncodeConfig{ get; set; }

        /// <summary>
        /// <p>Output image width. <strong>Only valid for AI image expansion scenarios</strong>.</p>
        /// </summary>
        [JsonProperty("ImageWidth")]
        public ulong? ImageWidth{ get; set; }

        /// <summary>
        /// <p>Output image height. <strong>Valid only in AI expansion scenarios</strong>.</p>
        /// </summary>
        [JsonProperty("ImageHeight")]
        public ulong? ImageHeight{ get; set; }

        /// <summary>
        /// <p>Output resolution. Only valid for the <code>ai_try_on</code> scenario. Available values: 1K, 2K, 4K.</p>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageMode", this.StorageMode);
            this.SetParamSimple(map, prefix + "MediaName", this.MediaName);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamObj(map, prefix + "EncodeConfig.", this.EncodeConfig);
            this.SetParamSimple(map, prefix + "ImageWidth", this.ImageWidth);
            this.SetParamSimple(map, prefix + "ImageHeight", this.ImageHeight);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
        }
    }
}

