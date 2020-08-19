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

    public class TaskSimpleInfo : AbstractModel
    {
        
        /// <summary>
        /// Task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Task type. Valid values:
        /// <li>Procedure: video processing task;</li>
        /// <li>EditMedia: video editing task</li>
        /// <li>WechatDistribute: release on WeChat task.</li>
        /// Task types compatible with v2017:
        /// <li>Transcode: transcoding task;</li>
        /// <li>SnapshotByTimeOffset: video screencapturing task</li>
        /// <li>Concat: video splicing task;</li>
        /// <li>Clip: video clipping task;</li>
        /// <li>ImageSprites: image sprite generating task.</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// Creation time of task in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Start time of task execution in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I). If the task has not been started yet, this field will be empty.
        /// </summary>
        [JsonProperty("BeginProcessTime")]
        public string BeginProcessTime{ get; set; }

        /// <summary>
        /// End time of task in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I). If the task has not been completed yet, this field will be empty.
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// ID used for deduplication if there was a request with the same ID in the last seven days.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Source context, which is used to pass through the user request information.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BeginProcessTime", this.BeginProcessTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
        }
    }
}

