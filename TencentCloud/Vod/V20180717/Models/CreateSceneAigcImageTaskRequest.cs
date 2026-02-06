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

    public class CreateSceneAigcImageTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>The VOD [application](https://intl.cloud.tencent.com/document/product/266/14574) ID. For customers who activate VOD service from December 25, 2023, if they want to access resources in a VOD application (whether it's the default application or a newly created one), they must fill in this field with the application ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Scenario-Based image generation parameter configuration.
        /// </summary>
        [JsonProperty("SceneInfo")]
        public AigcImageSceneInfo SceneInfo{ get; set; }

        /// <summary>
        /// Input image list. supported image formats: jpg, jpeg, png, webp. different scenarios require different input data.
        /// 
        /// - AI clothing change scenario: input only 1 model image.
        /// - AI product image scenario: manually input 1-10 images of different angles per product.
        /// </summary>
        [JsonProperty("FileInfos")]
        public SceneAigcImageTaskInputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// Specifies the output media file configuration for the scenario-based image task.
        /// </summary>
        [JsonProperty("OutputConfig")]
        public SceneAigcImageOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// An identifier for deduplication. if there has been a request with the same identifier within the past 3 days, an error will be returned for the current request. the maximum length is 50 characters. leaving it blank or using an empty string indicates no deduplication.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Source context, used to pass through user request information. the audio and video quality revival complete callback will return the value of this field, up to 1000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// Task priority. the higher the value, the higher the priority. the value range is from -10 to 10. if left blank, the default value is 0.
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// Reserved field, used for special purpose.
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamObj(map, prefix + "SceneInfo.", this.SceneInfo);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

