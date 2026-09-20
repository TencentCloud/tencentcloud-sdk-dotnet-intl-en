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

    public class ComposeMediaTask : AbstractModel
    {
        
        /// <summary>
        /// Task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Task stream status. Valid values:
        /// <li>PROCESSING: Processing;</li>
        /// <li>FINISH: completed</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Error code.
        /// <li>0: success;</li>
        /// <li>Other value: Failed.</li>
        /// </summary>
        [JsonProperty("ErrCode")]
        public long? ErrCode{ get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Progress of the media file creation task, with a value range of [0-100].
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// Input of a media file creation task.
        /// </summary>
        [JsonProperty("Input")]
        public ComposeMediaTaskInput Input{ get; set; }

        /// <summary>
        /// Output of the media file creation task.
        /// </summary>
        [JsonProperty("Output")]
        public ComposeMediaTaskOutput Output{ get; set; }

        /// <summary>
        /// Meta information of the output video.
        /// </summary>
        [JsonProperty("MetaData")]
        public MediaMetaData MetaData{ get; set; }

        /// <summary>
        /// An identifier for deduplication. If there has been a request with the same identifier within the past seven days, an error will be returned for the current request. The maximum length is 50 characters. Leaving it blank or using a null string indicates no deduplication is required.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Source context, which is used to pass through the user request information. The callback for task flow status changes will return the value of this field. The maximum length is 1,000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamObj(map, prefix + "Input.", this.Input);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamObj(map, prefix + "MetaData.", this.MetaData);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
        }
    }
}

