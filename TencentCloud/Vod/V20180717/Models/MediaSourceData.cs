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

    public class MediaSourceData : AbstractModel
    {
        
        /// <summary>
        /// Media file source category:
        /// <li>Record: comes from recording, such as live recording, live streaming time shift recording.</li>
        /// <li>Upload: Comes from upload, such as pull upload, server-side upload, and client UGC upload.</li>
        /// <li>VideoProcessing: comes from video processing, such as video splicing, video editing.</li>
        /// <li>TrtcRecord: Comes from TRTC simultaneous recording.</li>
        /// <li>WebPageRecord: comes from panoramic recording.</li>
        /// <li>Unknown: Unknown source.</li>
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// Field passed through when the user creates a file.
        /// </summary>
        [JsonProperty("SourceContext")]
        public string SourceContext{ get; set; }

        /// <summary>
        /// Live recording information is valid when file source is Record.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LiveRecordInfo")]
        public LiveRecordInfo LiveRecordInfo{ get; set; }

        /// <summary>
        /// TRTC Companion Recording Information. Valid at that time when the file source is TrtcRecord.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TrtcRecordInfo")]
        public TrtcRecordInfo TrtcRecordInfo{ get; set; }

        /// <summary>
        /// Panoramic recording information. Valid when the file source is WebPageRecord.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WebPageRecordInfo")]
        public WebPageRecordInfo WebPageRecordInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "SourceContext", this.SourceContext);
            this.SetParamObj(map, prefix + "LiveRecordInfo.", this.LiveRecordInfo);
            this.SetParamObj(map, prefix + "TrtcRecordInfo.", this.TrtcRecordInfo);
            this.SetParamObj(map, prefix + "WebPageRecordInfo.", this.WebPageRecordInfo);
        }
    }
}

