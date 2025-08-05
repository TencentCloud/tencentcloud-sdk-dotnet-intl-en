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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaProcessTaskSampleSnapshotResult : AbstractModel
    {
        
        /// <summary>
        /// Task status. Valid values: PROCESSING, SUCCESS, FAIL.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// The error code. An empty string indicates the task is successful; any other value returned indicates the task failed. For details, see [Error Codes](https://intl.cloud.tencent.com/document/product/1041/40249).
        /// </summary>
        [JsonProperty("ErrCodeExt")]
        public string ErrCodeExt{ get; set; }

        /// <summary>
        /// Error code. 0 indicates the task is successful; otherwise it is failed. This parameter is no longer recommended. Consider using the new error code parameter ErrCodeExt.
        /// </summary>
        [JsonProperty("ErrCode")]
        public long? ErrCode{ get; set; }

        /// <summary>
        /// Error message.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Input for a sampled screenshot task.
        /// </summary>
        [JsonProperty("Input")]
        public SampleSnapshotTaskInput Input{ get; set; }

        /// <summary>
        /// Output of the sampled screenshot task for videos.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Output")]
        public MediaSampleSnapshotItem Output{ get; set; }

        /// <summary>
        /// Task execution start time in [ISO datetime format](https://intl.cloud.tencent.com/document/product/862/37710?from_cn_redirect=1#52).
        /// </summary>
        [JsonProperty("BeginProcessTime")]
        public string BeginProcessTime{ get; set; }

        /// <summary>
        /// Task execution completion time in [ISO datetime format](https://intl.cloud.tencent.com/document/product/862/37710?from_cn_redirect=1#52).
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrCodeExt", this.ErrCodeExt);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamObj(map, prefix + "Input.", this.Input);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "BeginProcessTime", this.BeginProcessTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
        }
    }
}

