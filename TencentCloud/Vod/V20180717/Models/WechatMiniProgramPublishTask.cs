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

    public class WechatMiniProgramPublishTask : AbstractModel
    {
        
        /// <summary>
        /// Task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Task status. Valid values:
        /// WAITING: waiting.
        /// PROCESSING: Processing;
        /// FINISH: completed.
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
        /// Video file ID for publishing.
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Transcoding template ID for the published video. 0 represents the original video.
        /// </summary>
        [JsonProperty("SourceDefinition")]
        public ulong? SourceDefinition{ get; set; }

        /// <summary>
        /// WeChat Mini Program Video Publishing status. Parameter Value:
        /// <li>Pass: published successfully;</li>
        /// <li>Failed: Release failure;</li>
        /// <li>Rejected: The audio and video moderation failed to pass.</li>
        /// </summary>
        [JsonProperty("PublishResult")]
        public string PublishResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "SourceDefinition", this.SourceDefinition);
            this.SetParamSimple(map, prefix + "PublishResult", this.PublishResult);
        }
    }
}

