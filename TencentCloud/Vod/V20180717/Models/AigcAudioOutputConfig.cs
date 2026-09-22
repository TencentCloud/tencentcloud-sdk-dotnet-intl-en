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

    public class AigcAudioOutputConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Storage mode</p><p>Enumeration values:</p><ul><li>Temporary: temporary storage. The generated video file will not be stored in VOD. You can obtain a temporary access URL in the event notification, with a valid period of 7 days.</li><li>Permanent: permanent storage. The generated video file will be stored in VOD. You can obtain the FileId in the event notification.</li></ul><p>Default value: Temporary</p>
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// <p>Output filename. It can contain up to 64 characters. By default, the system specifies the filename.</p>
        /// </summary>
        [JsonProperty("MediaName")]
        public string MediaName{ get; set; }

        /// <summary>
        /// <p>Category ID, used to categorize and manage media. You can create a category through the <a href="https://www.tencentcloud.com/document/product/266/7812?from_cn_redirect=1">create category</a> API to obtain the category ID.</p><li>Default value: 0, indicating other categories.</li>
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// <p>Expiry date of the output file. The file will be deleted after this time. The default is permanent with no expiration. The format follows the ISO 8601 standard. For details, see <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format description</a>.</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>Audio duration. Not filled in by default.</p><p>Value range: [0, 60]</p>
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// <p>Output audio format. By default, this is not specified.</p>
        /// </summary>
        [JsonProperty("OutputAudioFormat")]
        public string OutputAudioFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StorageMode", this.StorageMode);
            this.SetParamSimple(map, prefix + "MediaName", this.MediaName);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "OutputAudioFormat", this.OutputAudioFormat);
        }
    }
}

