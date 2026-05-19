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

    public class CreateSceneAigcVideoTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// **VOD application ID.** Customers who activate on-demand services from December 25, 2023 must fill this field with the application ID when accessing resources in on-demand applications (whether default or newly created).
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Scenario-based video parameter configuration.
        /// </summary>
        [JsonProperty("SceneInfo")]
        public AigcVideoSceneInfo SceneInfo{ get; set; }

        /// <summary>
        /// Scenario-based output media file configuration for video tasks.
        /// </summary>
        [JsonProperty("OutputConfig")]
        public SceneAigcVideoOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// Input image list. Supported image formats: jpg, jpeg, png, webp.
        /// 
        /// </summary>
        [JsonProperty("FileInfos")]
        public SceneAigcVideoTaskInputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// An identifier for deduplication. If there has been a request with the same identifier within the past 3 days, an error will be returned for the current request. The maximum length is 50 characters. Leaving it blank or using an empty string indicates no deduplication.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Source context, used for passing through user request information. The audio and video quality revival complete callback will return the value of this field, up to 1000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// Task priority. The higher the value, the higher the priority. The value ranges from -10 to 10. If left blank, it represents 0.
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// Reserved field, used for special purpose.
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }

        /// <summary>
        /// Customize prompt
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamObj(map, prefix + "SceneInfo.", this.SceneInfo);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
        }
    }
}

