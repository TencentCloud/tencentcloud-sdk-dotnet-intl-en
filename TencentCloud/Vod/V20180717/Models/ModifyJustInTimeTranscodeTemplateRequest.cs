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

    public class ModifyJustInTimeTranscodeTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Template name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <b>VOD application ID. If you want to access resources in a sub-application, fill this field with the SubAppID; when empty, it means accessing the resources of the default application.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public long? SubAppId{ get; set; }

        /// <summary>
        /// Video parameter configuration.
        /// </summary>
        [JsonProperty("VideoConfigure")]
        public VideoConfigureInfoForUpdate VideoConfigure{ get; set; }

        /// <summary>
        /// Watermark parameter configuration.
        /// </summary>
        [JsonProperty("WatermarkConfigure")]
        public WatermarkConfigureInfoForUpdate WatermarkConfigure{ get; set; }

        /// <summary>
        /// Template description, the length is limited to 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamObj(map, prefix + "VideoConfigure.", this.VideoConfigure);
            this.SetParamObj(map, prefix + "WatermarkConfigure.", this.WatermarkConfigure);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
        }
    }
}

