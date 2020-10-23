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

    public class ProcessMediaByUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// Information of input video, including video's URL, name, and custom ID.
        /// </summary>
        [JsonProperty("InputInfo")]
        public MediaInputInfo InputInfo{ get; set; }

        /// <summary>
        /// Information of COS path to output file.
        /// </summary>
        [JsonProperty("OutputInfo")]
        public MediaOutputInfo OutputInfo{ get; set; }

        /// <summary>
        /// Type parameter of video content audit task.
        /// </summary>
        [JsonProperty("AiContentReviewTask")]
        public AiContentReviewTaskInput AiContentReviewTask{ get; set; }

        /// <summary>
        /// Video content analysis task parameter.
        /// </summary>
        [JsonProperty("AiAnalysisTask")]
        public AiAnalysisTaskInput AiAnalysisTask{ get; set; }

        /// <summary>
        /// Type parameter of video content recognition task.
        /// </summary>
        [JsonProperty("AiRecognitionTask")]
        public AiRecognitionTaskInput AiRecognitionTask{ get; set; }

        /// <summary>
        /// Task flow priority. The higher the value, the higher the priority. Value range: -10-10. If this parameter is left empty, 0 will be used.
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// Notification mode for task flow status change. Valid values: Finish, Change, None. If this parameter is left empty, `Finish` will be used.
        /// </summary>
        [JsonProperty("TasksNotifyMode")]
        public string TasksNotifyMode{ get; set; }

        /// <summary>
        /// The source context which is used to pass through the user request information. The task flow status change callback will return the value of this field. It can contain up to 1,000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// The ID used for deduplication. If there was a request with the same ID in the last seven days, the current request will return an error. The ID can contain up to 50 characters. If this parameter is left empty or a blank string is entered, no deduplication will be performed.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// [Subapplication](https://intl.cloud.tencent.com/document/product/266/14574?from_cn_redirect=1) ID in VOD. If you need to access a resource in a subapplication, enter the subapplication ID in this field; otherwise, leave it empty.
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamObj(map, prefix + "OutputInfo.", this.OutputInfo);
            this.SetParamObj(map, prefix + "AiContentReviewTask.", this.AiContentReviewTask);
            this.SetParamObj(map, prefix + "AiAnalysisTask.", this.AiAnalysisTask);
            this.SetParamObj(map, prefix + "AiRecognitionTask.", this.AiRecognitionTask);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "TasksNotifyMode", this.TasksNotifyMode);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

