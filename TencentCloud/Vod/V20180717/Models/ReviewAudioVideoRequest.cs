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

    public class ReviewAudioVideoRequest : AbstractModel
    {
        
        /// <summary>
        /// Media file ID, the globally unique ID of the file in VOD, assigned by the VOD backend after successful upload. You can obtain this field in the video upload completion event notification (https://www.tencentcloud.com/document/product/266/7830?from_cn_redirect=1) or the VOD console (https://console.cloud.tencent.com/vod/media).
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Media storage path.
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
        /// Content to review. Optional values:
        /// <li>Media: original audio/video;</li>
        /// <li>Cover: cover.</li>
        /// If this parameter is not specified or is set to an empty array, Media will be reviewed by default.
        /// </summary>
        [JsonProperty("ReviewContents")]
        public string[] ReviewContents{ get; set; }

        /// <summary>
        /// Content Review Template ID. Default value: 10. Value range:
        /// <li>10: [Preset template](https://www.tencentcloud.com/document/product/266/33476?from_cn_redirect=1#.E9.A2.84.E7.BD.AE.E9.9F.B3.E8.A7.86.E9.A2.91.E5.AE.A1.E6.A0.B8.E6.A8.A1.E6.9D.BF.5B.5D(id.3Averify)), supports detection of violation labels including pornography (Porn), violence (Terror), inappropriate information (Polity), and panting (Moan).</li>
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// Priority of the task flow. The higher the value, the higher the priority. The value range is from -10 to 10. If left blank, the default value is 0.
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// Source context, used to pass through user request information. The value of this field will be returned in the audio/video moderation completion callback. It can contain up to 1000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// Identifier for deduplication. If a request with the same identifier has been sent within the past three days, an error is returned for the current request. The maximum length is 50 characters. If this is not specified or left empty, deduplication is not performed.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Reserved field, used for special purposes.
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "MediaStoragePath", this.MediaStoragePath);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamArraySimple(map, prefix + "ReviewContents.", this.ReviewContents);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

