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

    public class MediaSourceData : AbstractModel
    {
        
        /// <summary>
        /// Media files source category: <li>Record: From recording. Such as live streaming recording, live time shift recording, etc.</li> <li>Upload: From upload. Such as pull upload, upload from server, client UGC upload, etc.</li> <li>VideoProcessing: From video processing. Such as video splicing, video editing, etc.</li> <li>TrtcRecord: From TRTC accompanying recording.</li> <li>WebPageRecord: From panoramic recording.</li> <li>Unknown: Unknown source.</li>
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// User-transparent transmission field when creating a file.
        /// </summary>
        [JsonProperty("SourceContext")]
        public string SourceContext{ get; set; }

        /// <summary>
        /// Live streaming recording information, valid when the file source is Record.
        /// </summary>
        [JsonProperty("LiveRecordInfo")]
        public LiveRecordInfo LiveRecordInfo{ get; set; }

        /// <summary>
        /// The TRTC recording information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TrtcRecordInfo")]
        public TrtcRecordInfo TrtcRecordInfo{ get; set; }

        /// <summary>
        /// Panoramic recording information, valid when the file source is WebPageRecord.
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

