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

    public class ProcessMediaByMPSRequest : AbstractModel
    {
        
        /// <summary>
        /// Media file ID, i.e., the globally unique ID of a file in VOD assigned by the VOD backend after successful upload. This field can be obtained through the [video upload completion event notification](https://intl.cloud.tencent.com/document/product/266/7830?from_cn_redirect=1) or [VOD Console](https://console.cloud.tencent.com/vod/media).
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <b>The VOD [application](https://intl.cloud.tencent.com/document/product/266/14574) ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// This parameter is used for passing through to media processing service (MPS) so that video processing tasks can be triggered from VOD.
        /// For detailed information on video processing parameters, please refer to [MPS Initiate Media Processing](https://www.tencentcloud.com/document/product/1041/33640). 
        /// Instructions: 
        /// 1. Currently, only the AiAnalysisTask parameter in the MPS "ProcessMedia" API needs to be configured. Other parameters are not required. If other parameters are included, the system will automatically ignore them. 
        /// 2. Currently, this is the only method used to initiate Smart Erase tasks. If parameters related to other task types are configured, the system will automatically ignore them.
        /// </summary>
        [JsonProperty("MPSProcessMediaParams")]
        public string MPSProcessMediaParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "MPSProcessMediaParams", this.MPSProcessMediaParams);
        }
    }
}

