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

    public class CreateAigcVideoRedrawTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>On-demand <a href="https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1">application</a> ID. For customers who activate on-demand services from December 25, 2023, this field must be filled with the app ID when accessing resources in on-demand applications, whether in the default application or a newly created application.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Input video file information for an AIGC video conversion task. The input video duration must be less than 90 seconds and the size within 2 GB.</p>
        /// </summary>
        [JsonProperty("FileInfo")]
        public AigcVideoRedrawTaskInputFileInfo FileInfo{ get; set; }

        /// <summary>
        /// <p>Task parameter information for AIGC video conversion.</p>
        /// </summary>
        [JsonProperty("TaskInfo")]
        public AigcVideoRedrawTaskInfo TaskInfo{ get; set; }

        /// <summary>
        /// <p>Output media file configuration for an AIGC video conversion task.</p>
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcVideoRedrawOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// <p>Identifier for deduplication. If a request with the same identifier has been sent within the past three days, an error is returned for the current request. The maximum length is 50 characters. If this is not specified or left empty, deduplication is not performed.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Source context. This is used to pass user request information. The audio and video quality revival complete callback returns the value of this field. The maximum length is 1000 characters.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Task Priority. The higher the value, the higher the priority. The value range is from -10 to 10. If left blank, the default value is 0.</p>
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// <p>Reserved field, used for special purposes.</p>
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamObj(map, prefix + "FileInfo.", this.FileInfo);
            this.SetParamObj(map, prefix + "TaskInfo.", this.TaskInfo);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

