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
        /// Subsequent media task processing operations allow automatic task initiation after media upload is completed. the parameter value is the task flow template name. VOD (video on demand) supports creating task flow templates and template naming.
        /// </summary>
        [JsonProperty("Procedure")]
        public string Procedure{ get; set; }

        /// <summary>
        /// Media file expiry time is the absolute expiration time from the current system time. to save for one day, enter "86400". to retain permanently, enter "0". the default is permanent preservation.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// Specify the upload park, applicable only to the user with special requirement for upload region.
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// Category ID is used to categorize and manage media. you can create a category and obtain the category ID through the create category api.
        /// The default value is 0, indicating other categories.
        /// </summary>
        [JsonProperty("ClassId")]
        public ulong? ClassId{ get; set; }

        /// <summary>
        /// Subapplication ID for video-on-demand (vod). if you need to access resources belonging to a subapplication, fill in this field with the subapplication ID. otherwise, this field is not required.
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Task flow context, passed through when task complete.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// Upload context, passed through on upload completion callback.
        /// </summary>
        [JsonProperty("SourceContext")]
        public string SourceContext{ get; set; }

        /// <summary>
        /// The recording file format type uploaded to the vod platform. valid values: 0: mp4 (default), 1: hls, 2: aac (valid at that time when StreamType=1 for audio-only recording).
        /// 3: hls+mp4, 4: hls+aac (valid at that time when StreamType=1 is audio-only recording).
        /// </summary>
        [JsonProperty("MediaType")]
        public ulong? MediaType{ get; set; }

        /// <summary>
        /// Only supports API recording upload to vod. this parameter indicates you can customize the recording file name prefix. [length limit: 64 bytes, only allows a combination of uppercase and lowercase letters (a-zA-Z), numbers (0-9), underline, and hyphen]. the prefix is separated from the automatically generated recording file name by `__UserDefine_u_`.
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

