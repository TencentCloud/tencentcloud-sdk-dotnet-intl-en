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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TencentVod : AbstractModel
    {
        
        /// <summary>
        /// The operation to perform on the media uploaded. The value of this parameter is the name of a task flow template. You can create a custom task flow template in Tencent Cloud VOD.
        /// </summary>
        [JsonProperty("Procedure")]
        public string Procedure{ get; set; }

        /// <summary>
        /// The expiration time of the media file, which is a time period (seconds) from the current time. For example, `86400` means to save the media file for one day. To save the file permanently, set this parameter to `0`.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// The storage region. Set this parameter if you have special requirements on the storage region.
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// The category ID, which is returned after you create a category by calling an API. You can use categories to manage media files.
        /// The default value is `0`, which means others.
        /// </summary>
        [JsonProperty("ClassId")]
        public ulong? ClassId{ get; set; }

        /// <summary>
        /// The VOD subapplication ID. If you need to access a resource in a subapplication, set this parameter to the subapplication ID; otherwise, leave it empty.
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// The task flow context, which is passed through after the task is completed.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// The upload context, which is passed through after upload is completed.
        /// </summary>
        [JsonProperty("SourceContext")]
        public string SourceContext{ get; set; }

        /// <summary>
        /// The format of recording files uploaded to VOD. `0` (default): MP4; `1`: HLS; `2`: AAC (valid only if `StreamType` is `1`); `3`: HLS+MP4; `4`: HLS+AAC.
        /// </summary>
        [JsonProperty("MediaType")]
        public ulong? MediaType{ get; set; }

        /// <summary>
        /// The custom prefix of recording files. This parameter is valid only if recording files are uploaded to VOD. It can contain letters, numbers, underscores, and hyphens and cannot exceed 64 bytes. This prefix and the automatically generated filename are connected with `__UserId_u_`.
        /// </summary>
        [JsonProperty("UserDefineRecordId")]
        public string UserDefineRecordId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Procedure", this.Procedure);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SourceContext", this.SourceContext);
            this.SetParamSimple(map, prefix + "MediaType", this.MediaType);
            this.SetParamSimple(map, prefix + "UserDefineRecordId", this.UserDefineRecordId);
        }
    }
}

