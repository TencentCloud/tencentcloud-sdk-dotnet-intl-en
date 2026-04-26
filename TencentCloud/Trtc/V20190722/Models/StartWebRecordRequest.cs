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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartWebRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// [Required] webpage URL that needs to be recorded.
        /// </summary>
        [JsonProperty("RecordUrl")]
        public string RecordUrl{ get; set; }

        /// <summary>
        /// [Required] cloud storage related parameters. currently supports tencent cloud object storage as well as VOD. no support for third-party cloud storage. the storage format of the output file is only supported for hls or mp4.
        /// </summary>
        [JsonProperty("StorageParams")]
        public StorageParams StorageParams{ get; set; }

        /// <summary>
        /// [Required] the SdkAppId of TRTC.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// Maximum recording duration limit in seconds. valid values [1800, 86400]. default 86400s (24 hr).
        /// </summary>
        [JsonProperty("MaxDurationLimit")]
        public ulong? MaxDurationLimit{ get; set; }

        /// <summary>
        /// Page recording video parameter.
        /// </summary>
        [JsonProperty("WebRecordVideoParams")]
        public WebRecordVideoParams WebRecordVideoParams{ get; set; }

        /// <summary>
        /// When sensitive to repetition tasks, pay attention to this value: to avoid triggering tasks repeatedly in a short time frame, which may lead to task duplication.
        /// Import the recording RecordId to identify the task, less than 32 bytes. if carrying RecordId initiates start recording requests more than twice, only one task will start up, and the second will report error FailedOperation.TaskExist. note that when StartWebRecord call fails instead of FailedOperation.TaskExist error, change RecordId and re-initiate the request.
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// If you want to push stream to CDN, you can configure parameters in PublishCdnParams.N. it supports streaming simultaneously to up to 10 CDN addresses. if the relay address is tencent cloud CDN, set IsTencentCdn to 1.
        /// </summary>
        [JsonProperty("PublishCdnParams")]
        public McuPublishCdnParam[] PublishCdnParams{ get; set; }

        /// <summary>
        /// Timeout period for recording page resource loading, unit: second. default value is 0, which must be greater than or equal to 0 and less than or equal to 60. do not set this parameter when page loading timeout detection is disabled for the recording page.
        /// </summary>
        [JsonProperty("ReadyTimeout")]
        public ulong? ReadyTimeout{ get; set; }

        /// <summary>
        /// Render the mobile mode parameter. do not set this parameter when not preparing to render the mobile mode webpage.
        /// </summary>
        [JsonProperty("EmulateMobileParams")]
        public EmulateMobileParams EmulateMobileParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordUrl", this.RecordUrl);
            this.SetParamObj(map, prefix + "StorageParams.", this.StorageParams);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "MaxDurationLimit", this.MaxDurationLimit);
            this.SetParamObj(map, prefix + "WebRecordVideoParams.", this.WebRecordVideoParams);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamArrayObj(map, prefix + "PublishCdnParams.", this.PublishCdnParams);
            this.SetParamSimple(map, prefix + "ReadyTimeout", this.ReadyTimeout);
            this.SetParamObj(map, prefix + "EmulateMobileParams.", this.EmulateMobileParams);
        }
    }
}

